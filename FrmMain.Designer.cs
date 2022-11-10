namespace GESTIUNE_CINEMA
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.conectareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.înregistrareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jocuriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contulMeuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gold;
            this.menuStrip1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conectareToolStripMenuItem,
            this.înregistrareToolStripMenuItem,
            this.filmeToolStripMenuItem,
            this.jocuriToolStripMenuItem,
            this.contulMeuToolStripMenuItem,
            this.administrareToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1329, 31);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // conectareToolStripMenuItem
            // 
            this.conectareToolStripMenuItem.Name = "conectareToolStripMenuItem";
            this.conectareToolStripMenuItem.Size = new System.Drawing.Size(116, 27);
            this.conectareToolStripMenuItem.Text = "Conectare";
            this.conectareToolStripMenuItem.Click += new System.EventHandler(this.conectareToolStripMenuItem_Click);
            // 
            // înregistrareToolStripMenuItem
            // 
            this.înregistrareToolStripMenuItem.Name = "înregistrareToolStripMenuItem";
            this.înregistrareToolStripMenuItem.Size = new System.Drawing.Size(135, 27);
            this.înregistrareToolStripMenuItem.Text = "Înregistrare";
            this.înregistrareToolStripMenuItem.Click += new System.EventHandler(this.înregistrareToolStripMenuItem_Click);
            // 
            // filmeToolStripMenuItem
            // 
            this.filmeToolStripMenuItem.Name = "filmeToolStripMenuItem";
            this.filmeToolStripMenuItem.Size = new System.Drawing.Size(76, 27);
            this.filmeToolStripMenuItem.Text = "Filme";
            this.filmeToolStripMenuItem.Click += new System.EventHandler(this.filmeToolStripMenuItem_Click);
            // 
            // jocuriToolStripMenuItem
            // 
            this.jocuriToolStripMenuItem.Name = "jocuriToolStripMenuItem";
            this.jocuriToolStripMenuItem.Size = new System.Drawing.Size(116, 27);
            this.jocuriToolStripMenuItem.Text = "Paparazzi";
            this.jocuriToolStripMenuItem.Visible = false;
            this.jocuriToolStripMenuItem.Click += new System.EventHandler(this.jocuriToolStripMenuItem_Click);
            // 
            // contulMeuToolStripMenuItem
            // 
            this.contulMeuToolStripMenuItem.Name = "contulMeuToolStripMenuItem";
            this.contulMeuToolStripMenuItem.Size = new System.Drawing.Size(128, 27);
            this.contulMeuToolStripMenuItem.Text = "Contul meu";
            this.contulMeuToolStripMenuItem.Visible = false;
            this.contulMeuToolStripMenuItem.Click += new System.EventHandler(this.contulMeuToolStripMenuItem_Click);
            // 
            // administrareToolStripMenuItem
            // 
            this.administrareToolStripMenuItem.Name = "administrareToolStripMenuItem";
            this.administrareToolStripMenuItem.Size = new System.Drawing.Size(147, 27);
            this.administrareToolStripMenuItem.Text = "Administrare";
            this.administrareToolStripMenuItem.Visible = false;
            this.administrareToolStripMenuItem.Click += new System.EventHandler(this.administrareToolStripMenuItem_Click);
            // 
            // pbExit
            // 
            this.pbExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbExit.BackColor = System.Drawing.Color.Gold;
            this.pbExit.Image = ((System.Drawing.Image)(resources.GetObject("pbExit.Image")));
            this.pbExit.Location = new System.Drawing.Point(1293, 1);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(35, 31);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExit.TabIndex = 4;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1329, 774);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filmeToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbExit;
        public System.Windows.Forms.ToolStripMenuItem jocuriToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem contulMeuToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem înregistrareToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem conectareToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem administrareToolStripMenuItem;
    }
}

