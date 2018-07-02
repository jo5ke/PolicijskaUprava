using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PolicijskaUprava.Entiteti;

namespace PolicijskaUprava.DTOs
{
	public class UpravaView
	{
		public int Id { get; set; }
		public string Grad { get; set; }
		public IList<PolicijskaStanicaView> PolicijskeStanice { get; set; }
		//public virtual IList<Policajac> Policajci { get; set; }

		public UpravaView(Uprava u)
		{
			this.PolicijskeStanice = new List< PolicijskaStanicaView > ();
			this.Id = u.ID;
			this.Grad = u.Grad;
			
			foreach(PolicijskaStanica polStan in u.PolicijskeStanice)
			{
				this.PolicijskeStanice.Add(new PolicijskaStanicaView(polStan));
			}
		}

		public UpravaView()
		{

		}
	}
}
