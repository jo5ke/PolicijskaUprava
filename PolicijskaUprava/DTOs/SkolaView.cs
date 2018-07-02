using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PolicijskaUprava.Entiteti;

namespace PolicijskaUprava.DTOs
{
	public class SkolaView
	{
		public int ID { get; set; }
		public string Tip_skole { get; set; }
		public string Naziv { get; set; }
		public int Br_telefona { get; set; }
		public string Adresa { get; set; }
		public string Ime { get; set; }
		public string Prezime { get; set; }
		public IList<SkolskiView> Skolski { get; set; }

		public SkolaView()
		{

		}

		public SkolaView(Skola s)
		{
			this.Skolski = new List<SkolskiView>();
			this.ID = s.ID;
			this.Tip_skole = s.Tip_skole;
			this.Naziv = s.Naziv;
			this.Br_telefona = s.Br_telefona;
			this.Adresa = s.Adresa;
			this.Ime = s.Ime;
			this.Prezime = s.Prezime;

			foreach(Skolski sk in s.Skolski)
			{
				this.Skolski.Add(new SkolskiView(sk));
			}
		}


	}
}
