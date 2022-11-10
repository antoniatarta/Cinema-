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
    public partial class FrmInreg : Form
    {
        public FrmInreg()
        {
            InitializeComponent();
        }

        private void FrmInreg_FormClosed(object sender, FormClosedEventArgs e)
        {
            (this.MdiParent as FrmMain).frmI = null;
        }

        private bool Check(string username)
        {
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = @"SERVER=localhost; DATABASE=cinema; UID=root; PASSWORD=; Allow User Variables=True";
            connection.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "SELECT * FROM Conturi WHERE NumeU = @utilizator";
            cmd.Parameters.AddWithValue("utilizator", username);
            MySqlDataReader r = cmd.ExecuteReader();

            if (r.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void BtnInreg_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString = @"SERVER=localhost; DATABASE=cinema; UID=root; PASSWORD=; Allow User Variables=True";
                connection.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                if(txtNume.Text!="" && txtNumeU.Text!="" && txtTel.Text!="" && txtParola.Text != "")
                {
                    if(Check(txtNumeU.Text) == true)
                    {
                        MessageBox.Show("Acest nume de utilizator exită!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNumeU.Text = "";
                    }
                    else
                    {
                        cmd.CommandText = "INSERT INTO Conturi(Nume, NumeU, Functie, Telefon, Parola, Scor,Recompensa) values (@Nume, @NumeU, @Functie, @Telefon, @Parola, @Scor, @Recompensa)";
                        cmd.Parameters.AddWithValue("Nume", txtNume.Text);
                        cmd.Parameters.AddWithValue("NumeU", txtNumeU.Text );
                        cmd.Parameters.AddWithValue("Functie", "Client");
                        cmd.Parameters.AddWithValue("Telefon", txtTel.Text );
                        cmd.Parameters.AddWithValue("Parola", txtParola.Text);
                        cmd.Parameters.AddWithValue("Scor", "0");
                        cmd.Parameters.AddWithValue("Recompensa", 0);
                        if (cmd.ExecuteNonQuery() != 0)
                        {
                            MessageBox.Show("Contul a fost creat cu succes!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //(this.MdiParent as FrmMain).jocuriToolStripMenuItem.Visible = true;
                            // (this.MdiParent as FrmMain).contulMeuToolStripMenuItem.Visible = true;
                            (this.MdiParent as FrmMain).înregistrareToolStripMenuItem.Visible = true;
                            (this.MdiParent as FrmMain).conectareToolStripMenuItem.Visible = true;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Datele nu au fost adaugate!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

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

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int x, y;
        private void FrmInreg_MouseClick(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }


        private void FrmInreg_MouseUp(object sender, MouseEventArgs e)
        {
            int xnou, ynou;
            xnou = this.Left + e.X - x;
            ynou = this.Top + e.Y - y;
            this.Location = new Point(xnou, ynou);
        }
    }
}
