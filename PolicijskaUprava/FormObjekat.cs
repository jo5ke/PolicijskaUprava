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
    public partial class FormObjekat : Form
    {
        Objekat obj;
        AlarmniSistem alarmniSistem;
       // IList<Patrola> patrole;
        public FormObjekat(Objekat objekat)
        {
            
            InitializeComponent();
            ISession s = DataLayer.GetSession();
            obj = s.Load<Objekat>(objekat.ID);
            alarmniSistem = s.Load<AlarmniSistem>(obj.InstaliranAlarmniSis.Serijski_br);
            foreach (Patrola p in obj.Patrole)
            {
              //  patrole.Add(p);
                listBoxPatrole.Items.Add(p);
            }
            IzObjektaUKontrole(obj);
            s.Close();
        }

        private void FormObjekat_Load(object sender, EventArgs e)
        {


        }
        private void IzObjektaUKontrole(Objekat objekat)
        {
            txtModel.Text = alarmniSistem.Model;
            txtGodinaProiz.Text = alarmniSistem.Godina_proizvodnje.ToString();
            txtOpisServisiranja.Text = alarmniSistem.Opis_servisiranja;
            txtProizvodjac.Text = alarmniSistem.Proizvodjac;
            txtTip.Text = alarmniSistem.Tip;
            dtpDatumAtest.Value = alarmniSistem.Datum_Atesta;
            dtpDatumServisiranja.Value = alarmniSistem.Datum_Poslednjeg_Servisiranja;
            textBoxTehLice.Text = alarmniSistem.TehnickoLice.vratiIme();
            lblIme.Text = obj.Ime;
            lblAdresa.Text = obj.Adresa;
            lblPrezime.Text = obj.Prezime;
            lblTel.Text = obj.Br_telefona.ToString();
            lblPovrsina.Text = obj.Povrsina.ToString();
            lblTip.Text = obj.Tip;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAlarmniSistem fas = new FormAlarmniSistem();
            fas.Show();
            this.Hide();
        }

        private void btnIzmeniTehLice_Click(object sender, EventArgs e)
        {

        }
    }
}
