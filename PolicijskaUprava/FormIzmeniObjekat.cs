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
    public partial class FormIzmeniObjekat : Form
    {
        Objekat o;

        public FormIzmeniObjekat(Objekat ob)
        {
            InitializeComponent();

            o= ob;
            txtTip.Text = o.Tip;
            txtAdresa.Text = o.Adresa;
            txtPovrsina.Text = o.Povrsina.ToString();
            txtIme.Text = o.Ime;
            txtPrezime.Text = o.Prezime;
            txtBrTelefona.Text = o.Br_telefona.ToString();

            txtSerijskiBr.Text = o.InstaliranAlarmniSis.Serijski_br.ToString();

            dtpDatumInstaliranja.Value = o.Datum_instalacije;
        }


       

       

        private void btnIzmeniObjekat_Click(object sender, EventArgs e)
        {
           
           // IzKontroleUObjekat();
            //this.Hide();
        }

        private void FormIzmeniObjekat_Load(object sender, EventArgs e)
        {

        }

        private void btnIzmeniObjekat_Click_1(object sender, EventArgs e)
        {

            try
            {
                o.Tip = txtTip.Text;
                o.Adresa = txtAdresa.Text;
                o.Povrsina = Int32.Parse(txtPovrsina.Text);
                o.Ime = txtIme.Text;
                o.Prezime = txtPrezime.Text;
                o.Br_telefona = Int32.Parse(txtBrTelefona.Text);
                int serijski_br = Int32.Parse(txtSerijskiBr.Text);
                ISession s = DataLayer.GetSession();
                AlarmniSistem sistem = s.Load<AlarmniSistem>(serijski_br);
                o.InstaliranAlarmniSis = sistem;
                sistem.ObjekatInstaliran = o;
                s.SaveOrUpdate(sistem);
                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();
                this.Hide();
            }
            catch (NonUniqueObjectException ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
