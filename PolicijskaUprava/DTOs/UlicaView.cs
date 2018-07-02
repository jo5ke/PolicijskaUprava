using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PolicijskaUprava.Entiteti;

namespace PolicijskaUprava.DTOs
{
	public class UlicaView
	{
		public int ID { get; set; }
		//public virtual int ID_Policajca { get; set; }
		public string Naziv { get; set; }
		//public virtual Pozornik PozornikUlice { get; set; }
		public int PozornikUlice { get; set; }

		public UlicaView()
		{

		}

		public UlicaView(Ulica u)
		{
			this.ID = u.ID;
			this.Naziv = u.Naziv;
			if (u.PozornikUlice != null)
				this.PozornikUlice = u.PozornikUlice.ID;
		}
	}
}
