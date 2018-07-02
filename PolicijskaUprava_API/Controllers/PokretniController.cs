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
    public class PokretniController : ApiController
    {
		// GET api/Pokretni
		public IEnumerable<PokretniView> Get()
		{
			DataProvider provider = new DataProvider();

			IEnumerable<PokretniView> sistemi = provider.GetPokretne();

			return sistemi;
		}

		// GET api/Pokretni/1
		public PokretniView Get(int id)
		{
			DataProvider provider = new DataProvider();

			return provider.GetPokretni(id);

		}

		// POST api/Pokretni
		public int Post([FromBody]Pokretni p)
		{
			DataProvider provider = new DataProvider();

			return provider.AddPokretni(p);
		}

		// PUT api/Pokretni/1
		public int Put(int id, [FromBody]Pokretni p)
		{
			DataProvider provider = new DataProvider();

			return provider.UpdatePokretni(id, p);
		}

		// DELETE api/Pokretni/1
		public int Delete(int id)
		{
			DataProvider provider = new DataProvider();

			return provider.RemovePokretni(id);
		}
	}
}
