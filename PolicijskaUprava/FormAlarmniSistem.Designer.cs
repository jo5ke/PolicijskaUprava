namespace PolicijskaUprava
{
    partial class FormAlarmniSistem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxAlarmi = new System.Windows.Forms.ListBox();
            this.btnDodajSis = new System.Windows.Forms.Button();
            this.btnIzmeniSis = new System.Windows.Forms.Button();
            this.btnObrisiSis = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGodProizvodnje = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtProizvodjac = new System.Windows.Forms.TextBox();
            this.dtpDatumAtesta = new System.Windows.Forms.DateTimePicker();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTehLice = new System.Windows.Forms.Label();
            this.lblObjekat = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpPoslednjegServisiranja = new System.Windows.Forms.DateTimePicker();
            this.txtOpisServisiranja = new System.Windows.Forms.TextBox();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtFrekvencija = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtVertikalna = new System.Windows.Forms.TextBox();
            this.txtHorizontalna = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtTezina = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtRegBr = new System.Windows.Forms.TextBox();
            this.lblRegBr = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Svi postojeci alarmni sistemi:";
            // 
            // listBoxAlarmi
            // 
            this.listBoxAlarmi.BackColor = System.Drawing.Color.LightGreen;
            this.listBoxAlarmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxAlarmi.FormattingEnabled = true;
            this.listBoxAlarmi.Location = new System.Drawing.Point(27, 56);
            this.listBoxAlarmi.Name = "listBoxAlarmi";
            this.listBoxAlarmi.Size = new System.Drawing.Size(334, 82);
            this.listBoxAlarmi.TabIndex = 1;
            // 
            // btnDodajSis
            // 
            this.btnDodajSis.BackColor = System.Drawing.Color.MistyRose;
            this.btnDodajSis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajSis.Location = new System.Drawing.Point(27, 158);
            this.btnDodajSis.Name = "btnDodajSis";
            this.btnDodajSis.Size = new System.Drawing.Size(100, 49);
            this.btnDodajSis.TabIndex = 2;
            this.btnDodajSis.Text = "Dodaj novi alarmni sistem";
            this.btnDodajSis.UseVisualStyleBackColor = false;
            this.btnDodajSis.Click += new System.EventHandler(this.btnDodajSis_Click);
            // 
            // btnIzmeniSis
            // 
            this.btnIzmeniSis.BackColor = System.Drawing.Color.MistyRose;
            this.btnIzmeniSis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzmeniSis.Location = new System.Drawing.Point(263, 158);
            this.btnIzmeniSis.Name = "btnIzmeniSis";
            this.btnIzmeniSis.Size = new System.Drawing.Size(98, 49);
            this.btnIzmeniSis.TabIndex = 3;
            this.btnIzmeniSis.Text = "Izmeni selektovani alarmni sistem";
            this.btnIzmeniSis.UseVisualStyleBackColor = false;
            this.btnIzmeniSis.Click += new System.EventHandler(this.btnIzmeniSis_Click);
            // 
            // btnObrisiSis
            // 
            this.btnObrisiSis.BackColor = System.Drawing.Color.MistyRose;
            this.btnObrisiSis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisiSis.Location = new System.Drawing.Point(145, 158);
            this.btnObrisiSis.Name = "btnObrisiSis";
            this.btnObrisiSis.Size = new System.Drawing.Size(96, 49);
            this.btnObrisiSis.TabIndex = 4;
            this.btnObrisiSis.Text = "Obrisi selektovani alarmni sistem";
            this.btnObrisiSis.UseVisualStyleBackColor = false;
            this.btnObrisiSis.Click += new System.EventHandler(this.btnObrisiSis_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prozvodjac:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Model:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Godina proizvodnje:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Datum atesta:";
            // 
            // txtGodProizvodnje
            // 
            this.txtGodProizvodnje.BackColor = System.Drawing.Color.LightGreen;
            this.txtGodProizvodnje.Location = new System.Drawing.Point(7, 39);
            this.txtGodProizvodnje.Name = "txtGodProizvodnje";
            this.txtGodProizvodnje.Size = new System.Drawing.Size(100, 20);
            this.txtGodProizvodnje.TabIndex = 14;
            // 
            // txtModel
            // 
            this.txtModel.BackColor = System.Drawing.Color.LightGreen;
            this.txtModel.Location = new System.Drawing.Point(9, 162);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(98, 20);
            this.txtModel.TabIndex = 15;
            // 
            // txtProizvodjac
            // 
            this.txtProizvodjac.BackColor = System.Drawing.Color.LightGreen;
            this.txtProizvodjac.Location = new System.Drawing.Point(9, 80);
            this.txtProizvodjac.Name = "txtProizvodjac";
            this.txtProizvodjac.Size = new System.Drawing.Size(100, 20);
            this.txtProizvodjac.TabIndex = 16;
            // 
            // dtpDatumAtesta
            // 
            this.dtpDatumAtesta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatumAtesta.Location = new System.Drawing.Point(9, 123);
            this.dtpDatumAtesta.Name = "dtpDatumAtesta";
            this.dtpDatumAtesta.Size = new System.Drawing.Size(100, 20);
            this.dtpDatumAtesta.TabIndex = 18;
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnDodaj.Location = new System.Drawing.Point(125, 193);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(94, 34);
            this.btnDodaj.TabIndex = 19;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDodaj);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblTehLice);
            this.groupBox1.Controls.Add(this.txtGodProizvodnje);
            this.groupBox1.Controls.Add(this.lblObjekat);
            this.groupBox1.Controls.Add(this.dtpDatumAtesta);
            this.groupBox1.Controls.Add(this.txtModel);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtProizvodjac);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(386, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 244);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // lblTehLice
            // 
            this.lblTehLice.AutoSize = true;
            this.lblTehLice.Location = new System.Drawing.Point(155, 130);
            this.lblTehLice.Name = "lblTehLice";
            this.lblTehLice.Size = new System.Drawing.Size(66, 13);
            this.lblTehLice.TabIndex = 12;
            this.lblTehLice.Text = "lblTehLice";
            // 
            // lblObjekat
            // 
            this.lblObjekat.AutoSize = true;
            this.lblObjekat.Location = new System.Drawing.Point(155, 64);
            this.lblObjekat.Name = "lblObjekat";
            this.lblObjekat.Size = new System.Drawing.Size(64, 13);
            this.lblObjekat.TabIndex = 11;
            this.lblObjekat.Text = "lblObjekat";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(109, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Tehnicko lice za odrzavanje:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(122, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Objekat gde je instaliran:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.dtpPoslednjegServisiranja);
            this.groupBox2.Controls.Add(this.txtOpisServisiranja);
            this.groupBox2.Controls.Add(this.btnIzmeni);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(398, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 125);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(199, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Opis servisiranja:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(180, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Datum poslednjeg servisiranja:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // dtpPoslednjegServisiranja
            // 
            this.dtpPoslednjegServisiranja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPoslednjegServisiranja.Location = new System.Drawing.Point(20, 38);
            this.dtpPoslednjegServisiranja.Name = "dtpPoslednjegServisiranja";
            this.dtpPoslednjegServisiranja.Size = new System.Drawing.Size(120, 20);
            this.dtpPoslednjegServisiranja.TabIndex = 8;
            // 
            // txtOpisServisiranja
            // 
            this.txtOpisServisiranja.BackColor = System.Drawing.Color.LightGreen;
            this.txtOpisServisiranja.Location = new System.Drawing.Point(202, 38);
            this.txtOpisServisiranja.Name = "txtOpisServisiranja";
            this.txtOpisServisiranja.Size = new System.Drawing.Size(120, 20);
            this.txtOpisServisiranja.TabIndex = 7;
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnIzmeni.Location = new System.Drawing.Point(125, 80);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(94, 41);
            this.btnIzmeni.TabIndex = 4;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = false;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(27, 242);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(353, 91);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SandyBrown;
            this.button4.Location = new System.Drawing.Point(236, 26);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 41);
            this.button4.TabIndex = 3;
            this.button4.Text = "Dodaj ultrazvucni";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(153, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(8, 8);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SandyBrown;
            this.button2.Location = new System.Drawing.Point(118, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "Dodaj pokretni";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SandyBrown;
            this.button1.Location = new System.Drawing.Point(6, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dodaj toplotni";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtFrekvencija);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox4.Location = new System.Drawing.Point(666, 98);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(138, 64);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            // 
            // txtFrekvencija
            // 
            this.txtFrekvencija.BackColor = System.Drawing.Color.LightGreen;
            this.txtFrekvencija.Location = new System.Drawing.Point(12, 32);
            this.txtFrekvencija.Name = "txtFrekvencija";
            this.txtFrekvencija.Size = new System.Drawing.Size(100, 20);
            this.txtFrekvencija.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Frekvencija:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtVertikalna);
            this.groupBox5.Controls.Add(this.txtHorizontalna);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox5.Location = new System.Drawing.Point(666, 164);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(141, 99);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            // 
            // txtVertikalna
            // 
            this.txtVertikalna.BackColor = System.Drawing.Color.LightGreen;
            this.txtVertikalna.Location = new System.Drawing.Point(12, 63);
            this.txtVertikalna.Name = "txtVertikalna";
            this.txtVertikalna.Size = new System.Drawing.Size(100, 20);
            this.txtVertikalna.TabIndex = 3;
            // 
            // txtHorizontalna
            // 
            this.txtHorizontalna.BackColor = System.Drawing.Color.LightGreen;
            this.txtHorizontalna.Location = new System.Drawing.Point(10, 24);
            this.txtHorizontalna.Name = "txtHorizontalna";
            this.txtHorizontalna.Size = new System.Drawing.Size(100, 20);
            this.txtHorizontalna.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 47);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(126, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Vertikalna rezolucija:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(140, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Horizontalna rezolucija:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtTezina);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox6.Location = new System.Drawing.Point(664, 24);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(138, 68);
            this.groupBox6.TabIndex = 25;
            this.groupBox6.TabStop = false;
            // 
            // txtTezina
            // 
            this.txtTezina.BackColor = System.Drawing.Color.LightGreen;
            this.txtTezina.Location = new System.Drawing.Point(12, 32);
            this.txtTezina.Name = "txtTezina";
            this.txtTezina.Size = new System.Drawing.Size(100, 20);
            this.txtTezina.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Tezina";
            // 
            // txtRegBr
            // 
            this.txtRegBr.BackColor = System.Drawing.Color.LightGreen;
            this.txtRegBr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtRegBr.Location = new System.Drawing.Point(224, 219);
            this.txtRegBr.Name = "txtRegBr";
            this.txtRegBr.Size = new System.Drawing.Size(100, 20);
            this.txtRegBr.TabIndex = 26;
            // 
            // lblRegBr
            // 
            this.lblRegBr.AutoSize = true;
            this.lblRegBr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRegBr.Location = new System.Drawing.Point(38, 222);
            this.lblRegBr.Name = "lblRegBr";
            this.lblRegBr.Size = new System.Drawing.Size(163, 13);
            this.lblRegBr.TabIndex = 27;
            this.lblRegBr.Text = "Unesite serijski broj alarma:";
            // 
            // FormAlarmniSistem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(814, 405);
            this.Controls.Add(this.lblRegBr);
            this.Controls.Add(this.txtRegBr);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnObrisiSis);
            this.Controls.Add(this.btnIzmeniSis);
            this.Controls.Add(this.btnDodajSis);
            this.Controls.Add(this.listBoxAlarmi);
            this.Controls.Add(this.label1);
            this.Name = "FormAlarmniSistem";
            this.Text = "Alarmni sistem";
            this.Load += new System.EventHandler(this.FormAlarmniSistem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxAlarmi;
        private System.Windows.Forms.Button btnDodajSis;
        private System.Windows.Forms.Button btnIzmeniSis;
        private System.Windows.Forms.Button btnObrisiSis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGodProizvodnje;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtProizvodjac;
        private System.Windows.Forms.DateTimePicker dtpDatumAtesta;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpPoslednjegServisiranja;
        private System.Windows.Forms.TextBox txtOpisServisiranja;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtFrekvencija;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtVertikalna;
        private System.Windows.Forms.TextBox txtHorizontalna;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtTezina;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblTehLice;
        private System.Windows.Forms.Label lblObjekat;
        private System.Windows.Forms.TextBox txtRegBr;
        private System.Windows.Forms.Label lblRegBr;
    }
}