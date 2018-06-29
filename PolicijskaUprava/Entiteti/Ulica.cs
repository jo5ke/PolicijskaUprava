using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicijskaUprava.Entiteti
{
	public class Ulica
	{
        public virtual int ID { get; set; }
		//public virtual int ID_Policajca { get; set; }
		public virtual string Naziv { get; set; }

		public virtual Pozornik PozornikUlice { get; set; }

		public Ulica()
		{

		}
	}
}
