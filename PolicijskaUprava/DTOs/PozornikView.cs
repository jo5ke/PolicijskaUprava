using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PolicijskaUprava.Entiteti;

namespace PolicijskaUprava.DTOs
{
	public class PozornikView : PolicajacView
	{
		public IList<UlicaView> Ulice { get; set; }

		public PozornikView()
		{

		}

		public PozornikView(Pozornik p)
		{
			this.Ulice = new List<UlicaView>();

			foreach(Ulica u in p.Ulice)
			{
				this.Ulice.Add(new UlicaView(u));
			}

			//Policajac

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
			if (p.JeZamenikUprave != null)
				this.JeZamenikUprave = p.JeZamenikUprave.ID;
			if (p.JeNacelnikUprave != null)
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
