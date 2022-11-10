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

namespace GESTIUNE_CINEMA
{
    public partial class FrmRez : Form
    {
        public FrmRez()
        {
            InitializeComponent();
        }

        Panel[] pnl = new Panel[80];
        PictureBox[] pb = new PictureBox[80];
        Label[] lbl = new Label[80];
        private void FrmRez_Load(object sender, EventArgs e)
        {
            lblGratis.Text = Utilizator.rec.ToString();
            lblTitlu.Text =Film.denumire ;
            string aux;
            try
            {
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString = @"SERVER=localhost; DATABASE=cinema; UID=root; PASSWORD=; Allow User Variables=True";
                connection.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT Data FROM difuzari WHERE difuzari.idF=(select filme.idF FROM filme WHERE denumire=@denumire)";
                cmd.Parameters.AddWithValue("denumire", lblTitlu.Text);

                MySqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    aux = r["data"].ToString();
                    cbDif.Items.Add(aux);
                }
                connection.Close();
            }

            catch (Exception)
            {
                MessageBox.Show("Database error!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            int x = 17, y = 60;
            for(int i=1;i<=60;i++)
            {
                pnl[i] = new Panel();
                pnlSala.Controls.Add(pnl[i]);
                pnl[i].BackColor = Color.Black;
                pnl[i].BorderStyle = BorderStyle.FixedSingle;
                pnl[i].Size = new Size(49, 58);
                pnl[i].Location = new Point(x, y);

                pb[i] = new PictureBox();
                pnl[i].Controls.Add(pb[i]);
                pb[i].BackColor = Color.Black;
                pb[i].Location = new Point(1, 22);
                pb[i].Size = new Size(45, 33);
                pb[i].Image = pbV.Image;
                pb[i].SizeMode = PictureBoxSizeMode.Zoom;
                pb[i].Click += new System.EventHandler(this.pbV_Click);

                lbl[i] = new Label();
                pnl[i].Controls.Add(lbl[i]);
                lbl[i].ForeColor = Color.White;
                lbl[i].Location = new Point(1, 2);
                lbl[i].Size = new Size(45, 18);
                lbl[i].TextAlign =ContentAlignment.MiddleCenter;
                lbl[i].Text = i.ToString();
                x += 60;
                if(i%5==0 && i%10!=0)
                {
                    x += 60;
                }
                if(i%10==0)
                {
                    x = 17;
                    y += 60;
                }
            }
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int a,b;
        private void FrmRez_MouseClick(object sender, MouseEventArgs e)
        {
            a = e.X;
            b = e.Y;
        }

        int pret=0,total=0;
        Int16 cate = 0;
        private void pbV_Click(object sender, EventArgs e)
        {
            PictureBox crt = (sender as PictureBox);
            if(crt.Image!=pbR.Image && crt.Name!=pbV.Name)
            {
                if (crt.Image == pbA.Image)
                {
                    crt.Image = pbV.Image;
                    cate--;
                    pret -= Film.pret;
                }
                else
                {
                    crt.Image = pbA.Image;
                    cate++;
                    pret += Film.pret;
                }
            }
            if (cate > 0)
            {
                if (cate > Utilizator.rec)
                {
                    total = pret - Utilizator.rec * Film.pret;
                }
                else
                {
                    total = 0;
                }
            }
            lblNr.Text = cate.ToString();
            lblPret.Text = pret.ToString();
            lblTotal.Text = total.ToString();
        }
        int id;
        private void btnRez_Click(object sender, EventArgs e)
        {
            int ok = 0;
            string locuri="";
            if(cbDif.Text=="")
                MessageBox.Show("Selectați o dată", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                for (int i = 1; i <= 60; i++)
                {
                    if (pb[i].Image == pbA.Image)
                    {
                        if (locuri == "")
                            locuri = i.ToString();
                        else
                            locuri += "," + i;

                        id = 0;
                        try
                        {
                            MySqlConnection connection = new MySqlConnection();
                            connection.ConnectionString = @"SERVER=localhost; DATABASE=cinema; UID=root; PASSWORD=; Allow User Variables=True";
                            connection.Open();

                            MySqlCommand cmd = new MySqlCommand();
                            cmd.Connection = connection;
                            cmd.CommandText = "select idd FROM difuzari WHERE data=@data";
                            cmd.Parameters.AddWithValue("data", DATA);

                            MySqlDataReader r = cmd.ExecuteReader();
                            if (r.Read())
                            {
                                id = Convert.ToInt16(r["idd"].ToString());
                            }
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
                            if (cbDif.Text != "")
                            {
                                cmd.CommandText = "INSERT INTO locuri(idd, loc) values (@idd, @loc)";
                                cmd.Parameters.AddWithValue("idd", id);
                                cmd.Parameters.AddWithValue("loc", i);
                                if (cmd.ExecuteNonQuery() != 0)
                                {
                                    ok = 1;
                                }
                            }
                            connection.Close();
                        }

                        catch (Exception)
                        {
                            MessageBox.Show("Database error!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            if (ok == 1)
            { 
                if (cate > Utilizator.rec)
                {
                     Utilizator.rec = 0;
                }
                else 
                {
                     Utilizator.rec -= cate;
                }
                try
                {
                    MySqlConnection connection = new MySqlConnection();
                    connection.ConnectionString = @"SERVER=localhost; DATABASE=cinema; UID=root; PASSWORD=; Allow User Variables=True";
                    connection.Open();

                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE Conturi Set Recompensa=@recompensa WHERE NumeU = @utilizator";
                    cmd.Parameters.AddWithValue("recompensa", Utilizator.rec);
                    cmd.Parameters.AddWithValue("utilizator", Utilizator.numeU);

                    if (cmd.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("Biletele au fost rezervate!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

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

                    cmd.CommandText = "INSERT INTO rezervari(idU, idd,loc,total) values (@idU, @idd,@loc,@total)";
                    cmd.Parameters.AddWithValue("idU", Utilizator.id);
                    cmd.Parameters.AddWithValue("idd", id);
                    cmd.Parameters.AddWithValue("loc", locuri);
                    cmd.Parameters.AddWithValue("total", total);
                    if (cmd.ExecuteNonQuery() != 0)
                    {
                        ok = 1;
                    }
                    connection.Close();
                }

                catch (Exception)
                {
                    MessageBox.Show("Database error!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        string DATA;
        private void cbDif_SelectedIndexChanged(object sender, EventArgs e)
        {
            pret = 0;
            cate = 0;
            lblNr.Text = cate.ToString();
            lblPret.Text = pret.ToString();
            for (int i = 1; i <= 60; i++)
                pb[i].Image = pbV.Image;

            int l;
            string aux;
            aux = cbDif.Text;
            string[] d = aux.Split('/',' ');
            aux = "";
            aux += d[2]+"-";
            if (Convert.ToInt16(d[0]) < 10)
                aux += 0;
            aux += d[0]+"-";
            if (Convert.ToInt16(d[1]) < 10)
                aux += 0;
            aux += d[1] + " ";
            string[] ora = d[3].Split(':');
            l = Convert.ToInt16(ora[0]);
            if (l<12 && d[4]=="PM")
            {
                l += 12;
                ora[0] = l.ToString();
            }
            aux += ora[0] + ":" + ora[1] + ":" + ora[2];
            DATA = aux;

            try
            {
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString = @"SERVER=localhost; DATABASE=cinema; UID=root; PASSWORD=; Allow User Variables=True";
                connection.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT Loc FROM locuri,difuzari WHERE locuri.idd=(select difuzari.idd FROM difuzari WHERE data=@data)";
                cmd.Parameters.AddWithValue("data", aux);

                MySqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    l = Convert.ToInt16(r["loc"]);
                    pb[l].Image = pbR.Image;
                }
                connection.Close();
            }

            catch (Exception)
            {
                MessageBox.Show("Database error!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void FrmRez_MouseUp(object sender, MouseEventArgs e)
        {
            int xnou, ynou;
            xnou = this.Left + e.X - a;
            ynou = this.Top + e.Y - b;
            this.Location = new Point(xnou, ynou);
        }
    }
}
