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
    public class OstaliController : ApiController
    {
		// GET api/Ostali
		public IEnumerable<OstaliView> Get()
		{
			DataProvider provider = new DataProvider();

			IEnumerable<OstaliView> ostali = provider.GetOstale();

			return ostali;
		}

		// GET api/Ostali/1
		public OstaliView Get(int id)
		{
			DataProvider provider = new DataProvider();

			return provider.GetOstali(id);

		}

		// POST api/Ostali
		public int Post([FromBody]Ostali p)
		{
			DataProvider provider = new DataProvider();

			return provider.AddOstali(p);
		}

		// PUT api/Ostali/1
		public int Put(int id, [FromBody]Ostali p)
		{
			DataProvider provider = new DataProvider();

			return provider.UpdateOstali(id, p);
		}

		// DELETE api/Ostali/1
		public int Delete(int id)
		{
			DataProvider provider = new DataProvider();

			return provider.RemoveOstali(id);
		}
	}
}
