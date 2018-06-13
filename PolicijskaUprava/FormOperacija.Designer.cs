namespace PolicijskaUprava
{
    partial class FormOperacija
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Operacija = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 436);
            this.panel1.TabIndex = 0;
            // 
            // btn_Operacija
            // 
            this.btn_Operacija.Location = new System.Drawing.Point(331, 491);
            this.btn_Operacija.Name = "btn_Operacija";
            this.btn_Operacija.Size = new System.Drawing.Size(253, 53);
            this.btn_Operacija.TabIndex = 1;
            this.btn_Operacija.Text = "Operacija";
            this.btn_Operacija.UseVisualStyleBackColor = true;
            // 
            // FormOperacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 593);
            this.Controls.Add(this.btn_Operacija);
            this.Controls.Add(this.panel1);
            this.Name = "FormOperacija";
            this.Text = "FormOperacija";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Operacija;
    }
}