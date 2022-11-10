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
    public partial class FrmConectare : Form
    {
        public FrmConectare()
        {
            InitializeComponent();
        }
        private void FrmAdaugare_FormClosed(object sender, FormClosedEventArgs e)
        {
            (this.MdiParent as FrmMain).frmC = null;
        }
        private bool Check(string username, string password)
        {
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = @"SERVER=localhost; DATABASE=cinema; UID=root; PASSWORD=; Allow User Variables=True";
            connection.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "SELECT * FROM Conturi WHERE NumeU = @utilizator and parola = @parola";
            cmd.Parameters.AddWithValue("utilizator", username);
            cmd.Parameters.AddWithValue("parola", password);

            MySqlDataReader r = cmd.ExecuteReader();

            if (r.Read())
            {
                Utilizator.id = Convert.ToInt16(r["idU"].ToString());
                Utilizator.nume = r["Nume"].ToString();
                Utilizator.numeU = r["NumeU"].ToString();
                Utilizator.functie = r["Functie"].ToString();
                Utilizator.tel = r["Telefon"].ToString();
                Utilizator.mybest = Convert.ToInt16(r["Scor"].ToString());
                Utilizator.rec = Convert.ToInt16(r["Recompensa"].ToString());
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnConectare_Click(object sender, EventArgs e)
        {
            if (Check(txtNumeU.Text, txtParola.Text) == true)
            {
               // MessageBox.Show("Te-ai conectat cu succes!", "", MessageBoxButtons.OK);
                (this.MdiParent as FrmMain).jocuriToolStripMenuItem.Visible = true;
                (this.MdiParent as FrmMain).contulMeuToolStripMenuItem.Visible = true;
                (this.MdiParent as FrmMain).înregistrareToolStripMenuItem.Visible = false;
                (this.MdiParent as FrmMain).conectareToolStripMenuItem.Visible = false;
                if(Utilizator.functie == "Administrator")
                {
                    (this.MdiParent as FrmMain).administrareToolStripMenuItem.Visible = true;
                    (this.MdiParent as FrmMain).înregistrareToolStripMenuItem.Visible = true;
                }
                Close();
            }
            else
            {
                if(txtNumeU.Text!="" && txtParola.Text!="")
                {
                    MessageBox.Show("Numele sau parola greșită.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtParola.Text ="";
                    txtNumeU.Text = "";
                }
                else
                {
                    MessageBox.Show("Toate câmpurile sunt obligatorii!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
        }

        int x, y;
        private void FrmConectare_MouseClick(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmConectare_MouseUp(object sender, MouseEventArgs e)
        {
            int xnou, ynou;
            xnou = this.Left + e.X - x;
            ynou = this.Top+ e.Y - y;
            this.Location = new Point(xnou, ynou);
        }
    }
}
