using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace vkus
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Registreties_Click(object sender, EventArgs e)
        {
            if(lietotajvards.Text.Length == 0 || parole.Text.Length == 0 || epasts.Text.Length == 0 || vards.Text.Length == 0 || uzvards.Text.Length == 0)
            {
                MessageBox.Show("Kāds no laukiem ir tukšs!");
                return;
            }
            if (parole.Text != paroleAtkartoti.Text)
            {
                MessageBox.Show("Paroles nav vienadas!");
                return;
            }
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(epasts.Text);
            if(!match.Success)
            {
                MessageBox.Show("E-pasta formāts nav pareizs!");
                return;
            }

            try
            {
                using(NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;Password=postgres;Database=vkus;"))
                {
                    using (NpgsqlCommand cmd = new NpgsqlCommand("insert into lietotajs(lietotajvards,parole,epasts,vards,uzvards) values(@lietotajvards,@parole,@epasts,@vards,@uzvards)", conn))
                    {
                        conn.Open();
                        cmd.Parameters.AddWithValue("lietotajvards", lietotajvards.Text);
                        cmd.Parameters.AddWithValue("parole", parole.Text);
                        cmd.Parameters.AddWithValue("epasts", epasts.Text);
                        cmd.Parameters.AddWithValue("vards", vards.Text);
                        cmd.Parameters.AddWithValue("uzvards", uzvards.Text);

                        cmd.ExecuteNonQuery();
                        using (NpgsqlCommand cmd2 = new NpgsqlCommand("select lietotajs_id from lietotajs where lietotajvards=@lietotajvards and parole=@parole", conn))
                        {
                            cmd2.Parameters.AddWithValue("lietotajvards", lietotajvards.Text);
                            cmd2.Parameters.AddWithValue("parole", parole.Text);
                            int result = 0;
                            if (cmd2.ExecuteScalar() != null)
                            {
                                result = (int)cmd2.ExecuteScalar();
                            }
                            using (NpgsqlCommand cmd3 = new NpgsqlCommand("insert into lietotajs_tips(tips_id,lietotajs_id) values(@tips_id,@lietotajs_id)", conn))
                            {
                                cmd3.Parameters.AddWithValue("tips_id", 1);
                                cmd3.Parameters.AddWithValue("lietotajs_id", result);
                                cmd3.ExecuteNonQuery();
                            }
                        }
                        Close();
                        conn.Close();
                    }
                } 
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error! " + ex.Message);
            }
        }
    }
}
