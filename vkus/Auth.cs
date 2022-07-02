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
    public partial class Auth : Form
    {
        
        public Auth()
        {
            InitializeComponent();
        }

        private void Registreties_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void Ielogoties_Click(object sender, EventArgs e)
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres;Password=postgres;Database=vkus;"))
                {
                    using (NpgsqlCommand cmd = new NpgsqlCommand("select lietotajs_id,lietotajvards,parole from lietotajs where lietotajvards=@lietotajvards and parole=@parole", conn))
                    {
                        conn.Open();
                        cmd.Parameters.AddWithValue("lietotajvards", lietotajvards.Text);
                        cmd.Parameters.AddWithValue("parole", parole.Text);
                        if (cmd.ExecuteScalar() != null)
                        {
                            int result = (int)cmd.ExecuteScalar();
                            using (NpgsqlCommand cmd2 = new NpgsqlCommand("select tips_id from lietotajs_tips where lietotajs_id=@lietotajs_id", conn))
                            {
                                cmd2.Parameters.AddWithValue("lietotajs_id", result);
                                if (cmd2.ExecuteScalar() != null)
                                {
                                    int result2 = (int)cmd2.ExecuteScalar();
                                    if(result2 == 1)
                                    {
                                        Hide();
                                        Client form = new Client(lietotajvards.Text, result);
                                        form.Show();
                                    }
                                    if(result2 == 2)
                                    {
                                        Hide();
                                        Employee form = new Employee(lietotajvards.Text);
                                        form.Show();
                                    }
                                }
                            }
                        }
                        else
                            MessageBox.Show("Nepareizs lietotajvards vai/un parole");
                        conn.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error! " +ex.Message );
            }
        }
    }
}
