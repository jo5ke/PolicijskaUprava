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
    public partial class FormTehLiceDodaj : Form
    {
        int ser_br;
        TehnickoLice lice;
        public FormTehLiceDodaj(int alarmniSistem)
        {
            InitializeComponent();
            lice = new TehnickoLice();
            ser_br = alarmniSistem;

        }

        private void FormTehLiceDodaj_Load(object sender, EventArgs e)
        {


        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            AlarmniSistem sistem = s.Load<AlarmniSistem>(ser_br);
            lice.Ime = txtIme.Text;
            lice.Serijski_br_alarma = sistem;
            sistem.TehnickoLice = lice;
            s.Save(lice);
            s.SaveOrUpdate(sistem);
            s.Flush();
            s.Close();
            this.Hide();
           
            
        }
    }
}
