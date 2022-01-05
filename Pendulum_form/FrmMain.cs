using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pendulum_form
{
    public partial class FrmMain : Form
    {
        public string ConnectionString { get; private set; }
        public FrmMain()
        {
            ConnectionString =  @"Server = (localdb)\MSSQLLocalDB; Database = music;";
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            FillcbArtist();
            tbSearch.Enabled = false;
            btnAddURL.Enabled = false;
            btnEdit.Enabled = false;
        }

        private void FillcbArtist()
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                var r = new SqlCommand("SELECT Albums.artist FROM Albums GROUP BY Albums.artist;", conn).ExecuteReader();
                while (r.Read())
                {
                    cbArtist.Items.Add(r[0]);
                }
            }
            cbAlbum.Enabled = false;
        }
        private void cbArtist_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbAlbum.Enabled = true;
            FillcbAlbum(cbArtist.GetItemText(cbArtist.SelectedItem));
        }

        private void FillcbAlbum(string artist)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                var r = new SqlCommand($"SELECT Albums.title FROM Albums WHERE Albums.artist = '{artist}';", conn).ExecuteReader();
                while (r.Read())
                {
                    cbAlbum.Items.Add(r[0]);
                }
            }
        }

        private void cbAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbAlbum.Text)
            {
                case "Hold Your Colour":
                    pbAlbum.Image = Properties.Resources.hold_your_colour;
                    break;
                case "Immersion":
                    pbAlbum.Image = Properties.Resources.immersion;
                    break;
                case "In Silico":
                    pbAlbum.Image = Properties.Resources.in_silico;
                    break;
            }

            Fillrtb();

            Filldgv();
        }

        private void Filldgv()
        {
            dgv.Rows.Clear();
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                var r = new SqlCommand($"SELECT Tracks.title, Tracks.length, Tracks.url, Tracks.id FROM Tracks, Albums WHERE Tracks.album = Albums.id AND Albums.title LIKE '{cbAlbum.Text}' AND Tracks.title LIKE '%{tbSearch.Text}%';", conn).ExecuteReader();
                while (r.Read())
                {
                    dgv.Rows.Add(r[0], r[1], r[2], r[3]);
                }
                tbSearch.Enabled = true;
            }
        }

        private void Fillrtb()
        {
            rtb.Clear();
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                var r = new SqlCommand($"SELECT Albums.release FROM Albums WHERE Albums.title LIKE '{cbAlbum.Text}';", conn).ExecuteReader();
                while (r.Read())
                {
                    rtb.Text = $"Kiadási dátum: {DateTime.Parse(r[0].ToString()).ToString("yyyy. MMMM dd.")}";
                }
                r.Close();
                r = new SqlCommand($"SELECT SUM(DATEDIFF(MINUTE, '0:00:00',Tracks.length)) FROM Tracks, Albums WHERE Albums.id = Tracks.album AND Albums.title = '{cbAlbum.Text}' GROUP BY Tracks.album;", conn).ExecuteReader();
                while (r.Read())
                {
                    rtb.Text += $"\nAlbum hossza: {r[0]} perc";
                }
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            Filldgv();
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv.CurrentRow.Cells[2].Value.ToString() != "null")
            {
                linkURL.Text = $"https://youtu.be/{dgv.CurrentRow.Cells[2].Value.ToString()}";
                btnAddURL.Enabled = false;
            }
            else
            {
                linkURL.Text = "NOPE";
                btnAddURL.Enabled = true;
                
            }
            btnEdit.Enabled = true;
        }

        private void btnAddURL_Click(object sender, EventArgs e)
        {
            new FrmURL(ConnectionString, Convert.ToInt32(dgv.CurrentRow.Cells[3].Value)).Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            new FrmEdit(ConnectionString, Convert.ToInt32(dgv.CurrentRow.Cells[3].Value)).Show();
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            List<AlbumsClass> Albums = new List<AlbumsClass>();
            List<TracksClass> Tracks = new List<TracksClass>();

            string pathToFile = "";
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "TXT files|*.txt";
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(theDialog.FileName.ToString());
                pathToFile = theDialog.FileName;
            }

            if (File.Exists(pathToFile))
            {
                using (StreamReader sr = new StreamReader(pathToFile, Encoding.UTF8))
                {
                    string FirstLine = "";
                    FirstLine = sr.ReadLine();
                    if (FirstLine.Contains("[albums]"))
                    {
                        string line = "";
                        try
                        {
                            while (!line.Contains("[tracks]"))
                            {
                                line = sr.ReadLine();
                                if (!line.Contains("[tracks]"))
                                {
                                    Albums.Add(new AlbumsClass(line));
                                }
                                else
                                {
                                    sr.ReadLine();
                                }

                            }
                            while (!sr.EndOfStream)
                            {
                                Tracks.Add(new TracksClass(sr.ReadLine()));
                            }
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Hibás fájl beolvasás");
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Hibás fájl beolvasás");
                    }

                    using (var conn = new SqlConnection(ConnectionString))
                    {
                        conn.Open();
                        foreach (var x in Albums)
                        {
                            //rtb.Text += $"INSERT INTO Albums VALUES ('{x.id}','{x.artist}','{x.title}','{x.release.Year}-{x.release.Month}-{x.release.Day}');";
                            new SqlCommand($"INSERT INTO Albums VALUES ('{x.id}','{x.artist}','{x.title}','{x.release.Year}-{x.release.Month}-{x.release.Day}');", conn).ExecuteNonQuery();
                        }
                        foreach (var x in Tracks)
                        {
                            //rtb.Text += $"INSERT INTO Tracks VALUES ('{x.title}','{x.length.Hours.ToString()}:{x.length.Minutes.ToString()}:{x.length.Seconds.ToString()}','{x.album}','{x.url}');";
                            new SqlCommand($"INSERT INTO Tracks VALUES ('{x.title}','{x.length.Hours.ToString()}:{x.length.Minutes.ToString()}:{x.length.Seconds.ToString()}','{x.album}','{x.url}');", conn).ExecuteNonQuery();
                        }
                    }
                }
            }
        }
    }
}
