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
    public class UlicaController : ApiController
    {
		// GET api/Ulica
		public IEnumerable<UlicaView> Get()
		{
			DataProvider provider = new DataProvider();

			IEnumerable<UlicaView> ulice = provider.GetUlice();

			return ulice;
		}

		// GET api/Ulica/1
		public UlicaView Get(int id)
		{
			DataProvider provider = new DataProvider();

			return provider.GetUlica(id);

		}

		// POST api/Ulica
		public int Post([FromBody]Ulica p)
		{
			DataProvider provider = new DataProvider();

			return provider.AddUlica(p);
		}

		// PUT api/Cin/1
		public int Put(int id, [FromBody]Ulica p)
		{
			DataProvider provider = new DataProvider();

			return provider.UpdateUlica(id, p);
		}

		// DELETE api/Ulica/1
		public int Delete(int id)
		{
			DataProvider provider = new DataProvider();

			return provider.RemoveUlica(id);
		}
	}
}
