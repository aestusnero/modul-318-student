namespace GUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnK = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.PV = new System.Windows.Forms.Panel();
            this.VSG = new System.Windows.Forms.GroupBox();
            this.LN = new System.Windows.Forms.Label();
            this.LV = new System.Windows.Forms.Label();
            this.LZ = new System.Windows.Forms.Label();
            this.LD = new System.Windows.Forms.Label();
            this.ZEIT = new System.Windows.Forms.DateTimePicker();
            this.DATUM = new System.Windows.Forms.DateTimePicker();
            this.txtNACH = new System.Windows.Forms.ComboBox();
            this.txtVON = new System.Windows.Forms.ComboBox();
            this.btnSuche = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.Von = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dauer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abfahrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ankunft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gleis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Schliessen = new System.Windows.Forms.Button();
            this.STG = new System.Windows.Forms.Panel();
            this.SSG = new System.Windows.Forms.GroupBox();
            this.txtSS = new System.Windows.Forms.ComboBox();
            this.btnSS = new System.Windows.Forms.Button();
            this.DGS = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KAG = new System.Windows.Forms.Panel();
            this.Karte = new System.Windows.Forms.WebBrowser();
            this.KGG = new System.Windows.Forms.GroupBox();
            this.txtKA = new System.Windows.Forms.ComboBox();
            this.btnKG = new System.Windows.Forms.Button();
            this.btnVB = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.PV.SuspendLayout();
            this.VSG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.STG.SuspendLayout();
            this.SSG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGS)).BeginInit();
            this.KAG.SuspendLayout();
            this.KGG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnK
            // 
            this.btnK.Location = new System.Drawing.Point(194, 524);
            this.btnK.Name = "btnK";
            this.btnK.Size = new System.Drawing.Size(85, 25);
            this.btnK.TabIndex = 0;
            this.btnK.Text = "Karte";
            this.btnK.UseVisualStyleBackColor = true;
            this.btnK.Click += new System.EventHandler(this.btnK_Click);
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(103, 524);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(85, 25);
            this.btnA.TabIndex = 1;
            this.btnA.Text = "Abfahrt";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // PV
            // 
            this.PV.Controls.Add(this.VSG);
            this.PV.Controls.Add(this.DGV);
            this.PV.Location = new System.Drawing.Point(12, 12);
            this.PV.Name = "PV";
            this.PV.Size = new System.Drawing.Size(510, 506);
            this.PV.TabIndex = 2;
            this.PV.Visible = false;
            // 
            // VSG
            // 
            this.VSG.Controls.Add(this.pictureBox1);
            this.VSG.Controls.Add(this.LN);
            this.VSG.Controls.Add(this.LV);
            this.VSG.Controls.Add(this.LZ);
            this.VSG.Controls.Add(this.LD);
            this.VSG.Controls.Add(this.ZEIT);
            this.VSG.Controls.Add(this.DATUM);
            this.VSG.Controls.Add(this.txtNACH);
            this.VSG.Controls.Add(this.txtVON);
            this.VSG.Controls.Add(this.btnSuche);
            this.VSG.Controls.Add(this.btnReverse);
            this.VSG.Location = new System.Drawing.Point(3, 3);
            this.VSG.Name = "VSG";
            this.VSG.Size = new System.Drawing.Size(504, 78);
            this.VSG.TabIndex = 6;
            this.VSG.TabStop = false;
            this.VSG.Text = "Verbindungen";
            // 
            // LN
            // 
            this.LN.AutoSize = true;
            this.LN.Location = new System.Drawing.Point(52, 50);
            this.LN.Name = "LN";
            this.LN.Size = new System.Drawing.Size(33, 13);
            this.LN.TabIndex = 12;
            this.LN.Text = "Nach";
            // 
            // LV
            // 
            this.LV.AutoSize = true;
            this.LV.Location = new System.Drawing.Point(59, 21);
            this.LV.Name = "LV";
            this.LV.Size = new System.Drawing.Size(26, 13);
            this.LV.TabIndex = 11;
            this.LV.Text = "Von";
            // 
            // LZ
            // 
            this.LZ.AutoSize = true;
            this.LZ.Location = new System.Drawing.Point(290, 52);
            this.LZ.Name = "LZ";
            this.LZ.Size = new System.Drawing.Size(25, 13);
            this.LZ.TabIndex = 10;
            this.LZ.Text = "Zeit";
            // 
            // LD
            // 
            this.LD.AutoSize = true;
            this.LD.Location = new System.Drawing.Point(290, 24);
            this.LD.Name = "LD";
            this.LD.Size = new System.Drawing.Size(38, 13);
            this.LD.TabIndex = 9;
            this.LD.Text = "Datum";
            // 
            // ZEIT
            // 
            this.ZEIT.CustomFormat = "HH.mm";
            this.ZEIT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ZEIT.Location = new System.Drawing.Point(334, 52);
            this.ZEIT.Name = "ZEIT";
            this.ZEIT.ShowUpDown = true;
            this.ZEIT.Size = new System.Drawing.Size(87, 20);
            this.ZEIT.TabIndex = 8;
            // 
            // DATUM
            // 
            this.DATUM.CustomFormat = "dd.MM.yyyy";
            this.DATUM.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DATUM.Location = new System.Drawing.Point(334, 22);
            this.DATUM.Name = "DATUM";
            this.DATUM.Size = new System.Drawing.Size(87, 20);
            this.DATUM.TabIndex = 7;
            // 
            // txtNACH
            // 
            this.txtNACH.FormattingEnabled = true;
            this.txtNACH.Location = new System.Drawing.Point(91, 50);
            this.txtNACH.Name = "txtNACH";
            this.txtNACH.Size = new System.Drawing.Size(113, 21);
            this.txtNACH.TabIndex = 6;
            this.txtNACH.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNACH_KeyUp);
            // 
            // txtVON
            // 
            this.txtVON.FormattingEnabled = true;
            this.txtVON.Location = new System.Drawing.Point(91, 21);
            this.txtVON.Name = "txtVON";
            this.txtVON.Size = new System.Drawing.Size(113, 21);
            this.txtVON.TabIndex = 5;
            this.txtVON.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtVON_KeyUp);
            // 
            // btnSuche
            // 
            this.btnSuche.Location = new System.Drawing.Point(427, 22);
            this.btnSuche.Name = "btnSuche";
            this.btnSuche.Size = new System.Drawing.Size(71, 51);
            this.btnSuche.TabIndex = 2;
            this.btnSuche.Text = "Verbindung Suchen";
            this.btnSuche.UseVisualStyleBackColor = true;
            this.btnSuche.Click += new System.EventHandler(this.btnSuche_Click);
            // 
            // btnReverse
            // 
            this.btnReverse.BackColor = System.Drawing.Color.Transparent;
            this.btnReverse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReverse.BackgroundImage")));
            this.btnReverse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReverse.Location = new System.Drawing.Point(210, 21);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(48, 51);
            this.btnReverse.TabIndex = 4;
            this.btnReverse.UseCompatibleTextRendering = true;
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // DGV
            // 
            this.DGV.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Von,
            this.Nach,
            this.Dauer,
            this.Abfahrt,
            this.Ankunft,
            this.Gleis});
            this.DGV.Location = new System.Drawing.Point(3, 81);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersVisible = false;
            this.DGV.Size = new System.Drawing.Size(504, 422);
            this.DGV.TabIndex = 4;
            this.DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Von
            // 
            this.Von.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Von.FillWeight = 68.21066F;
            this.Von.HeaderText = "Von";
            this.Von.Name = "Von";
            this.Von.Width = 150;
            // 
            // Nach
            // 
            this.Nach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nach.FillWeight = 523.858F;
            this.Nach.HeaderText = "Nach";
            this.Nach.Name = "Nach";
            this.Nach.Width = 150;
            // 
            // Dauer
            // 
            this.Dauer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dauer.FillWeight = 1.982869F;
            this.Dauer.HeaderText = "Dauer";
            this.Dauer.Name = "Dauer";
            // 
            // Abfahrt
            // 
            this.Abfahrt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Abfahrt.FillWeight = 1.982869F;
            this.Abfahrt.HeaderText = "Abfahrt";
            this.Abfahrt.Name = "Abfahrt";
            // 
            // Ankunft
            // 
            this.Ankunft.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ankunft.FillWeight = 1.982869F;
            this.Ankunft.HeaderText = "Ankunft";
            this.Ankunft.Name = "Ankunft";
            // 
            // Gleis
            // 
            this.Gleis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gleis.FillWeight = 1.982869F;
            this.Gleis.HeaderText = "Gleis";
            this.Gleis.Name = "Gleis";
            // 
            // Schliessen
            // 
            this.Schliessen.Location = new System.Drawing.Point(442, 524);
            this.Schliessen.Name = "Schliessen";
            this.Schliessen.Size = new System.Drawing.Size(80, 25);
            this.Schliessen.TabIndex = 6;
            this.Schliessen.Text = "Schliessen";
            this.Schliessen.UseVisualStyleBackColor = true;
            this.Schliessen.Click += new System.EventHandler(this.Schliessen_Click);
            // 
            // STG
            // 
            this.STG.Controls.Add(this.SSG);
            this.STG.Controls.Add(this.DGS);
            this.STG.Location = new System.Drawing.Point(12, 12);
            this.STG.Name = "STG";
            this.STG.Size = new System.Drawing.Size(510, 506);
            this.STG.TabIndex = 7;
            this.STG.Visible = false;
            this.STG.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SSG
            // 
            this.SSG.Controls.Add(this.pictureBox3);
            this.SSG.Controls.Add(this.txtSS);
            this.SSG.Controls.Add(this.btnSS);
            this.SSG.Location = new System.Drawing.Point(3, 3);
            this.SSG.Name = "SSG";
            this.SSG.Size = new System.Drawing.Size(504, 78);
            this.SSG.TabIndex = 7;
            this.SSG.TabStop = false;
            this.SSG.Text = "Stationen";
            // 
            // txtSS
            // 
            this.txtSS.FormattingEnabled = true;
            this.txtSS.Location = new System.Drawing.Point(59, 22);
            this.txtSS.Name = "txtSS";
            this.txtSS.Size = new System.Drawing.Size(163, 21);
            this.txtSS.TabIndex = 1;
            this.txtSS.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSS_KeyUp);
            // 
            // btnSS
            // 
            this.btnSS.Location = new System.Drawing.Point(412, 21);
            this.btnSS.Name = "btnSS";
            this.btnSS.Size = new System.Drawing.Size(86, 49);
            this.btnSS.TabIndex = 2;
            this.btnSS.Text = "Verbindungen Suchen";
            this.btnSS.UseVisualStyleBackColor = true;
            this.btnSS.Click += new System.EventHandler(this.btnSS_Click);
            // 
            // DGS
            // 
            this.DGS.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.DGS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn2});
            this.DGS.Location = new System.Drawing.Point(3, 81);
            this.DGS.Name = "DGS";
            this.DGS.RowHeadersVisible = false;
            this.DGS.Size = new System.Drawing.Size(504, 422);
            this.DGS.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Station";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Abfahrtszeit";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nach";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // KAG
            // 
            this.KAG.Controls.Add(this.Karte);
            this.KAG.Controls.Add(this.KGG);
            this.KAG.Location = new System.Drawing.Point(12, 12);
            this.KAG.Name = "KAG";
            this.KAG.Size = new System.Drawing.Size(510, 506);
            this.KAG.TabIndex = 9;
            this.KAG.Visible = false;
            // 
            // Karte
            // 
            this.Karte.Location = new System.Drawing.Point(3, 81);
            this.Karte.MinimumSize = new System.Drawing.Size(20, 20);
            this.Karte.Name = "Karte";
            this.Karte.Size = new System.Drawing.Size(504, 422);
            this.Karte.TabIndex = 9;
            // 
            // KGG
            // 
            this.KGG.Controls.Add(this.pictureBox2);
            this.KGG.Controls.Add(this.txtKA);
            this.KGG.Controls.Add(this.btnKG);
            this.KGG.Location = new System.Drawing.Point(3, 3);
            this.KGG.Name = "KGG";
            this.KGG.Size = new System.Drawing.Size(504, 78);
            this.KGG.TabIndex = 8;
            this.KGG.TabStop = false;
            this.KGG.Text = "Ortschaften";
            // 
            // txtKA
            // 
            this.txtKA.FormattingEnabled = true;
            this.txtKA.Location = new System.Drawing.Point(59, 23);
            this.txtKA.Name = "txtKA";
            this.txtKA.Size = new System.Drawing.Size(163, 21);
            this.txtKA.TabIndex = 1;
            this.txtKA.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtKA_KeyUp);
            // 
            // btnKG
            // 
            this.btnKG.Location = new System.Drawing.Point(412, 23);
            this.btnKG.Name = "btnKG";
            this.btnKG.Size = new System.Drawing.Size(86, 47);
            this.btnKG.TabIndex = 2;
            this.btnKG.Text = "Stationen Suchen";
            this.btnKG.UseVisualStyleBackColor = true;
            this.btnKG.Click += new System.EventHandler(this.btnKG_Click);
            // 
            // btnVB
            // 
            this.btnVB.Location = new System.Drawing.Point(12, 524);
            this.btnVB.Name = "btnVB";
            this.btnVB.Size = new System.Drawing.Size(85, 25);
            this.btnVB.TabIndex = 10;
            this.btnVB.Text = "Verbindungen";
            this.btnVB.UseVisualStyleBackColor = true;
            this.btnVB.Click += new System.EventHandler(this.btnVB_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 49);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 49);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(6, 23);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 49);
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 561);
            this.Controls.Add(this.btnVB);
            this.Controls.Add(this.Schliessen);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.btnK);
            this.Controls.Add(this.STG);
            this.Controls.Add(this.PV);
            this.Controls.Add(this.KAG);
            this.Name = "Form1";
            this.Text = "ÖV";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PV.ResumeLayout(false);
            this.VSG.ResumeLayout(false);
            this.VSG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.STG.ResumeLayout(false);
            this.SSG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGS)).EndInit();
            this.KAG.ResumeLayout(false);
            this.KGG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnK;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Panel PV;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnSuche;
        private System.Windows.Forms.Button Schliessen;
        private System.Windows.Forms.GroupBox VSG;
        private System.Windows.Forms.Panel STG;
        private System.Windows.Forms.DataGridView DGS;
        private System.Windows.Forms.GroupBox SSG;
        private System.Windows.Forms.ComboBox txtSS;
        private System.Windows.Forms.Button btnSS;
        private System.Windows.Forms.Panel KAG;
        private System.Windows.Forms.GroupBox KGG;
        private System.Windows.Forms.ComboBox txtKA;
        private System.Windows.Forms.Button btnKG;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.WebBrowser Karte;
        private System.Windows.Forms.Button btnVB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Von;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dauer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ankunft;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gleis;
        private System.Windows.Forms.ComboBox txtNACH;
        private System.Windows.Forms.ComboBox txtVON;
        private System.Windows.Forms.Label LN;
        private System.Windows.Forms.Label LV;
        private System.Windows.Forms.Label LZ;
        private System.Windows.Forms.Label LD;
        private System.Windows.Forms.DateTimePicker ZEIT;
        private System.Windows.Forms.DateTimePicker DATUM;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

