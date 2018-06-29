using NHibernate;
using PolicijskaUprava.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolicijskaUprava
{
    public partial class FormDodajPolicajca : Form

    {

        IList<Skola> skole;
        IList<Ustanova> ustanove;
        IList<Cin> cinovi;
        IList<Patrola> patrole;
        IList<Ulica> ulice;
        PolicijskaStanica stanica;
        public FormDodajPolicajca(PolicijskaStanica pol)
        {
            InitializeComponent();
            
            ISession s = DataLayer.GetSession();
            stanica = pol ;
            cinovi = s.QueryOver<Cin>().List<Cin>();
            listBoxCin.Items.Clear();
            foreach(var c in cinovi)
            {
                listBoxCin.Items.Add(c);
            }
            ustanove = s.QueryOver<Ustanova>().List<Ustanova>();
            listBoxUstanova.Items.Clear();
            foreach(var u in ustanove)
            {
                listBoxUstanova.Items.Add(u);
            }
            s.Close();
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox1.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;



        }

        private void btnSkolski_Click(object sender, EventArgs e)
        {
           

        }

        private void btnDodaj_Click(object sender, EventArgs e) //obrisano
        {


        }

        private void btnOstali_Click(object sender, EventArgs e)
        {
           
        }

        private void btnVanredni_Click(object sender, EventArgs e)
        {
           
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btnPozornik_Click(object sender, EventArgs e)
        {
           
        }



        private void btnDodajVanredni_Click(object sender, EventArgs e)
        {
         
        }

        private void btnDodajPozornik_Click(object sender, EventArgs e)
        {
         
        }



        private void btnDodajSkolski_Click(object sender, EventArgs e)
        {
        
        }

        private void btnDodajOstali_Click(object sender, EventArgs e)
        {
          
        }

        private void FormDodajPolicajca_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnDodajPozornik_Click_1(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Pozornik p = new Pozornik();


                p.Licno_ime = txtIme.Text;
                p.Ime_roditelja = txtImeRod.Text;
                p.Prezime = txtPrezime.Text;
                p.JMBG = Int64.Parse(txtJMBG.Text);
                p.Pol = txtPol.Text[0]; //proveriti
                p.Datum_rodj = dtpDatumRodj.Value;
                p.Adresa = txtAdresa.Text;
                p.Datum_diplomiranja = dtpDatumDipl.Value;
                p.Datum_unapredjenja = dtpDatumUnapredjenja.Value;
                p.Tip = "Pozornik";


                if (listBoxCin.SelectedIndex != -1)
                {

                    Cin c = (Cin)listBoxCin.SelectedItem;

                    c = s.Load<PolicijskaUprava.Entiteti.Cin>(c.ID);
                    p.ImaCin = c;
                    c.Policajci.Add(p);
                    s.Save(c);


                }

                if (listBoxUlica.SelectedIndex != -1)
                {

                    Ulica ul = (Ulica)listBoxUlica.SelectedItem;

                    ul = s.Load<PolicijskaUprava.Entiteti.Ulica>(ul.ID);
                    p.Ulice.Add(ul);
                    ul.PozornikUlice = p;
                    s.Save(ul);
                }

                if (listBoxUstanova.SelectedIndex != -1)
                {

                    Ustanova u = (Ustanova)listBoxUstanova.SelectedItem;

                    u = s.Load<PolicijskaUprava.Entiteti.Ustanova>(u.ID);
                    p.PripadaUstanovi = u;
                    u.Policajci.Add(p);
                    s.Save(u);

                }
                if (groupBox5.Visible == true)
                    groupBox5.Visible = false;
                if (groupBox1.Visible == true)
                    groupBox1.Visible = false;

                stanica.Policajci.Add(p);
                PolicijskaStanica st = s.Load<PolicijskaStanica>(stanica.ID);
                st.Policajci.Add(p);
                p.RadiUStanici = st;
                s.SaveOrUpdate(st);
                s.Save(p);
                s.Flush();
                s.Close();




            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void btnDodajVanredni_Click_1(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                VanredneSituacije p = new VanredneSituacije();


                p.Licno_ime = txtIme.Text;
                p.Ime_roditelja = txtImeRod.Text;
                p.Prezime = txtPrezime.Text;
                p.JMBG = Int64.Parse(txtJMBG.Text);
                p.Pol = txtPol.Text[0]; //proveriti
                p.Datum_rodj = dtpDatumRodj.Value;
                p.Adresa = txtAdresa.Text;
                p.Datum_diplomiranja = dtpDatumDipl.Value;
                p.Datum_unapredjenja = dtpDatumUnapredjenja.Value;
                p.Kurs = txtKurs.Text;
                p.Sertifikat = txtSertifikat.Text;
                p.Naziv_vestine = txtVestina.Text;
                p.Datum_kursa = dtpDatumKursa.Value;
                p.Datum_sertifikata = dtpDatumSert.Value;
                p.Tip = "Vanredne situacije";


                if (listBoxCin.SelectedIndex != -1)
                {

                    Cin c = (Cin)listBoxCin.SelectedItem;

                    c = s.Load<PolicijskaUprava.Entiteti.Cin>(c.ID);
                    p.ImaCin = c;
                    c.Policajci.Add(p);
                    s.Save(c);


                }



                if (listBoxUstanova.SelectedIndex != -1)
                {

                    Ustanova u = (Ustanova)listBoxUstanova.SelectedItem;

                    u = s.Load<PolicijskaUprava.Entiteti.Ustanova>(u.ID);
                    p.PripadaUstanovi = u;
                    u.Policajci.Add(p);
                    s.Save(u);

                }
                if (groupBox4.Visible == true)
                    groupBox4.Visible = false;
                if (groupBox1.Visible == true)
                    groupBox1.Visible = false;
                PolicijskaStanica st = s.Load<PolicijskaStanica>(stanica.ID);
                st.Policajci.Add(p);
                p.RadiUStanici = st;
                s.SaveOrUpdate(st);
                s.Save(p);
                s.Flush();
                s.Close();




            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void btnDodajOstali_Click_1(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Ostali p = new Ostali();


                p.Licno_ime = txtIme.Text;
                p.Ime_roditelja = txtImeRod.Text;
                p.Prezime = txtPrezime.Text;
                p.JMBG = Int64.Parse(txtJMBG.Text);
                p.Pol = txtPol.Text[0]; //proveriti
                p.Datum_rodj = dtpDatumRodj.Value;
                p.Adresa = txtAdresa.Text;
                p.Datum_diplomiranja = dtpDatumDipl.Value;
                p.Datum_unapredjenja = dtpDatumUnapredjenja.Value;
                p.Tip = "Ostali";


                if (listBoxCin.SelectedIndex != -1)
                {

                    Cin c = (Cin)listBoxCin.SelectedItem;

                    c = s.Load<PolicijskaUprava.Entiteti.Cin>(c.ID);
                    p.ImaCin = c;
                    c.Policajci.Add(p);
                    s.Save(c);

                }
                if (listBoxPatrola.SelectedIndex != -1)
                {

                    Patrola pat = (Patrola)listBoxPatrola.SelectedItem;

                    pat = s.Load<PolicijskaUprava.Entiteti.Patrola>(pat.Redni_br);

                    p.RadiU = pat;
                    pat.Radnici.Add(p);
                    s.Save(pat);
                }


                if (listBoxUstanova.SelectedIndex != -1)
                {

                    Ustanova u = (Ustanova)listBoxUstanova.SelectedItem;

                    u = s.Load<PolicijskaUprava.Entiteti.Ustanova>(u.ID);
                    p.PripadaUstanovi = u;
                    u.Policajci.Add(p);
                    s.Save(u);

                }
                if (groupBox3.Visible == true)
                    groupBox3.Visible = false;
                if (groupBox1.Visible == true)
                    groupBox1.Visible = false;
                PolicijskaStanica st = s.Load<PolicijskaStanica>(stanica.ID);
                st.Policajci.Add(p);
                p.RadiUStanici = st;
                s.SaveOrUpdate(st);

                s.Save(p);
                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void btnDodajSkolski_Click_1(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Skolski p = new Skolski();


                p.Licno_ime = txtIme.Text;
                p.Ime_roditelja = txtImeRod.Text;
                p.Prezime = txtPrezime.Text;
                p.JMBG = Int64.Parse(txtJMBG.Text);
                p.Pol = txtPol.Text[0]; //proveriti
                p.Datum_rodj = dtpDatumRodj.Value;
                p.Adresa = txtAdresa.Text;
                p.Datum_diplomiranja = dtpDatumDipl.Value;
                p.Datum_unapredjenja = dtpDatumUnapredjenja.Value;
                p.Tip = "Skolski";


                if (listBoxCin.SelectedIndex != -1)
                {

                    Cin c = (Cin)listBoxCin.SelectedItem;

                    c = s.Load<PolicijskaUprava.Entiteti.Cin>(c.ID);
                    p.ImaCin = c;
                    c.Policajci.Add(p);
                    s.Save(c);


                }

                if (listBoxSkola.SelectedIndex != -1)
                {

                    Skola sk = (Skola)listBoxSkola.SelectedItem;

                    sk = s.Load<PolicijskaUprava.Entiteti.Skola>(sk.ID);
                    p.RadiUSkoli = sk;
                    sk.Skolski.Add(p);
                    s.Save(sk);
                }

                if (listBoxUstanova.SelectedIndex != -1)
                {

                    Ustanova u = (Ustanova)listBoxUstanova.SelectedItem;

                    u = s.Load<PolicijskaUprava.Entiteti.Ustanova>(u.ID);
                    p.PripadaUstanovi = u;
                    u.Policajci.Add(p);
                    s.Save(u);

                }
                if (groupBox2.Visible == true)
                    groupBox2.Visible = false;
                if (groupBox1.Visible == true)
                    groupBox1.Visible = false;
                PolicijskaStanica st = s.Load<PolicijskaStanica>(stanica.ID);
                st.Policajci.Add(p);
                p.RadiUStanici = st;
                s.SaveOrUpdate(st);

                s.Save(p);
                s.Flush();
                s.Close();




            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void btnSkolski_Click_1(object sender, EventArgs e)
        {
            if (groupBox1.Visible == false)
                groupBox1.Visible = true;
            if (groupBox2.Visible == false)
                groupBox2.Visible = true;
            if (groupBox3.Visible == true)
                groupBox3.Visible = false;
            if (groupBox4.Visible == true)
                groupBox4.Visible = false;
            if (groupBox5.Visible == true)
                groupBox5.Visible = false;
            ISession s = DataLayer.GetSession();
            skole = s.QueryOver<Skola>().List<Skola>();
            listBoxSkola.Items.Clear();
            foreach(var sk in skole)
            {
                listBoxSkola.Items.Add(sk);
            }
            s.Close();


        }

        private void btnOstali_Click_1(object sender, EventArgs e)
        {
            if (groupBox1.Visible == false)
                groupBox1.Visible = true;
            if (groupBox3.Visible == false)
                groupBox3.Visible = true;
            if (groupBox2.Visible == true)
                groupBox2.Visible = false;
            if (groupBox4.Visible == true)
                groupBox4.Visible = false;
            if (groupBox5.Visible == true)
                groupBox5.Visible = false;
            ISession s = DataLayer.GetSession();
            patrole = s.QueryOver<Patrola>().List<Patrola>();
            listBoxPatrola.Items.Clear();
            foreach (var p in patrole)
            {
                listBoxPatrola.Items.Add(p);
            }
            s.Close();

        }

        private void btnVanredni_Click_1(object sender, EventArgs e)
        {
            if (groupBox1.Visible == false)
                groupBox1.Visible = true;
            if (groupBox4.Visible == false)
                groupBox4.Visible = true;
            if (groupBox3.Visible == true)
                groupBox3.Visible = false;
            if (groupBox2.Visible == true)
                groupBox2.Visible = false;
            if (groupBox5.Visible == true)
                groupBox5.Visible = false;


        }

        private void btnPozornik_Click_1(object sender, EventArgs e)
        {
            if (groupBox1.Visible == false)
                groupBox1.Visible = true;
            if (groupBox5.Visible == false)
                groupBox5.Visible = true;
            if (groupBox3.Visible == true)
                groupBox3.Visible = false;
            if (groupBox4.Visible == true)
                groupBox4.Visible = false;
            if (groupBox2.Visible == true)
                groupBox2.Visible = false;
            ISession s = DataLayer.GetSession();
            ulice = s.QueryOver<Ulica>().List<Ulica>();
            listBoxUlica.Items.Clear();
            foreach (var ul in ulice)
            {
                listBoxUlica.Items.Add(ul);
            }
            s.Close();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
