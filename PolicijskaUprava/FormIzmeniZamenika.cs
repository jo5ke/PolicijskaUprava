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
    public partial class FormIzmeniZamenika : Form
    {
        IList<Cin> cinovi;
        IList<Ustanova> ustanove;
        Policajac zam;
        public FormIzmeniZamenika(Policajac zamenik) //Policijska stanica
        {
            InitializeComponent();
            zam = zamenik;
            IzObjektaUKontrole(zam);
        }

        private void FormIzmeniZamenika_Load(object sender, EventArgs e)
        {

        }
        public void IzObjektaUKontrole(Policajac zam)
        {
           ISession s = DataLayer.GetSession();
            txtIme.Text = zam.Licno_ime;
            txtPrezime.Text =zam.Prezime;
            txtImeRod.Text = zam.Ime_roditelja;
            txtAdresa.Text = zam.Adresa;
            txtJMBG.Text = zam.JMBG.ToString();
            txtPol.Text = zam.Pol.ToString();
            dtpDatumRodj.Value = zam.Datum_rodj;
            dtpDatumDipl.Value = zam.Datum_diplomiranja;
            dtpDatumUnapredjenja.Value = zam.Datum_unapredjenja;
            Cin cin = s.Load<Cin>(zam.ImaCin.ID);
            txtCin.Text = cin.vratiNaziv();
            Ustanova ustanova = s.Load<Ustanova>(zam.PripadaUstanovi.ID);
            txtUstanova.Text = ustanova.vratiNaziv();

            cinovi = s.QueryOver<Cin>().List<Cin>();
            listBoxCin.Items.Clear();
            foreach (var c in cinovi)
            {
                listBoxCin.Items.Add(c);
            }
            ustanove = s.QueryOver<Ustanova>().List<Ustanova>();
            listBoxUstanova.Items.Clear();
            foreach (var u in ustanove)
            {
                listBoxUstanova.Items.Add(u);
            }
            s.Close();

        }
        public void IzKontroleUObjekat()
        {
          //  ISession s = DataLayer.GetSession();
            zam.Licno_ime = txtIme.Text;
            zam.Ime_roditelja = txtImeRod.Text;
            zam.Prezime = txtPrezime.Text;
            zam.JMBG = Int64.Parse(txtJMBG.Text);
            zam.Pol = txtPol.Text[0];
            zam.Adresa = txtAdresa.Text;
            zam.Datum_diplomiranja = dtpDatumDipl.Value;
            zam.Datum_rodj = dtpDatumRodj.Value;
            zam.Datum_unapredjenja = dtpDatumUnapredjenja.Value;

         
            
        }
     
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnIzmeniCin_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Cin ciin = (Cin)listBoxCin.SelectedItem;

            PolicijskaUprava.Entiteti.Cin c = s.Load<PolicijskaUprava.Entiteti.Cin>(ciin.ID);
            zam.ImaCin = c;
            txtCin.Text = zam.ImaCin.vratiNaziv();
            s.Close();
        }

        private void btnIzmeniUstanovu_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Ustanova ust = (Ustanova)listBoxUstanova.SelectedItem;

            PolicijskaUprava.Entiteti.Ustanova u = s.Load<PolicijskaUprava.Entiteti.Ustanova>(ust.ID);
            zam.PripadaUstanovi = u;
            txtUstanova.Text = zam.PripadaUstanovi.vratiNaziv();
            s.Close();
           

        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            IzKontroleUObjekat();
            s.SaveOrUpdate(zam);
            s.Flush();
            s.Close();
            this.Hide();
        }
    }
}
