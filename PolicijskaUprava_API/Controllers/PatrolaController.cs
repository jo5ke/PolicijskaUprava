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
    public class PatrolaController : ApiController
    {
		// GET api/Patrola
		public IEnumerable<PatrolaView> Get()
		{
			DataProvider provider = new DataProvider();

			IEnumerable<PatrolaView> patrole = provider.GetPatrole();

			return patrole;
		}

		// GET api/Patrola/1
		public PatrolaView Get(int id)
		{
			DataProvider provider = new DataProvider();

			return provider.GetPatrola(id);

		}

		// POST api/Patrola
		public int Post([FromBody]Patrola p)
		{
			DataProvider provider = new DataProvider();

			return provider.AddPatrola(p);
		}

		// PUT api/Patrola/1
		public int Put(int id, [FromBody]Patrola p)
		{
			DataProvider provider = new DataProvider();

			return provider.UpdatePatrola(id, p);
		}

		// DELETE api/Patrola/1
		public int Delete(int id)
		{
			DataProvider provider = new DataProvider();

			return provider.RemovePatrola(id);
		}
	}
}
