namespace GESTIUNE_CINEMA
{
    partial class FrmFilm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFilm));
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstPoze = new System.Windows.Forms.ListBox();
            this.lblPoza = new System.Windows.Forms.Label();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.pbNext = new System.Windows.Forms.PictureBox();
            this.btnRez = new System.Windows.Forms.Button();
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.lblDes = new System.Windows.Forms.Label();
            this.lblDis = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lblPret = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lblDurata = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lblFormat = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lblAn = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblGen = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.cbFilm = new System.Windows.Forms.ComboBox();
            this.btnPref = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk300 = new System.Windows.Forms.CheckBox();
            this.chk200 = new System.Windows.Forms.CheckBox();
            this.chk150 = new System.Windows.Forms.CheckBox();
            this.chk100 = new System.Windows.Forms.CheckBox();
            this.lstGen = new System.Windows.Forms.ListBox();
            this.gbFormat = new System.Windows.Forms.GroupBox();
            this.rb4Dx = new System.Windows.Forms.RadioButton();
            this.rb3D = new System.Windows.Forms.RadioButton();
            this.rb2D = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbFormat.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbExit
            // 
            this.pbExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbExit.BackColor = System.Drawing.Color.Gold;
            this.pbExit.Image = ((System.Drawing.Image)(resources.GetObject("pbExit.Image")));
            this.pbExit.Location = new System.Drawing.Point(1265, 5);
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
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.cbFilm);
            this.panel1.Controls.Add(this.btnPref);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.lstGen);
            this.panel1.Controls.Add(this.gbFormat);
            this.panel1.Location = new System.Drawing.Point(15, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1270, 831);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lstPoze);
            this.panel2.Controls.Add(this.lblPoza);
            this.panel2.Controls.Add(this.pbBack);
            this.panel2.Controls.Add(this.pbNext);
            this.panel2.Controls.Add(this.btnRez);
            this.panel2.Controls.Add(this.pbImg);
            this.panel2.Controls.Add(this.lblDes);
            this.panel2.Controls.Add(this.lblDis);
            this.panel2.Controls.Add(this.lbl6);
            this.panel2.Controls.Add(this.lblPret);
            this.panel2.Controls.Add(this.lbl5);
            this.panel2.Controls.Add(this.lblDurata);
            this.panel2.Controls.Add(this.lbl4);
            this.panel2.Controls.Add(this.lblFormat);
            this.panel2.Controls.Add(this.lbl3);
            this.panel2.Controls.Add(this.lblAn);
            this.panel2.Controls.Add(this.lbl2);
            this.panel2.Controls.Add(this.lblGen);
            this.panel2.Controls.Add(this.lbl1);
            this.panel2.Controls.Add(this.lblTitlu);
            this.panel2.Location = new System.Drawing.Point(330, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(901, 626);
            this.panel2.TabIndex = 17;
            // 
            // lstPoze
            // 
            this.lstPoze.FormattingEnabled = true;
            this.lstPoze.ItemHeight = 16;
            this.lstPoze.Location = new System.Drawing.Point(795, 94);
            this.lstPoze.Name = "lstPoze";
            this.lstPoze.Size = new System.Drawing.Size(48, 180);
            this.lstPoze.TabIndex = 42;
            this.lstPoze.Visible = false;
            // 
            // lblPoza
            // 
            this.lblPoza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPoza.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoza.Location = new System.Drawing.Point(441, 273);
            this.lblPoza.Name = "lblPoza";
            this.lblPoza.Size = new System.Drawing.Size(299, 36);
            this.lblPoza.TabIndex = 41;
            this.lblPoza.Text = "1/3";
            this.lblPoza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPoza.Visible = false;
            // 
            // pbBack
            // 
            this.pbBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbBack.BackColor = System.Drawing.Color.Transparent;
            this.pbBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBack.Image = ((System.Drawing.Image)(resources.GetObject("pbBack.Image")));
            this.pbBack.Location = new System.Drawing.Point(403, 273);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(39, 36);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBack.TabIndex = 40;
            this.pbBack.TabStop = false;
            this.pbBack.Visible = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // pbNext
            // 
            this.pbNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbNext.BackColor = System.Drawing.Color.Transparent;
            this.pbNext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbNext.Image = ((System.Drawing.Image)(resources.GetObject("pbNext.Image")));
            this.pbNext.Location = new System.Drawing.Point(739, 273);
            this.pbNext.Name = "pbNext";
            this.pbNext.Size = new System.Drawing.Size(38, 36);
            this.pbNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNext.TabIndex = 9;
            this.pbNext.TabStop = false;
            this.pbNext.Visible = false;
            this.pbNext.Click += new System.EventHandler(this.pbNext_Click);
            // 
            // btnRez
            // 
            this.btnRez.BackColor = System.Drawing.Color.White;
            this.btnRez.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRez.Location = new System.Drawing.Point(720, 589);
            this.btnRez.Name = "btnRez";
            this.btnRez.Size = new System.Drawing.Size(176, 32);
            this.btnRez.TabIndex = 39;
            this.btnRez.Text = "Rezervare";
            this.btnRez.UseVisualStyleBackColor = false;
            this.btnRez.Visible = false;
            this.btnRez.Click += new System.EventHandler(this.btnRez_Click);
            // 
            // pbImg
            // 
            this.pbImg.BackColor = System.Drawing.Color.White;
            this.pbImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImg.Location = new System.Drawing.Point(403, 93);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(374, 181);
            this.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImg.TabIndex = 37;
            this.pbImg.TabStop = false;
            this.pbImg.Visible = false;
            // 
            // lblDes
            // 
            this.lblDes.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDes.Location = new System.Drawing.Point(33, 398);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(835, 188);
            this.lblDes.TabIndex = 32;
            this.lblDes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDis
            // 
            this.lblDis.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDis.Location = new System.Drawing.Point(177, 326);
            this.lblDis.Name = "lblDis";
            this.lblDis.Size = new System.Drawing.Size(691, 59);
            this.lblDis.TabIndex = 30;
            // 
            // lbl6
            // 
            this.lbl6.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.Location = new System.Drawing.Point(6, 317);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(156, 44);
            this.lbl6.TabIndex = 29;
            this.lbl6.Text = "Distribuție:";
            this.lbl6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl6.Visible = false;
            // 
            // lblPret
            // 
            this.lblPret.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPret.Location = new System.Drawing.Point(177, 269);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(169, 44);
            this.lblPret.TabIndex = 28;
            this.lblPret.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl5
            // 
            this.lbl5.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(49, 269);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(113, 44);
            this.lbl5.TabIndex = 27;
            this.lbl5.Text = "Preț:";
            this.lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl5.Visible = false;
            // 
            // lblDurata
            // 
            this.lblDurata.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDurata.Location = new System.Drawing.Point(177, 225);
            this.lblDurata.Name = "lblDurata";
            this.lblDurata.Size = new System.Drawing.Size(169, 44);
            this.lblDurata.TabIndex = 26;
            this.lblDurata.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl4
            // 
            this.lbl4.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(49, 225);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(113, 44);
            this.lbl4.TabIndex = 25;
            this.lbl4.Text = "Durata:";
            this.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl4.Visible = false;
            // 
            // lblFormat
            // 
            this.lblFormat.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormat.Location = new System.Drawing.Point(177, 181);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(169, 44);
            this.lblFormat.TabIndex = 24;
            this.lblFormat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl3
            // 
            this.lbl3.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(39, 181);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(123, 44);
            this.lbl3.TabIndex = 23;
            this.lbl3.Text = "Format:";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl3.Visible = false;
            // 
            // lblAn
            // 
            this.lblAn.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAn.Location = new System.Drawing.Point(177, 137);
            this.lblAn.Name = "lblAn";
            this.lblAn.Size = new System.Drawing.Size(169, 44);
            this.lblAn.TabIndex = 22;
            this.lblAn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl2
            // 
            this.lbl2.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(44, 137);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(118, 44);
            this.lbl2.TabIndex = 21;
            this.lbl2.Text = "An:";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl2.Visible = false;
            // 
            // lblGen
            // 
            this.lblGen.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGen.Location = new System.Drawing.Point(177, 93);
            this.lblGen.Name = "lblGen";
            this.lblGen.Size = new System.Drawing.Size(169, 44);
            this.lblGen.TabIndex = 20;
            this.lblGen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl1
            // 
            this.lbl1.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(49, 93);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(113, 44);
            this.lbl1.TabIndex = 19;
            this.lbl1.Text = "Gen:";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl1.Visible = false;
            // 
            // lblTitlu
            // 
            this.lblTitlu.Font = new System.Drawing.Font("Cambria", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlu.Location = new System.Drawing.Point(12, 9);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(874, 68);
            this.lblTitlu.TabIndex = 18;
            this.lblTitlu.Text = "Titlu";
            this.lblTitlu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitlu.Visible = false;
            // 
            // cbFilm
            // 
            this.cbFilm.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilm.FormattingEnabled = true;
            this.cbFilm.Location = new System.Drawing.Point(330, 96);
            this.cbFilm.Name = "cbFilm";
            this.cbFilm.Size = new System.Drawing.Size(901, 31);
            this.cbFilm.TabIndex = 16;
            this.cbFilm.Text = "Toate filmele";
            this.cbFilm.SelectedIndexChanged += new System.EventHandler(this.cbFilm_SelectedIndexChanged);
            this.cbFilm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbFilm_KeyPress);
            // 
            // btnPref
            // 
            this.btnPref.BackColor = System.Drawing.Color.White;
            this.btnPref.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPref.Location = new System.Drawing.Point(38, 729);
            this.btnPref.Name = "btnPref";
            this.btnPref.Size = new System.Drawing.Size(254, 61);
            this.btnPref.TabIndex = 15;
            this.btnPref.Text = "Căutare";
            this.btnPref.UseVisualStyleBackColor = false;
            this.btnPref.Click += new System.EventHandler(this.btnPref_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.chk300);
            this.groupBox1.Controls.Add(this.chk200);
            this.groupBox1.Controls.Add(this.chk150);
            this.groupBox1.Controls.Add(this.chk100);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 487);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 221);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Durata(minute)";
            // 
            // chk300
            // 
            this.chk300.AutoSize = true;
            this.chk300.Location = new System.Drawing.Point(68, 177);
            this.chk300.Name = "chk300";
            this.chk300.Size = new System.Drawing.Size(80, 27);
            this.chk300.TabIndex = 3;
            this.chk300.Text = "200+";
            this.chk300.UseVisualStyleBackColor = true;
            // 
            // chk200
            // 
            this.chk200.AutoSize = true;
            this.chk200.Location = new System.Drawing.Point(68, 132);
            this.chk200.Name = "chk200";
            this.chk200.Size = new System.Drawing.Size(111, 27);
            this.chk200.TabIndex = 2;
            this.chk200.Text = "150-200";
            this.chk200.UseVisualStyleBackColor = true;
            // 
            // chk150
            // 
            this.chk150.AutoSize = true;
            this.chk150.Location = new System.Drawing.Point(68, 88);
            this.chk150.Name = "chk150";
            this.chk150.Size = new System.Drawing.Size(111, 27);
            this.chk150.TabIndex = 1;
            this.chk150.Text = "100-150";
            this.chk150.UseVisualStyleBackColor = true;
            // 
            // chk100
            // 
            this.chk100.AutoSize = true;
            this.chk100.Checked = true;
            this.chk100.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk100.Location = new System.Drawing.Point(68, 45);
            this.chk100.Name = "chk100";
            this.chk100.Size = new System.Drawing.Size(80, 27);
            this.chk100.TabIndex = 0;
            this.chk100.Text = "<100";
            this.chk100.UseVisualStyleBackColor = true;
            // 
            // lstGen
            // 
            this.lstGen.BackColor = System.Drawing.Color.White;
            this.lstGen.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstGen.FormattingEnabled = true;
            this.lstGen.ItemHeight = 23;
            this.lstGen.Location = new System.Drawing.Point(38, 164);
            this.lstGen.Name = "lstGen";
            this.lstGen.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstGen.Size = new System.Drawing.Size(254, 326);
            this.lstGen.TabIndex = 13;
            // 
            // gbFormat
            // 
            this.gbFormat.BackColor = System.Drawing.Color.Transparent;
            this.gbFormat.Controls.Add(this.rb4Dx);
            this.gbFormat.Controls.Add(this.rb3D);
            this.gbFormat.Controls.Add(this.rb2D);
            this.gbFormat.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFormat.Location = new System.Drawing.Point(38, 66);
            this.gbFormat.Name = "gbFormat";
            this.gbFormat.Size = new System.Drawing.Size(254, 80);
            this.gbFormat.TabIndex = 12;
            this.gbFormat.TabStop = false;
            this.gbFormat.Text = "Format";
            // 
            // rb4Dx
            // 
            this.rb4Dx.AutoSize = true;
            this.rb4Dx.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rb4Dx.Location = new System.Drawing.Point(166, 34);
            this.rb4Dx.Name = "rb4Dx";
            this.rb4Dx.Size = new System.Drawing.Size(68, 27);
            this.rb4Dx.TabIndex = 2;
            this.rb4Dx.Text = "4Dx";
            this.rb4Dx.UseVisualStyleBackColor = true;
            // 
            // rb3D
            // 
            this.rb3D.AutoSize = true;
            this.rb3D.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rb3D.Location = new System.Drawing.Point(98, 34);
            this.rb3D.Name = "rb3D";
            this.rb3D.Size = new System.Drawing.Size(57, 27);
            this.rb3D.TabIndex = 1;
            this.rb3D.Text = "3D";
            this.rb3D.UseVisualStyleBackColor = true;
            // 
            // rb2D
            // 
            this.rb2D.AutoSize = true;
            this.rb2D.Checked = true;
            this.rb2D.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rb2D.Location = new System.Drawing.Point(26, 34);
            this.rb2D.Name = "rb2D";
            this.rb2D.Size = new System.Drawing.Size(57, 27);
            this.rb2D.TabIndex = 0;
            this.rb2D.TabStop = true;
            this.rb2D.Text = "2D";
            this.rb2D.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Snow;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(577, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 37);
            this.label3.TabIndex = 8;
            this.label3.Text = "Filme";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1303, 882);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFilm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFilm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmFilm_FormClosed);
            this.Load += new System.EventHandler(this.FrmFilm_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FrmFilm_MouseClick);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmFilm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbFormat.ResumeLayout(false);
            this.gbFormat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbFormat;
        private System.Windows.Forms.RadioButton rb4Dx;
        private System.Windows.Forms.RadioButton rb3D;
        private System.Windows.Forms.RadioButton rb2D;
        private System.Windows.Forms.ListBox lstGen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chk300;
        private System.Windows.Forms.CheckBox chk200;
        private System.Windows.Forms.CheckBox chk150;
        private System.Windows.Forms.CheckBox chk100;
        private System.Windows.Forms.Button btnPref;
        private System.Windows.Forms.ComboBox cbFilm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblGen;
        private System.Windows.Forms.Label lblAn;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lblDurata;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lblPret;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lblDis;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.PictureBox pbImg;
        private System.Windows.Forms.Button btnRez;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.PictureBox pbNext;
        private System.Windows.Forms.Label lblPoza;
        private System.Windows.Forms.ListBox lstPoze;
    }
}