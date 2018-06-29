namespace PolicijskaUprava
{
    partial class FormDodajStanicu
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
            this.txtOpstina = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDatumOsnivanja = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lbxSef = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbxZamenik = new System.Windows.Forms.ListBox();
            this.btnDodajStanicu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adresa:";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(92, 6);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(100, 20);
            this.txtAdresa.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(15, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Opstina:";
            // 
            // txtOpstina
            // 
            this.txtOpstina.Location = new System.Drawing.Point(92, 45);
            this.txtOpstina.Name = "txtOpstina";
            this.txtOpstina.Size = new System.Drawing.Size(100, 20);
            this.txtOpstina.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(15, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Naziv:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(92, 84);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(100, 20);
            this.txtNaziv.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Datum osnivanja:";
            // 
            // dtpDatumOsnivanja
            // 
            this.dtpDatumOsnivanja.Location = new System.Drawing.Point(15, 147);
            this.dtpDatumOsnivanja.Name = "dtpDatumOsnivanja";
            this.dtpDatumOsnivanja.Size = new System.Drawing.Size(218, 20);
            this.dtpDatumOsnivanja.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(246, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Izaberi sefa stanice:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbxSef
            // 
            this.lbxSef.FormattingEnabled = true;
            this.lbxSef.Location = new System.Drawing.Point(268, 29);
            this.lbxSef.Name = "lbxSef";
            this.lbxSef.Size = new System.Drawing.Size(150, 56);
            this.lbxSef.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(246, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Izaberi zamenika stanice:";
            // 
            // lbxZamenik
            // 
            this.lbxZamenik.FormattingEnabled = true;
            this.lbxZamenik.Location = new System.Drawing.Point(267, 121);
            this.lbxZamenik.Name = "lbxZamenik";
            this.lbxZamenik.Size = new System.Drawing.Size(150, 69);
            this.lbxZamenik.TabIndex = 20;
            // 
            // btnDodajStanicu
            // 
            this.btnDodajStanicu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDodajStanicu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajStanicu.Location = new System.Drawing.Point(45, 186);
            this.btnDodajStanicu.Name = "btnDodajStanicu";
            this.btnDodajStanicu.Size = new System.Drawing.Size(159, 48);
            this.btnDodajStanicu.TabIndex = 21;
            this.btnDodajStanicu.Text = "Dodaj Stanicu";
            this.btnDodajStanicu.UseVisualStyleBackColor = false;
            this.btnDodajStanicu.Click += new System.EventHandler(this.btnDodajStanicu_Click_1);
            // 
            // FormDodajStanicu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PolicijskaUprava.Properties.Resources.stanicaa;
            this.ClientSize = new System.Drawing.Size(430, 256);
            this.Controls.Add(this.btnDodajStanicu);
            this.Controls.Add(this.lbxZamenik);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbxSef);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpDatumOsnivanja);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOpstina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.label1);
            this.Name = "FormDodajStanicu";
            this.Text = "Dodaj policijsku stanicu";
            this.Load += new System.EventHandler(this.FormDodajStanicu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOpstina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDatumOsnivanja;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbxSef;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbxZamenik;
        private System.Windows.Forms.Button btnDodajStanicu;
    }
}