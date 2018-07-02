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
    public class PolicajacController : ApiController
    {
		// GET api/Policajac
		public IEnumerable<PolicajacView> Get()
		{
			DataProvider provider = new DataProvider();

			IEnumerable<PolicajacView> policajci = provider.GetPolicajci();

			//return new [] {
			//    new Vojnik() {Naziv="test"}
			//};

			return policajci;
		}

		// GET api/Policajac/1
		public PolicajacView Get(int id)
		{
			DataProvider provider = new DataProvider();

			return provider.GetPolicajacView(id);

		}

		// POST api/Policajac
		public int Post([FromBody]Policajac p)
		{
			DataProvider provider = new DataProvider();

			return provider.AddPolicajac(p);
		}

		// PUT api/Policajac/1
		public int Put(int id, [FromBody]Policajac p)
		{
			DataProvider provider = new DataProvider();

			return provider.UpdatePolicajac(id, p);
		}

		// DELETE api/Policajac/1
		public int Delete(int id)
		{
			DataProvider provider = new DataProvider();

			return provider.RemovePolicajac(id);
		}
	}
}
