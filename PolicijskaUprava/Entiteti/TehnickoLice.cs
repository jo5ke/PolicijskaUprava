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
		public virtual int ID { get; set; }

		//public TehnickoLice()
		//{

		//}

		//public override bool Equals(object Object)
		//{

		//	//if (Object.ReferenceEquals(this, Object))
		//	//    return true;

		//	//if (Object.GetType() != typeof(Kontraindikacije))
		//	//    return false;

		//	//Kontraindikacije recievedObject = (Kontraindikacije)Object;

		//	//if (opisKontraindikacije.Equals(recievedObject.opisKontraindikacije) &&
		//	//    (idLeka.komercijalniNaziv.Equals(recievedObject.idLeka.komercijalniNaziv)))
		//	//{
		//	//    return true;
		//	//}

		//	return false;
		//}
		//public override int GetHashCode()
  //      {
  //          return base.GetHashCode();
  //      }
    }
}
