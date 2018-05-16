using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicijskaUprava.Entiteti
{
	public class Uprava
	{
		public virtual int ID { get; set; }
		public virtual string Grad { get; set; }
		public virtual int ID_Nacelnika { get; set; }

		public Uprava()
		{

		}
	}
}
