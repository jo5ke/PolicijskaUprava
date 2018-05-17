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

        private void cmdCreatePolicajac_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.PolicijskaStanica p = new Entiteti.PolicijskaStanica()
                {
                    Naziv = "blbla",
                    Adresa = "fdsf",
                    Opstina = "ddd",
                    // Datum_osnivanja = 

                };

                Policajac pol = new Policajac()
                {
                    Licno_ime = "",
                    Ime_roditelja = "",
                    Prezime = "",
                    JMBG = 323,
                    // Pol = "M",
                    //Datum_rodj=
                    Adresa = "",
                    //Datum_diplomiranja=
                    //Datum_unapredjenja=
                    Oblast = 1,
                  
                };


                
                s.Save(p);

                pol.RadiUStanici = p;
                s.Save(pol);
                
                p.Policajci.Add(pol);

                s.Save(p);

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdCreateVozilo_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.PolicijskaStanica p = new Entiteti.PolicijskaStanica()
                {
                    Naziv = "blbla",
                    Adresa = "fdsf",
                    Opstina = "ddd",
                    // Datum_osnivanja = 

                };

                Entiteti.Patrola pat = new Entiteti.Patrola()
                {
                    //Vreme=
                    Opis = "",

                };

                Vozilo v = new Vozilo()
                {
                    Reg_oznaka = "",
                    Boja = "",
                    Tip="",
                    Model="",
                    Proizvodjac="",

                };

               
                s.Save(p);

                v.PosedujeStanica = p;
                v.VoziVozilo = pat;
                s.Save(v);
                s.Save(pat);

                p.Vozila.Add(v);
                pat.VoziloPatrole=v;
                
                s.Save(p);

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdCreatePatrola_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.Objekat o = new Entiteti.Objekat()
                {
                    Tip = "",
                    Adresa = "",
                    Povrsina = 8,
                    Ime = "",
                    Prezime = "",
                    Br_telefona = 3,
                    Serijski_br_alarma = 5,
                    //Datum_instalacije=

                };

                Patrola pat = new Patrola()
                {
                    //Vreme=
                    Opis = "",

                };



                s.Save(o);

                pat.InterveniseObjekat = o;
                s.Save(pat);

                o.Patrole.Add(pat);

                s.Save(o);

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void cmdCreateObjekat_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Entiteti.PolicijskaStanica p = new Entiteti.PolicijskaStanica()
                {
                    Naziv = "blbla",
                    Adresa = "fdsf",
                    Opstina = "ddd",
                    // Datum_osnivanja = 

                };

                Objekat o = new Objekat()
                {
                    Tip = "",
                    Adresa = "",
                    Povrsina = 8,
                    Ime = "",
                    Prezime = "",
                    Br_telefona = 3,
                    Serijski_br_alarma = 5,
                    //Datum_instalacije=
                    
                };



                s.Save(p);

                o.NadzireStanica= p;
                s.Save(o);

                p.Objekti.Add(o);

                s.Save(p);

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

                Entiteti.Objekat o = new Entiteti.Objekat()
                {
                    Tip = "",
                    Adresa = "",
                    Povrsina = 8,
                    Ime = "",
                    Prezime = "",
                    Br_telefona = 3,
                    Serijski_br_alarma = 5,
                    //Datum_instalacije=

                };

                Toplotni t = new Toplotni()
                {
                    //Datum_Atesta=
                    //Datum_Poslednjeg_Atesta=
                    Opis_servisiranja="",
                    Model="",
                    Proizvodjac="",
                    //Godina_proizvodnje=
                    Horiznotnalna_rez=3,
                    Vertikalna_rez=3,

                };

                Pokretni p = new Pokretni()
                {
                    //Datum_Atesta=
                    //Datum_Poslednjeg_Atesta=
                    Opis_servisiranja = "",
                    Model = "",
                    Proizvodjac = "",
                    //Godina_proizvodnje=
                    Tezina=5,

                };

                Ultrazvucni u = new Ultrazvucni()
                {
                    //Datum_Atesta=
                    //Datum_Poslednjeg_Atesta=
                    Opis_servisiranja = "",
                    Model = "",
                    Proizvodjac = "",
                    //Godina_proizvodnje=
                    Frekvencija=5,

                };





                s.Save(o);

                t.ObjekatInstaliran = o;
                s.Save(t);
                o.InstaliranAlarmniSis=t;

                p.ObjekatInstaliran = o;
                s.Save(p);
                o.InstaliranAlarmniSis = p;

                u.ObjekatInstaliran = o;
                s.Save(u);
                o.InstaliranAlarmniSis = u;

                s.Save(o);

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

                Entiteti.Objekat u = s.Load<Entiteti.Objekat>(61);

                //kolona TIP automatski dobija vrednost DO5
                Toplotni t = new Toplotni()
                {
                    //Datum_Atesta=
                    //Datum_Poslednjeg_Atesta=
                    Opis_servisiranja = "",
                    Model = "",
                    Proizvodjac = "",
                    //Godina_proizvodnje=
                    Horiznotnalna_rez = 3,
                    Vertikalna_rez = 3,
                };

                s.Save(t);

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

                //Ucitavaju se podaci o policijskoj upravi sa zadatim brojem
                PolicijskaUprava.Entiteti.Uprava u = s.Load<PolicijskaUprava.Entiteti.Uprava>(61);

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
    }
}
