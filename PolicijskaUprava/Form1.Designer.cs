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
			this.cmdCreatePolicijskaStanica = new System.Windows.Forms.Button();
			this.cmdCreatePolicajac = new System.Windows.Forms.Button();
			this.cmdCreateAlarmniSistem = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.cmdCreateToplotni = new System.Windows.Forms.Button();
			this.cmdOneToMany = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// cmdCreatePolicijskaStanica
			// 
			this.cmdCreatePolicijskaStanica.Location = new System.Drawing.Point(12, 41);
			this.cmdCreatePolicijskaStanica.Name = "cmdCreatePolicijskaStanica";
			this.cmdCreatePolicijskaStanica.Size = new System.Drawing.Size(196, 23);
			this.cmdCreatePolicijskaStanica.TabIndex = 1;
			this.cmdCreatePolicijskaStanica.Text = "Dodavanje policijske stanice";
			this.cmdCreatePolicijskaStanica.UseVisualStyleBackColor = true;
			this.cmdCreatePolicijskaStanica.Click += new System.EventHandler(this.cmdCreatePolicijskaStanica_Click);
			// 
			// cmdCreatePolicajac
			// 
			this.cmdCreatePolicajac.Location = new System.Drawing.Point(11, 70);
			this.cmdCreatePolicajac.Name = "cmdCreatePolicajac";
			this.cmdCreatePolicajac.Size = new System.Drawing.Size(197, 23);
			this.cmdCreatePolicajac.TabIndex = 2;
			this.cmdCreatePolicajac.Text = "Dodavanje policajca";
			this.cmdCreatePolicajac.UseVisualStyleBackColor = true;
			this.cmdCreatePolicajac.Click += new System.EventHandler(this.cmdCreatePolicajac_Click);
			// 
			// cmdCreateAlarmniSistem
			// 
			this.cmdCreateAlarmniSistem.Location = new System.Drawing.Point(11, 99);
			this.cmdCreateAlarmniSistem.Name = "cmdCreateAlarmniSistem";
			this.cmdCreateAlarmniSistem.Size = new System.Drawing.Size(197, 23);
			this.cmdCreateAlarmniSistem.TabIndex = 6;
			this.cmdCreateAlarmniSistem.Text = "Dodavanje alarmnog sistema";
			this.cmdCreateAlarmniSistem.UseVisualStyleBackColor = true;
			this.cmdCreateAlarmniSistem.Click += new System.EventHandler(this.cmdCreateAlarmniSistem_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(11, 128);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(197, 23);
			this.button1.TabIndex = 7;
			this.button1.Text = "Table-per-Class-Hierarchy inheritance";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// cmdCreateToplotni
			// 
			this.cmdCreateToplotni.Location = new System.Drawing.Point(12, 157);
			this.cmdCreateToplotni.Name = "cmdCreateToplotni";
			this.cmdCreateToplotni.Size = new System.Drawing.Size(196, 23);
			this.cmdCreateToplotni.TabIndex = 8;
			this.cmdCreateToplotni.Text = "Dodavanje toplotnog";
			this.cmdCreateToplotni.UseVisualStyleBackColor = true;
			this.cmdCreateToplotni.Click += new System.EventHandler(this.cmdCreateToplotni_Click);
			// 
			// cmdOneToMany
			// 
			this.cmdOneToMany.Location = new System.Drawing.Point(11, 186);
			this.cmdOneToMany.Name = "cmdOneToMany";
			this.cmdOneToMany.Size = new System.Drawing.Size(197, 23);
			this.cmdOneToMany.TabIndex = 9;
			this.cmdOneToMany.Text = "Veza one to many";
			this.cmdOneToMany.UseVisualStyleBackColor = true;
			this.cmdOneToMany.Click += new System.EventHandler(this.cmdOneToMany_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(12, 215);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(196, 23);
			this.button2.TabIndex = 10;
			this.button2.Text = "Veza many to one";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.cmdOneToMany);
			this.Controls.Add(this.cmdCreateToplotni);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.cmdCreateAlarmniSistem);
			this.Controls.Add(this.cmdCreatePolicajac);
			this.Controls.Add(this.cmdCreatePolicijskaStanica);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

        #endregion
        private System.Windows.Forms.Button cmdCreatePolicijskaStanica;
        private System.Windows.Forms.Button cmdCreatePolicajac;
        private System.Windows.Forms.Button cmdCreateAlarmniSistem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cmdCreateToplotni;
        private System.Windows.Forms.Button cmdOneToMany;
		private System.Windows.Forms.Button button2;
	}
}

