using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTIUNE_CINEMA
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public FrmConectare frmC= null;
        public FrmInreg frmI = null;
        public FrmFilm frmF =null;
        public FrmAdm frmA = null;
        public FrmJoc frmJ = null;
        public FrmCont frmc = null;
        private void FrmMain_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                MdiClient client = control as MdiClient;
                if (!(client == null))
                {
                    client.BackColor = Color.FromArgb(25,25,112);
                    break;
                }
            }
        }
        private void conectareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmC == null)
            {
                frmC = new FrmConectare();
                frmC.MdiParent = this;
                frmC.Show();
            }
        }

        private void înregistrareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmI == null)
            {
                frmI = new FrmInreg();
                frmI.MdiParent = this;
                frmI.Show();
            }
        }

        private void administrareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmA == null)
            {
                frmA = new FrmAdm();
                frmA.MdiParent = this;
                frmA.Show();
            }
        }
        private void filmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmF == null)
            {
                frmF = new FrmFilm();
                frmF.MdiParent = this;
                frmF.Show();
            }
        }

        private void jocuriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmJ == null)
            {
                frmJ = new FrmJoc();
                frmJ.MdiParent = this;
                frmJ.Show();
            }
        }

        private void contulMeuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmc == null)
            {
                frmc = new FrmCont();
                frmc.MdiParent = this;
                frmc.Show();
            }
        }
    }
}
