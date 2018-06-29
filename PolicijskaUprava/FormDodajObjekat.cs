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
    public partial class FormDodajObjekat : Form
    {
        Objekat obj;
        int ser_br;
        IList<PolicijskaStanica> stanice;

        public FormDodajObjekat(int serijski_br)
        {
            ISession s = DataLayer.GetSession();
            InitializeComponent();
            ser_br = serijski_br;
            obj = new Objekat();
            stanice = s.QueryOver<PolicijskaStanica>().List<PolicijskaStanica>();
            listBox1.Items.Clear();
            foreach(var st in stanice)
            {
                listBox1.Items.Add(st);
            }
            s.Close();
        }

        private void btnDodajObjekat_Click(object sender, EventArgs e)
        {

        }

        private void OsobaZaKontakt_Enter(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                AlarmniSistem alarmniSis = s.Load<AlarmniSistem>(ser_br);

                if(listBox1.SelectedItem!= null)
                {
                    PolicijskaStanica pol = (PolicijskaStanica)listBox1.SelectedItem;
                    PolicijskaStanica stanica = s.Load<PolicijskaStanica>(pol.ID);
                    obj.NadzireStanica = stanica;
                    stanica.Objekti.Add(obj);
                    s.SaveOrUpdate(stanica);
                }
                obj.Tip = txtTip.Text;
                obj.Adresa = txtAdresa.Text;
                obj.Povrsina = Int32.Parse(txtPovrsina.Text);
                obj.Ime = txtIme.Text;
                obj.Prezime = txtPrezime.Text;
                obj.Br_telefona = Int32.Parse(txtBrTelefona.Text);
                obj.InstaliranAlarmniSis = alarmniSis;
                alarmniSis.ObjekatInstaliran = obj;
                s.SaveOrUpdate(alarmniSis);
                s.Save(obj);
                s.Flush();
                s.Close();




            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void FormDodajObjekat_Load(object sender, EventArgs e)
        {

        }
    }
}
