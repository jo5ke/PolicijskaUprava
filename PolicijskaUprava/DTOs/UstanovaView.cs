using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PolicijskaUprava.Entiteti;

namespace PolicijskaUprava.DTOs
{
	public class UstanovaView
	{
		public int ID { get; set; }
		public string Naziv_ustanove { get; set; }
		public string Tip { get; set; }
		public IList<PolicajacView> Policajci { get; set; }

		public UstanovaView()
		{

		}

		public UstanovaView(Ustanova u)
		{
			this.Policajci = new List<PolicajacView>();
			this.ID = u.ID;
			this.Naziv_ustanove = u.Naziv_ustanove;
			this.Tip = u.Tip;
			
			foreach(Policajac p in u.Policajci)
			{
				this.Policajci.Add(new PolicajacView(p));
			}
		}
	}
}
