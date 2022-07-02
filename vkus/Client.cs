using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vkus
{
    public partial class Client : Form
    {
        public string _username;
        public int _u_id;
        public List<string> laiki = new List<string>() { "8:30", "9:00", "9:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00" };
        public Client(string username, int u_id)
        {
            InitializeComponent();
            pieraksti.Size = jaunsPieraksts.Size;
            pieraksti.Location = jaunsPieraksts.Location;
            pierakstsEsosam.Size = pierakstsJaunam.Size;
            pierakstsEsosam.Location = pierakstsJaunam.Location;
            pierakstsEsosam.Parent = jaunsPieraksts;
            pierakstsJaunam.Visible = false;
            _username = username;
            _u_id = u_id;
            Text = "Veterinārārsta klīnika - " + username;
            List<string> dzimumi = new List<string>() { "Viriesu", "Sieviesu" };
            
            List<string> iemesli = new List<string>() { "Vakcinacija","Apskate","Cits"};
            dzimums.Items.AddRange(dzimumi.ToArray());
            laiksJaunam.Items.AddRange(laiki.ToArray());
            iemeslsJaunam.Items.AddRange(iemesli.ToArray());
            laiksEsosam.Items.AddRange(laiki.ToArray());
            iemeslsEsosam.Items.AddRange(iemesli.ToArray());
            dzimums.DropDownStyle = ComboBoxStyle.DropDownList;
            laiksJaunam.DropDownStyle = ComboBoxStyle.DropDownList;
            iemeslsJaunam.DropDownStyle = ComboBoxStyle.DropDownList;
            iemeslsEsosam.DropDownStyle = ComboBoxStyle.DropDownList;
            laiksEsosam.DropDownStyle = ComboBoxStyle.DropDownList;
            pierakstsJaunamPoga.Visible = false;
            pierakstsEsosamPoga.Visible = false;
        }

        private void Pieraksti_Click(object sender, EventArgs e)
        {
            jaunsPieraksts.Visible = false;
            pieraksti.Visible = true;
            if(pierakstiMajdzivniekaVardi.Items.Count == 0)
            {
                using (NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;Password=postgres;Database=vkus;"))
                {
                    using (NpgsqlCommand cmd = new NpgsqlCommand("select vards from majdzivnieks where lietotajs_id=@lietotajs_id", conn))
                    {
                        conn.Open();
                        cmd.Parameters.AddWithValue("lietotajs_id", _u_id);
                        NpgsqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            pierakstiMajdzivniekaVardi.Items.Add(reader[0].ToString());
                        }
                        conn.Close();
                    }
                }
            }

        }

        private void JaunsPieraksts_Click(object sender, EventArgs e)
        {
            jaunsPieraksts.Visible = true;
            pieraksti.Visible = false;
            pierakstsJaunamPoga.Visible = true;
            pierakstsEsosamPoga.Visible = true;
        }

        private void PierakstsJaunam_Click(object sender, EventArgs e)
        {
            pierakstsJaunam.Visible = true;
            pierakstsEsosam.Visible = false;
            datumsJaunam.Value = DateTime.Today;
            datumsEsosam.Value = DateTime.Today;
        }

        private void PierakstsEsosam_Click(object sender, EventArgs e)
        {
            pierakstsEsosam.Visible = true;
            pierakstsJaunam.Visible = false;
            datumsJaunam.Value = DateTime.Today;
            datumsEsosam.Value = DateTime.Today;

            using (NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;Password=postgres;Database=vkus;"))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand("select vards from majdzivnieks where lietotajs_id=@lietotajs_id", conn))
                {
                    cmd.Parameters.AddWithValue("lietotajs_id",_u_id);
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    pacientsVards.Items.Clear();
                    while (reader.Read())
                    {
                        pacientsVards.Items.Add(reader[0].ToString());
                    }
                }
                conn.Close();
            }
        }

        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void apstiprinatJaunam_Click(object sender, EventArgs e)
        {
            if (pacientaVardsTextBox.Text.Length == 0 || pacientaSugaTextBox.Text.Length == 0  || dzimums.Text.Length == 0 || laiksJaunam.Text.Length == 0 || iemeslsJaunam.Text.Length == 0)
            {
                MessageBox.Show("Visi nepieciešamie lauki nav aizpildīti!");
                return;
            }
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;Password=postgres;Database=vkus;"))
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand("insert into majdzivnieks(vards,suga,dzimums,vecums_menesi,lietotajs_id) values(@vards,@suga,@dzimums,@menesi,@lietotajs_id)", conn))
                    {
                        cmd.Parameters.AddWithValue("vards",pacientaVardsTextBox.Text);
                        cmd.Parameters.AddWithValue("suga", pacientaSugaTextBox.Text);
                        cmd.Parameters.AddWithValue("dzimums", dzimums.Text);
                        cmd.Parameters.AddWithValue("menesi", vecums.Value);
                        cmd.Parameters.AddWithValue("lietotajs_id", _u_id);
                        cmd.ExecuteNonQuery();
                        using(NpgsqlCommand cmd2 = new NpgsqlCommand("select majdzivnieks_id from majdzivnieks where lietotajs_id=@id and vards=@vards", conn))
                        {
                            cmd2.Parameters.AddWithValue("id", _u_id);
                            cmd2.Parameters.AddWithValue("vards", pacientaVardsTextBox.Text);
                            int result = (int)cmd2.ExecuteScalar();
                            using (NpgsqlCommand cmd3 = new NpgsqlCommand("insert into pieraksts(laiks,iemesls,piezimes,lietotajs_id,majdzivnieks_id,datums) values(@laiks,@iemesls,@piezimes,@lietotajs_id,@majdzivnieks_id,@datums)", conn))
                            {
                                string[] datumsSplit = datumsJaunam.Text.Split(',');
                                cmd3.Parameters.AddWithValue("datums", DbType.Date).Value = datumsJaunam.Value.Date;
                                cmd3.Parameters.AddWithValue("laiks", laiksJaunam.Text);
                                cmd3.Parameters.AddWithValue("iemesls", iemeslsJaunam.Text);
                                cmd3.Parameters.AddWithValue("piezimes", piezimesJaunam.Text);
                                cmd3.Parameters.AddWithValue("lietotajs_id", _u_id);
                                cmd3.Parameters.AddWithValue("majdzivnieks_id", result);
                                cmd3.ExecuteNonQuery();
                            }
                        }
                        conn.Close();
                        MessageBox.Show("Pieraksts veiksmīgi izveidots!");
                        Hide();
                        Client clientFrm = new Client(_username, _u_id);
                        clientFrm.Show();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error! " + ex.Message);
            }
        }

        private void datumsJaunam_ValueChanged(object sender, EventArgs e)
        {
            laiksJaunam.Items.Clear();
            laiksJaunam.Items.AddRange(laiki.ToArray());

            using (NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;Password=postgres;Database=vkus;"))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand("select laiks from pieraksts where datums=@datums", conn))
                {
                    cmd.Parameters.AddWithValue("datums", DbType.Date).Value = datumsJaunam.Value.Date;
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    List<string> aiznemtieLaiki = new List<string>();
                    while (reader.Read())
                    {
                        aiznemtieLaiki.Add(reader[0].ToString());
                    }
                    foreach(string aiznemtaisLaiks in aiznemtieLaiki)
                    {
                        foreach(string laiks in laiki)
                        {
                            if(aiznemtaisLaiks == laiks)
                            {
                                laiksJaunam.Items.Remove(laiks);
                            }
                        }
                    }
                }
                conn.Close();
            }
        }

        private void datumsEsosam_ValueChanged(object sender, EventArgs e)
        {
            laiksEsosam.Items.Clear();
            laiksEsosam.Items.AddRange(laiki.ToArray());

            using (NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;Password=postgres;Database=vkus;"))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand("select laiks from pieraksts where datums=@datums", conn))
                {
                    cmd.Parameters.AddWithValue("datums", DbType.Date).Value = datumsEsosam.Value.Date;
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    List<string> aiznemtieLaiki = new List<string>();
                    while (reader.Read())
                    {
                        aiznemtieLaiki.Add(reader[0].ToString());
                    }
                    foreach (string aiznemtaisLaiks in aiznemtieLaiki)
                    {
                        foreach (string laiks in laiki)
                        {
                            if (aiznemtaisLaiks == laiks)
                            {
                                laiksEsosam.Items.Remove(laiks);
                            }
                        }
                    }
                }
                conn.Close();
            }
        }

        private void apstiprinatEsosam_Click(object sender, EventArgs e)
        {
            if (pacientsVards.Text.Length == 0 ||  laiksEsosam.Text.Length == 0 || iemeslsEsosam.Text.Length == 0)
            {
                MessageBox.Show("Visi nepieciešamie lauki nav aizpildīti!");
                return;
            }
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;Password=postgres;Database=vkus;"))
                {
                    conn.Open();
                    using (NpgsqlCommand cmd2 = new NpgsqlCommand("select majdzivnieks_id from majdzivnieks where lietotajs_id=@id and vards=@vards", conn))
                    {
                        cmd2.Parameters.AddWithValue("id", _u_id);
                        cmd2.Parameters.AddWithValue("vards", pacientsVards.Text);
                        int result = (int)cmd2.ExecuteScalar();
                        using (NpgsqlCommand cmd3 = new NpgsqlCommand("insert into pieraksts(laiks,iemesls,piezimes,lietotajs_id,majdzivnieks_id,datums) values(@laiks,@iemesls,@piezimes,@lietotajs_id,@majdzivnieks_id,@datums)", conn))
                        {
                            string[] datumsSplit = datumsEsosam.Text.Split(',');
                            cmd3.Parameters.AddWithValue("datums", DbType.Date).Value = datumsEsosam.Value.Date;
                            cmd3.Parameters.AddWithValue("laiks", laiksEsosam.Text);
                            cmd3.Parameters.AddWithValue("iemesls", iemeslsEsosam.Text);
                            cmd3.Parameters.AddWithValue("piezimes", piezimesEsosam.Text);
                            cmd3.Parameters.AddWithValue("lietotajs_id", _u_id);
                            cmd3.Parameters.AddWithValue("majdzivnieks_id", result);
                            cmd3.ExecuteNonQuery();
                        }
                    }
                    conn.Close();
                    MessageBox.Show("Pieraksts veiksmīgi izveidots!");
                    Hide();
                    Client clientFrm = new Client(_username, _u_id);
                    clientFrm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex.Message);
            }
        }

        private void pierakstiMajdzivniekaVardi_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;Password=postgres;Database=vkus;"))
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand("select majdzivnieks_id from majdzivnieks where lietotajs_id=@id and vards=@vards", conn))
                    {
                        cmd.Parameters.AddWithValue("id", _u_id);
                        cmd.Parameters.AddWithValue("vards", pierakstiMajdzivniekaVardi.Text);
                        int result = (int)cmd.ExecuteScalar();
                        using (NpgsqlCommand cmd2 = new NpgsqlCommand("select * from pieraksts where lietotajs_id=@id and majdzivnieks_id=@majdzivnieks_id", conn))
                        {
                            cmd2.Parameters.AddWithValue("id", _u_id);
                            cmd2.Parameters.AddWithValue("majdzivnieks_id", result);
                            DataTable dt = new DataTable();
                            var dr = cmd2.ExecuteReader();
                            dt.Load(dr);
                            dataGridView1.DataSource = dt;
                            dataGridView1.Columns[0].Visible = false;
                            dataGridView1.Columns[4].Visible = false;
                            dataGridView1.Columns[5].Visible = false;
                        }
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex.Message);
            }
        }
    }
}
