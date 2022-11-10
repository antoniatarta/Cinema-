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
    public partial class FrmJoc : Form
    {
        public FrmJoc()
        {
            InitializeComponent();
        }

        int pipeSpeed = 8; 
        int gravity = 15; 
        Int16 score = 0;
        Int16 best;

        private void FrmJoc_FormClosed(object sender, FormClosedEventArgs e)
        {
            (this.MdiParent as FrmMain).frmJ = null;
        }

        int x, y;

        private void FrmJoc_MouseClick(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int a, b,c,d,g,f;

        private void pbDR_Click(object sender, EventArgs e)
        {
            flappyBird.Image = pbDR.Image;
            flappyBird.BackColor = Color.Transparent;
        }

        private void pbLD_Click(object sender, EventArgs e)
        {
            flappyBird.Image = pbLD.Image;
            flappyBird.BackColor = Color.Transparent;
        }

        private void FrmJoc_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(25, 25, 112);
            gameTimer.Stop();
            a = flappyBird.Location.X;
            b = flappyBird.Location.Y;
            c = pipeTop.Location.X;
            d = pipeTop.Location.Y;
            g = pipeBottom.Location.X;
            f = pipeBottom.Location.Y;
            try
            {
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString = @"SERVER=localhost; DATABASE=cinema; UID=root; PASSWORD=; Allow User Variables=True";
                connection.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT MAX(Scor) FROM Conturi ";
                MySqlDataReader r = cmd.ExecuteReader();

                if (r.Read())
                {
                    best = Convert.ToInt16(r["MAX(Scor)"].ToString());
                }
                connection.Close();
            }

            catch (Exception)
            {
                MessageBox.Show("Database error!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            lblScor.Text = "Best: " + best;
            lblScor.Text =lblScor.Text+  "\nMy best: " + Utilizator.mybest;
        }

        private void FrmJoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
        }

        private void FrmJoc_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
            if (e.KeyCode == Keys.R)
            {
                gameTimer.Start();
                flappyBird.Location = new Point(a, b);
                pipeTop.Location = new Point(c, d);
                pipeBottom.Location = new Point(g, f);
                score = 0;
            }
        }
        private void endGame()
        {
            gameTimer.Stop(); 
            Score.Text += "\n Game over!!!";
            if(score>best)
            {
                best = score;
                Utilizator.rec++;
                MessageBox.Show("Ai câștigat un bilet gratis la film!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            lblScor.Text = "Best: " + best;
            if (score>Utilizator.mybest)
            {
                Utilizator.mybest = score;
                try
                {
                    MySqlConnection connection = new MySqlConnection();
                    connection.ConnectionString = @"SERVER=localhost; DATABASE=cinema; UID=root; PASSWORD=; Allow User Variables=True";
                    connection.Open();

                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE Conturi Set Scor=@scor , Recompensa=@recompensa WHERE NumeU = @utilizator";
                    cmd.Parameters.AddWithValue("scor", score);
                    cmd.Parameters.AddWithValue("recompensa", Utilizator.rec);
                    cmd.Parameters.AddWithValue("utilizator", Utilizator.numeU);
                    cmd.Parameters["scor"].DbType = DbType.Int16;

                    if (cmd.ExecuteNonQuery()!=0)
                    {
                        
                    }
                  
                    connection.Close();
                }

                catch (Exception)
                {
                    MessageBox.Show("Database error!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            lblScor.Text = lblScor.Text + "\nMy best: " + Utilizator.mybest;
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            Score.Text ="Scor: " + score;

            if (pipeBottom.Left < -150)
            {
                pipeBottom.Left = 800;
                score++;
            }
            if (pipeTop.Left < -180)
            {
                pipeTop.Left = 950;
                score++;
            }

            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) || flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds) || flappyBird.Top < -25)
            {
                endGame();
            }

            if (score > 5)
            {
                pipeSpeed = 12;
            }
        }

        private void FrmJoc_MouseUp(object sender, MouseEventArgs e)
        {
            int xnou, ynou;
            xnou = this.Left + e.X - x;
            ynou = this.Top + e.Y - y;
            this.Location = new Point(xnou, ynou);
        }


    }
}
