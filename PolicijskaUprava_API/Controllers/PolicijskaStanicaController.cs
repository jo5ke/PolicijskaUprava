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
    public class PolicijskaStanicaController : ApiController
    {
		// GET api/PolicijskaStanica
		public IEnumerable<PolicijskaStanicaView> Get()
		{
			DataProvider provider = new DataProvider();

			IEnumerable<PolicijskaStanicaView> stanice = provider.GetPolicijskeStanice();

			return stanice;
		}

		// GET api/PolicijskaStanica/1
		public PolicijskaStanicaView Get(int id)
		{
			DataProvider provider = new DataProvider();

			return provider.GetPolicijskaStanica(id);

		}

		// POST api/PolicijskaStanica
		public int Post([FromBody]PolicijskaStanica p)
		{
			DataProvider provider = new DataProvider();

			return provider.AddPolicijskaStanica(p);
		}

		// PUT api/PolicijskaStanica/1
		public int Put(int id, [FromBody]PolicijskaStanica p)
		{
			DataProvider provider = new DataProvider();

			return provider.UpdatePolicijskaStanica(id, p);
		}

		// DELETE api/PolicijskaStanica/1
		public int Delete(int id)
		{
			DataProvider provider = new DataProvider();

			return provider.RemovePolicijskaStanica(id);
		}
	}
}
