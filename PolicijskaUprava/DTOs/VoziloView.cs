using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PolicijskaUprava.Entiteti;

namespace PolicijskaUprava.DTOs
{
	public class VoziloView
	{
		public long Reg_oznaka { get; set; } //isto
		public string Boja { get; set; }
		public string Tip { get; set; }
		public string Model { get; set; } //ne znam sto niste nap
		public string Proizvodjac { get; set; } //isto

		//public virtual Patrola VoziVozilo { get; set; }
		public int VoziVozilo { get; set; }

		//public virtual PolicijskaStanica PosedujeStanica { get; set; }
		public int PosedujeStanica { get; set; }


		public VoziloView()
		{

		}

		public VoziloView(Vozilo v)
		{
			this.Reg_oznaka = v.Reg_oznaka;
			this.Boja = v.Boja;
			this.Tip = v.Tip;
			this.Model = v.Model;
			this.Proizvodjac = v.Proizvodjac;

			if(v.VoziVozilo != null)
				this.VoziVozilo = v.VoziVozilo.Redni_br;
			if (v.PosedujeStanica != null)
				this.PosedujeStanica = v.PosedujeStanica.ID;
		}
	}
}
