namespace PolicijskaUprava
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
            this.cmdCreate = new System.Windows.Forms.Button();
            this.cmdCreatePolicijskaStanica = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdCreate
            // 
            this.cmdCreate.Location = new System.Drawing.Point(12, 12);
            this.cmdCreate.Name = "cmdCreate";
            this.cmdCreate.Size = new System.Drawing.Size(172, 23);
            this.cmdCreate.TabIndex = 0;
            this.cmdCreate.Text = "Dodavanje uprave";
            this.cmdCreate.UseVisualStyleBackColor = true;
            this.cmdCreate.Click += new System.EventHandler(this.cmdCreate_Click);
            // 
            // cmdCreatePolicijskaStanica
            // 
            this.cmdCreatePolicijskaStanica.Location = new System.Drawing.Point(12, 56);
            this.cmdCreatePolicijskaStanica.Name = "cmdCreatePolicijskaStanica";
            this.cmdCreatePolicijskaStanica.Size = new System.Drawing.Size(172, 23);
            this.cmdCreatePolicijskaStanica.TabIndex = 1;
            this.cmdCreatePolicijskaStanica.Text = "Dodavanje policijske stanice";
            this.cmdCreatePolicijskaStanica.UseVisualStyleBackColor = true;
            this.cmdCreatePolicijskaStanica.Click += new System.EventHandler(this.cmdCreatePolicijskaStanica_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 98);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cmdCreatePolicijskaStanica);
            this.Controls.Add(this.cmdCreate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.Button cmdCreate;
        private System.Windows.Forms.Button cmdCreatePolicijskaStanica;
        private System.Windows.Forms.Button button3;
    }
}

