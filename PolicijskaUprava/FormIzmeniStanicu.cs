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
    public partial class FormIzmeniStanicu : Form
    {
     //   IList<Policajac> sefovi;
     //   IList<Policajac> zamenici;
        PolicijskaStanica stanica;
        public FormIzmeniStanicu(PolicijskaStanica pol)
        {
            InitializeComponent();
            stanica = pol;
            IzObjektaUKontrole(stanica);
        }

        public void IzObjektaUKontrole(PolicijskaStanica stanica)
        {
            ISession s = DataLayer.GetSession();
            txtAdresa.Text = stanica.Adresa;
            txtOpstina.Text = stanica.Opstina;
            txtNaziv.Text = stanica.Naziv;
            dtpDatumOsnivanja.Value = stanica.Datum_osnivanja;

            Policajac sef = s.Load<Policajac>(stanica.SefStanice.ID);
            lblSef.Text = sef.Licno_ime;
            Policajac zamenik = s.Load<Policajac>(stanica.ZamenikStanice.ID);
            lblZamenik.Text = zamenik.Licno_ime;
            s.Close();

           

        }

        public void IzKontroleUObjekat()
        {
            stanica.Adresa = txtAdresa.Text;
            stanica.Opstina = txtOpstina.Text;
            stanica.Naziv = txtNaziv.Text;
            stanica.Datum_osnivanja = dtpDatumOsnivanja.Value;
        }


        private void btnIzmeniStanicu_Click(object sender, EventArgs e)
        {
           
        }

        private void btnIzmeniSefa_Click(object sender, EventArgs e)
        {
        }

        private void btnIzmeniZamenika_Click(object sender, EventArgs e)
        {
            
        }

        private void FormIzmeniStanicu_Load(object sender, EventArgs e)
        {

        }

        private void btnIzmeniStanicu_Click_1(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            IzKontroleUObjekat();
            s.SaveOrUpdate(stanica);
            s.Flush();
            s.Close();
            this.Hide();

        }
    }
}
