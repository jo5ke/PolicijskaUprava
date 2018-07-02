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
    public class VoziloController : ApiController
    {
		// GET api/Vozilo
		public IEnumerable<VoziloView> Get()
		{
			DataProvider provider = new DataProvider();

			IEnumerable<VoziloView> vozila = provider.GetVozila();

			return vozila;
		}

		// GET api/Vozilo/1
		public VoziloView Get(int id)
		{
			DataProvider provider = new DataProvider();

			return provider.GetVozilo(id);

		}

		// POST api/Vozilo
		public int Post([FromBody]Vozilo p)
		{
			DataProvider provider = new DataProvider();

			return provider.AddVozilo(p);
		}

		// PUT api/Vozilo/1
		public int Put(int id, [FromBody]Vozilo p)
		{
			DataProvider provider = new DataProvider();

			return provider.UpdateVozilo(id, p);
		}

		// DELETE api/Vozilo/1
		public int Delete(int id)
		{
			DataProvider provider = new DataProvider();

			return provider.RemoveVozilo(id);
		}
	}
}
