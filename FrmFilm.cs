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
    public partial class FrmFilm : Form
    {
        public FrmFilm()
        {
            InitializeComponent();
        }

        private void FrmFilm_FormClosed(object sender, FormClosedEventArgs e)
        {
            (this.MdiParent as FrmMain).frmF = null;
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int x, y;


        private void FrmFilm_MouseClick(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void FrmFilm_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString = @"SERVER=localhost; DATABASE=cinema; UID=root; PASSWORD=; Allow User Variables=True";
                connection.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "Select distinct Gen from filme";

                MySqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    lstGen.Items.Add(r["gen"]);
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
                cmd.CommandText = "Select denumire from filme";

                MySqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    cbFilm.Items.Add(r["denumire"]);
                }
                connection.Close();
            }

            catch (Exception)
            {
                MessageBox.Show("Database error!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            lstGen.SelectedIndex = 0;
        }

        private void btnPref_Click(object sender, EventArgs e)
        {
            cbFilm.Text = "Filme";
            if(lstGen.SelectedItems.Count==0)
            {
                MessageBox.Show("Selectati un gen!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbFilm.Items.Clear();
                return;
            }
            try
            {
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString = @"SERVER=localhost; DATABASE=cinema; UID=root; PASSWORD=; Allow User Variables=True";
                connection.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT  denumire FROM filme WHERE true";
          
                if (rb2D.Checked)
                {
                    cmd.CommandText += " AND format=@format";
                    cmd.Parameters.AddWithValue("format", rb2D.Text);
                }

                if (rb3D.Checked)
                {
                    cmd.CommandText += " AND format=@format";
                    cmd.Parameters.AddWithValue("format", rb3D.Text);
                }

                if (rb4Dx.Checked)
                {
                    cmd.CommandText += " AND format=@format";
                    cmd.Parameters.AddWithValue("format", rb4Dx.Text);
                }

                cmd.CommandText += " AND (false ";
                if(chk100.Checked)
                {
                    cmd.CommandText += " OR durata<100";
                }
                if(chk150.Checked)
                {
                    cmd.CommandText += " OR (durata>=100 AND durata<=150)";
                }
                if(chk200.Checked)
                {
                    cmd.CommandText += " OR (durata>=150 AND durata<=200)";
                }
                if(chk300.Checked)
                {
                    cmd.CommandText += " OR durata>300";
                }
                cmd.CommandText += ") ";
                
                cmd.CommandText+=" AND (false ";
                for (int i = 0; i < lstGen.SelectedItems.Count; i++)
                {
                    cmd.CommandText += " OR gen=@gen"+i+ " " ;
                    cmd.Parameters.AddWithValue("gen"+i, lstGen.SelectedItems[i]);
                }
                cmd.CommandText += ") ";

                MySqlDataReader r = cmd.ExecuteReader();
                cbFilm.Items.Clear();
                while (r.Read())
                {
                     cbFilm.Items.Add(r["denumire"]);
                }
                if (cbFilm.Items.Count==0)
                {
                    cbFilm.Text = "Niciun film nu corespunde cerințelor!";
                }
                connection.Close();
            }

            catch (Exception)
            {
                MessageBox.Show("Database error!");
            }
        }

        private void cbFilm_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            Film.denumire = "";
            Film.gen = "";
            Film.format = "";
            Film.dis = "";
            Film.des = "";
            Film.an = 0;
            Film.durata = 0;
            Film.pret = 0;
            try
            {
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString = @"SERVER=localhost; DATABASE=cinema; UID=root; PASSWORD=; Allow User Variables=True";
                connection.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT  * FROM filme WHERE denumire=@denumire";
                cmd.Parameters.AddWithValue("denumire", cbFilm.Text);

                MySqlDataReader r = cmd.ExecuteReader();

                if (r.Read())
                {
                    Film.denumire = r["denumire"].ToString();
                    Film.gen = r["gen"].ToString();
                    Film.pret = Convert.ToInt16(r["pret"].ToString());
                    Film.format = r["format"].ToString();
                    Film.dis = r["distributie"].ToString();
                    Film.des = r["descriere"].ToString();
                    Film.an = Convert.ToInt16(r["an"].ToString());
                    Film.durata = Convert.ToInt16(r["durata"].ToString());
                    Film.img = r["imagine"].ToString();
                }
                if (cbFilm.Items.Count == 0)
                {
                    cbFilm.Text = "Niciun film nu corespunde cerințelor!";
                }
                connection.Close();
            }

            catch (Exception)
            {
                MessageBox.Show("Database error!");
            }
            lblTitlu.Visible = lbl1.Visible = lbl2.Visible = lbl3.Visible = lbl4.Visible = lbl5.Visible = lbl6.Visible = lblPoza.Visible = true;
            lblTitlu.Text = Film.denumire;
            lblGen.Text = Film.gen;
            lblAn.Text = Film.an.ToString();
            lblFormat.Text = Film.format;
            lblDurata.Text = Film.durata.ToString() + " min";
            lblPret.Text = Film.pret.ToString();
            lblPret.Text += " lei";
            lblDis.Text = Film.dis;
            lblDes.Text = Film.des;
            if (Utilizator.functie == "Administrator" || Utilizator.functie == "Vanzator" || Utilizator.functie == "Client")
            {
                btnRez.Visible = true;
            }
            pbNext.Visible = pbBack.Visible = pbImg.Visible = true;
            string[] imagini = Film.img.Split('*');
            pbImg.Image = new Bitmap(imagini[0]);
            lstPoze.Items.Clear();
            for(int i=0;i<imagini.Length;i++)
            {
                lstPoze.Items.Add(imagini[i]);
            }
            j = 0;
            lblPoza.Text = "1/" + lstPoze.Items.Count;
        }
        int j = 0;
        private void pbNext_Click(object sender, EventArgs e)
        {
            j++;
            if (j == lstPoze.Items.Count)
                j = 0;
            pbImg.Image = new Bitmap(lstPoze.Items[j].ToString());
            lblPoza.Text = (j + 1).ToString() + "/" + lstPoze.Items.Count;
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            j--;
            if (j == -1)
                j = lstPoze.Items.Count-1;
            pbImg.Image = new Bitmap(lstPoze.Items[j].ToString());
            lblPoza.Text = (j + 1).ToString() + "/" + lstPoze.Items.Count;
        }

        private void btnRez_Click(object sender, EventArgs e)
        {
            Film.denumire = cbFilm.Text;
            FrmRez frmV = new FrmRez();
            frmV.Show();
            this.Close();
           
        }

        private void FrmFilm_MouseUp(object sender, MouseEventArgs e)
        {
            int xnou, ynou;
            xnou = this.Left + e.X - x;
            ynou = this.Top + e.Y - y;
            this.Location = new Point(xnou, ynou);
        }
    }
}
