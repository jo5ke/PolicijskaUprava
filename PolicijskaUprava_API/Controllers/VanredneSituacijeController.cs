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
    public class VanredneSituacijeController : ApiController
    {
		// GET api/VanredneSituacije
		public IEnumerable<VanredneSituacijeView> Get()
		{
			DataProvider provider = new DataProvider();

			IEnumerable<VanredneSituacijeView> vsituacije = provider.GetVanredneSituacije();

			return vsituacije;
		}

		// GET api/VanredneSituacije/1
		public VanredneSituacijeView Get(int id)
		{
			DataProvider provider = new DataProvider();

			return provider.GetVanrednaSituacija(id);

		}

		// POST api/VanredneSituacije
		public int Post([FromBody]VanredneSituacije p)
		{
			DataProvider provider = new DataProvider();

			return provider.AddVanredneSituacije(p);
		}

		// PUT api/Ostali/1
		public int Put(int id, [FromBody]VanredneSituacije p)
		{
			DataProvider provider = new DataProvider();

			return provider.UpdateVanredneSituacije(id, p);
		}

		// DELETE api/Ostali/1
		public int Delete(int id)
		{
			DataProvider provider = new DataProvider();

			return provider.RemoveVanredneSituacije(id);
		}
	}
}
