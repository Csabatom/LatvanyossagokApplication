using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatvanyossagokApplication
{
    public partial class Main : Form
    {
        MySqlConnection conn;
        MySqlDataReader reader;

        public Main()
        {
            InitializeComponent();
            BTN_UjVarosLetrehozasa.Visible = false;
            BTN_VarosHozzaadas.Enabled = false;
            BTN_UjLatvanyossagLetrehozasa.Visible = false;
            BTN_LatvanyossagHozzaadas.Enabled = false;
            BTN_VarosTorles.Enabled = false;
            BTN_LatvanyossagTorles.Enabled = false;

            conn = new MySqlConnection("Server=localhost; Database=latvanyossagokdb; Uid=root; Pwd=;");
            try
            {
                conn.Open();
                reader = SQLparancs("CREATE TABLE IF NOT EXISTS varosok(id int(11) NOT NULL AUTO_INCREMENT, nev text COLLATE utf8mb4_hungarian_ci NOT NULL, lakossag int(11) NOT NULL, PRIMARY KEY(id), UNIQUE KEY nev(nev) USING HASH)");
                reader.Close();
                reader = SQLparancs("CREATE TABLE IF NOT EXISTS latvanyossagok (id int(11) NOT NULL AUTO_INCREMENT, varos_id int(11), nev text COLLATE utf8mb4_hungarian_ci NOT NULL, leiras text COLLATE utf8mb4_hungarian_ci NOT NULL, ar int(11) DEFAULT NULL, PRIMARY KEY(id), FOREIGN KEY(varos_id) REFERENCES varosok(id))");
                reader.Close();
                VarosListaFrissites();
            } catch
            {
                DialogResult dialogresult = MessageBox.Show("Sikertelen kapcsolódás az adatbázishoz");
                if (dialogresult == DialogResult.OK)
                {
                    Application.Exit();
                }
            }

            this.FormClosed += (sender, args) => {
                if (conn != null)
                {
                    conn.Close();
                }
            };

        }

        private MySqlDataReader SQLparancs(string inputCommand)
        {
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = inputCommand;
            MySqlDataReader reader;
            reader = comm.ExecuteReader();
            return reader;
        }

        private void BTN_VarosHozzaadas_Click(object sender, EventArgs e)
        {
            if(BTN_VarosHozzaadas.Text == "✔")
            {
                try
                {
                    reader = SQLparancs("INSERT INTO varosok (nev, lakossag) VALUES('" + TXTBOX_VarosNev.Text + "', " + NUPDOWN_VarosLakossag.Value + ")");
                    reader.Close();
                    VarosListaFrissites();
                    VarosHozzaadasFormTorles();
                }
                catch
                {
                    MessageBox.Show("Létezik már ilyen névvel város!");
                }
            } else
            {
                try
                {
                    reader = SQLparancs("UPDATE varosok SET nev='" + TXTBOX_VarosNev.Text + "', lakossag=" + NUPDOWN_VarosLakossag.Value + " WHERE ID LIKE '" + ((Varos)LB_Varosok.SelectedItem).Id + "'");
                    reader.Close();
                    VarosListaFrissites();
                    VarosHozzaadasFormTorles();
                }
                catch
                {
                    MessageBox.Show("Hiba volt a módosítással!");
                }
            }
        }

        private void VarosListaFrissites()
        {
            LB_Varosok.Items.Clear();
            reader = SQLparancs("SELECT * FROM varosok");
            using (reader)
            {
                while(reader.Read())
                {
                    LB_Varosok.Items.Add(new Varos(int.Parse(reader.GetString("id")), reader.GetString("nev"), int.Parse(reader.GetString("lakossag"))));
                }
            }
            reader.Close();
        }

        private void BTN_VarosTorles_Click(object sender, EventArgs e)
        {
            LB_Latvanyossagok.Items.Clear();
            reader = SQLparancs("DELETE FROM latvanyossagok WHERE varos_id LIKE '" + ((Varos)LB_Varosok.SelectedItem).Id + "'");
            reader.Close();
            reader = SQLparancs("DELETE FROM varosok WHERE id LIKE '" + ((Varos)LB_Varosok.SelectedItem).Id + "'");
            reader.Close();
            VarosHozzaadasFormTorles();
            VarosListaFrissites();
        }

        private void BTN_LatvanyossagHozzaadas_Click(object sender, EventArgs e)
        {
            if(LB_Varosok.SelectedIndex != -1)
            {
                if (BTN_LatvanyossagHozzaadas.Text == "✔")
                {
                    try
                    {
                        reader = SQLparancs("INSERT INTO latvanyossagok (varos_id, nev, leiras, ar) VALUES(" + ((Varos)LB_Varosok.SelectedItem).Id + ", '" + TXTBOX_LatvanyossagNev.Text + "', '" + TXTBOX_LatvanyossagLeiras.Text + "', " + NUPDOWN_LatvanyossagAr.Value + ")");
                        reader.Close();
                        LatvanyossagListaFrissites();
                        LatvanyossagHozzaadasFormTorles();
                    }
                    catch
                    {
                        MessageBox.Show("Hiba volt a felvétellel!");
                    }
                }
                else
                {
                    try
                    {
                        reader = SQLparancs("UPDATE latvanyossagok SET nev='" + TXTBOX_LatvanyossagNev.Text + "', leiras='" + TXTBOX_LatvanyossagLeiras.Text + "', ar=" + NUPDOWN_LatvanyossagAr.Value + " WHERE ID LIKE '" + ((Latvanyossag)LB_Latvanyossagok.SelectedItem).Id + "'");
                        reader.Close();
                        LatvanyossagListaFrissites();
                        LatvanyossagHozzaadasFormTorles();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hiba volt a módosítással!" + ex);
                    }
                }
            }
            else
            {
                MessageBox.Show("Válasszon ki egy várost!");
            }
        }

        private void LatvanyossagListaFrissites()
        {
            if(LB_Varosok.SelectedIndex != -1)
            {
                LB_Latvanyossagok.Items.Clear();
                reader = SQLparancs("SELECT * FROM latvanyossagok WHERE varos_id LIKE '" + ((Varos)LB_Varosok.SelectedItem).Id + "'");
                using (reader)
                {
                    while (reader.Read())
                    {
                        LB_Latvanyossagok.Items.Add(new Latvanyossag(int.Parse(reader.GetString("id")), int.Parse(reader.GetString("varos_id")), reader.GetString("nev"), reader.GetString("leiras"), int.Parse(reader.GetString("ar"))));
                    }
                }
                reader.Close();
            }
        }

        private void BTN_LatvanyossagTorles_Click(object sender, EventArgs e)
        {
            if(LB_Latvanyossagok.SelectedIndex != -1)
            {
                reader = SQLparancs("DELETE FROM latvanyossagok WHERE id LIKE '" + ((Latvanyossag)LB_Latvanyossagok.SelectedItem).Id + "'");
                reader.Close();
                LatvanyossagHozzaadasFormTorles();
                LatvanyossagListaFrissites();
            }
        }

        private void LB_Varosok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(LB_Varosok.SelectedIndex != -1)
            {
                TXTBOX_VarosNev.Text = ((Varos)LB_Varosok.SelectedItem).Nev;
                NUPDOWN_VarosLakossag.Value = ((Varos)LB_Varosok.SelectedItem).Lakossag;
                BTN_VarosHozzaadas.Text = "✏";
                BTN_VarosHozzaadas.Enabled = false;
                BTN_UjVarosLetrehozasa.Visible = true;
                BTN_VarosTorles.Enabled = true;
                BTN_LatvanyossagTorles.Enabled = false;
            } else
            {
                BTN_UjVarosLetrehozasa.Visible = false;
                BTN_VarosTorles.Enabled = false;
            }

            LatvanyossagListaFrissites();
        }

        private void LB_Latvanyossagok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(LB_Latvanyossagok.SelectedIndex != -1)
            {
                TXTBOX_LatvanyossagNev.Text = ((Latvanyossag)LB_Latvanyossagok.SelectedItem).Nev;
                TXTBOX_LatvanyossagLeiras.Text = ((Latvanyossag)LB_Latvanyossagok.SelectedItem).Leiras;
                NUPDOWN_LatvanyossagAr.Value = ((Latvanyossag)LB_Latvanyossagok.SelectedItem).Ar;
                BTN_LatvanyossagHozzaadas.Text = "✏";
                BTN_LatvanyossagHozzaadas.Enabled = false;
                BTN_UjLatvanyossagLetrehozasa.Visible = true;
                BTN_LatvanyossagTorles.Enabled = true;
            } else
            {
                BTN_LatvanyossagTorles.Enabled = false;
                BTN_UjLatvanyossagLetrehozasa.Visible = false;
            }
        }

        private void TXTBOX_VarosNev_TextChanged(object sender, EventArgs e)
        {
            if(TXTBOX_VarosNev.Text != "")
            {
                if (BTN_VarosHozzaadas.Text == "✔")
                {
                    BTN_VarosHozzaadas.Enabled = true;
                }
                else
                {
                    if (TXTBOX_VarosNev.Text != ((Varos)LB_Varosok.SelectedItem).Nev || NUPDOWN_VarosLakossag.Value != ((Varos)LB_Varosok.SelectedItem).Lakossag)
                    {
                        BTN_VarosHozzaadas.Enabled = true;
                    }
                    else
                    {
                        BTN_VarosHozzaadas.Enabled = false;
                    }
                }
            } else
            {
                BTN_VarosHozzaadas.Enabled = false;
            }
        }

        private void BTN_UjVarosLetrehozasa_Click(object sender, EventArgs e)
        {
            TXTBOX_VarosNev.Text = "";
            NUPDOWN_VarosLakossag.Value = 0;
            BTN_VarosHozzaadas.Text = "✔";
            BTN_UjVarosLetrehozasa.Visible = false;
            LB_Varosok.SelectedIndex = -1;
            LB_Latvanyossagok.Items.Clear();
            VarosHozzaadasFormTorles();
            VarosListaFrissites();
        }

        private void VarosHozzaadasFormTorles()
        {
            TXTBOX_VarosNev.Text = "";
            NUPDOWN_VarosLakossag.Value = 0;
            BTN_VarosHozzaadas.Text = "✔";
            BTN_UjVarosLetrehozasa.Visible = false;
            BTN_VarosTorles.Enabled = false;
            LatvanyossagHozzaadasFormTorles();
            LB_Latvanyossagok.Items.Clear();
        }

        private void NUPDOWN_VarosLakossag_ValueChanged(object sender, EventArgs e)
        {
            if (TXTBOX_VarosNev.Text != "")
            {
                if (BTN_VarosHozzaadas.Text == "✔")
                {
                    BTN_VarosHozzaadas.Enabled = true;
                }
                else
                {
                    if (TXTBOX_VarosNev.Text != ((Varos)LB_Varosok.SelectedItem).Nev || NUPDOWN_VarosLakossag.Value != ((Varos)LB_Varosok.SelectedItem).Lakossag)
                    {
                        BTN_VarosHozzaadas.Enabled = true;
                    }
                    else
                    {
                        BTN_VarosHozzaadas.Enabled = false;
                    }
                }
            }
            else
            {
                BTN_VarosHozzaadas.Enabled = false;
            }
        }

        private void TXTBOX_LatvanyossagNev_TextChanged(object sender, EventArgs e)
        {
            if (TXTBOX_LatvanyossagNev.Text != "")
            {
                if (BTN_LatvanyossagHozzaadas.Text == "✔")
                {
                    BTN_LatvanyossagHozzaadas.Enabled = true;
                }
                else
                {
                    if (TXTBOX_LatvanyossagNev.Text != ((Latvanyossag)LB_Latvanyossagok.SelectedItem).Nev || TXTBOX_LatvanyossagLeiras.Text != ((Latvanyossag)LB_Latvanyossagok.SelectedItem).Leiras || NUPDOWN_LatvanyossagAr.Value != ((Latvanyossag)LB_Latvanyossagok.SelectedItem).Ar)
                    {
                        BTN_LatvanyossagHozzaadas.Enabled = true;
                    }
                    else
                    {
                        BTN_LatvanyossagHozzaadas.Enabled = false;
                    }
                }
            }
            else
            {
                BTN_LatvanyossagHozzaadas.Enabled = false;
            }
        }

        private void TXTBOX_LatvanyossagLeiras_TextChanged(object sender, EventArgs e)
        {
            if (TXTBOX_LatvanyossagNev.Text != "")
            {
                if (BTN_LatvanyossagHozzaadas.Text == "✔")
                {
                    BTN_LatvanyossagHozzaadas.Enabled = true;
                }
                else
                {
                    if (TXTBOX_LatvanyossagNev.Text != ((Latvanyossag)LB_Latvanyossagok.SelectedItem).Nev || TXTBOX_LatvanyossagLeiras.Text != ((Latvanyossag)LB_Latvanyossagok.SelectedItem).Leiras || NUPDOWN_LatvanyossagAr.Value != ((Latvanyossag)LB_Latvanyossagok.SelectedItem).Ar)
                    {
                        BTN_LatvanyossagHozzaadas.Enabled = true;
                    }
                    else
                    {
                        BTN_LatvanyossagHozzaadas.Enabled = false;
                    }
                }
            }
            else
            {
                BTN_LatvanyossagHozzaadas.Enabled = false;
            }
        }

        private void NUPDOWN_LatvanyossagAr_ValueChanged(object sender, EventArgs e)
        {
            if (TXTBOX_LatvanyossagNev.Text != "")
            {
                if (BTN_LatvanyossagHozzaadas.Text == "✔")
                {
                    BTN_LatvanyossagHozzaadas.Enabled = true;
                }
                else
                {
                    if (TXTBOX_LatvanyossagNev.Text != ((Latvanyossag)LB_Latvanyossagok.SelectedItem).Nev || TXTBOX_LatvanyossagLeiras.Text != ((Latvanyossag)LB_Latvanyossagok.SelectedItem).Leiras || NUPDOWN_LatvanyossagAr.Value != ((Latvanyossag)LB_Latvanyossagok.SelectedItem).Ar)
                    {
                        BTN_LatvanyossagHozzaadas.Enabled = true;
                    }
                    else
                    {
                        BTN_LatvanyossagHozzaadas.Enabled = false;
                    }
                }
            }
            else
            {
                BTN_LatvanyossagHozzaadas.Enabled = false;
            }
        }

        private void BTN_UjLatvanyossagLetrehozasa_Click(object sender, EventArgs e)
        {
            TXTBOX_LatvanyossagNev.Text = "";
            TXTBOX_LatvanyossagLeiras.Text = "";
            NUPDOWN_LatvanyossagAr.Value = 0;
            BTN_LatvanyossagHozzaadas.Text = "✔";
            LB_Latvanyossagok.SelectedIndex = -1;
        }

        private void LatvanyossagHozzaadasFormTorles()
        {
            TXTBOX_LatvanyossagNev.Text = "";
            TXTBOX_LatvanyossagLeiras.Text = "";
            NUPDOWN_LatvanyossagAr.Value = 0;
            BTN_LatvanyossagHozzaadas.Text = "✔";
            BTN_UjLatvanyossagLetrehozasa.Visible = false;
        }
    }
}
