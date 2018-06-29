namespace PolicijskaUprava
{
    partial class FormUprava
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblGrad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNacelnik = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbxPolicijskeStanice = new System.Windows.Forms.ListBox();
            this.btnDodajStanicu = new System.Windows.Forms.Button();
            this.btnIzmeniStanicu = new System.Windows.Forms.Button();
            this.btnObrisiStanicu = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbxZamenici = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(26, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Grad:";
            // 
            // lblGrad
            // 
            this.lblGrad.AutoSize = true;
            this.lblGrad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGrad.Location = new System.Drawing.Point(193, 58);
            this.lblGrad.Name = "lblGrad";
            this.lblGrad.Size = new System.Drawing.Size(49, 20);
            this.lblGrad.TabIndex = 12;
            this.lblGrad.Text = "Grad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(26, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nacelnik uprave:";
            // 
            // lblNacelnik
            // 
            this.lblNacelnik.AutoSize = true;
            this.lblNacelnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNacelnik.Location = new System.Drawing.Point(193, 22);
            this.lblNacelnik.Name = "lblNacelnik";
            this.lblNacelnik.Size = new System.Drawing.Size(77, 20);
            this.lblNacelnik.TabIndex = 14;
            this.lblNacelnik.Text = "Nacelnik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(27, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Policijske stanice:";
            // 
            // lbxPolicijskeStanice
            // 
            this.lbxPolicijskeStanice.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbxPolicijskeStanice.FormattingEnabled = true;
            this.lbxPolicijskeStanice.Location = new System.Drawing.Point(22, 125);
            this.lbxPolicijskeStanice.Name = "lbxPolicijskeStanice";
            this.lbxPolicijskeStanice.Size = new System.Drawing.Size(185, 160);
            this.lbxPolicijskeStanice.TabIndex = 16;
            // 
            // btnDodajStanicu
            // 
            this.btnDodajStanicu.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnDodajStanicu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajStanicu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDodajStanicu.Location = new System.Drawing.Point(466, 295);
            this.btnDodajStanicu.Name = "btnDodajStanicu";
            this.btnDodajStanicu.Size = new System.Drawing.Size(133, 34);
            this.btnDodajStanicu.TabIndex = 17;
            this.btnDodajStanicu.Text = "Dodaj Stanicu";
            this.btnDodajStanicu.UseVisualStyleBackColor = false;
            this.btnDodajStanicu.Click += new System.EventHandler(this.btnDodajStanicu_Click_1);
            // 
            // btnIzmeniStanicu
            // 
            this.btnIzmeniStanicu.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnIzmeniStanicu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzmeniStanicu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIzmeniStanicu.Location = new System.Drawing.Point(249, 297);
            this.btnIzmeniStanicu.Name = "btnIzmeniStanicu";
            this.btnIzmeniStanicu.Size = new System.Drawing.Size(126, 32);
            this.btnIzmeniStanicu.TabIndex = 18;
            this.btnIzmeniStanicu.Text = "Izmeni Stanicu";
            this.btnIzmeniStanicu.UseVisualStyleBackColor = false;
            this.btnIzmeniStanicu.Click += new System.EventHandler(this.btnIzmeniStanicu_Click_1);
            // 
            // btnObrisiStanicu
            // 
            this.btnObrisiStanicu.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnObrisiStanicu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisiStanicu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnObrisiStanicu.Location = new System.Drawing.Point(36, 299);
            this.btnObrisiStanicu.Name = "btnObrisiStanicu";
            this.btnObrisiStanicu.Size = new System.Drawing.Size(142, 30);
            this.btnObrisiStanicu.TabIndex = 19;
            this.btnObrisiStanicu.Text = "Obrisi Stanicu";
            this.btnObrisiStanicu.UseVisualStyleBackColor = false;
            this.btnObrisiStanicu.Click += new System.EventHandler(this.btnObrisiStanicu_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(450, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 22);
            this.label4.TabIndex = 20;
            this.label4.Text = "Zamenici u upravi:";
            // 
            // lbxZamenici
            // 
            this.lbxZamenici.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbxZamenici.FormattingEnabled = true;
            this.lbxZamenici.Location = new System.Drawing.Point(479, 34);
            this.lbxZamenici.Name = "lbxZamenici";
            this.lbxZamenici.Size = new System.Drawing.Size(127, 121);
            this.lbxZamenici.TabIndex = 21;
            // 
            // FormUprava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PolicijskaUprava.Properties.Resources.police2;
            this.ClientSize = new System.Drawing.Size(634, 330);
            this.Controls.Add(this.lbxZamenici);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnObrisiStanicu);
            this.Controls.Add(this.btnIzmeniStanicu);
            this.Controls.Add(this.btnDodajStanicu);
            this.Controls.Add(this.lbxPolicijskeStanice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNacelnik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblGrad);
            this.Controls.Add(this.label1);
            this.Name = "FormUprava";
            this.Text = "Dobrodosli u upravu!";
            this.Load += new System.EventHandler(this.FormUprava_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGrad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNacelnik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbxPolicijskeStanice;
        private System.Windows.Forms.Button btnDodajStanicu;
        private System.Windows.Forms.Button btnIzmeniStanicu;
        private System.Windows.Forms.Button btnObrisiStanicu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbxZamenici;
    }
}