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
    public partial class FrmCont : Form
    {
        public FrmCont()
        {
            InitializeComponent();
        }

        private void FrmCont_Load(object sender, EventArgs e)
        {
            lblNume.Text = Utilizator.nume;
            lblNumeU.Text= Utilizator.numeU;
            lblTel.Text = Utilizator.tel;
            lblRec.Text = Utilizator.rec.ToString();

            try
            {
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString = @"SERVER=localhost; DATABASE=cinema; UID=root; PASSWORD=; Allow User Variables=True";
                connection.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT Denumire, Data, Loc,Total FROM difuzari,rezervari,filme WHERE idu=@idu AND rezervari.idd=difuzari.idD AND difuzari.idF=filme.idF";
                cmd.Parameters.AddWithValue("idu", Utilizator.id);

                MySqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    string aux = r["denumire"].ToString() + "       " + r["data"].ToString() + "       Locuri: " + r["Loc"].ToString() + "       Preț: " + r["Total"].ToString();
                    lstRez.Items.Add(aux);
                }
                connection.Close();
            }

            catch (Exception)
            {
                MessageBox.Show("Database error!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void FrmCont_FormClosed(object sender, FormClosedEventArgs e)
        {
            (this.MdiParent as FrmMain).frmc = null;
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int x, y;

        private void FrmCont_MouseClick(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void btnSterg_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString = @"SERVER=localhost; DATABASE=cinema; UID=root; PASSWORD=; Allow User Variables=True";
                connection.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "DELETE FROM conturi WHERE idU=@idU";
                cmd.Parameters.AddWithValue("idU", Utilizator.id);

                MySqlDataReader r = cmd.ExecuteReader();

                (this.MdiParent as FrmMain).jocuriToolStripMenuItem.Visible = false;
                (this.MdiParent as FrmMain).contulMeuToolStripMenuItem.Visible = false;
                (this.MdiParent as FrmMain).înregistrareToolStripMenuItem.Visible = true;
                (this.MdiParent as FrmMain).conectareToolStripMenuItem.Visible = true;
                (this.MdiParent as FrmMain).administrareToolStripMenuItem.Visible = false;
                Utilizator.functie = "";
                MessageBox.Show("Contul a fost șters!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

                connection.Close();
            }

            catch (Exception)
            {
                MessageBox.Show("Database error!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmCont_MouseUp(object sender, MouseEventArgs e)
        {
            int xnou, ynou;
            xnou = this.Left + e.X - x;
            ynou = this.Top + e.Y - y;
            this.Location = new Point(xnou, ynou);
        }
       
    }
}
