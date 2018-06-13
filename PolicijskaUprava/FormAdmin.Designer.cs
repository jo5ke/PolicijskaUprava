namespace PolicijskaUprava
{
    partial class FormAdmin
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_Nadji_PolicijskaStanica = new System.Windows.Forms.Button();
            this.btn_Dodaj_PolicijskaStanica = new System.Windows.Forms.Button();
            this.btn_Izmeni_PolicijskaStanica = new System.Windows.Forms.Button();
            this.btn_Obrisi_PolicijskaStanica = new System.Windows.Forms.Button();
            this.btn_Obnovi_PolicijskaStanica = new System.Windows.Forms.Button();
            this.dgv_Policijska_Stanica = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Policijska_Stanica)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(910, 644);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tabPage1.Controls.Add(this.dgv_Policijska_Stanica);
            this.tabPage1.Controls.Add(this.btn_Obnovi_PolicijskaStanica);
            this.tabPage1.Controls.Add(this.btn_Obrisi_PolicijskaStanica);
            this.tabPage1.Controls.Add(this.btn_Izmeni_PolicijskaStanica);
            this.tabPage1.Controls.Add(this.btn_Dodaj_PolicijskaStanica);
            this.tabPage1.Controls.Add(this.btn_Nadji_PolicijskaStanica);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(902, 618);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_Nadji_PolicijskaStanica
            // 
            this.btn_Nadji_PolicijskaStanica.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Nadji_PolicijskaStanica.Location = new System.Drawing.Point(3, 6);
            this.btn_Nadji_PolicijskaStanica.Name = "btn_Nadji_PolicijskaStanica";
            this.btn_Nadji_PolicijskaStanica.Size = new System.Drawing.Size(220, 45);
            this.btn_Nadji_PolicijskaStanica.TabIndex = 0;
            this.btn_Nadji_PolicijskaStanica.Text = "Nadji";
            this.btn_Nadji_PolicijskaStanica.UseVisualStyleBackColor = false;
            // 
            // btn_Dodaj_PolicijskaStanica
            // 
            this.btn_Dodaj_PolicijskaStanica.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Dodaj_PolicijskaStanica.Location = new System.Drawing.Point(229, 6);
            this.btn_Dodaj_PolicijskaStanica.Name = "btn_Dodaj_PolicijskaStanica";
            this.btn_Dodaj_PolicijskaStanica.Size = new System.Drawing.Size(220, 45);
            this.btn_Dodaj_PolicijskaStanica.TabIndex = 1;
            this.btn_Dodaj_PolicijskaStanica.Text = "Dodaj";
            this.btn_Dodaj_PolicijskaStanica.UseVisualStyleBackColor = false;
            // 
            // btn_Izmeni_PolicijskaStanica
            // 
            this.btn_Izmeni_PolicijskaStanica.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Izmeni_PolicijskaStanica.Location = new System.Drawing.Point(455, 6);
            this.btn_Izmeni_PolicijskaStanica.Name = "btn_Izmeni_PolicijskaStanica";
            this.btn_Izmeni_PolicijskaStanica.Size = new System.Drawing.Size(220, 45);
            this.btn_Izmeni_PolicijskaStanica.TabIndex = 2;
            this.btn_Izmeni_PolicijskaStanica.Text = "Izmeni";
            this.btn_Izmeni_PolicijskaStanica.UseVisualStyleBackColor = false;
            // 
            // btn_Obrisi_PolicijskaStanica
            // 
            this.btn_Obrisi_PolicijskaStanica.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Obrisi_PolicijskaStanica.Location = new System.Drawing.Point(681, 6);
            this.btn_Obrisi_PolicijskaStanica.Name = "btn_Obrisi_PolicijskaStanica";
            this.btn_Obrisi_PolicijskaStanica.Size = new System.Drawing.Size(220, 45);
            this.btn_Obrisi_PolicijskaStanica.TabIndex = 3;
            this.btn_Obrisi_PolicijskaStanica.Text = "Obrisi";
            this.btn_Obrisi_PolicijskaStanica.UseVisualStyleBackColor = false;
            // 
            // btn_Obnovi_PolicijskaStanica
            // 
            this.btn_Obnovi_PolicijskaStanica.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_Obnovi_PolicijskaStanica.Location = new System.Drawing.Point(6, 57);
            this.btn_Obnovi_PolicijskaStanica.Name = "btn_Obnovi_PolicijskaStanica";
            this.btn_Obnovi_PolicijskaStanica.Size = new System.Drawing.Size(890, 45);
            this.btn_Obnovi_PolicijskaStanica.TabIndex = 4;
            this.btn_Obnovi_PolicijskaStanica.Text = "Obnovi Sve Podatke";
            this.btn_Obnovi_PolicijskaStanica.UseVisualStyleBackColor = false;
            // 
            // dgv_Policijska_Stanica
            // 
            this.dgv_Policijska_Stanica.BackgroundColor = System.Drawing.Color.Tan;
            this.dgv_Policijska_Stanica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Policijska_Stanica.Location = new System.Drawing.Point(7, 109);
            this.dgv_Policijska_Stanica.Name = "dgv_Policijska_Stanica";
            this.dgv_Policijska_Stanica.Size = new System.Drawing.Size(889, 503);
            this.dgv_Policijska_Stanica.TabIndex = 2;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(972, 668);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Policijska_Stanica)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_Obnovi_PolicijskaStanica;
        private System.Windows.Forms.Button btn_Obrisi_PolicijskaStanica;
        private System.Windows.Forms.Button btn_Izmeni_PolicijskaStanica;
        private System.Windows.Forms.Button btn_Dodaj_PolicijskaStanica;
        private System.Windows.Forms.Button btn_Nadji_PolicijskaStanica;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgv_Policijska_Stanica;
    }
}