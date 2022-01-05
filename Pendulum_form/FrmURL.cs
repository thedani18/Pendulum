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
    public partial class FrmURL : Form
    {
        public string ConnectionString { get; private set; }
        public int Id { get; set; }

        public FrmURL(string connectionString, int id)
        {
            ConnectionString = connectionString;
            Id = id;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbURL.Text.Substring(0, tbURL.Text.LastIndexOf("/") + 1) == "https://youtu.be/")
                {
                    using (var conn = new SqlConnection(ConnectionString))
                    {
                        conn.Open();
                        new SqlCommand($"UPDATE Tracks SET url = '{tbURL.Text.Split('/').Last()}' WHERE id = {Id};", conn).ExecuteNonQuery();
                        this.Close();
                        MessageBox.Show("Sikeresen Frissítetted!","Sikeres Frissítés");
                    }
                }
                else
                {
                    MessageBox.Show("hibás link!","hiba");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("hibás link!", "hiba");
            }
            
        }
    }
}
