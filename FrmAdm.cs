using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace GESTIUNE_CINEMA
{
    public partial class FrmAdm : Form
    {
        public FrmAdm()
        {
            InitializeComponent();
        }

        private void FrmAdm_FormClosed(object sender, FormClosedEventArgs e)
        {
            (this.MdiParent as FrmMain).frmA = null;
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAdm_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString = @"SERVER=localhost; DATABASE=cinema; UID=root; PASSWORD=; Allow User Variables=True";
                connection.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "Select denumire from filme";

                MySqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    cbFilm.Items.Add(r["denumire"]);
                    cbFilm2.Items.Add(r["denumire"]);
                }
                connection.Close();
            }

            catch (Exception)
            {
                MessageBox.Show("Database error!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            if (cbFilm.Text == "" || cbFilm.Text == "Toate filmele")
            {
                MessageBox.Show("Selectați un film!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString = @"SERVER=localhost; DATABASE=cinema; UID=root; PASSWORD=; Allow User Variables=True";
                connection.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "DELETE FROM filme WHERE denumire=@denumire";
                cmd.Parameters.AddWithValue("denumire", cbFilm.Text);

                MySqlDataReader r = cmd.ExecuteReader();
                
                MessageBox.Show("Datele au fost șterse!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbFilm.Items.Remove(cbFilm.SelectedItem);
               
                connection.Close();
            }

            catch (Exception)
            {
                MessageBox.Show("Database error!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtAn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtDurata_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string imagine = lblImg.Text;
            try
            {
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString = @"SERVER=localhost; DATABASE=cinema; UID=root; PASSWORD=; Allow User Variables=True";
                connection.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                if (lblImg.Text!="" && txtDen.Text != "" && txtGen.Text != "" && txtAn.Text != "" && cboFormat.Text != "Format" && txtDurata.Text != "" && txtDis.Text != "" && txtDescriere.Text != "")
                {
                    cmd.CommandText = "INSERT INTO Filme(Denumire, Gen, An, Format, Durata, Distributie, Descriere, Imagine) values (@Denumire, @Gen, @An, @Format, @Durata, @Distributie, @Descriere,@Imagine)";
                    cmd.Parameters.AddWithValue("Denumire", txtDen.Text);
                    cmd.Parameters.AddWithValue("Gen", txtGen.Text);
                    cmd.Parameters.AddWithValue("An", txtAn.Text);
                    cmd.Parameters.AddWithValue("Format", cboFormat.Text);
                    cmd.Parameters.AddWithValue("Durata", txtDurata.Text);
                    cmd.Parameters.AddWithValue("Distributie", txtDis.Text);
                    cmd.Parameters.AddWithValue("Descriere", txtDescriere.Text);
                    cmd.Parameters.AddWithValue("Imagine", imagine);
                    if (cmd.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("Filmul a fost adăugat cu succes!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Datele nu au fost adaugate!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Toate câmpurile sunt obligatorii!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Database error!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        int i = 0;
        private void btnAddPoza_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                i++;
                lblNr.Text = i.ToString();
                string extensie = Path.GetExtension(ofd.FileName);
                String newFileName = string.Format(@"filme/{0}{1}", Path.GetFileNameWithoutExtension(Path.GetTempFileName()), extensie);
                File.Copy(ofd.FileName, newFileName);
                pbImg.Image = new Bitmap(ofd.FileName);
                if (lblImg.Text == "")
                    lblImg.Text = newFileName;
                else
                    lblImg.Text = lblImg.Text + "*" + newFileName;
            }
            else
            {
                if (lblImg.Text == "")
                {
                    pbImg.Image = new Bitmap("filme/nopic.jpg");
                    lblImg.Text = "filme/nopic.jpg";
                    lblNr.Text = "0";
                }
            }
        }

        private void cbFilm2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboDif.Items.Clear();
            lstOra.Items.Clear();
            try
            {
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString = @"SERVER=localhost; DATABASE=cinema; UID=root; PASSWORD=; Allow User Variables=True";
                connection.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "Select data,OraFinal from difuzari where difuzari.idf=(select filme.idf from filme Where denumire=@denumire)";
                cmd.Parameters.AddWithValue("denumire", cbFilm2.Text);

                MySqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    cboDif.Items.Add(r["data"]);
                    lstOra.Items.Add(r["OraFinal"]);
                    
                }
                connection.Close();
            }

            catch (Exception)
            {
                MessageBox.Show("Database error!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        int iddif;
        private void btnStergD_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString = @"SERVER=localhost; DATABASE=cinema; UID=root; PASSWORD=; Allow User Variables=True";
                connection.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "DELETE FROM rezervari WHERE idd=@idd";
                cmd.Parameters.AddWithValue("idd", iddif);

                if (cmd.ExecuteNonQuery() != 0)
                { }

                connection.Close();
            }

            catch (Exception)
            {
                MessageBox.Show("Database error!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            try
            {
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString = @"SERVER=localhost; DATABASE=cinema; UID=root; PASSWORD=; Allow User Variables=True";
                connection.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "DELETE FROM locuri WHERE idd=@idd";
                cmd.Parameters.AddWithValue("idd", iddif);

                if (cmd.ExecuteNonQuery() != 0)
                { }

                connection.Close();
            }

            catch (Exception)
            {
                MessageBox.Show("Database error!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            try
            {
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString = @"SERVER=localhost; DATABASE=cinema; UID=root; PASSWORD=; Allow User Variables=True";
                connection.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "DELETE FROM difuzari WHERE data=@data";
                cmd.Parameters.AddWithValue("data", Datadif);

                if (cmd.ExecuteNonQuery() != 0)
                    MessageBox.Show("Difuzarea a fost ștearsă!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


                connection.Close();
            }

            catch (Exception)
            {
                MessageBox.Show("Database error!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        string Datadif;
        string mod_d(string aux)
        {
            int l;
            string[] d = aux.Split('/', ' ');
            aux = "";
            aux += d[2] + "-";
            if (Convert.ToInt16(d[0]) < 10)
                aux += 0;
            aux += d[0] + "-";
            if (Convert.ToInt16(d[1]) < 10)
                aux += 0;
            aux += d[1] + " ";
            string[] ora = d[3].Split(':');
            l = Convert.ToInt16(ora[0]);
            if (l < 12 && d[4] == "PM")
            {
                l += 12;
                ora[0] = l.ToString();
            }
            if (l == 12 && d[4] == "AM")
            {
                ora[0] = "00";
            }
            aux += ora[0] + ":" + ora[1] + ":00";
            return aux;
        }
        string o_f(string aux,int durata)
        {
            int aux2;
            string[] a = aux.Split(' ', ':');
            aux2 = Convert.ToInt16(a[2])+durata;
            a[2] = (aux2%60).ToString();
            a[1]= ((Convert.ToInt16(a[1])) + (aux2)/ 60).ToString();
            if (Convert.ToInt16(a[2])<10)
            {
                a[2] = "0" + a[2];
            }
            aux =  a[1] + ":" + a[2] + ":00";
            return aux;
        }
        private void cboDif_SelectedIndexChanged(object sender, EventArgs e)
        {
            Datadif = mod_d(cboDif.Text);
            try
            {
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString = @"SERVER=localhost; DATABASE=cinema; UID=root; PASSWORD=; Allow User Variables=True";
                connection.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "Select idD from difuzari where data=@data";
                cmd.Parameters.AddWithValue("data", Datadif);

                MySqlDataReader r = cmd.ExecuteReader();
                if (r.Read())
                {
                    iddif = Convert.ToInt16(r["idD"].ToString());
                }
                connection.Close();
            }

            catch (Exception)
            {
                MessageBox.Show("Database error!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        string DataNou,OraF,OraNF;

        private void txtH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        int durf, idfilm;
        private void btnDif_Click(object sender, EventArgs e)
        {
            string aux= monthCalendar1.SelectionRange.Start.ToShortDateString();
            string[] d = aux.Split('/');
            aux = "";
            aux += d[2] + "-";
            if (Convert.ToInt16(d[0]) < 10)
                aux += 0;
            aux += d[0] + "-";
            if (Convert.ToInt16(d[1]) < 10)
                aux += 0;
            aux += d[1] + " ";
            if (txtM.Text != "" && txtH.Text != "")
            {
                /*if(txtH.Text=="00")
                {
                    aux += "00:";
                }
                else
                {
                    if (Convert.ToInt16(txtH.Text) < 10)
                        aux += 0;
                    aux += txtH.Text + ":";
                }
                if (txtM.Text == "00")
                {
                    aux += "00:00";
                }
                else
                {
                    if (Convert.ToInt16(txtM.Text) < 10)
                        aux += 0;
                    aux += txtM.Text + ":00";
                }*/
                aux += txtH.Text + ":" + txtM.Text + ":00";

                if (Convert.ToInt16(txtH.Text) > 23 || Convert.ToInt16(txtM.Text) > 59)
                {
                    MessageBox.Show("Ora nu este corectă!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Stabiliți ora!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            DataNou = aux;
            
            try
            {
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString = @"SERVER=localhost; DATABASE=cinema; UID=root; PASSWORD=; Allow User Variables=True";
                connection.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT idf,durata FROM filme WHERE Denumire=@denumire";
                cmd.Parameters.AddWithValue("denumire", cbFilm2.Text);

                MySqlDataReader r = cmd.ExecuteReader();
                if (r.Read())
                {
                    idfilm = Convert.ToInt16(r["idf"].ToString());
                    durf = Convert.ToInt16(r["durata"].ToString());
                }
                connection.Close();
            }
            
            catch (Exception)
            {
                MessageBox.Show("Database error!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            OraNF = o_f(DataNou, durf);

            string[] a=DataNou.Split(' '), b;
            int ok = 1;
            for (int i = 0; i < cboDif.Items.Count; i++)
            {
                Datadif = mod_d(cboDif.Items[i].ToString());
                OraF = lstOra.Items[i].ToString();
                b = Datadif.Split(' ');
                if (String.Equals(a[0], b[0]) == true)
                {
                    if ( (String.Compare(b[1], a[1]) <= 0 && String.Compare(a[1], OraF) <= 0) || (String.Compare(b[1], OraNF) <= 0 && String.Compare(OraNF, OraF)<= 0 ) )
                    {
                        MessageBox.Show("Sala este ocupată!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ok = 0;
                    }
                }
            }
            if (ok == 1)
            {
                try
                {
                    MySqlConnection connection = new MySqlConnection();
                    connection.ConnectionString = @"SERVER=localhost; DATABASE=cinema; UID=root; PASSWORD=; Allow User Variables=True";
                    connection.Open();

                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = "INSERT INTO difuzari(idF, Data, OraFinal) values (@idF, @Data, @OraFinal)";
                    cmd.Parameters.AddWithValue("idF", idfilm);
                    cmd.Parameters.AddWithValue("Data", DataNou);
                    cmd.Parameters.AddWithValue("OraFinal", OraNF);
                    if (cmd.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("Difuzarea a fost adăugată!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Difuzarea nu a fost adăugată!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                catch (Exception)
                {
                    MessageBox.Show("Database error!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
