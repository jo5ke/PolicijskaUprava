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
    public partial class FormIzmeniPolicajca : Form
    {
        Policajac p = new Policajac();
        IList<Ulica> ulice;
        IList<Cin> cinovi;
       // IList<Ustanova> ustanove;
        IList<Skola> skole;
      //  IList<Patrola> patrole;
        VanredneSituacije vanrednesit;
        Ostali ostali;
        Pozornik pozornik;
        Skolski skolski;

        public FormIzmeniPolicajca(Policajac pol)
        {
            InitializeComponent();
            p = pol;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox8.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            IzObjektaUKontrole(p);

        }
        public void IzObjektaUKontrole(Policajac p)
        {
            ISession s = DataLayer.GetSession();

            txtLicnoIme.Text = p.Licno_ime;
            txtImeRoditelja.Text = p.Ime_roditelja;
            txtPrezime.Text = p.Prezime;
            txtJMBG.Text = p.JMBG.ToString();
            txtPol.Text = p.Pol.ToString(); //proveriti
            dtpDatumRodjenja.Value = p.Datum_rodj;
            txtAdresa.Text = p.Adresa;
            dtpDatumDiplomiranja.Value = p.Datum_diplomiranja;
            dtpDatumUnapredjenja.Value = p.Datum_unapredjenja;

            txtCin.Text = p.ImaCin.Naziv_cina;
            txtUstanova.Text = p.PripadaUstanovi.Naziv_ustanove;


            if (p.Tip == "Skolski")
            {
                Skolski skolski = s.Load<Skolski>(p.ID);
                if (groupBox2.Visible == false)
                    groupBox2.Visible = true;
                txtSkola.Text = skolski.RadiUSkoli.Naziv;
                lbxSkola.Items.Clear();
                skole = s.QueryOver<Skola>().List<Skola>();
                foreach(var sk in skole)
                {
                    lbxSkola.Items.Add(sk);
                }
               

               
            }

            if (p.Tip == "Ostali")
            {
                Ostali ostali = s.Load<Ostali>(p.ID);
                if (groupBox3.Visible == false)
                    groupBox3.Visible = true;
                txtPatrola.Text = ostali.RadiU.Redni_br.ToString();

              
            }


            if (p.Tip == "Vanredni")
            {
                VanredneSituacije vanredni = s.Load<VanredneSituacije>(p.ID);
                if (groupBox3.Visible == false)
                    groupBox3.Visible = true;
                txtNazivVestine.Text = vanredni.Naziv_vestine;
                txtKurs.Text = vanredni.Kurs;
                dtpDatumKursa.Value = vanredni.Datum_kursa;
                txtSertifikat.Text = vanredni.Sertifikat;
                dtpDatumSertifikata.Value = vanredni.Datum_sertifikata;
            }

            if (p.Tip == "Pozornik")
            {
                Pozornik pozornik = s.Load<Pozornik>(p.ID);
                if (groupBox5.Visible == false)
                    groupBox5.Visible = true;
                lbxUlice.Items.Clear();
                ulice = s.QueryOver<Ulica>().List<Ulica>();
                foreach (var u in ulice)
                {
                    lbxUlice.Items.Add(u);
                }


            }



        }



        public void IzKontroleUObjekat()
        {


            if (groupBox2.Visible == true)
            {
                ISession s = DataLayer.GetSession();
                skolski = s.Load<Skolski>(p.ID);
                skolski.RadiUSkoli.Naziv = txtSkola.Text;

                skolski.Licno_ime = txtLicnoIme.Text;
                skolski.Ime_roditelja = txtImeRoditelja.Text;
                skolski.Prezime = txtPrezime.Text;
                skolski.JMBG = Int64.Parse(txtJMBG.Text);
                skolski.Pol = txtPol.Text[0];
                skolski.Datum_rodj = dtpDatumRodjenja.Value;
                skolski.Adresa = txtAdresa.Text;
                skolski.Datum_diplomiranja = dtpDatumDiplomiranja.Value;
                skolski.Datum_unapredjenja = dtpDatumUnapredjenja.Value;

                if (lbxSkola.SelectedItem != null)
                {
                    Skola skola = (Skola)lbxSkola.SelectedItem;
                    Skola sk = s.Load<Skola>(skola.ID);
                    skolski.RadiUSkoli = sk;
                    sk.Skolski.Add(skolski);
                    s.Save(sk);
                }
                s.Save(skolski);
                s.Flush();
                s.Close();




            }

            if (groupBox3.Visible == true)
            {
                ISession s = DataLayer.GetSession();
                ostali = s.Load<Ostali>(p.ID);

                ostali.Licno_ime = txtLicnoIme.Text;
                ostali.Ime_roditelja = txtImeRoditelja.Text;
                ostali.Prezime = txtPrezime.Text;
                ostali.JMBG = Int32.Parse(txtJMBG.Text);
                ostali.Pol = txtPol.Text[0];
                ostali.Datum_rodj = dtpDatumRodjenja.Value;
                ostali.Adresa = txtAdresa.Text;
                ostali.Datum_diplomiranja = dtpDatumDiplomiranja.Value;
                ostali.Datum_unapredjenja = dtpDatumUnapredjenja.Value;
                if (lbxPatrola.SelectedItem != null)
                {
                    Patrola p = (Patrola)lbxPatrola.SelectedItem;
                    Patrola patrola = s.Load<Patrola>(p.Redni_br);
                    ostali.RadiU = patrola;
                    patrola.Radnici.Add(ostali);
                    s.Save(patrola);
                }
                s.Save(ostali);
                s.Flush();
                s.Close();


            }

            if (groupBox4.Visible == true)
            {
                ISession s = DataLayer.GetSession();
                vanrednesit = s.Load<VanredneSituacije>(p.ID);

                vanrednesit.Naziv_vestine = txtNazivVestine.Text;
                vanrednesit.Kurs = txtKurs.Text;
                vanrednesit.Datum_kursa = dtpDatumKursa.Value;
                vanrednesit.Sertifikat = txtSertifikat.Text;
                vanrednesit.Datum_sertifikata = dtpDatumSertifikata.Value;

                vanrednesit.Licno_ime = txtLicnoIme.Text;
                vanrednesit.Ime_roditelja = txtImeRoditelja.Text;
                vanrednesit.Prezime = txtPrezime.Text;
                vanrednesit.JMBG = Int32.Parse(txtJMBG.Text);
                vanrednesit.Pol = txtPol.Text[0];
                vanrednesit.Datum_rodj = dtpDatumRodjenja.Value;
                vanrednesit.Adresa = txtAdresa.Text;
                vanrednesit.Datum_diplomiranja = dtpDatumDiplomiranja.Value;
                vanrednesit.Datum_unapredjenja = dtpDatumUnapredjenja.Value;
                s.Save(vanrednesit);
                s.Flush();
                s.Close();

            }

            if (groupBox8.Visible == true)
            {
                ISession s = DataLayer.GetSession();
                pozornik = s.Load<Pozornik>(p.ID);

                pozornik.Licno_ime = txtLicnoIme.Text;
                pozornik.Ime_roditelja = txtImeRoditelja.Text;
                pozornik.Prezime = txtPrezime.Text;
                pozornik.JMBG = Int32.Parse(txtJMBG.Text);
                pozornik.Pol = txtPol.Text[0];
                pozornik.Datum_rodj = dtpDatumRodjenja.Value;
                pozornik.Adresa = txtAdresa.Text;
                pozornik.Datum_diplomiranja = dtpDatumDiplomiranja.Value;
                pozornik.Datum_unapredjenja = dtpDatumUnapredjenja.Value;

                if (lbxUlice.SelectedItem != null)
                {
                    Ulica u = (Ulica)lbxNoveUlice.SelectedItem;
                    Ulica ulica = s.Load<Ulica>(u.ID);
                    pozornik.Ulice.Add(ulica);
                    ulica.PozornikUlice = pozornik;
                    s.Save(ulica);
                }
                s.Save(pozornik);
                s.Flush();
                s.Close();


            }

        }

        private void btnIzmeniCin_Click(object sender, EventArgs e)
        {
           


        }

        private void btnIzmeniUstanovu_Click(object sender, EventArgs e)
        {
           

        }

        private void btnIzmeniPolicajca_Click(object sender, EventArgs e)
        {

          
        }

        private void btnIzmeniListuUlica_Click(object sender, EventArgs e)
        {
           
        }



        private void FormIzmeniPolicajca_Load(object sender, EventArgs e)
        {

        }

        private void btnIzmeniPolicajca_Click_1(object sender, EventArgs e)
        {
            IzKontroleUObjekat();
            this.Hide();

        }

        private void btnIzmeniListuUlica_Click_1(object sender, EventArgs e)
        {
            if (groupBox8.Visible == false)
                groupBox8.Visible = true;
            ISession s = DataLayer.GetSession();
            ulice = s.QueryOver<Ulica>().List<Ulica>();
            lbxNoveUlice.Items.Clear();
            foreach (var c in ulice)
            {
                lbxNoveUlice.Items.Add(c);

            }
            s.Close();

        }

        private void btnIzmeniCin_Click_1(object sender, EventArgs e)
        {
            if (groupBox6.Visible == false)
                groupBox6.Visible = true;
            ISession s = DataLayer.GetSession();
            cinovi = s.QueryOver<Cin>().List<Cin>();
            lbxCinovi.Items.Clear();
            foreach (var c in cinovi)
            {
                lbxCinovi.Items.Add(c);

            }
            s.Close();

        }

        private void btnIzmeniUstanovu_Click_1(object sender, EventArgs e)
        {

        }

        private void lbxSkola_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbxPatrola_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbxNoveUlice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbxUlice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbxUstanove_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbxCinovi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
