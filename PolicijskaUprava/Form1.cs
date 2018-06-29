using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using PolicijskaUprava.Entiteti;


namespace PolicijskaUprava
{
	public partial class Form1 : Form
	{
		
		public Form1()
		{
			InitializeComponent();
		
		}

		private void cmdCreatePolicijskaStanica_Click(object sender, EventArgs e)
        {
           
        }

        private void cmdCreatePolicajac_Click(object sender, EventArgs e)
        {
          
        }

     

        private void cmdCreateAlarmniSistem_Click(object sender, EventArgs e)
        {
		
		}

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void cmdCreateToplotni_Click(object sender, EventArgs e)
        {
          
        }

        private void cmdOneToMany_Click(object sender, EventArgs e)
        {
          
        }

		private void button2_Click(object sender, EventArgs e)
		{
		
		}

		private void button3_Click(object sender, EventArgs e)
		{
			FormAdmin fs = new FormAdmin();

			fs.Show();
            this.Hide();

			//this.Hide();
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

        private void button4_Click(object sender, EventArgs e)
        {
            FormKorisnik fk = new FormKorisnik();
            fk.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
