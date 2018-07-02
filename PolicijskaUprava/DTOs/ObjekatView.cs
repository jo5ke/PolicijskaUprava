using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PolicijskaUprava.Entiteti;

namespace PolicijskaUprava.DTOs
{
	public class ObjekatView
	{
		public int ID { get; set; }
		public string Tip { get; set; }
		public string Adresa { get; set; }
		public int Povrsina { get; set; }
		public string Ime { get; set; }
		public string Prezime { get; set; }
		public int Br_telefona { get; set; }
		//public virtual int Serijski_br_alarma { get; set; }
		public DateTime Datum_instalacije { get; set; }
		//	public virtual int ID_Stanice { get; set; }
		//public AlarmniSistem InstaliranAlarmniSis { get; set; }
		public int InstaliranAlarmniSis { get; set; }

		//public virtual PolicijskaStanica NadzireStanica { get; set; }
		public int NadzireStanica { get; set; }

		public IList<PatrolaView> Patrole { get; set; } 

		public ObjekatView()
		{

		}

		public ObjekatView(Objekat o)
		{
			this.Patrole = new List<PatrolaView>();
			this.ID = o.ID;
			this.Tip = o.Tip;
			this.Adresa = o.Adresa;
			this.Povrsina = o.Povrsina;
			this.Ime = o.Ime;
			this.Prezime = o.Prezime;
			this.Br_telefona = o.Br_telefona;
			this.Datum_instalacije = o.Datum_instalacije;
			this.InstaliranAlarmniSis = o.InstaliranAlarmniSis.Serijski_br;
			this.NadzireStanica = o.NadzireStanica.ID;

			foreach(Patrola p in o.Patrole)
			{
				this.Patrole.Add(new PatrolaView(p));
			}

		}
	}
}
