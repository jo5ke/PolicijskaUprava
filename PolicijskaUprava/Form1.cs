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
            try
            {
                ISession s = DataLayer.GetSession();

				Uprava u = s.Load<Uprava>(1);
				Policajac sef = s.Load<Policajac>(5);
				Policajac zamenik = s.Load<Policajac>(6);

				PolicijskaStanica p = new PolicijskaStanica();
               
				p.Adresa = "Vozdova";
				p.Opstina = "Pirot";
                p.Naziv = "Stanica Pirot";
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

        private void cmdCreatePolicajac_Click(object sender, EventArgs e)
        {
            try
            {

                ISession s = DataLayer.GetSession();

                PolicijskaStanica stanica = s.Load<PolicijskaStanica>(1);
                Ustanova ustanova = s.Load<Ustanova>(1);
                Skola skola = s.Load<Skola>(1);
                Cin cin = s.Load<Cin>(1);
                Skolski pol = new Skolski();

                //pol.ID = 12;
                pol.Licno_ime = "Nikola";
                pol.Ime_roditelja = "Stefan";
                pol.Prezime = "Ilic";
                pol.JMBG = 3158658965223;
                pol.Pol ='M';
                pol.Datum_rodj = DateTime.Now;
                pol.Adresa = "Dusanova";
                pol.Datum_diplomiranja = DateTime.Now;
                pol.Datum_unapredjenja = DateTime.Now;
                pol.PripadaUstanovi = ustanova;
                pol.ImaCin = cin;
                pol.RadiUStanici = stanica;
                pol.RadiUSkoli = skola;
              
                cin.Policajci.Add(pol);
                s.Save(cin);
                ustanova.Policajci.Add(pol);
                s.Save(ustanova);
                skola.Skolski.Add(pol);
                s.Save(skola);
                stanica.Policajci.Add(pol);
                s.Save(stanica);
                s.Save(pol);
              s.Flush();
               s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

     

        private void cmdCreateAlarmniSistem_Click(object sender, EventArgs e)
        {
			try
			{
				ISession s = DataLayer.GetSession();

				Objekat o = s.Load<Objekat>(2);
                //TehnickoLice lice = s.Load<TehnickoLice>(1);

                Toplotni t = new Toplotni();

                t.Godina_proizvodnje = 1998;
                t.Proizvodjac = "Samsung";
                t.Model = "Cz67zS";
                t.Datum_Atesta = DateTime.Now;
                t.Datum_Poslednjeg_Atesta = DateTime.Now;
                t.Opis_servisiranja = "Kvar";
                t.Horizontalna_rez = 3;
                t.Vertikalna_rez = 3;
                t.Tip = "TOPLOTNI";
                t.Serijski_br = 4;
                s.Save(t);




                Pokretni p = new Pokretni()
				{
					Datum_Atesta = DateTime.Now,
					Datum_Poslednjeg_Atesta = DateTime.Now,
					Opis_servisiranja = "Kvar",
					Model = "A53ujz",
					Proizvodjac = "Samsung",
					Godina_proizvodnje = 1996,
					Tezina = 5,

				};

				Ultrazvucni u = new Ultrazvucni()
				{
					Datum_Atesta = DateTime.Now,
					Datum_Poslednjeg_Atesta = DateTime.Now,
					Opis_servisiranja = "Kvar",
					Model = "H87kfd",
					Proizvodjac = "Samsung",
					Godina_proizvodnje = 1999,
					Frekvencija = 5,

				};





				

				t.ObjekatInstaliran = o;
				s.Save(t);
				o.InstaliranAlarmniSis = t;

				p.ObjekatInstaliran = o;
				s.Save(p);
				o.InstaliranAlarmniSis = p;

				u.ObjekatInstaliran = o;
				s.Save(u);
				o.InstaliranAlarmniSis = u;

				s.Save(o);
                s.Flush();
                s.Close();
			}
			catch (Exception ec)
			{
				MessageBox.Show(ec.Message);
			}
		}

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                IList<AlarmniSistem> alarmniSistemi = s.QueryOver<AlarmniSistem>()
                                                .List<AlarmniSistem>();

                foreach (AlarmniSistem a in alarmniSistemi)
                {
                    if (a.GetType() == typeof(Toplotni))
                    {
                        Toplotni t = (Toplotni)a;
                    }
                    else if (a.GetType() == typeof(Pokretni))
                    {
                        Pokretni p = (Pokretni)a;
                    }
                    else
                    {
                        Ultrazvucni u = (Ultrazvucni)a;
                    }
                }

                s.Close();



            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdCreateToplotni_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Objekat u = s.Load<Entiteti.Objekat>(2);

              
                Toplotni t = new Toplotni()
                {
                    Datum_Atesta=DateTime.Now,
                    Datum_Poslednjeg_Atesta=DateTime.Now,
					//Tip="Toplotni",
                    Opis_servisiranja = "Kvar",
                    Model = "G6557j",
                    Proizvodjac = "",
					Godina_proizvodnje=1990,
					Horizontalna_rez = 3,
                    Vertikalna_rez = 3
                };

                s.Save(t);
				t.ObjekatInstaliran = u;
				s.Save(t);
				u.InstaliranAlarmniSis=t;

				s.Save(u);
               s.Flush();

                s.Close();
				



            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdOneToMany_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                
                PolicijskaUprava.Entiteti.Uprava u = s.Load<PolicijskaUprava.Entiteti.Uprava>(1);

                foreach (PolicijskaStanica p in u.PolicijskeStanice)
                {
                    MessageBox.Show(p.Naziv + " " + p.Opstina);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				
				PolicijskaStanica p = s.Load<PolicijskaStanica>(1);

				MessageBox.Show(p.Naziv);
				MessageBox.Show(p.PripadaUpravi.Grad);

				s.Close();
			}
			catch (Exception ec)
			{
				MessageBox.Show(ec.Message);
			}
		}
	}
}
