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
    public partial class FormUprava : Form
    {
      //  Policajac nacelnik;
        IList<PolicijskaStanica> listaPolStanica;
        IList<Policajac> listaZamenika;

        Uprava up;
        public FormUprava()
        {
            InitializeComponent();
            //    lbxPolicijskeStanice.MouseDoubleClick += new MouseEventHandler(lbxPolicijskeStanice_doubleClick);

            ISession s = DataLayer.GetSession();
            up = s.Load<Uprava>(1);
            listaPolStanica = up.PolicijskeStanice;
            lbxPolicijskeStanice.Items.Clear();
            foreach (var stanica in listaPolStanica)
            {
                lbxPolicijskeStanice.Items.Add(stanica);
            }
            IzObjektaUKontrole(up);
            s.Close();
        }
        private void IzObjektaUKontrole(Uprava up)
        {
            lblGrad.Text = up.Grad;
            lblNacelnik.Text = up.NacelnikUprave.Licno_ime;
            listaZamenika = up.Policajci;
            lbxZamenici.Items.Clear();
            foreach (var zamenik in listaZamenika)
            {
                lbxZamenici.Items.Add(zamenik);
            }

        }

        

        private void lbxPolicijskeStanice_doubleClick(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnDodajStanicu_Click(object sender, EventArgs e)
        {
          
        }

        private void lbxPolicijskeStanice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnIzmeniStanicu_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnObrisiStanicu_Click(object sender, EventArgs e)
        {
            


        }

        private void FormUprava_Load(object sender, EventArgs e)
        {

        }

        private void btnObrisiStanicu_Click_1(object sender, EventArgs e)
        {
            if(lbxPolicijskeStanice.SelectedItem!=null)
            {
                ISession s = DataLayer.GetSession();
                PolicijskaStanica stanica = (PolicijskaStanica)lbxPolicijskeStanice.SelectedItem;
                PolicijskaStanica st = s.Load<PolicijskaStanica>(stanica.ID);
                s.Delete(st);
                s.Flush();
                s.Close();
            }
        }

        private void btnIzmeniStanicu_Click_1(object sender, EventArgs e)
        {
            if (lbxPolicijskeStanice.SelectedItem != null) {
                PolicijskaStanica polst = (PolicijskaStanica)lbxPolicijskeStanice.SelectedItem;

                FormIzmeniStanicu fis = new FormIzmeniStanicu(polst);
                fis.Show();
                
             }
        }

        private void btnDodajStanicu_Click_1(object sender, EventArgs e)
        {
            FormDodajStanicu fds = new FormDodajStanicu(up);
            fds.Show();
        }
    }
}
