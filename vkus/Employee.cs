using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace vkus
{
    public partial class Employee : Form
    {
        string _username;
        public List<string> laiki = new List<string>() { "8:30", "9:00", "9:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00" };
        public Employee(string username)
        {
            InitializeComponent();
            Text = "Veterinārārsta klīnika - " + username;
            izveidotklientuPanel.Visible = false;
            apskatitpierakstusPanel.Visible = false;
            izveidotmajdzivniekuPanel.Visible = false;
            izveidotpierakstuPanel.Visible = false;
            _username = username;
            List<string> dzimumi = new List<string>() { "Viriesu", "Sieviesu" };
            List<string> iemesli = new List<string>() { "Vakcinacija", "Apskate", "Cits" };
            pacientadzimums.Items.AddRange(dzimumi.ToArray());
            iemeslsCb.Items.AddRange(iemesli.ToArray());
            laikiCb.Items.AddRange(laiki.ToArray());
        }

        private void Employee_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void apskatitpierakstusBtn_Click(object sender, EventArgs e)
        {
            izveidotklientuPanel.Visible = false;
            apskatitpierakstusPanel.Visible = true;
            izveidotmajdzivniekuPanel.Visible = false;
            izveidotpierakstuPanel.Visible = false;
        }

        private void izveidotklientuBtn_Click(object sender, EventArgs e)
        {
            izveidotklientuPanel.Visible = true;
            apskatitpierakstusPanel.Visible = false;
            izveidotmajdzivniekuPanel.Visible = false;
            izveidotpierakstuPanel.Visible = false;
        }

        private void izveidotmajdzivniekuBtn_Click(object sender, EventArgs e)
        {
            izveidotklientuPanel.Visible = false;
            apskatitpierakstusPanel.Visible = false;
            izveidotmajdzivniekuPanel.Visible = true;
            izveidotpierakstuPanel.Visible = false;
        }

        private void izveidotpierakstuBtn_Click(object sender, EventArgs e)
        {
            izveidotklientuPanel.Visible = false;
            apskatitpierakstusPanel.Visible = false;
            izveidotmajdzivniekuPanel.Visible = false;
            izveidotpierakstuPanel.Visible = true;
            datumsPicker.Value = DateTime.Today;
        }

        private void searchipasnieksApskatitpierakstus_TextChanged(object sender, EventArgs e)
        {

        }

        private void apstiprinatklientuBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0)
            {
                MessageBox.Show("Kāds no laukiem ir tukšs!");
                return;
            }
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;Password=postgres;Database=vkus;"))
                {
                    using (NpgsqlCommand cmd = new NpgsqlCommand("insert into lietotajs(vards,uzvards) values(@vards,@uzvards)", conn))
                    {
                        conn.Open();
                        cmd.Parameters.AddWithValue("vards", textBox1.Text);
                        cmd.Parameters.AddWithValue("uzvards", textBox2.Text);
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Klients veiksmīgi izveidots!");
                    }
                    Hide();
                    Employee clientFrm = new Employee(_username);
                    clientFrm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex.Message);
            }
        }

        private void mekletipasnieksjaunsMd_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void izviedotpacientuBtn_Click(object sender, EventArgs e)
        {
            if (ipasnieksCb.Text.Length == 0 || pacientavards.Text.Length == 0 || pacientasuga.Text.Length == 0 || pacientavecums.Value == 0 || pacientadzimums.Text.Length == 0)
            {
                MessageBox.Show("Kāds no laukiem ir tukšs!");
                return;
            }
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;Password=postgres;Database=vkus;"))
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand("select lietotajs_id from lietotajs where vards=@vards and uzvards=@uzvards", conn))
                    {
                        cmd.Parameters.AddWithValue("vards",ipasnieksCb.Text.Split(' ')[0]);
                        cmd.Parameters.AddWithValue("uzvards", ipasnieksCb.Text.Split(' ')[1]);
                        int result = (int)cmd.ExecuteScalar();
                        using (NpgsqlCommand cmd2 = new NpgsqlCommand("insert into majdzivnieks(vards,suga,dzimums,vecums_menesi,lietotajs_id) values(@vards,@suga,@dzimums,@menesi,@lietotajs_id)", conn))
                        {
                            cmd2.Parameters.AddWithValue("vards", pacientavards.Text);
                            cmd2.Parameters.AddWithValue("suga", pacientasuga.Text);
                            cmd2.Parameters.AddWithValue("dzimums", pacientadzimums.Text);
                            cmd2.Parameters.AddWithValue("menesi", pacientavecums.Value);
                            cmd2.Parameters.AddWithValue("lietotajs_id", result);
                            cmd2.ExecuteNonQuery();
                            conn.Close();
                            MessageBox.Show("Mājdzivnieks veiksmīgi izveidots!");
                            Hide();
                            Employee clientFrm = new Employee(_username);
                            clientFrm.Show();
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex.Message);
            }
        }

        private void datumsPicker_ValueChanged(object sender, EventArgs e)
        {
            laikiCb.Items.Clear();
            laikiCb.Items.AddRange(laiki.ToArray());

            using (NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;Password=postgres;Database=vkus;"))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand("select laiks from pieraksts where datums=@datums", conn))
                {
                    cmd.Parameters.AddWithValue("datums", DbType.Date).Value = datumsPicker.Value.Date;
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
                                laikiCb.Items.Remove(laiks);
                            }
                        }
                    }
                }
                conn.Close();
            }
        }

        private void mekletipasniekupieraksts_TextChanged(object sender, EventArgs e)
        {

        }

        private void ipasniekspierakstsCb_SelectedValueChanged(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;Password=postgres;Database=vkus;"))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand("select lietotajs_id from lietotajs where vards=@vards and uzvards=@uzvards", conn))
                {
                    cmd.Parameters.AddWithValue("vards", ipasniekspierakstsCb.Text.Split(' ')[0]);
                    cmd.Parameters.AddWithValue("uzvards", ipasniekspierakstsCb.Text.Split(' ')[1]);
                    int result = (int)cmd.ExecuteScalar();
                    using (NpgsqlCommand cmd2 = new NpgsqlCommand("select vards from majdzivnieks where lietotajs_id=@lietotajs_id", conn))
                    {
                        cmd2.Parameters.AddWithValue("lietotajs_id", result);
                        NpgsqlDataReader reader = cmd2.ExecuteReader();
                        pacientavardsCb.Items.Clear();
                        while (reader.Read())
                        {
                            pacientavardsCb.Items.Add(reader[0].ToString());
                        }
                    }
                    conn.Close();
                }

            }
        }

        private void apstiprinatpierakstuBtn_Click(object sender, EventArgs e)
        {
            if (ipasniekspierakstsCb.Text.Length == 0 || pacientavardsCb.Text.Length == 0 || laikiCb.Text.Length == 0 || iemeslsCb.Text.Length == 0)
            {
                MessageBox.Show("Visi nepieciešamie lauki nav aizpildīti!");
                return;
            }
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;Password=postgres;Database=vkus;"))
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand("select lietotajs_id from lietotajs where vards=@vards and uzvards=@uzvards", conn))
                    {
                        cmd.Parameters.AddWithValue("vards", ipasniekspierakstsCb.Text.Split(' ')[0]);
                        cmd.Parameters.AddWithValue("uzvards", ipasniekspierakstsCb.Text.Split(' ')[1]);
                        int result = (int)cmd.ExecuteScalar();
                        using (NpgsqlCommand cmd2 = new NpgsqlCommand("select majdzivnieks_id from majdzivnieks where lietotajs_id=@id and vards=@vards", conn))
                        {
                            cmd2.Parameters.AddWithValue("id", result);
                            cmd2.Parameters.AddWithValue("vards", pacientavardsCb.Text);
                            int result2 = (int)cmd2.ExecuteScalar();
                            using (NpgsqlCommand cmd3 = new NpgsqlCommand("insert into pieraksts(laiks,iemesls,piezimes,lietotajs_id,majdzivnieks_id,datums) values(@laiks,@iemesls,@piezimes,@lietotajs_id,@majdzivnieks_id,@datums)", conn))
                            {
                                string[] datumsSplit = datumsPicker.Text.Split(',');
                                cmd3.Parameters.AddWithValue("datums", DbType.Date).Value = datumsPicker.Value.Date;
                                cmd3.Parameters.AddWithValue("laiks", laikiCb.Text);
                                cmd3.Parameters.AddWithValue("iemesls", iemeslsCb.Text);
                                cmd3.Parameters.AddWithValue("piezimes", piezimesRtb.Text);
                                cmd3.Parameters.AddWithValue("lietotajs_id", result);
                                cmd3.Parameters.AddWithValue("majdzivnieks_id", result2);
                                cmd3.ExecuteNonQuery();
                            }
                        }
                    }

                    conn.Close();
                    MessageBox.Show("Pieraksts veiksmīgi izveidots!");
                    Hide();
                    Employee clientFrm = new Employee(_username);
                    clientFrm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! " + ex.Message);
            }
        }

        private void mekletipasniekupieraksts_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    using (NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;Password=postgres;Database=vkus;"))
                    {
                        conn.Open();
                        using (NpgsqlCommand cmd = new NpgsqlCommand("select vards, uzvards from lietotajs where vards=@vards and uzvards like @uzvards", conn))
                        {
                            string vards = mekletipasniekupieraksts.Text.Split(' ')[0];
                            string uzvards = "";
                            if (mekletipasniekupieraksts.Text.Contains(' '))
                            {
                                uzvards = mekletipasniekupieraksts.Text.Split(' ')[1];
                            }
                            cmd.Parameters.AddWithValue("vards", vards);
                            cmd.Parameters.AddWithValue("uzvards", uzvards + "%");
                            if (cmd.ExecuteScalar() != null)
                            {
                                NpgsqlDataReader reader = cmd.ExecuteReader();
                                while (reader.Read())
                                {
                                    bool duplicate = false;
                                    foreach (string s in ipasniekspierakstsCb.Items)
                                    {
                                        if (reader[0].ToString() + " " + reader[1].ToString() == s)
                                            duplicate = true;
                                    }
                                    if (!duplicate)
                                        ipasniekspierakstsCb.Items.Add(reader[0].ToString() + " " + reader[1].ToString());
                                }
                                conn.Close();
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error! " + ex.Message);
                }
                e.Handled = true;
            }
        }

        private void mekletipasnieksjaunsMd_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    using (NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;Password=postgres;Database=vkus;"))
                    {
                        conn.Open();
                        using (NpgsqlCommand cmd = new NpgsqlCommand("select vards, uzvards from lietotajs where vards=@vards and uzvards like @uzvards", conn))
                        {
                            string vards = mekletipasnieksjaunsMd.Text.Split(' ')[0];
                            string uzvards = "";
                            if (mekletipasnieksjaunsMd.Text.Contains(' '))
                            {
                                uzvards = mekletipasnieksjaunsMd.Text.Split(' ')[1];
                            }
                            cmd.Parameters.AddWithValue("vards", vards);
                            cmd.Parameters.AddWithValue("uzvards", uzvards + "%");
                            if (cmd.ExecuteScalar() != null)
                            {
                                NpgsqlDataReader reader = cmd.ExecuteReader();
                                while (reader.Read())
                                {
                                    bool duplicate = false;
                                    foreach (string s in ipasnieksCb.Items)
                                    {
                                        if (reader[0].ToString() + " " + reader[1].ToString() == s)
                                            duplicate = true;
                                    }
                                    if (!duplicate)
                                        ipasnieksCb.Items.Add(reader[0].ToString() + " " + reader[1].ToString());
                                }
                                conn.Close();
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error! " + ex.Message);
                }
                e.Handled = true;
            }
        }

        private void searchipasnieksApskatitpierakstus_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    using (NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;Password=postgres;Database=vkus;"))
                    {
                        conn.Open();
                        using (NpgsqlCommand cmd = new NpgsqlCommand("select lietotajs_id from lietotajs where vards=@vards and uzvards like @uzvards", conn))
                        {
                            string vards = searchipasnieksApskatitpierakstus.Text.Split(' ')[0];
                            string uzvards = "";
                            if (searchipasnieksApskatitpierakstus.Text.Contains(' '))
                            {
                                uzvards = searchipasnieksApskatitpierakstus.Text.Split(' ')[1];
                            }
                            cmd.Parameters.AddWithValue("vards", vards);
                            cmd.Parameters.AddWithValue("uzvards", uzvards + "%");
                            if (cmd.ExecuteScalar() != null)
                            {
                                int result = (int)cmd.ExecuteScalar();
                                using (NpgsqlCommand cmd2 = new NpgsqlCommand("select * from pieraksts where lietotajs_id=@lietotajs_id", conn))
                                {
                                    cmd2.Parameters.AddWithValue("lietotajs_id", result);
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error! " + ex.Message);
                }
                e.Handled = true;
            }
        }
    }
}
