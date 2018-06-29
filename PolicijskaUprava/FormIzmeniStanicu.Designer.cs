namespace PolicijskaUprava
{
    partial class FormIzmeniStanicu
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
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDatumOsnivanja = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnIzmeniStanicu = new System.Windows.Forms.Button();
            this.txtOpstina = new System.Windows.Forms.TextBox();
            this.lblZamenik = new System.Windows.Forms.Label();
            this.lblSef = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adresa:";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(166, 126);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(100, 20);
            this.txtAdresa.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Opstina:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Naziv:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(166, 21);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(100, 20);
            this.txtNaziv.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Datum osnivanja:";
            // 
            // dtpDatumOsnivanja
            // 
            this.dtpDatumOsnivanja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumOsnivanja.Location = new System.Drawing.Point(167, 58);
            this.dtpDatumOsnivanja.Name = "dtpDatumOsnivanja";
            this.dtpDatumOsnivanja.Size = new System.Drawing.Size(99, 20);
            this.dtpDatumOsnivanja.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(12, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Sef:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(12, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Zamenik:";
            // 
            // btnIzmeniStanicu
            // 
            this.btnIzmeniStanicu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIzmeniStanicu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzmeniStanicu.Location = new System.Drawing.Point(55, 246);
            this.btnIzmeniStanicu.Name = "btnIzmeniStanicu";
            this.btnIzmeniStanicu.Size = new System.Drawing.Size(147, 40);
            this.btnIzmeniStanicu.TabIndex = 20;
            this.btnIzmeniStanicu.Text = "Izmeni Stanicu";
            this.btnIzmeniStanicu.UseVisualStyleBackColor = false;
            this.btnIzmeniStanicu.Click += new System.EventHandler(this.btnIzmeniStanicu_Click_1);
            // 
            // txtOpstina
            // 
            this.txtOpstina.Location = new System.Drawing.Point(166, 94);
            this.txtOpstina.Name = "txtOpstina";
            this.txtOpstina.Size = new System.Drawing.Size(100, 20);
            this.txtOpstina.TabIndex = 27;
            // 
            // lblZamenik
            // 
            this.lblZamenik.AutoSize = true;
            this.lblZamenik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZamenik.Location = new System.Drawing.Point(167, 166);
            this.lblZamenik.Name = "lblZamenik";
            this.lblZamenik.Size = new System.Drawing.Size(67, 16);
            this.lblZamenik.TabIndex = 28;
            this.lblZamenik.Text = "Zamenik";
            // 
            // lblSef
            // 
            this.lblSef.AutoSize = true;
            this.lblSef.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSef.Location = new System.Drawing.Point(167, 200);
            this.lblSef.Name = "lblSef";
            this.lblSef.Size = new System.Drawing.Size(31, 16);
            this.lblSef.TabIndex = 29;
            this.lblSef.Text = "Sef";
            // 
            // FormIzmeniStanicu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PolicijskaUprava.Properties.Resources.stanicaa;
            this.ClientSize = new System.Drawing.Size(290, 306);
            this.Controls.Add(this.lblSef);
            this.Controls.Add(this.lblZamenik);
            this.Controls.Add(this.txtOpstina);
            this.Controls.Add(this.btnIzmeniStanicu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpDatumOsnivanja);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.label1);
            this.Name = "FormIzmeniStanicu";
            this.Text = "Izmeni policijsku stanicu";
            this.Load += new System.EventHandler(this.FormIzmeniStanicu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDatumOsnivanja;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnIzmeniStanicu;
        private System.Windows.Forms.TextBox txtOpstina;
        private System.Windows.Forms.Label lblZamenik;
        private System.Windows.Forms.Label lblSef;
    }
}