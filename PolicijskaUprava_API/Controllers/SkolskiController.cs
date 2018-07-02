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
    public class SkolskiController : ApiController
    {
		// GET api/Skolski
		public IEnumerable<SkolskiView> Get()
		{
			DataProvider provider = new DataProvider();

			IEnumerable<SkolskiView> skolski = provider.GetSkolske();

			return skolski;
		}

		// GET api/Skolski/1
		public SkolskiView Get(int id)
		{
			DataProvider provider = new DataProvider();

			return provider.GetSkolski(id);

		}

		// POST api/Skolski
		public int Post([FromBody]Skolski p)
		{
			DataProvider provider = new DataProvider();

			return provider.AddSkolski(p);
		}

		// PUT api/Skolski/1
		public int Put(int id, [FromBody]Skolski p)
		{
			DataProvider provider = new DataProvider();

			return provider.UpdateSkolski(id, p);
		}

		// DELETE api/Skolski/1
		public int Delete(int id)
		{
			DataProvider provider = new DataProvider();

			return provider.RemoveSkolski(id);
		}
	}
}
