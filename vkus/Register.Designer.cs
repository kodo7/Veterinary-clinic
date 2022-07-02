namespace vkus
{
    partial class Register
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
            this.lietotajvards = new System.Windows.Forms.TextBox();
            this.parole = new System.Windows.Forms.TextBox();
            this.paroleAtkartoti = new System.Windows.Forms.TextBox();
            this.vards = new System.Windows.Forms.TextBox();
            this.uzvards = new System.Windows.Forms.TextBox();
            this.epasts = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lietotajvards
            // 
            this.lietotajvards.Location = new System.Drawing.Point(104, 66);
            this.lietotajvards.Name = "lietotajvards";
            this.lietotajvards.Size = new System.Drawing.Size(201, 20);
            this.lietotajvards.TabIndex = 0;
            // 
            // parole
            // 
            this.parole.Location = new System.Drawing.Point(104, 109);
            this.parole.Name = "parole";
            this.parole.PasswordChar = '*';
            this.parole.Size = new System.Drawing.Size(201, 20);
            this.parole.TabIndex = 1;
            // 
            // paroleAtkartoti
            // 
            this.paroleAtkartoti.Location = new System.Drawing.Point(104, 147);
            this.paroleAtkartoti.Name = "paroleAtkartoti";
            this.paroleAtkartoti.PasswordChar = '*';
            this.paroleAtkartoti.Size = new System.Drawing.Size(201, 20);
            this.paroleAtkartoti.TabIndex = 2;
            // 
            // vards
            // 
            this.vards.Location = new System.Drawing.Point(104, 232);
            this.vards.Name = "vards";
            this.vards.Size = new System.Drawing.Size(201, 20);
            this.vards.TabIndex = 3;
            // 
            // uzvards
            // 
            this.uzvards.Location = new System.Drawing.Point(104, 277);
            this.uzvards.Name = "uzvards";
            this.uzvards.Size = new System.Drawing.Size(201, 20);
            this.uzvards.TabIndex = 4;
            // 
            // epasts
            // 
            this.epasts.Location = new System.Drawing.Point(104, 191);
            this.epasts.Name = "epasts";
            this.epasts.Size = new System.Drawing.Size(201, 20);
            this.epasts.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Reģistrēties";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Registreties_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lietotājvārds";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Parole";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Atkārtota parole";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "E-pasts";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Vārds";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Uzvārds";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 437);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.epasts);
            this.Controls.Add(this.uzvards);
            this.Controls.Add(this.vards);
            this.Controls.Add(this.paroleAtkartoti);
            this.Controls.Add(this.parole);
            this.Controls.Add(this.lietotajvards);
            this.Name = "Register";
            this.ShowIcon = false;
            this.Text = "Reģistrācija";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lietotajvards;
        private System.Windows.Forms.TextBox parole;
        private System.Windows.Forms.TextBox paroleAtkartoti;
        private System.Windows.Forms.TextBox vards;
        private System.Windows.Forms.TextBox uzvards;
        private System.Windows.Forms.TextBox epasts;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}