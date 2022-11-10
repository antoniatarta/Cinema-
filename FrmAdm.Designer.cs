namespace GESTIUNE_CINEMA
{
    partial class FrmAdm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdm));
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstOra = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnStergD = new System.Windows.Forms.Button();
            this.cboDif = new System.Windows.Forms.ComboBox();
            this.btnDif = new System.Windows.Forms.Button();
            this.txtM = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbFilm2 = new System.Windows.Forms.ComboBox();
            this.lblNr = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblImg = new System.Windows.Forms.Label();
            this.btnAddPoza = new System.Windows.Forms.Button();
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.cboFormat = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDescriere = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDis = new System.Windows.Forms.TextBox();
            this.txtDurata = new System.Windows.Forms.TextBox();
            this.txtAn = new System.Windows.Forms.TextBox();
            this.txtGen = new System.Windows.Forms.TextBox();
            this.txtDen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnStergF = new System.Windows.Forms.Button();
            this.cbFilm = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            this.SuspendLayout();
            // 
            // pbExit
            // 
            this.pbExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbExit.BackColor = System.Drawing.Color.Gold;
            this.pbExit.Image = ((System.Drawing.Image)(resources.GetObject("pbExit.Image")));
            this.pbExit.Location = new System.Drawing.Point(1112, 5);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(35, 31);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExit.TabIndex = 7;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lstOra);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnStergD);
            this.panel1.Controls.Add(this.cboDif);
            this.panel1.Controls.Add(this.btnDif);
            this.panel1.Controls.Add(this.txtM);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtH);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.cbFilm2);
            this.panel1.Controls.Add(this.lblNr);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblImg);
            this.panel1.Controls.Add(this.btnAddPoza);
            this.panel1.Controls.Add(this.pbImg);
            this.panel1.Controls.Add(this.cboFormat);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtDescriere);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtDis);
            this.panel1.Controls.Add(this.txtDurata);
            this.panel1.Controls.Add(this.txtAn);
            this.panel1.Controls.Add(this.txtGen);
            this.panel1.Controls.Add(this.txtDen);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbl6);
            this.panel1.Controls.Add(this.lbl4);
            this.panel1.Controls.Add(this.lbl2);
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Controls.Add(this.btnStergF);
            this.panel1.Controls.Add(this.cbFilm);
            this.panel1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1125, 623);
            this.panel1.TabIndex = 8;
            // 
            // lstOra
            // 
            this.lstOra.FormattingEnabled = true;
            this.lstOra.ItemHeight = 23;
            this.lstOra.Location = new System.Drawing.Point(1108, 190);
            this.lstOra.Name = "lstOra";
            this.lstOra.Size = new System.Drawing.Size(10, 4);
            this.lstOra.TabIndex = 71;
            this.lstOra.Visible = false;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(788, 501);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 31);
            this.label7.TabIndex = 70;
            this.label7.Text = "(sub forma HH:MM)";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStergD
            // 
            this.btnStergD.BackColor = System.Drawing.Color.White;
            this.btnStergD.Location = new System.Drawing.Point(706, 137);
            this.btnStergD.Name = "btnStergD";
            this.btnStergD.Size = new System.Drawing.Size(278, 57);
            this.btnStergD.TabIndex = 69;
            this.btnStergD.Text = "Șterge difuzarea";
            this.btnStergD.UseVisualStyleBackColor = false;
            this.btnStergD.Click += new System.EventHandler(this.btnStergD_Click);
            // 
            // cboDif
            // 
            this.cboDif.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDif.FormattingEnabled = true;
            this.cboDif.Location = new System.Drawing.Point(587, 80);
            this.cboDif.Name = "cboDif";
            this.cboDif.Size = new System.Drawing.Size(518, 31);
            this.cboDif.TabIndex = 68;
            this.cboDif.Text = "Toate difuzările";
            this.cboDif.SelectedIndexChanged += new System.EventHandler(this.cboDif_SelectedIndexChanged);
            // 
            // btnDif
            // 
            this.btnDif.BackColor = System.Drawing.Color.White;
            this.btnDif.Location = new System.Drawing.Point(706, 535);
            this.btnDif.Name = "btnDif";
            this.btnDif.Size = new System.Drawing.Size(278, 57);
            this.btnDif.TabIndex = 67;
            this.btnDif.Text = "Adaugă difuzarea";
            this.btnDif.UseVisualStyleBackColor = false;
            this.btnDif.Click += new System.EventHandler(this.btnDif_Click);
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(893, 461);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(47, 31);
            this.txtM.TabIndex = 66;
            this.txtM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtM_KeyPress);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(870, 461);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 29);
            this.label6.TabIndex = 65;
            this.label6.Text = ":";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(817, 461);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(47, 31);
            this.txtH.TabIndex = 64;
            this.txtH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtH_KeyPress);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(693, 461);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 31);
            this.label5.TabIndex = 63;
            this.label5.Text = "Ora:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(714, 245);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 62;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gold;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(-2, 129);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(558, 10);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 61;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gold;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(554, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 624);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // cbFilm2
            // 
            this.cbFilm2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilm2.FormattingEnabled = true;
            this.cbFilm2.Location = new System.Drawing.Point(587, 29);
            this.cbFilm2.Name = "cbFilm2";
            this.cbFilm2.Size = new System.Drawing.Size(518, 31);
            this.cbFilm2.TabIndex = 59;
            this.cbFilm2.Text = "Toate filmele";
            this.cbFilm2.SelectedIndexChanged += new System.EventHandler(this.cbFilm2_SelectedIndexChanged);
            // 
            // lblNr
            // 
            this.lblNr.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNr.Location = new System.Drawing.Point(143, 446);
            this.lblNr.Name = "lblNr";
            this.lblNr.Size = new System.Drawing.Size(69, 33);
            this.lblNr.TabIndex = 58;
            this.lblNr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-9, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 27);
            this.label4.TabIndex = 57;
            this.label4.Text = "Nr. imagini adăugate:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblImg
            // 
            this.lblImg.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblImg.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImg.Location = new System.Drawing.Point(182, 523);
            this.lblImg.Name = "lblImg";
            this.lblImg.Size = new System.Drawing.Size(30, 31);
            this.lblImg.TabIndex = 56;
            this.lblImg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblImg.Visible = false;
            // 
            // btnAddPoza
            // 
            this.btnAddPoza.BackColor = System.Drawing.Color.White;
            this.btnAddPoza.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPoza.Location = new System.Drawing.Point(472, 411);
            this.btnAddPoza.Name = "btnAddPoza";
            this.btnAddPoza.Size = new System.Drawing.Size(24, 33);
            this.btnAddPoza.TabIndex = 55;
            this.btnAddPoza.Text = "+";
            this.btnAddPoza.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddPoza.UseVisualStyleBackColor = false;
            this.btnAddPoza.Click += new System.EventHandler(this.btnAddPoza_Click);
            // 
            // pbImg
            // 
            this.pbImg.BackColor = System.Drawing.Color.White;
            this.pbImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImg.Location = new System.Drawing.Point(218, 410);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(278, 144);
            this.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImg.TabIndex = 54;
            this.pbImg.TabStop = false;
            // 
            // cboFormat
            // 
            this.cboFormat.FormattingEnabled = true;
            this.cboFormat.Items.AddRange(new object[] {
            "2D",
            "3D",
            "4Dx"});
            this.cboFormat.Location = new System.Drawing.Point(218, 265);
            this.cboFormat.Name = "cboFormat";
            this.cboFormat.Size = new System.Drawing.Size(105, 31);
            this.cboFormat.TabIndex = 53;
            this.cboFormat.Text = "Format";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(218, 558);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(278, 57);
            this.btnAdd.TabIndex = 52;
            this.btnAdd.Text = "Adaugă filmul";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDescriere
            // 
            this.txtDescriere.Location = new System.Drawing.Point(218, 374);
            this.txtDescriere.Name = "txtDescriere";
            this.txtDescriere.Size = new System.Drawing.Size(307, 31);
            this.txtDescriere.TabIndex = 51;
            this.txtDescriere.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 27);
            this.label1.TabIndex = 50;
            this.label1.Text = "Descriere:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDis
            // 
            this.txtDis.Location = new System.Drawing.Point(218, 338);
            this.txtDis.Name = "txtDis";
            this.txtDis.Size = new System.Drawing.Size(307, 31);
            this.txtDis.TabIndex = 49;
            this.txtDis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDurata
            // 
            this.txtDurata.Location = new System.Drawing.Point(218, 301);
            this.txtDurata.Name = "txtDurata";
            this.txtDurata.Size = new System.Drawing.Size(76, 31);
            this.txtDurata.TabIndex = 48;
            this.txtDurata.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDurata.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDurata_KeyPress);
            // 
            // txtAn
            // 
            this.txtAn.Location = new System.Drawing.Point(218, 226);
            this.txtAn.Name = "txtAn";
            this.txtAn.Size = new System.Drawing.Size(76, 31);
            this.txtAn.TabIndex = 46;
            this.txtAn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAn_KeyPress);
            // 
            // txtGen
            // 
            this.txtGen.Location = new System.Drawing.Point(218, 188);
            this.txtGen.Name = "txtGen";
            this.txtGen.Size = new System.Drawing.Size(146, 31);
            this.txtGen.TabIndex = 45;
            this.txtGen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDen
            // 
            this.txtDen.Location = new System.Drawing.Point(218, 151);
            this.txtDen.Name = "txtDen";
            this.txtDen.Size = new System.Drawing.Size(307, 31);
            this.txtDen.TabIndex = 44;
            this.txtDen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 27);
            this.label2.TabIndex = 43;
            this.label2.Text = "Denumire:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl6
            // 
            this.lbl6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.Location = new System.Drawing.Point(56, 336);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(156, 27);
            this.lbl6.TabIndex = 41;
            this.lbl6.Text = "Distribuție:";
            this.lbl6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl4
            // 
            this.lbl4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(99, 298);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(113, 29);
            this.lbl4.TabIndex = 37;
            this.lbl4.Text = "Durata:";
            this.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl2
            // 
            this.lbl2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(99, 223);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(118, 29);
            this.lbl2.TabIndex = 33;
            this.lbl2.Text = "An:";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl1
            // 
            this.lbl1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(99, 186);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(113, 27);
            this.lbl1.TabIndex = 31;
            this.lbl1.Text = "Gen:";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnStergF
            // 
            this.btnStergF.BackColor = System.Drawing.Color.White;
            this.btnStergF.Location = new System.Drawing.Point(147, 66);
            this.btnStergF.Name = "btnStergF";
            this.btnStergF.Size = new System.Drawing.Size(278, 57);
            this.btnStergF.TabIndex = 18;
            this.btnStergF.Text = "Șterge filmul";
            this.btnStergF.UseVisualStyleBackColor = false;
            this.btnStergF.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // cbFilm
            // 
            this.cbFilm.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilm.FormattingEnabled = true;
            this.cbFilm.Location = new System.Drawing.Point(22, 29);
            this.cbFilm.Name = "cbFilm";
            this.cbFilm.Size = new System.Drawing.Size(513, 31);
            this.cbFilm.TabIndex = 17;
            this.cbFilm.Text = "Toate filmele";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Snow;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(497, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 37);
            this.label3.TabIndex = 9;
            this.label3.Text = "Administrare";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // FrmAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1149, 676);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAdm_FormClosed);
            this.Load += new System.EventHandler(this.FrmAdm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFilm;
        private System.Windows.Forms.Button btnStergF;
        private System.Windows.Forms.TextBox txtDen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtAn;
        private System.Windows.Forms.TextBox txtGen;
        private System.Windows.Forms.TextBox txtDurata;
        private System.Windows.Forms.TextBox txtDescriere;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDis;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cboFormat;
        private System.Windows.Forms.PictureBox pbImg;
        private System.Windows.Forms.Button btnAddPoza;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Label lblImg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNr;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbFilm2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDif;
        private System.Windows.Forms.Button btnStergD;
        private System.Windows.Forms.ComboBox cboDif;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstOra;
    }
}