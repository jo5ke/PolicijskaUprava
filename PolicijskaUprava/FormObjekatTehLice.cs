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
    public partial class FormObjekatTehLice : Form
    {
        AlarmniSistem sistem;
        public FormObjekatTehLice(int alarm)
        {
            ISession s = DataLayer.GetSession();
            InitializeComponent();
            sistem = s.Load<AlarmniSistem>(alarm);
            s.Close();
        }

        private void FormObjekatTehLice_Load(object sender, EventArgs e)
        {

        }

        private void btnTehLice_Click(object sender, EventArgs e)
        {
            FormTehLiceDodaj flc = new FormTehLiceDodaj(sistem.Serijski_br);
            flc.Show();
        }

        private void btnObjekat_Click(object sender, EventArgs e)
        {
            FormDodajObjekat fo = new FormDodajObjekat(sistem.Serijski_br);
            fo.Show();
        }
    }
}
