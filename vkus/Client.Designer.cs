namespace vkus
{
    partial class Client
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.jaunsPieraksts = new System.Windows.Forms.Panel();
            this.pierakstsJaunam = new System.Windows.Forms.Panel();
            this.pierakstsEsosam = new System.Windows.Forms.Panel();
            this.apstiprinatEsosam = new System.Windows.Forms.Button();
            this.pacientsVards = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.piezimesEsosam = new System.Windows.Forms.RichTextBox();
            this.iemeslsEsosam = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.datumsEsosam = new System.Windows.Forms.DateTimePicker();
            this.laiksEsosam = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.apstiprinatJaunam = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.piezimesJaunam = new System.Windows.Forms.RichTextBox();
            this.iemeslsJaunam = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.laiksJaunam = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.datumsJaunam = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dzimums = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.vecums = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.pacientaSugaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pacientaVardsTextBox = new System.Windows.Forms.TextBox();
            this.pacientaVardsLabel = new System.Windows.Forms.Label();
            this.pierakstsEsosamPoga = new System.Windows.Forms.Button();
            this.pierakstsJaunamPoga = new System.Windows.Forms.Button();
            this.pieraksti = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pierakstiMajdzivniekaVardi = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jaunsPieraksts.SuspendLayout();
            this.pierakstsJaunam.SuspendLayout();
            this.pierakstsEsosam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vecums)).BeginInit();
            this.pieraksti.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Izveidot jaunu pierakstu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.JaunsPieraksts_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Pieraksti";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Pieraksti_Click);
            // 
            // jaunsPieraksts
            // 
            this.jaunsPieraksts.Controls.Add(this.pierakstsJaunam);
            this.jaunsPieraksts.Controls.Add(this.pierakstsEsosamPoga);
            this.jaunsPieraksts.Controls.Add(this.pierakstsJaunamPoga);
            this.jaunsPieraksts.Location = new System.Drawing.Point(192, 2);
            this.jaunsPieraksts.Name = "jaunsPieraksts";
            this.jaunsPieraksts.Size = new System.Drawing.Size(596, 436);
            this.jaunsPieraksts.TabIndex = 2;
            // 
            // pierakstsJaunam
            // 
            this.pierakstsJaunam.Controls.Add(this.pierakstsEsosam);
            this.pierakstsJaunam.Controls.Add(this.apstiprinatJaunam);
            this.pierakstsJaunam.Controls.Add(this.label7);
            this.pierakstsJaunam.Controls.Add(this.piezimesJaunam);
            this.pierakstsJaunam.Controls.Add(this.iemeslsJaunam);
            this.pierakstsJaunam.Controls.Add(this.label6);
            this.pierakstsJaunam.Controls.Add(this.laiksJaunam);
            this.pierakstsJaunam.Controls.Add(this.label5);
            this.pierakstsJaunam.Controls.Add(this.datumsJaunam);
            this.pierakstsJaunam.Controls.Add(this.label4);
            this.pierakstsJaunam.Controls.Add(this.dzimums);
            this.pierakstsJaunam.Controls.Add(this.label3);
            this.pierakstsJaunam.Controls.Add(this.vecums);
            this.pierakstsJaunam.Controls.Add(this.label2);
            this.pierakstsJaunam.Controls.Add(this.pacientaSugaTextBox);
            this.pierakstsJaunam.Controls.Add(this.label1);
            this.pierakstsJaunam.Controls.Add(this.pacientaVardsTextBox);
            this.pierakstsJaunam.Controls.Add(this.pacientaVardsLabel);
            this.pierakstsJaunam.Location = new System.Drawing.Point(196, 12);
            this.pierakstsJaunam.Name = "pierakstsJaunam";
            this.pierakstsJaunam.Size = new System.Drawing.Size(397, 410);
            this.pierakstsJaunam.TabIndex = 6;
            // 
            // pierakstsEsosam
            // 
            this.pierakstsEsosam.Controls.Add(this.apstiprinatEsosam);
            this.pierakstsEsosam.Controls.Add(this.pacientsVards);
            this.pierakstsEsosam.Controls.Add(this.label9);
            this.pierakstsEsosam.Controls.Add(this.label8);
            this.pierakstsEsosam.Controls.Add(this.piezimesEsosam);
            this.pierakstsEsosam.Controls.Add(this.iemeslsEsosam);
            this.pierakstsEsosam.Controls.Add(this.label12);
            this.pierakstsEsosam.Controls.Add(this.label10);
            this.pierakstsEsosam.Controls.Add(this.datumsEsosam);
            this.pierakstsEsosam.Controls.Add(this.laiksEsosam);
            this.pierakstsEsosam.Controls.Add(this.label11);
            this.pierakstsEsosam.Location = new System.Drawing.Point(0, 0);
            this.pierakstsEsosam.Name = "pierakstsEsosam";
            this.pierakstsEsosam.Size = new System.Drawing.Size(397, 412);
            this.pierakstsEsosam.TabIndex = 7;
            this.pierakstsEsosam.Visible = false;
            // 
            // apstiprinatEsosam
            // 
            this.apstiprinatEsosam.Location = new System.Drawing.Point(225, 384);
            this.apstiprinatEsosam.Name = "apstiprinatEsosam";
            this.apstiprinatEsosam.Size = new System.Drawing.Size(169, 23);
            this.apstiprinatEsosam.TabIndex = 16;
            this.apstiprinatEsosam.Text = "Apstiprināt pierakstu";
            this.apstiprinatEsosam.UseVisualStyleBackColor = true;
            this.apstiprinatEsosam.Click += new System.EventHandler(this.apstiprinatEsosam_Click);
            // 
            // pacientsVards
            // 
            this.pacientsVards.FormattingEnabled = true;
            this.pacientsVards.Location = new System.Drawing.Point(164, 4);
            this.pacientsVards.Name = "pacientsVards";
            this.pacientsVards.Size = new System.Drawing.Size(200, 21);
            this.pacientsVards.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Piezīmes:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Pacients:";
            // 
            // piezimesEsosam
            // 
            this.piezimesEsosam.Location = new System.Drawing.Point(78, 111);
            this.piezimesEsosam.Name = "piezimesEsosam";
            this.piezimesEsosam.Size = new System.Drawing.Size(306, 109);
            this.piezimesEsosam.TabIndex = 23;
            this.piezimesEsosam.Text = "";
            // 
            // iemeslsEsosam
            // 
            this.iemeslsEsosam.FormattingEnabled = true;
            this.iemeslsEsosam.Location = new System.Drawing.Point(164, 84);
            this.iemeslsEsosam.Name = "iemeslsEsosam";
            this.iemeslsEsosam.Size = new System.Drawing.Size(200, 21);
            this.iemeslsEsosam.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Apmeklējuma datums:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Apmeklējuma iemesls:";
            // 
            // datumsEsosam
            // 
            this.datumsEsosam.Location = new System.Drawing.Point(164, 30);
            this.datumsEsosam.Name = "datumsEsosam";
            this.datumsEsosam.Size = new System.Drawing.Size(200, 20);
            this.datumsEsosam.TabIndex = 18;
            this.datumsEsosam.ValueChanged += new System.EventHandler(this.datumsEsosam_ValueChanged);
            // 
            // laiksEsosam
            // 
            this.laiksEsosam.FormattingEnabled = true;
            this.laiksEsosam.Location = new System.Drawing.Point(164, 57);
            this.laiksEsosam.Name = "laiksEsosam";
            this.laiksEsosam.Size = new System.Drawing.Size(200, 21);
            this.laiksEsosam.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Pieejamie laiki:";
            // 
            // apstiprinatJaunam
            // 
            this.apstiprinatJaunam.Location = new System.Drawing.Point(225, 384);
            this.apstiprinatJaunam.Name = "apstiprinatJaunam";
            this.apstiprinatJaunam.Size = new System.Drawing.Size(169, 23);
            this.apstiprinatJaunam.TabIndex = 7;
            this.apstiprinatJaunam.Text = "Apstiprināt pierakstu";
            this.apstiprinatJaunam.UseVisualStyleBackColor = true;
            this.apstiprinatJaunam.Click += new System.EventHandler(this.apstiprinatJaunam_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Piezīmes:";
            // 
            // piezimesJaunam
            // 
            this.piezimesJaunam.Location = new System.Drawing.Point(88, 197);
            this.piezimesJaunam.Name = "piezimesJaunam";
            this.piezimesJaunam.Size = new System.Drawing.Size(306, 109);
            this.piezimesJaunam.TabIndex = 14;
            this.piezimesJaunam.Text = "";
            // 
            // iemeslsJaunam
            // 
            this.iemeslsJaunam.FormattingEnabled = true;
            this.iemeslsJaunam.Location = new System.Drawing.Point(174, 170);
            this.iemeslsJaunam.Name = "iemeslsJaunam";
            this.iemeslsJaunam.Size = new System.Drawing.Size(200, 21);
            this.iemeslsJaunam.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Apmeklējuma iemesls:";
            // 
            // laiksJaunam
            // 
            this.laiksJaunam.FormattingEnabled = true;
            this.laiksJaunam.Location = new System.Drawing.Point(174, 143);
            this.laiksJaunam.Name = "laiksJaunam";
            this.laiksJaunam.Size = new System.Drawing.Size(200, 21);
            this.laiksJaunam.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Pieejamie laiki:";
            // 
            // datumsJaunam
            // 
            this.datumsJaunam.Location = new System.Drawing.Point(174, 116);
            this.datumsJaunam.Name = "datumsJaunam";
            this.datumsJaunam.Size = new System.Drawing.Size(200, 20);
            this.datumsJaunam.TabIndex = 9;
            this.datumsJaunam.ValueChanged += new System.EventHandler(this.datumsJaunam_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Apmeklējuma datums:";
            // 
            // dzimums
            // 
            this.dzimums.FormattingEnabled = true;
            this.dzimums.Location = new System.Drawing.Point(174, 85);
            this.dzimums.Name = "dzimums";
            this.dzimums.Size = new System.Drawing.Size(121, 21);
            this.dzimums.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pacienta dzimums:";
            // 
            // vecums
            // 
            this.vecums.Location = new System.Drawing.Point(175, 60);
            this.vecums.Name = "vecums";
            this.vecums.Size = new System.Drawing.Size(120, 20);
            this.vecums.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pacienta vecums mēnešos:";
            // 
            // pacientaSugaTextBox
            // 
            this.pacientaSugaTextBox.Location = new System.Drawing.Point(117, 34);
            this.pacientaSugaTextBox.Name = "pacientaSugaTextBox";
            this.pacientaSugaTextBox.Size = new System.Drawing.Size(277, 20);
            this.pacientaSugaTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pacienta suga:";
            // 
            // pacientaVardsTextBox
            // 
            this.pacientaVardsTextBox.Location = new System.Drawing.Point(117, 6);
            this.pacientaVardsTextBox.Name = "pacientaVardsTextBox";
            this.pacientaVardsTextBox.Size = new System.Drawing.Size(277, 20);
            this.pacientaVardsTextBox.TabIndex = 1;
            // 
            // pacientaVardsLabel
            // 
            this.pacientaVardsLabel.AutoSize = true;
            this.pacientaVardsLabel.Location = new System.Drawing.Point(20, 9);
            this.pacientaVardsLabel.Name = "pacientaVardsLabel";
            this.pacientaVardsLabel.Size = new System.Drawing.Size(81, 13);
            this.pacientaVardsLabel.TabIndex = 0;
            this.pacientaVardsLabel.Text = "Pacienta vārds:";
            // 
            // pierakstsEsosamPoga
            // 
            this.pierakstsEsosamPoga.Location = new System.Drawing.Point(13, 41);
            this.pierakstsEsosamPoga.Name = "pierakstsEsosamPoga";
            this.pierakstsEsosamPoga.Size = new System.Drawing.Size(169, 23);
            this.pierakstsEsosamPoga.TabIndex = 5;
            this.pierakstsEsosamPoga.Text = "Pieraksts esošam mājdzviniekam";
            this.pierakstsEsosamPoga.UseVisualStyleBackColor = true;
            this.pierakstsEsosamPoga.Click += new System.EventHandler(this.PierakstsEsosam_Click);
            // 
            // pierakstsJaunamPoga
            // 
            this.pierakstsJaunamPoga.Location = new System.Drawing.Point(13, 12);
            this.pierakstsJaunamPoga.Name = "pierakstsJaunamPoga";
            this.pierakstsJaunamPoga.Size = new System.Drawing.Size(169, 23);
            this.pierakstsJaunamPoga.TabIndex = 4;
            this.pierakstsJaunamPoga.Text = "Pieraksts jaunam mājdzivniekam";
            this.pierakstsJaunamPoga.UseVisualStyleBackColor = true;
            this.pierakstsJaunamPoga.Click += new System.EventHandler(this.PierakstsJaunam_Click);
            // 
            // pieraksti
            // 
            this.pieraksti.Controls.Add(this.panel1);
            this.pieraksti.Location = new System.Drawing.Point(181, 5);
            this.pieraksti.Name = "pieraksti";
            this.pieraksti.Size = new System.Drawing.Size(601, 418);
            this.pieraksti.TabIndex = 3;
            this.pieraksti.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pierakstiMajdzivniekaVardi);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 430);
            this.panel1.TabIndex = 0;
            // 
            // pierakstiMajdzivniekaVardi
            // 
            this.pierakstiMajdzivniekaVardi.FormattingEnabled = true;
            this.pierakstiMajdzivniekaVardi.Location = new System.Drawing.Point(100, 12);
            this.pierakstiMajdzivniekaVardi.Name = "pierakstiMajdzivniekaVardi";
            this.pierakstiMajdzivniekaVardi.Size = new System.Drawing.Size(121, 21);
            this.pierakstiMajdzivniekaVardi.TabIndex = 2;
            this.pierakstiMajdzivniekaVardi.SelectedValueChanged += new System.EventHandler(this.pierakstiMajdzivniekaVardi_SelectedValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(23, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Majdzivnieks:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(587, 370);
            this.dataGridView1.TabIndex = 0;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pieraksti);
            this.Controls.Add(this.jaunsPieraksts);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Client";
            this.ShowIcon = false;
            this.Text = "Veterinārārsta klīnika";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Client_FormClosed);
            this.jaunsPieraksts.ResumeLayout(false);
            this.pierakstsJaunam.ResumeLayout(false);
            this.pierakstsJaunam.PerformLayout();
            this.pierakstsEsosam.ResumeLayout(false);
            this.pierakstsEsosam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vecums)).EndInit();
            this.pieraksti.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel jaunsPieraksts;
        private System.Windows.Forms.Panel pieraksti;
        private System.Windows.Forms.Panel pierakstsJaunam;
        private System.Windows.Forms.Button pierakstsEsosamPoga;
        private System.Windows.Forms.Button pierakstsJaunamPoga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pacientaSugaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pacientaVardsTextBox;
        private System.Windows.Forms.Label pacientaVardsLabel;
        private System.Windows.Forms.ComboBox dzimums;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown vecums;
        private System.Windows.Forms.DateTimePicker datumsJaunam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox laiksJaunam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox iemeslsJaunam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button apstiprinatJaunam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox piezimesJaunam;
        private System.Windows.Forms.Panel pierakstsEsosam;
        private System.Windows.Forms.Button apstiprinatEsosam;
        private System.Windows.Forms.ComboBox pacientsVards;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox piezimesEsosam;
        private System.Windows.Forms.ComboBox iemeslsEsosam;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker datumsEsosam;
        private System.Windows.Forms.ComboBox laiksEsosam;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox pierakstiMajdzivniekaVardi;
    }
}

