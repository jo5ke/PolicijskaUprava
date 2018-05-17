using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicijskaUprava.Entiteti
{
	public class TehnickoLice
	{
		// id?
		public virtual AlarmniSistem Serijski_br_alarma { get; set; }
		public virtual string Ime { get; set; }
	
		public TehnickoLice()
		{

		}
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
