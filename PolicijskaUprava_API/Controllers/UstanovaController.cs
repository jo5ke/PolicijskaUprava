using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PolicijskaUprava;
using PolicijskaUprava.DTOs;
using PolicijskaUprava.Entiteti;

namespace PolicijskaUprava_API.Controllers
{
    public class UstanovaController : ApiController
    {
		// GET api/Ustanova
		public IEnumerable<UstanovaView> Get()
		{
			DataProvider provider = new DataProvider();

			IEnumerable<UstanovaView> ustanove = provider.GetUstanove();

			return ustanove;
		}

		// GET api/Ustanova/1
		public UstanovaView Get(int id)
		{
			DataProvider provider = new DataProvider();

			return provider.GetUstanova(id);

		}

		// POST api/Ustanova
		public int Post([FromBody]Ustanova p)
		{
			DataProvider provider = new DataProvider();

			return provider.AddUstanova(p);
		}

		// PUT api/Ustanova/1
		public int Put(int id, [FromBody]Ustanova p)
		{
			DataProvider provider = new DataProvider();

			return provider.UpdateUstanova(id, p);
		}

		// DELETE api/Ustanova/1
		public int Delete(int id)
		{
			DataProvider provider = new DataProvider();

			return provider.RemoveUstanova(id);
		}
	}
}
