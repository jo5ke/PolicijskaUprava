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
    public class SkolaController : ApiController
    {
		// GET api/Skola
		public IEnumerable<SkolaView> Get()
		{
			DataProvider provider = new DataProvider();

			IEnumerable<SkolaView> skole = provider.GetSkole();

			return skole;
		}

		// GET api/Skola/1
		public SkolaView Get(int id)
		{
			DataProvider provider = new DataProvider();

			return provider.GetSkola(id);

		}

		// POST api/Skola
		public int Post([FromBody]Skola p)
		{
			DataProvider provider = new DataProvider();

			return provider.AddSkola(p);
		}

		// PUT api/Skola/1
		public int Put(int id, [FromBody]Skola p)
		{
			DataProvider provider = new DataProvider();

			return provider.UpdateSkola(id, p);
		}

		// DELETE api/Skola/1
		public int Delete(int id)
		{
			DataProvider provider = new DataProvider();

			return provider.RemoveSkola(id);
		}
	}
}
