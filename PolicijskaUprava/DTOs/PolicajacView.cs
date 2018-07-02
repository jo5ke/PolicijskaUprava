using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PolicijskaUprava.Entiteti;

namespace PolicijskaUprava.DTOs
{
	public class PolicajacView
	{
		public int ID { get; set; }
		public string Licno_ime { get; set; }
		public string Tip { get; set; }
		public string Ime_roditelja { get; set; }
		public string Prezime { get; set; }
		public Int64 JMBG { get; set; }
		public char Pol { get; set; }
		public DateTime Datum_rodj { get; set; }
		public string Adresa { get; set; }
		public DateTime Datum_diplomiranja { get; set; }
		public DateTime Datum_unapredjenja { get; set; }
		public string Oblast { get; set; }
		//public virtual int ID_Ustanove { get; set; }
		//public virtual int ID_Cina { get; set; }
		//public virtual int ID_Uprave { get; set; }
		//public virtual int ID_Stanice { get; set; }

		//public Uprava JeZamenikUprave { get; set; }
		//public Ustanova PripadaUstanovi { get; set; }
		//public Uprava JeNacelnikUprave { get; set; }
		//public PolicijskaStanica RadiUStanici { get; set; }
		//public PolicijskaStanica PolicijskaStanicaZamenika { get; set; }
		//public PolicijskaStanica PolicijskaStanicaSefa { get; set; }

		public int JeZamenikUprave { get; set; }
		public int PripadaUstanovi { get; set; }
		public int JeNacelnikUprave { get; set; }
		public int RadiUStanici { get; set; }
		public int PolicijskaStanicaZamenika { get; set; }
		public int PolicijskaStanicaSefa { get; set; }

		//public Cin ImaCin { get; set; }
		public int ImaCin { get; set; }

		public PolicajacView()
		{

		}

		public PolicajacView(Policajac p)
		{
			this.ID = p.ID;
			this.Licno_ime = p.Licno_ime;
			this.Tip = p.Tip;
			this.Ime_roditelja = p.Ime_roditelja;
			this.Prezime = p.Prezime;
			this.JMBG = p.JMBG;
			this.Pol = p.Pol;
			this.Datum_rodj = p.Datum_rodj;
			this.Adresa = p.Adresa;
			this.Datum_diplomiranja = p.Datum_diplomiranja;
			this.Datum_unapredjenja = p.Datum_unapredjenja;
			this.Oblast = p.Oblast;

			if (p.PripadaUstanovi != null)
				this.PripadaUstanovi = p.PripadaUstanovi.ID;
			if(p.JeZamenikUprave != null)
				this.JeZamenikUprave = p.JeZamenikUprave.ID;
			if(p.JeNacelnikUprave != null)
				this.JeNacelnikUprave = p.JeNacelnikUprave.ID;
			if (p.RadiUStanici != null)
				this.RadiUStanici = p.RadiUStanici.ID;
			if (p.PolicijskaStanicaZamenika != null)
				this.PolicijskaStanicaZamenika = p.PolicijskaStanicaZamenika.ID;
			if (p.PolicijskaStanicaSefa != null)
				this.PolicijskaStanicaSefa = p.PolicijskaStanicaSefa.ID;
			if (p.ImaCin != null)
				this.ImaCin = p.ImaCin.ID;
		}
	}
}
