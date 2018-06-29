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
    public partial class FormDodajStanicu : Form
    {
        Uprava uprava = new Uprava();
        IList<Policajac> policajci;

        public FormDodajStanicu(Uprava up)
        {
            InitializeComponent();
            ISession s = DataLayer.GetSession();
            uprava = up;
            policajci = s.QueryOver<Policajac>().List<Policajac>();
            lbxSef.Items.Clear();
            lbxZamenik.Items.Clear();
            foreach(var p in policajci)
            {
                lbxSef.Items.Add(p);
                lbxZamenik.Items.Add(p);
            }
            s.Close();




            

        }

        private void btnDodajStanicu_Click(object sender, EventArgs e)
        {
            
        }

        private void FormDodajStanicu_Load(object sender, EventArgs e)
        {


        }

        private void btnDodajStanicu_Click_1(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PolicijskaStanica p = new PolicijskaStanica();


                p.Adresa = txtAdresa.Text;
                p.Opstina = txtOpstina.Text;
                p.Naziv = txtNaziv.Text;
                p.Datum_osnivanja = dtpDatumOsnivanja.Value;



                if (lbxSef.SelectedIndex != -1)
                {

                    Policajac sef = (Policajac)lbxSef.SelectedItem;

                    sef = s.Load<PolicijskaUprava.Entiteti.Policajac>(sef.ID);
                    p.SefStanice = sef;
                    sef.PolicijskaStanicaSefa = p;
                    s.Save(sef);
                    uprava.PolicijskeStanice.Add(p);

                }



                if (lbxZamenik.SelectedIndex != -1)
                {

                    Policajac zamenik = (Policajac)lbxZamenik.SelectedItem;

                    zamenik = s.Load<PolicijskaUprava.Entiteti.Policajac>(zamenik.ID);
                    p.ZamenikStanice = zamenik;
                    zamenik.PolicijskaStanicaZamenika = p;
                    s.Save(zamenik);
                    uprava.PolicijskeStanice.Add(p);

                }


                s.SaveOrUpdate(uprava);
                s.Save(p);
                s.Flush();
                s.Close();
                this.Hide();




            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
