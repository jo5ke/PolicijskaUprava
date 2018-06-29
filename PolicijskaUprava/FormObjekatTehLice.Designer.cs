namespace PolicijskaUprava
{
    partial class FormObjekatTehLice
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
            this.btnTehLice = new System.Windows.Forms.Button();
            this.btnObjekat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTehLice
            // 
            this.btnTehLice.BackColor = System.Drawing.Color.MistyRose;
            this.btnTehLice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTehLice.Location = new System.Drawing.Point(12, 12);
            this.btnTehLice.Name = "btnTehLice";
            this.btnTehLice.Size = new System.Drawing.Size(135, 39);
            this.btnTehLice.TabIndex = 0;
            this.btnTehLice.Text = "Dodaj tehnicko lice";
            this.btnTehLice.UseVisualStyleBackColor = false;
            this.btnTehLice.Click += new System.EventHandler(this.btnTehLice_Click);
            // 
            // btnObjekat
            // 
            this.btnObjekat.BackColor = System.Drawing.Color.MistyRose;
            this.btnObjekat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObjekat.Location = new System.Drawing.Point(12, 80);
            this.btnObjekat.Name = "btnObjekat";
            this.btnObjekat.Size = new System.Drawing.Size(135, 41);
            this.btnObjekat.TabIndex = 1;
            this.btnObjekat.Text = "Dodaj objekat";
            this.btnObjekat.UseVisualStyleBackColor = false;
            this.btnObjekat.Click += new System.EventHandler(this.btnObjekat_Click);
            // 
            // FormObjekatTehLice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(160, 131);
            this.Controls.Add(this.btnObjekat);
            this.Controls.Add(this.btnTehLice);
            this.Name = "FormObjekatTehLice";
            this.Load += new System.EventHandler(this.FormObjekatTehLice_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTehLice;
        private System.Windows.Forms.Button btnObjekat;
    }
}