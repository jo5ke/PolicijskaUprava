using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PolicijskaUprava.Entiteti;

namespace PolicijskaUprava.DTOs
{
	public class AlarmniSistemView
	{
		public int Serijski_br { get; set; }
		public int Godina_proizvodnje { get; set; }
		public string Proizvodjac { get; set; }
		public string Model { get; set; }
		public string Opis_servisiranja { get; set; }
		public string Tip { get; set; }
		public DateTime Datum_Atesta { get; set; }
		public DateTime Datum_Poslednjeg_Servisiranja { get; set; }
		//public Objekat ObjekatInstaliran { get; set; }
		public int ObjekatInstaliran { get; set; }
		//public TehnickoLice TehnickoLice { get; set; }
		public int TehnickoLice { get; set; }

		public AlarmniSistemView()
		{

		}

		public AlarmniSistemView(AlarmniSistem a)
		{
			this.Serijski_br = a.Serijski_br;
			this.Godina_proizvodnje = a.Godina_proizvodnje;
			this.Proizvodjac = a.Proizvodjac;
			this.Model = a.Model;
			this.Opis_servisiranja = a.Opis_servisiranja;
			this.Tip = a.Tip;
			this.Datum_Atesta = a.Datum_Atesta;
			this.Datum_Poslednjeg_Servisiranja = a.Datum_Poslednjeg_Servisiranja;
			if (a.ObjekatInstaliran != null)
				this.ObjekatInstaliran = a.ObjekatInstaliran.ID;
			if (a.TehnickoLice != null)
				this.TehnickoLice = a.TehnickoLice.Id;
			

		}
	}
}
