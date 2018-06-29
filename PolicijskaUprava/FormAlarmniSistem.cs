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
    public partial class FormAlarmniSistem : Form
    {
        Toplotni top;
        Ultrazvucni ultzv;
        Pokretni pok;
        IList<AlarmniSistem> listaAlarma=new List<AlarmniSistem>();
      //  IList<Objekat> listaObjekata;
        IList<TehnickoLice> listaTehLica;
        public FormAlarmniSistem()
        {
            InitializeComponent();
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            txtRegBr.Visible = false;
            lblRegBr.Visible = false;
            ISession s = DataLayer.GetSession();
            listaAlarma = s.QueryOver<AlarmniSistem>().List<AlarmniSistem>();
            listBoxAlarmi.Items.Clear();
            foreach (var alarm in listaAlarma)
            {
                listBoxAlarmi.Items.Add(alarm);
            }
            s.Close();
        }

        private void FormAlarmniSistem_Load(object sender, EventArgs e)
        {

        }

        private void btnDodajSis_Click(object sender, EventArgs e)
        {
            if (groupBox3.Visible == false)
                groupBox3.Visible = true;
            if (groupBox2.Visible == true)
                groupBox2.Visible = false;
            label10.Visible = false;
            label9.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (groupBox5.Visible == false)
                groupBox5.Visible = true;
            if (groupBox1.Visible == false)
                groupBox1.Visible = true;
            if (groupBox4.Visible == true)
                groupBox4.Visible = false;
            if (groupBox6.Visible == true)
                groupBox6.Visible = false;
            lblObjekat.Visible = false;
            lblTehLice.Visible = false;
            groupBox3.Visible = false;
            txtRegBr.Visible = true;
            lblRegBr.Visible = true;
            

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (groupBox5.Visible== true)
            {
                Toplotni alarmniSistem = new Toplotni();
                ISession s = DataLayer.GetSession();
                alarmniSistem.Godina_proizvodnje = Int32.Parse(txtGodProizvodnje.Text);
                alarmniSistem.Horizontalna_rez = Int32.Parse(txtHorizontalna.Text);
                alarmniSistem.Vertikalna_rez = Int32.Parse(txtVertikalna.Text);
                alarmniSistem.Model = txtModel.Text;
                alarmniSistem.Proizvodjac = txtProizvodjac.Text;
                alarmniSistem.Tip = "Toplotni";
                alarmniSistem.Datum_Atesta = dtpDatumAtesta.Value;
                s.Save(alarmniSistem);
                s.Flush();
                groupBox5.Visible = false;
                groupBox1.Visible = false;
                groupBox3.Visible = false;
                int reg_br = Int32.Parse(txtRegBr.Text);
                s.Close();
                FormObjekatTehLice fot = new FormObjekatTehLice(reg_br);
                fot.Show();
            }
            else if(groupBox6.Visible==true)
            {
                Pokretni alarmniSistem = new Pokretni();
                ISession s = DataLayer.GetSession();
                alarmniSistem.Godina_proizvodnje = Int32.Parse(txtGodProizvodnje.Text);
                alarmniSistem.Tezina = Int32.Parse(txtTezina.Text);
                alarmniSistem.Model = txtModel.Text;
                alarmniSistem.Proizvodjac = txtProizvodjac.Text;
                alarmniSistem.Tip = "Pokretni";
                alarmniSistem.Datum_Atesta = dtpDatumAtesta.Value;
                s.Save(alarmniSistem);
                s.Flush();
                groupBox6.Visible = false;
                groupBox1.Visible = false;
                groupBox3.Visible = false;
                int reg_br = Int32.Parse(txtRegBr.Text);
                s.Close();
                FormObjekatTehLice fot = new FormObjekatTehLice(reg_br);
                fot.Show();
            }
            else if (groupBox4.Visible == true)
            {
                Ultrazvucni alarmniSistem = new Ultrazvucni();
                ISession s = DataLayer.GetSession();
                alarmniSistem.Godina_proizvodnje = Int32.Parse(txtGodProizvodnje.Text);
                alarmniSistem.Frekvencija = Int32.Parse(txtFrekvencija.Text);
                alarmniSistem.Model = txtModel.Text;
                alarmniSistem.Proizvodjac = txtProizvodjac.Text;
                alarmniSistem.Tip = "Ultrazvucni";
                alarmniSistem.Datum_Atesta = dtpDatumAtesta.Value;
                s.Save(alarmniSistem);
                s.Flush();
                groupBox4.Visible = false;
                groupBox1.Visible = false;
                groupBox3.Visible = false;
                int reg_br = Int32.Parse(txtRegBr.Text);
                s.Close();
                FormObjekatTehLice fot = new FormObjekatTehLice(reg_br);
                fot.Show();

            }
           
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (groupBox6.Visible == false)
                groupBox6.Visible = true;
            if (groupBox1.Visible == false)
                groupBox1.Visible = true;
            if (groupBox5.Visible == true)
                groupBox5.Visible = false;
            if (groupBox4.Visible == true)
                groupBox4.Visible = false;
            lblObjekat.Visible = false;
            lblTehLice.Visible = false;
            groupBox3.Visible = false;
            txtRegBr.Visible = true;
            lblRegBr.Visible = true;



        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (groupBox4.Visible == false)
                groupBox4.Visible = true;
            if (groupBox1.Visible == false)
                groupBox1.Visible = true;
            if (groupBox5.Visible == true)
                groupBox5.Visible = false;
            if (groupBox6.Visible == true)
                groupBox6.Visible = false;
            lblObjekat.Visible = false;
            lblTehLice.Visible = false;
            groupBox3.Visible = false;
            txtRegBr.Visible = true;
            lblRegBr.Visible = true;

        }

        private void btnIzmeniSis_Click(object sender, EventArgs e)
        {
            if (groupBox1.Visible == false)
                groupBox1.Visible = true;
            if (groupBox2.Visible == false)
                groupBox2.Visible = true;
            if (btnDodaj.Visible == true)
                btnDodaj.Visible = false;

            if (listBoxAlarmi.SelectedItem!= null)
            {
                
                AlarmniSistem sistem = (AlarmniSistem)listBoxAlarmi.SelectedItem;
                if(sistem.Tip=="Toplotni")
                {
                    ISession s = DataLayer.GetSession();
                    if (groupBox5.Visible == false)
                        groupBox5.Visible = true;
                    groupBox4.Visible = false;
                    groupBox6.Visible = false;
                    listaTehLica = s.QueryOver<TehnickoLice>().List<TehnickoLice>();
                  
                    // Toplotni t = (Toplotni)listBoxAlarmi.SelectedItem;
                    Toplotni toplotni = s.Load<Toplotni>(sistem.Serijski_br);
                    top = toplotni;
                    

                    txtHorizontalna.Text = top.Horizontalna_rez.ToString();
                    txtVertikalna.Text = top.Vertikalna_rez.ToString();
                    txtModel.Text = top.Model;
                    txtGodProizvodnje.Text = top.Godina_proizvodnje.ToString();
                    txtOpisServisiranja.Text = top.Opis_servisiranja;
                    txtProizvodjac.Text = top.Proizvodjac;
                    dtpPoslednjegServisiranja.Value = top.Datum_Poslednjeg_Servisiranja;
                    dtpDatumAtesta.Value = top.Datum_Atesta;
                    txtOpisServisiranja.Text = top.Opis_servisiranja;
                    lblObjekat.Text = top.ObjekatInstaliran.vratiObj();
                    lblTehLice.Text = top.TehnickoLice.vratiIme();
                    s.Close();
                }
                if (sistem.Tip == "Pokretni")
                {
                    ISession s = DataLayer.GetSession();
                    if (groupBox6.Visible == false)
                        groupBox6.Visible = true;
                    groupBox4.Visible = false;
                    groupBox5.Visible = false;
                    listaTehLica = s.QueryOver<TehnickoLice>().List<TehnickoLice>();
                    // Toplotni t = (Toplotni)listBoxAlarmi.SelectedItem;
                    Pokretni pokretni = s.Load<Pokretni>(sistem.Serijski_br);
                    pok = pokretni;
                    txtTezina.Text = pok.Tezina.ToString();
                    txtModel.Text = pok.Model;
                    txtGodProizvodnje.Text = pok.Godina_proizvodnje.ToString();
                    txtOpisServisiranja.Text = pok.Opis_servisiranja;
                    txtProizvodjac.Text = pok.Proizvodjac;
                    dtpPoslednjegServisiranja.Value = pok.Datum_Poslednjeg_Servisiranja;
                    dtpDatumAtesta.Value = pok.Datum_Atesta;
                    txtOpisServisiranja.Text = pok.Opis_servisiranja;
                    lblObjekat.Text = top.ObjekatInstaliran.vratiObj();
                    lblTehLice.Text = top.TehnickoLice.vratiIme();
                    s.Close();
                }
                if (sistem.Tip == "Ultrazvucni")
                {
                    ISession s = DataLayer.GetSession();
                    if (groupBox4.Visible == false)
                        groupBox4.Visible = true;
                    groupBox5.Visible = false;
                    groupBox6.Visible = false;
                    // Toplotni t = (Toplotni)listBoxAlarmi.SelectedItem;
                    Ultrazvucni top = s.Load<Ultrazvucni>(sistem.Serijski_br);
                    ultzv = top;
                    txtFrekvencija.Text = ultzv.Frekvencija.ToString();
                    txtModel.Text = ultzv.Model;
                    txtGodProizvodnje.Text = ultzv.Godina_proizvodnje.ToString();
                    txtOpisServisiranja.Text = ultzv.Opis_servisiranja;
                    txtProizvodjac.Text = ultzv.Proizvodjac;
                    dtpPoslednjegServisiranja.Value = ultzv.Datum_Poslednjeg_Servisiranja;
                    dtpDatumAtesta.Value = ultzv.Datum_Atesta;
                    txtOpisServisiranja.Text = ultzv.Opis_servisiranja;
                    lblObjekat.Text = top.ObjekatInstaliran.vratiObj();
                    lblTehLice.Text = top.TehnickoLice.vratiIme();


                    s.Close();
                }
                sistem = null;

            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if(groupBox5.Visible==true)
            {
                ISession s = DataLayer.GetSession();
                top.Opis_servisiranja = txtOpisServisiranja.Text;
                top.Datum_Poslednjeg_Servisiranja=dtpPoslednjegServisiranja.Value;
                top.Godina_proizvodnje = Int32.Parse(txtGodProizvodnje.Text);
                top.Horizontalna_rez = Int32.Parse(txtHorizontalna.Text);
                top.Vertikalna_rez = Int32.Parse(txtVertikalna.Text);
                top.Model = txtModel.Text;
                top.Proizvodjac = txtProizvodjac.Text;
                top.Tip = "Toplotni";
                top.Datum_Atesta = dtpDatumAtesta.Value;
                
                s.SaveOrUpdate(top);
                s.Flush();
                s.Close();
                groupBox5.Visible = false;
                groupBox1.Visible = false;
                groupBox3.Visible = false;


            }
            else if (groupBox4.Visible == true)
            {
                ISession s = DataLayer.GetSession();
                ultzv.Opis_servisiranja = txtOpisServisiranja.Text;
                ultzv.Datum_Poslednjeg_Servisiranja = dtpPoslednjegServisiranja.Value;
                ultzv.Godina_proizvodnje = Int32.Parse(txtGodProizvodnje.Text);
                ultzv.Frekvencija = Int32.Parse(txtFrekvencija.Text);
                ultzv.Model = txtModel.Text;
                ultzv.Proizvodjac = txtProizvodjac.Text;
                ultzv.Tip = "Ultrazvucni";
                ultzv.Datum_Atesta = dtpDatumAtesta.Value;
                s.SaveOrUpdate(ultzv);
                s.Flush();
                s.Close();
                groupBox4.Visible = false;
                groupBox1.Visible = false;
                groupBox3.Visible = false;


            }
            else if (groupBox6.Visible == true)
            {
                ISession s = DataLayer.GetSession();
                pok.Opis_servisiranja = txtOpisServisiranja.Text;
                pok.Datum_Poslednjeg_Servisiranja = dtpPoslednjegServisiranja.Value;
                pok.Godina_proizvodnje = Int32.Parse(txtGodProizvodnje.Text);
                pok.Tezina = Int32.Parse(txtTezina.Text);
                pok.Model = txtModel.Text;
                pok.Proizvodjac = txtProizvodjac.Text;
                pok.Tip = "Pokretni";
                pok.Datum_Atesta = dtpDatumAtesta.Value;
                s.SaveOrUpdate(pok);
                s.Flush();
                s.Close();
                groupBox6.Visible = false;
                groupBox1.Visible = false;
                groupBox3.Visible = false;


            }
            groupBox2.Visible = false;

        }

        private void btnObrisiSis_Click(object sender, EventArgs e)
        {
            if(listBoxAlarmi.SelectedItem!=null)
            {
                ISession s = DataLayer.GetSession();
                AlarmniSistem sistem = (AlarmniSistem)listBoxAlarmi.SelectedItem;
                AlarmniSistem sis = s.Load<AlarmniSistem>(sistem.Serijski_br);
                s.Delete(sis);
                s.Flush();
                s.Close();
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnObjekat_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLice_Click(object sender, EventArgs e)
        {
            //FormTehLiceDodaj ftd = new FormTehLiceDodaj(sistem);
        }
    }
}
