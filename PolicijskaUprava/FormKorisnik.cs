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
    public partial class FormKorisnik : Form
    {
        PolicijskaStanica stanica = new PolicijskaStanica();
        Policajac sef = new Policajac();
        IList<PolicijskaStanica> stanice;

        public FormKorisnik()
        {
            InitializeComponent();
            groupBox1.Visible = false;
            groupBox3.Visible = false;

        }


        private void txtImeStanice_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnKontaktirajteSefa_Click(object sender, EventArgs e)
        {
            lblNaziv.Text = sef.Licno_ime;
            lblImeRoditelja.Text = sef.Ime_roditelja;
            lblPrezime.Text = sef.Prezime;
            lblJMBG.Text = sef.JMBG.ToString();
            lblPol.Text = sef.Pol.ToString();
            lblDatumRodjenja.Text = sef.Datum_rodj.ToString();
            lblAdresa.Text = sef.Adresa;
            lblDatumDiplomiranja.Text = sef.Datum_diplomiranja.ToString();
            lblDatumUnapredjenja.Text = sef.Datum_unapredjenja.ToString();
            //lblOblast.Text = sef.Oblast;
            //lblTip.Text = sef.Tip;


        }

        private void FormKorisnik_Load(object sender, EventArgs e)
        {

        }

        private void btnKontaktirajteSefa_Click_1(object sender, EventArgs e)
        {
            groupBox3.Visible = true;

            lblNaziv.Text = sef.Licno_ime;
            lblImeRoditelja.Text = sef.Ime_roditelja;
            lblPrezime.Text = sef.Prezime;
            lblJMBG.Text = sef.JMBG.ToString();
            lblPol.Text = sef.Pol.ToString();
            lblDatumRodjenja.Text = sef.Datum_rodj.ToString();
            lblAdresa.Text = sef.Adresa;
            lblDatumDiplomiranja.Text = sef.Datum_diplomiranja.ToString();
            lblDatumUnapredjenja.Text = sef.Datum_unapredjenja.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();

            stanice = s.QueryOver<PolicijskaStanica>().List<PolicijskaStanica>();
            

            foreach (var st in stanice)
            {
                if (st.Naziv == txtImeStanice.Text)
                {
                    stanica = st;
                    sef = st.SefStanice;
                }
            }

            lblAdresa.Text = stanica.Adresa;
            lblOpstina.Text = stanica.Opstina;
            lblNaziv.Text = stanica.Naziv;
            lblDatum.Text = stanica.Datum_osnivanja.ToString();
            groupBox1.Visible = true;
        }
    }
}
