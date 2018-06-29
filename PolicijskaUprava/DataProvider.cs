using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Linq;
using PolicijskaUprava.DTOs;
using NHibernate;
using PolicijskaUprava.Entiteti;

namespace PolicijskaUprava
{
	public class DataProvider
	{
		public IEnumerable<Uprava> GetUprave()
		{
			ISession s = DataLayer.GetSession();

			IEnumerable<Uprava> uprave = s.Query<Uprava>()
												//.Where(p => (p.Tip == "LUTKE" || p.Tip == "DODACI ZA LUTKE"))
												//.OrderBy(p => p.Tip).ThenBy(p => p.Naziv.Length)
												.Select(p => p);
			return uprave;
		}

		public UpravaView GetUpravaView(int id)
		{
			ISession s = DataLayer.GetSession();

			Uprava upr = s.Query<Uprava>()
				.Where(u => u.ID == id).Select(p => p).FirstOrDefault();

			if (upr == null) return new UpravaView();

			return new UpravaView(upr);
		}


	}
}
