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

        private void cmdCreate_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Entiteti.Uprava u = new Entiteti.Uprava();

              
                u.Grad = "Nis";
                

                s.Save(u);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdCreatePolicijskaStanica_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Uprava u = new Entiteti.Uprava()
                {
                    Grad = "Nis",
                    
                };

                PolicijskaStanica p = new PolicijskaStanica()
                {
                    Naziv = "blbla",
                    Adresa = "fdsf",
                    Opstina = "ddd",
                   // Datum_osnivanja = 
                };

              



                s.Save(u);

                p.PripadaUpravi = u;
                s.Save(p);

                

                u.PolicijskeStanice.Add(p);

                s.Save(u);

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
