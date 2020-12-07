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
            BTN_ÚjVárosLétrehozása.Visible = false;
            BTN_VarosHozzaadas.Enabled = false;

            conn = new MySqlConnection("Server=localhost; Database=latvanyossagokdb; Uid=root; Pwd=;");
            try
            {
                conn.Open();
                reader = SQLparancs("CREATE TABLE IF NOT EXISTS varosok(id int(11) NOT NULL AUTO_INCREMENT, nev text COLLATE utf8mb4_hungarian_ci NOT NULL, lakossag int(11) NOT NULL, PRIMARY KEY(id), UNIQUE KEY nev(nev) USING HASH)");
                reader.Close();
                reader = SQLparancs("CREATE TABLE IF NOT EXISTS latvanyossagok (id int(11) NOT NULL AUTO_INCREMENT, varos_id int(11), nev text COLLATE utf8mb4_hungarian_ci NOT NULL, leiras text COLLATE utf8mb4_hungarian_ci NOT NULL, ar int(11) DEFAULT NULL, PRIMARY KEY(id), FOREIGN KEY(varos_id) REFERENCES varosok(id))");
                reader.Close();
                VarosListaFrissites();
            } catch (Exception ex)
            {
                MessageBox.Show(ex+"");
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
            /*using (var reader = comm.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32("id");
                    string nev = reader.GetString("nev");

                    string uzlet;
                    try
                    {
                        uzlet = reader.GetString("uzlet");
                    }
                    catch (SqlNullValueException ex)
                    {
                        uzlet = null;
                    }
                    //var ajandek = new Ajandek(id, nev, uzlet);
                    //ajandekListBox.Items.Add(ajandek);
                }
            }*/
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
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
            reader = SQLparancs("DELETE FROM varosok WHERE ID LIKE '" + ((Varos)LB_Varosok.SelectedItem).Id + "'");
            reader.Close();
            VarosListaFrissites();
        }

        private void BTN_LatvanyossagHozzaadas_Click(object sender, EventArgs e)
        {
            if (TXTBOX_LatvanyossagNev.Text != "" && LB_Varosok.SelectedIndex != -1)
            {
                try
                {
                    reader = SQLparancs("INSERT INTO latvanyossagok (varos_id, nev, leiras, ar) VALUES(" + ((Varos)LB_Varosok.SelectedItem).Id + ", '" +TXTBOX_LatvanyossagNev.Text + "', '" + TXTBOX_LatvanyossagLeiras.Text + "', " + NUPDOWN_LatvanyossagAr.Value + ")");
                    reader.Close();
                    LatvanyossagListaFrissites();
                }
                catch
                {
                    MessageBox.Show("Hiba volt a felvétellel!");
                }
            } else
            {
                MessageBox.Show("Válasszon ki egy várost!");
            }
        }

        private void LatvanyossagListaFrissites()
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

        private void BTN_LatvanyossagTorles_Click(object sender, EventArgs e)
        {
            if(LB_Latvanyossagok.SelectedIndex != -1)
            {
                reader = SQLparancs("DELETE FROM latvanyossagok WHERE ID LIKE '" + ((Latvanyossag)LB_Latvanyossagok.SelectedItem).Id + "'");
                reader.Close();
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
                BTN_ÚjVárosLétrehozása.Visible = true;
            } else
            {
                BTN_ÚjVárosLétrehozása.Visible = false;
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

        private void BTN_ÚjVárosLétrehozása_Click(object sender, EventArgs e)
        {
            TXTBOX_VarosNev.Text = "";
            NUPDOWN_VarosLakossag.Value = 0;
            BTN_VarosHozzaadas.Text = "✔";
            BTN_ÚjVárosLétrehozása.Visible = false;
            LB_Varosok.SelectedIndex = -1;
        }

        private void VarosHozzaadasFormTorles()
        {
            TXTBOX_VarosNev.Text = "";
            NUPDOWN_VarosLakossag.Value = 0;
            BTN_VarosHozzaadas.Text = "✔";
            BTN_ÚjVárosLétrehozása.Visible = false;
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
    }
}
