using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PolicijskaUprava.Entiteti;

namespace PolicijskaUprava.DTOs
{
	public class TehnickoLiceView
	{
		//public virtual AlarmniSistem Serijski_br_alarma { get; set; }
		public int Serijski_br_alarma { get; set; }
		public string Ime { get; set; }
		public int Id { get; set; }

		public TehnickoLiceView()
		{

		}

		public TehnickoLiceView(TehnickoLice t)
		{
			if(t.Serijski_br_alarma != null)
				this.Serijski_br_alarma = t.Serijski_br_alarma.Serijski_br;
			this.Ime = t.Ime;
			this.Id = t.Id;
		}
	}
}
