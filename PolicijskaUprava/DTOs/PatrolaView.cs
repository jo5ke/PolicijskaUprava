using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PolicijskaUprava.Entiteti;

namespace PolicijskaUprava.DTOs
{
	public class PatrolaView
	{
		public int Redni_br { get; set; }
		//public virtual int ID_Vodje { get; set; }
		//public Ostali Vodja { get; set; }
		public int Vodja { get; set; }
		//	public virtual int Reg_oznaka_vozila { get; set; }
		//public virtual Vozilo VoziloPatrole { get; set; }
		public long VoziloPatrole { get; set; }
		//public virtual int ID_Objekta { get; set; }
		public DateTime Vreme { get; set; }
		public string Opis { get; set; }

		//public virtual Objekat InterveniseObjekat { get; set; }
		public int InterveniseObjekat { get; set; }

		public IList<OstaliView> Radnici { get; set; }

		public PatrolaView()
		{

		}

		public PatrolaView(Patrola p)
		{
			this.Redni_br = p.Redni_br;
			if(p.Vodja != null)
				this.Vodja = p.Vodja.ID;
			if (p.VoziloPatrole != null)
				this.VoziloPatrole = p.VoziloPatrole.Reg_oznaka;
			this.Vreme = p.Vreme;
			this.Opis = p.Opis;
			if (p.InterveniseObjekat != null)
				this.InterveniseObjekat = p.InterveniseObjekat.ID;

			foreach(Ostali o in p.Radnici)
			{
				this.Radnici.Add(new OstaliView(o));
			}
		}
	}
}
