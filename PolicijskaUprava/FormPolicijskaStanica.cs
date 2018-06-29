using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PolicijskaUprava.Entiteti;
using NHibernate;

namespace PolicijskaUprava
{
    public partial class FormPolicijskaStanica : Form
    {
        Policajac sef;
        Policajac zamenik;
        IList<PolicijskaStanica> listaPolStanica;
        IList<Objekat> listaObjekata;
        IList<Policajac> listaPolicajaca;
        PolicijskaStanica stt;
        Objekat ob;
        public FormPolicijskaStanica()
        {
            InitializeComponent();
            groupBoxPolicajci.Visible = false;
            groupBoxOstalo.Visible = false;
            listBoxObjekti.MouseDoubleClick += new MouseEventHandler(listBoxObjekti_DoubleClick);

            ISession s = DataLayer.GetSession();
            listaPolStanica = s.QueryOver<PolicijskaStanica>().List<PolicijskaStanica>();
            listBoxPolStanica.Items.Clear();
            foreach (var stanica in listaPolStanica)
            {
                listBoxPolStanica.Items.Add(stanica);
            }
            s.Close();
        }
        private void IzKontrolaUObjekat()
        {
            if (listBoxPolStanica.SelectedIndex != -1)
            {

            
                ISession s = DataLayer.GetSession();
                PolicijskaStanica st= (PolicijskaStanica)listBoxPolStanica.SelectedItem;


                stt = s.Load<PolicijskaStanica>(st.ID);

                sef= s.Load<Policajac>(st.SefStanice.ID);
                textBoxSef.Text = sef.vratiIme();
                zamenik = s.Load<Policajac>(st.ZamenikStanice.ID);
                textBoxZamenik.Text = zamenik.vratiIme();

                s.Flush();
                s.Close();

            }
        }

        private void FormPolicijskaStanica_Load(object sender, EventArgs e)
        {

        }

        private void btnPolStanica_Click(object sender, EventArgs e)
        {
            if (groupBoxPolicajci.Visible == false)
                groupBoxPolicajci.Visible = true;
            if (groupBoxOstalo.Visible == false)
                groupBoxOstalo.Visible = true;
            if (groupBox1.Visible == true)
                groupBox1.Visible = false;

            IzKontrolaUObjekat();
            ISession s = DataLayer.GetSession();
            listaPolicajaca = s.QueryOver<Policajac>().List<Policajac>();
            listBoxPolicajci.Items.Clear();
            foreach (var p in listaPolicajaca)
            {
                listBoxPolicajci.Items.Add(p);
            }
           
            listaObjekata = s.QueryOver<Objekat>().List<Objekat>();
            listBoxObjekti.Items.Clear();
            foreach(var o in listaObjekata)
            {
                listBoxObjekti.Items.Add(o);
            }
            s.Close();


        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Policajac pol = (Policajac)listBoxPolicajci.SelectedItem;

            PolicijskaUprava.Entiteti.Policajac p = s.Load<PolicijskaUprava.Entiteti.Policajac>(pol.ID);
            s.Delete(p);
            s.Flush();
            s.Close();
        }

        private void btnPromeniZam_Click(object sender, EventArgs e)
        {
            FormIzmeniZamenika fiz = new FormIzmeniZamenika(zamenik);

            fiz.Show();

        }

        private void groupBoxPolicajci_Enter(object sender, EventArgs e)
        {

        }

        private void btnPromeniSefa_Click(object sender, EventArgs e)
        {
            FormIzmeniZamenika fiz = new FormIzmeniZamenika(zamenik);

            fiz.Show();

        }

        private void listBoxObjekti_DoubleClick(object sender, EventArgs e)
        {
           // int index = this.listBoxObjekti.IndexFromPoint(e.Location);
            //if (index != System.Windows.Forms.ListBox.NoMatches)
           // {
             //   MessageBox.Show(index.ToString());
            //}
        }

        private void listBoxObjekti_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listBoxObjekti.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                
                if (listBoxObjekti.SelectedItem != null)
                {
                    ISession s = DataLayer.GetSession();
                    ob= (Objekat)listBoxObjekti.SelectedItem;
                    Objekat o = s.Load<Objekat>(ob.ID);
                    s.Close();
                    FormObjekat fo = new FormObjekat(o);
                    fo.Show();
                }
                
                
            }
        }

        private void listBoxObjekti_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnObrisiObj_Click(object sender, EventArgs e)
        {
            if(listBoxObjekti.SelectedItem!=null)
            {
                ISession s = DataLayer.GetSession();
               ob = (Objekat)listBoxObjekti.SelectedItem;
                Objekat o = s.Load<Objekat>(ob.ID);
                s.Delete(ob);
                s.Flush();
                s.Close();
            }
        }

        private void btnIzmeniObj_Click(object sender, EventArgs e)
        {
            if (listBoxObjekti.SelectedItem != null)
            {
                ISession s = DataLayer.GetSession();
                Objekat obj = (Objekat)listBoxObjekti.SelectedItem;
                Objekat objekat = s.Load<Objekat>(obj.ID);
                FormIzmeniObjekat fioo = new FormIzmeniObjekat(objekat);
                fioo.Show();
                s.Close();
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FormDodajPolicajca fdp = new FormDodajPolicajca(stt);
            fdp.Show();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (listBoxPolicajci.SelectedItem != null)
            {
                ISession s = DataLayer.GetSession();
                Policajac pool = (Policajac)listBoxPolicajci.SelectedItem;
                Policajac pol = s.Load<Policajac>(pool.ID);
                FormIzmeniPolicajca fipp = new FormIzmeniPolicajca(pol);
                fipp.Show();
                s.Close();
            }
        }
    }
}
