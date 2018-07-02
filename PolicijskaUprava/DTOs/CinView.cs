using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PolicijskaUprava.Entiteti;

namespace PolicijskaUprava.DTOs
{
	public class CinView
	{
		public int ID { get; set; }
		public string Naziv_cina { get; set; }
		public IList<PolicajacView> Policajci { get; set; }

		public CinView()
		{

		}

		public CinView(Cin c)
		{
			this.ID = c.ID;
			this.Naziv_cina = c.Naziv_cina;
			
			foreach(Policajac p in c.Policajci)
			{
				this.Policajci.Add(new PolicajacView(p));
			}

		}
	}
}
