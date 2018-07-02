using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PolicijskaUprava.Entiteti;

namespace PolicijskaUprava.DTOs
{
	public class PolicijskaStanicaView
	{
		public int ID { get; set; }
		public string Adresa { get; set; }
		public string Opstina { get; set; }
		public string Naziv { get; set; }
		public DateTime Datum_osnivanja { get; set; }
		//public virtual int ID_Sefa { get; set; }
		//public Policajac SefStanice { get; set; }
		public int SefStanice { get; set; }
		//public Policajac ZamenikStanice { get; set; }
		public int ZamenikStanice { get; set; }
		//public virtual int ID_Zamenika { get; set; }
		//public virtual int ID_Uprave { get; set; }
		public IList<ObjekatView> Objekti { get; set; }
		public IList<PolicajacView> Policajci { get; set; }
		//public Uprava PripadaUpravi { get; set; }
		public int PripadaUpravi { get; set; }
		public IList<VoziloView> Vozila { get; set; }

		public PolicijskaStanicaView()
		{

		}

		public PolicijskaStanicaView(PolicijskaStanica p)
		{
			this.Objekti = new List<ObjekatView>();
			this.Policajci = new List<PolicajacView>();
			this.Vozila = new List<VoziloView>();

			this.ID = p.ID;
			this.Adresa = p.Adresa;
			this.Opstina = p.Opstina;
			this.Naziv = p.Naziv;
			this.Datum_osnivanja = p.Datum_osnivanja;
			if (p.PripadaUpravi != null)
				this.PripadaUpravi = p.PripadaUpravi.ID;
			if (p.SefStanice != null)
				this.SefStanice = p.SefStanice.ID;
			if (p.ZamenikStanice != null)
				this.ZamenikStanice = p.ZamenikStanice.ID;

			foreach (Objekat o in p.Objekti)
			{
				this.Objekti.Add(new ObjekatView(o));
			}

			foreach(Vozilo v in p.Vozila)
			{
				this.Vozila.Add(new VoziloView(v));
			}

			foreach(Policajac pol in p.Policajci)
			{
				this.Policajci.Add(new PolicajacView(pol));
			}

		}
	}
}
