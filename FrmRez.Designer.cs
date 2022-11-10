namespace GESTIUNE_CINEMA
{
    partial class FrmRez
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRez));
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.pnlSala = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGratis = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pbV = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pbR = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pbA = new System.Windows.Forms.PictureBox();
            this.cbDif = new System.Windows.Forms.ComboBox();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNr = new System.Windows.Forms.Label();
            this.lblPret = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRez = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.pnlSala.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbV)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbR)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbA)).BeginInit();
            this.SuspendLayout();
            // 
            // pbExit
            // 
            this.pbExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbExit.BackColor = System.Drawing.Color.Gold;
            this.pbExit.Image = ((System.Drawing.Image)(resources.GetObject("pbExit.Image")));
            this.pbExit.Location = new System.Drawing.Point(1179, 3);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(35, 31);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExit.TabIndex = 5;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // pnlSala
            // 
            this.pnlSala.BackColor = System.Drawing.Color.White;
            this.pnlSala.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSala.Controls.Add(this.label3);
            this.pnlSala.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSala.Location = new System.Drawing.Point(288, 40);
            this.pnlSala.Name = "pnlSala";
            this.pnlSala.Size = new System.Drawing.Size(915, 539);
            this.pnlSala.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(69, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(777, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "ECRAN";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGratis
            // 
            this.lblGratis.BackColor = System.Drawing.Color.Black;
            this.lblGratis.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGratis.ForeColor = System.Drawing.Color.White;
            this.lblGratis.Location = new System.Drawing.Point(146, 399);
            this.lblGratis.Name = "lblGratis";
            this.lblGratis.Size = new System.Drawing.Size(63, 30);
            this.lblGratis.TabIndex = 20;
            this.lblGratis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(72, 399);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 30);
            this.label8.TabIndex = 19;
            this.label8.Text = "Gratis:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pbV);
            this.panel2.Location = new System.Drawing.Point(33, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(68, 71);
            this.panel2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Liber";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbV
            // 
            this.pbV.BackColor = System.Drawing.Color.Black;
            this.pbV.Image = ((System.Drawing.Image)(resources.GetObject("pbV.Image")));
            this.pbV.Location = new System.Drawing.Point(3, 26);
            this.pbV.Name = "pbV";
            this.pbV.Size = new System.Drawing.Size(60, 40);
            this.pbV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbV.TabIndex = 0;
            this.pbV.TabStop = false;
            this.pbV.Click += new System.EventHandler(this.pbV_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pbR);
            this.panel1.Location = new System.Drawing.Point(107, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(68, 71);
            this.panel1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ocupat";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbR
            // 
            this.pbR.BackColor = System.Drawing.Color.Black;
            this.pbR.Image = ((System.Drawing.Image)(resources.GetObject("pbR.Image")));
            this.pbR.Location = new System.Drawing.Point(3, 26);
            this.pbR.Name = "pbR";
            this.pbR.Size = new System.Drawing.Size(60, 40);
            this.pbR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbR.TabIndex = 0;
            this.pbR.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.pbA);
            this.panel3.Location = new System.Drawing.Point(183, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(68, 71);
            this.panel3.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Selectat";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbA
            // 
            this.pbA.BackColor = System.Drawing.Color.Black;
            this.pbA.Image = ((System.Drawing.Image)(resources.GetObject("pbA.Image")));
            this.pbA.Location = new System.Drawing.Point(3, 26);
            this.pbA.Name = "pbA";
            this.pbA.Size = new System.Drawing.Size(60, 40);
            this.pbA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbA.TabIndex = 0;
            this.pbA.TabStop = false;
            // 
            // cbDif
            // 
            this.cbDif.BackColor = System.Drawing.Color.Black;
            this.cbDif.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDif.ForeColor = System.Drawing.Color.White;
            this.cbDif.FormattingEnabled = true;
            this.cbDif.Location = new System.Drawing.Point(33, 270);
            this.cbDif.Name = "cbDif";
            this.cbDif.Size = new System.Drawing.Size(218, 23);
            this.cbDif.TabIndex = 12;
            this.cbDif.SelectedIndexChanged += new System.EventHandler(this.cbDif_SelectedIndexChanged);
            // 
            // lblTitlu
            // 
            this.lblTitlu.BackColor = System.Drawing.Color.Black;
            this.lblTitlu.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlu.ForeColor = System.Drawing.Color.White;
            this.lblTitlu.Location = new System.Drawing.Point(33, 201);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(218, 50);
            this.lblTitlu.TabIndex = 13;
            this.lblTitlu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(72, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 30);
            this.label5.TabIndex = 14;
            this.label5.Text = "Bilete:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNr
            // 
            this.lblNr.BackColor = System.Drawing.Color.Black;
            this.lblNr.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNr.ForeColor = System.Drawing.Color.White;
            this.lblNr.Location = new System.Drawing.Point(146, 321);
            this.lblNr.Name = "lblNr";
            this.lblNr.Size = new System.Drawing.Size(63, 30);
            this.lblNr.TabIndex = 15;
            this.lblNr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPret
            // 
            this.lblPret.BackColor = System.Drawing.Color.Black;
            this.lblPret.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPret.ForeColor = System.Drawing.Color.White;
            this.lblPret.Location = new System.Drawing.Point(146, 360);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(63, 30);
            this.lblPret.TabIndex = 17;
            this.lblPret.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(72, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 30);
            this.label7.TabIndex = 16;
            this.label7.Text = "Preț:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRez
            // 
            this.btnRez.BackColor = System.Drawing.Color.Black;
            this.btnRez.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRez.ForeColor = System.Drawing.Color.White;
            this.btnRez.Location = new System.Drawing.Point(33, 488);
            this.btnRez.Name = "btnRez";
            this.btnRez.Size = new System.Drawing.Size(217, 62);
            this.btnRez.TabIndex = 18;
            this.btnRez.Text = "Rezervare";
            this.btnRez.UseVisualStyleBackColor = false;
            this.btnRez.Click += new System.EventHandler(this.btnRez_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.Black;
            this.lblTotal.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(146, 438);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(63, 30);
            this.lblTotal.TabIndex = 22;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(72, 438);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 30);
            this.label9.TabIndex = 21;
            this.label9.Text = "Total:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmRez
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1216, 630);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblGratis);
            this.Controls.Add(this.btnRez);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblPret);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblNr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.cbDif);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlSala);
            this.Controls.Add(this.pbExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRez";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVz";
            this.Load += new System.EventHandler(this.FrmRez_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FrmRez_MouseClick);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmRez_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.pnlSala.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbV)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbR)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.Panel pnlSala;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbR;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbA;
        private System.Windows.Forms.ComboBox cbDif;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNr;
        private System.Windows.Forms.Label lblPret;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRez;
        private System.Windows.Forms.Label lblGratis;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label9;
    }
}