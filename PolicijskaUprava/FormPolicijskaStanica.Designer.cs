namespace PolicijskaUprava
{
    partial class FormPolicijskaStanica
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
            this.listBoxPolStanica = new System.Windows.Forms.ListBox();
            this.btnPolStanica = new System.Windows.Forms.Button();
            this.groupBoxPolicajci = new System.Windows.Forms.GroupBox();
            this.btnPromeniSefa = new System.Windows.Forms.Button();
            this.btnPromeniZam = new System.Windows.Forms.Button();
            this.textBoxZamenik = new System.Windows.Forms.TextBox();
            this.textBoxSef = new System.Windows.Forms.TextBox();
            this.lblZamenik = new System.Windows.Forms.Label();
            this.lblSef = new System.Windows.Forms.Label();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.listBoxPolicajci = new System.Windows.Forms.ListBox();
            this.groupBoxOstalo = new System.Windows.Forms.GroupBox();
            this.btnIzmeniObj = new System.Windows.Forms.Button();
            this.btnObrisiObj = new System.Windows.Forms.Button();
            this.listBoxObjekti = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxPolicajci.SuspendLayout();
            this.groupBoxOstalo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Izaberite policijsku stanicu:";
            // 
            // listBoxPolStanica
            // 
            this.listBoxPolStanica.FormattingEnabled = true;
            this.listBoxPolStanica.ItemHeight = 15;
            this.listBoxPolStanica.Location = new System.Drawing.Point(24, 45);
            this.listBoxPolStanica.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxPolStanica.Name = "listBoxPolStanica";
            this.listBoxPolStanica.Size = new System.Drawing.Size(323, 49);
            this.listBoxPolStanica.TabIndex = 1;
            // 
            // btnPolStanica
            // 
            this.btnPolStanica.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPolStanica.Location = new System.Drawing.Point(24, 102);
            this.btnPolStanica.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPolStanica.Name = "btnPolStanica";
            this.btnPolStanica.Size = new System.Drawing.Size(324, 27);
            this.btnPolStanica.TabIndex = 2;
            this.btnPolStanica.Text = "Prikazi detalje";
            this.btnPolStanica.UseVisualStyleBackColor = false;
            this.btnPolStanica.Click += new System.EventHandler(this.btnPolStanica_Click);
            // 
            // groupBoxPolicajci
            // 
            this.groupBoxPolicajci.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBoxPolicajci.Controls.Add(this.btnPromeniSefa);
            this.groupBoxPolicajci.Controls.Add(this.btnPromeniZam);
            this.groupBoxPolicajci.Controls.Add(this.textBoxZamenik);
            this.groupBoxPolicajci.Controls.Add(this.textBoxSef);
            this.groupBoxPolicajci.Controls.Add(this.lblZamenik);
            this.groupBoxPolicajci.Controls.Add(this.lblSef);
            this.groupBoxPolicajci.Controls.Add(this.btnIzmeni);
            this.groupBoxPolicajci.Controls.Add(this.btnObrisi);
            this.groupBoxPolicajci.Controls.Add(this.btnDodaj);
            this.groupBoxPolicajci.Controls.Add(this.listBoxPolicajci);
            this.groupBoxPolicajci.Location = new System.Drawing.Point(40, 192);
            this.groupBoxPolicajci.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxPolicajci.Name = "groupBoxPolicajci";
            this.groupBoxPolicajci.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxPolicajci.Size = new System.Drawing.Size(728, 351);
            this.groupBoxPolicajci.TabIndex = 3;
            this.groupBoxPolicajci.TabStop = false;
            this.groupBoxPolicajci.Enter += new System.EventHandler(this.groupBoxPolicajci_Enter);
            // 
            // btnPromeniSefa
            // 
            this.btnPromeniSefa.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPromeniSefa.Location = new System.Drawing.Point(547, 137);
            this.btnPromeniSefa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPromeniSefa.Name = "btnPromeniSefa";
            this.btnPromeniSefa.Size = new System.Drawing.Size(159, 23);
            this.btnPromeniSefa.TabIndex = 9;
            this.btnPromeniSefa.Text = "Izmeni zamenika";
            this.btnPromeniSefa.UseVisualStyleBackColor = false;
            this.btnPromeniSefa.Click += new System.EventHandler(this.btnPromeniSefa_Click);
            // 
            // btnPromeniZam
            // 
            this.btnPromeniZam.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPromeniZam.Location = new System.Drawing.Point(547, 63);
            this.btnPromeniZam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPromeniZam.Name = "btnPromeniZam";
            this.btnPromeniZam.Size = new System.Drawing.Size(159, 23);
            this.btnPromeniZam.TabIndex = 8;
            this.btnPromeniZam.Text = "Izmeni sefa";
            this.btnPromeniZam.UseVisualStyleBackColor = false;
            this.btnPromeniZam.Click += new System.EventHandler(this.btnPromeniZam_Click);
            // 
            // textBoxZamenik
            // 
            this.textBoxZamenik.Location = new System.Drawing.Point(405, 137);
            this.textBoxZamenik.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxZamenik.Name = "textBoxZamenik";
            this.textBoxZamenik.Size = new System.Drawing.Size(132, 21);
            this.textBoxZamenik.TabIndex = 7;
            // 
            // textBoxSef
            // 
            this.textBoxSef.Location = new System.Drawing.Point(405, 63);
            this.textBoxSef.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxSef.Name = "textBoxSef";
            this.textBoxSef.Size = new System.Drawing.Size(132, 21);
            this.textBoxSef.TabIndex = 6;
            // 
            // lblZamenik
            // 
            this.lblZamenik.AutoSize = true;
            this.lblZamenik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblZamenik.Location = new System.Drawing.Point(401, 102);
            this.lblZamenik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblZamenik.Name = "lblZamenik";
            this.lblZamenik.Size = new System.Drawing.Size(116, 15);
            this.lblZamenik.TabIndex = 5;
            this.lblZamenik.Text = "Zamenik stanice:";
            // 
            // lblSef
            // 
            this.lblSef.AutoSize = true;
            this.lblSef.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSef.Location = new System.Drawing.Point(401, 33);
            this.lblSef.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSef.Name = "lblSef";
            this.lblSef.Size = new System.Drawing.Size(82, 15);
            this.lblSef.TabIndex = 4;
            this.lblSef.Text = "Sef stanice:";
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnIzmeni.Location = new System.Drawing.Point(224, 317);
            this.btnIzmeni.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(100, 27);
            this.btnIzmeni.TabIndex = 3;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = false;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnObrisi.Location = new System.Drawing.Point(116, 317);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(100, 27);
            this.btnObrisi.TabIndex = 2;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDodaj.Location = new System.Drawing.Point(8, 317);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(100, 27);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // listBoxPolicajci
            // 
            this.listBoxPolicajci.FormattingEnabled = true;
            this.listBoxPolicajci.ItemHeight = 15;
            this.listBoxPolicajci.Location = new System.Drawing.Point(8, 22);
            this.listBoxPolicajci.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxPolicajci.Name = "listBoxPolicajci";
            this.listBoxPolicajci.Size = new System.Drawing.Size(315, 289);
            this.listBoxPolicajci.TabIndex = 0;
            // 
            // groupBoxOstalo
            // 
            this.groupBoxOstalo.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBoxOstalo.Controls.Add(this.btnIzmeniObj);
            this.groupBoxOstalo.Controls.Add(this.btnObrisiObj);
            this.groupBoxOstalo.Controls.Add(this.listBoxObjekti);
            this.groupBoxOstalo.Controls.Add(this.label2);
            this.groupBoxOstalo.Location = new System.Drawing.Point(380, 14);
            this.groupBoxOstalo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxOstalo.Name = "groupBoxOstalo";
            this.groupBoxOstalo.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxOstalo.Size = new System.Drawing.Size(396, 143);
            this.groupBoxOstalo.TabIndex = 4;
            this.groupBoxOstalo.TabStop = false;
            // 
            // btnIzmeniObj
            // 
            this.btnIzmeniObj.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnIzmeniObj.Location = new System.Drawing.Point(251, 102);
            this.btnIzmeniObj.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnIzmeniObj.Name = "btnIzmeniObj";
            this.btnIzmeniObj.Size = new System.Drawing.Size(115, 27);
            this.btnIzmeniObj.TabIndex = 4;
            this.btnIzmeniObj.Text = "Izmeni objekat";
            this.btnIzmeniObj.UseVisualStyleBackColor = false;
            this.btnIzmeniObj.Click += new System.EventHandler(this.btnIzmeniObj_Click);
            // 
            // btnObrisiObj
            // 
            this.btnObrisiObj.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnObrisiObj.Location = new System.Drawing.Point(50, 102);
            this.btnObrisiObj.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnObrisiObj.Name = "btnObrisiObj";
            this.btnObrisiObj.Size = new System.Drawing.Size(127, 27);
            this.btnObrisiObj.TabIndex = 3;
            this.btnObrisiObj.Text = "Obrisi objekat";
            this.btnObrisiObj.UseVisualStyleBackColor = false;
            this.btnObrisiObj.Click += new System.EventHandler(this.btnObrisiObj_Click);
            // 
            // listBoxObjekti
            // 
            this.listBoxObjekti.FormattingEnabled = true;
            this.listBoxObjekti.ItemHeight = 15;
            this.listBoxObjekti.Location = new System.Drawing.Point(8, 37);
            this.listBoxObjekti.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxObjekti.Name = "listBoxObjekti";
            this.listBoxObjekti.Size = new System.Drawing.Size(379, 64);
            this.listBoxObjekti.TabIndex = 1;
            this.listBoxObjekti.SelectedIndexChanged += new System.EventHandler(this.listBoxObjekti_SelectedIndexChanged);
            this.listBoxObjekti.DoubleClick += new System.EventHandler(this.listBoxObjekti_DoubleClick);
            this.listBoxObjekti.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxObjekti_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(8, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lista objekata koje stanica nadzire:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Controls.Add(this.listBoxPolStanica);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnPolStanica);
            this.groupBox1.Location = new System.Drawing.Point(16, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(356, 143);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // FormPolicijskaStanica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PolicijskaUprava.Properties.Resources.stanicaa;
            this.ClientSize = new System.Drawing.Size(784, 556);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxOstalo);
            this.Controls.Add(this.groupBoxPolicajci);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormPolicijskaStanica";
            this.Text = "Policijska stanica";
            this.Load += new System.EventHandler(this.FormPolicijskaStanica_Load);
            this.groupBoxPolicajci.ResumeLayout(false);
            this.groupBoxPolicajci.PerformLayout();
            this.groupBoxOstalo.ResumeLayout(false);
            this.groupBoxOstalo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxPolStanica;
        private System.Windows.Forms.Button btnPolStanica;
        private System.Windows.Forms.GroupBox groupBoxPolicajci;
        private System.Windows.Forms.ListBox listBoxPolicajci;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnPromeniSefa;
        private System.Windows.Forms.Button btnPromeniZam;
        private System.Windows.Forms.TextBox textBoxZamenik;
        private System.Windows.Forms.TextBox textBoxSef;
        private System.Windows.Forms.Label lblZamenik;
        private System.Windows.Forms.Label lblSef;
        private System.Windows.Forms.GroupBox groupBoxOstalo;
        private System.Windows.Forms.Button btnIzmeniObj;
        private System.Windows.Forms.Button btnObrisiObj;
        private System.Windows.Forms.ListBox listBoxObjekti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}