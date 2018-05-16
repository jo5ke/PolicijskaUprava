using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicijskaUprava.Entiteti
{
	public class Vozilo
	{
		public virtual string Boja { get; set; }
		public virtual string Tip { get; set; }
		
		public Vozilo()
		{

		}
	}
}
