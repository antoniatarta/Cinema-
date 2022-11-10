namespace GESTIUNE_CINEMA
{
    partial class FrmJoc
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJoc));
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblScor = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pbDR = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbLD = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLD)).BeginInit();
            this.SuspendLayout();
            // 
            // pbExit
            // 
            this.pbExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbExit.BackColor = System.Drawing.Color.Gold;
            this.pbExit.Image = ((System.Drawing.Image)(resources.GetObject("pbExit.Image")));
            this.pbExit.Location = new System.Drawing.Point(1301, 2);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(35, 31);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExit.TabIndex = 6;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblScor);
            this.panel1.Controls.Add(this.Score);
            this.panel1.Controls.Add(this.flappyBird);
            this.panel1.Controls.Add(this.pipeTop);
            this.panel1.Controls.Add(this.pipeBottom);
            this.panel1.Controls.Add(this.ground);
            this.panel1.Location = new System.Drawing.Point(216, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1097, 593);
            this.panel1.TabIndex = 7;
            // 
            // lblScor
            // 
            this.lblScor.BackColor = System.Drawing.Color.Black;
            this.lblScor.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScor.ForeColor = System.Drawing.Color.Gold;
            this.lblScor.Location = new System.Drawing.Point(715, 526);
            this.lblScor.Name = "lblScor";
            this.lblScor.Size = new System.Drawing.Size(187, 63);
            this.lblScor.TabIndex = 40;
            this.lblScor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Score
            // 
            this.Score.BackColor = System.Drawing.Color.Black;
            this.Score.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.ForeColor = System.Drawing.Color.Gold;
            this.Score.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Score.Location = new System.Drawing.Point(908, 526);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(187, 63);
            this.Score.TabIndex = 10;
            this.Score.Text = "Scor: 0";
            this.Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flappyBird
            // 
            this.flappyBird.BackColor = System.Drawing.Color.Transparent;
            this.flappyBird.Image = ((System.Drawing.Image)(resources.GetObject("flappyBird.Image")));
            this.flappyBird.Location = new System.Drawing.Point(160, 264);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(55, 53);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.flappyBird.TabIndex = 9;
            this.flappyBird.TabStop = false;
            // 
            // pipeTop
            // 
            this.pipeTop.Image = ((System.Drawing.Image)(resources.GetObject("pipeTop.Image")));
            this.pipeTop.Location = new System.Drawing.Point(1007, -2);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(88, 183);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 8;
            this.pipeTop.TabStop = false;
            // 
            // pipeBottom
            // 
            this.pipeBottom.Image = ((System.Drawing.Image)(resources.GetObject("pipeBottom.Image")));
            this.pipeBottom.Location = new System.Drawing.Point(557, 340);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(88, 186);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom.TabIndex = 7;
            this.pipeBottom.TabStop = false;
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.Black;
            this.ground.Location = new System.Drawing.Point(-2, 526);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1097, 63);
            this.ground.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(602, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 37);
            this.label3.TabIndex = 10;
            this.label3.Text = "PAPARAZZI";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl4
            // 
            this.lbl4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(15, 42);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(187, 236);
            this.lbl4.TabIndex = 38;
            this.lbl4.Text = "Ajută-i pe actori să se ascundă de paparazzi!\r\nAlege-ți preferatul, apoi apasă R " +
    "pentru a începe jocul. Controlează-ți caracterul cu tasta SPACE.";
            this.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // pbDR
            // 
            this.pbDR.BackColor = System.Drawing.Color.Transparent;
            this.pbDR.Image = ((System.Drawing.Image)(resources.GetObject("pbDR.Image")));
            this.pbDR.Location = new System.Drawing.Point(19, 314);
            this.pbDR.Name = "pbDR";
            this.pbDR.Size = new System.Drawing.Size(183, 131);
            this.pbDR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDR.TabIndex = 10;
            this.pbDR.TabStop = false;
            this.pbDR.Click += new System.EventHandler(this.pbDR_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 23);
            this.label2.TabIndex = 40;
            this.label2.Text = "Debby Ryan";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 461);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 23);
            this.label1.TabIndex = 42;
            this.label1.Text = "Leonardo DiCaprio";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbLD
            // 
            this.pbLD.BackColor = System.Drawing.Color.Transparent;
            this.pbLD.Image = ((System.Drawing.Image)(resources.GetObject("pbLD.Image")));
            this.pbLD.Location = new System.Drawing.Point(19, 484);
            this.pbLD.Name = "pbLD";
            this.pbLD.Size = new System.Drawing.Size(183, 131);
            this.pbLD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLD.TabIndex = 41;
            this.pbLD.TabStop = false;
            this.pbLD.Click += new System.EventHandler(this.pbLD_Click);
            // 
            // FrmJoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1338, 663);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbLD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.pbDR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmJoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmJoc";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmJoc_FormClosed);
            this.Load += new System.EventHandler(this.FrmJoc_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmJoc_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmJoc_KeyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FrmJoc_MouseClick);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmJoc_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label ground;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lblScor;
        private System.Windows.Forms.PictureBox pbDR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbLD;
    }
}