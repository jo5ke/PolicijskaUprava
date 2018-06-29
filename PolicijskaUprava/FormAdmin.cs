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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormPolicijskaStanica fs = new FormPolicijskaStanica();

            fs.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormUprava fu = new FormUprava();
            fu.Show();
            this.Hide();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
