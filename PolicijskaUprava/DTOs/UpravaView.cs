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

		public UpravaView(Uprava u)
		{
			this.Id = u.ID;
			this.Grad = u.Grad;
		}

		public UpravaView()
		{

		}
	}
}
