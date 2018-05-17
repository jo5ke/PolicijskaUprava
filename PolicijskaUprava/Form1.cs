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
				Policajac p = s.Load<Policajac>(1);
				MessageBox.Show(p.Licno_ime);
				u.ID_Nacelnika = p.ID;



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

				Uprava u = s.Load<Uprava>(1);
				Policajac sef = s.Load<Policajac>(5);
				Policajac zamenik = s.Load<Policajac>(6);

				PolicijskaStanica p = new PolicijskaStanica();
				p.Naziv = "Stanica Pirot";
				p.Adresa = "Dusanova";
				p.Opstina = "Pantelej";
				p.Datum_osnivanja = DateTime.Now;
				p.ID_Sefa = sef.ID;
				p.ID_Uprave = u.ID;
				p.ID_Zamenika = zamenik.ID;

                

                p.PripadaUpravi = u;
                s.Save(p);

                

                u.PolicijskeStanice.Add(p);

				s.Save(u);
				s.Flush();
				s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
