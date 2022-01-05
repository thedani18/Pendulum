using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pendulum_form
{
    public partial class FrmEdit : Form
    {
        public string ConnectionString { get; private set; }
        public int Id { get; set; }
        public FrmEdit(string connectionString, int id)
        {
            ConnectionString = connectionString;
            Id = id;
            InitializeComponent();
            tbId.Enabled = false;
        }

        private void FrmEdit_Load(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                var r = new SqlCommand($"SELECT * FROM Tracks WHERE id = {Id}", conn).ExecuteReader();
                while (r.Read())
                {
                    tbId.Text = r[0].ToString();
                    tbTitle.Text = r[1].ToString();
                    tbLength.Text = r[2].ToString();
                    tbAlbum.Text = r[3].ToString();
                    tbURL.Text = r[4].ToString();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Biztos szerkezteni akarod?","Edit",MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                using (var conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    if (tbURL.Text.ToLower() == "null")
                    {
                        new SqlCommand($"UPDATE Tracks SET title = '{tbTitle.Text}', length = '{tbLength.Text}', album = '{tbAlbum.Text}', url = '{tbURL.Text}' WHERE id = {Id};", conn).ExecuteNonQuery();
                    }
                    else
                    {
                        new SqlCommand($"UPDATE Tracks SET title = '{tbTitle.Text}', length = '{tbLength.Text}', album = '{tbAlbum.Text}', url = '{tbURL.Text}' WHERE id = '{Id}';", conn).ExecuteNonQuery();
                    }
                }
                this.Close();
                MessageBox.Show("Sikeresen módosítottuk");
            }
            if (res == DialogResult.No)
            {
                MessageBox.Show("Megszakítottuk a szerkeztést");
            }
        }
    }
}
