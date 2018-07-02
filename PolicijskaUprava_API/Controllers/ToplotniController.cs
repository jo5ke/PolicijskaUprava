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
    public class ToplotniController : ApiController
    {
		// GET api/Toplotni
		public IEnumerable<ToplotniView> Get()
		{
			DataProvider provider = new DataProvider();

			IEnumerable<ToplotniView> sistemi = provider.GetToplotne();

			return sistemi;
		}

		// GET api/Toplotni/1
		public ToplotniView Get(int id)
		{
			DataProvider provider = new DataProvider();

			return provider.GetToplotni(id);

		}

		// POST api/Toplotni
		public int Post([FromBody]Toplotni p)
		{
			DataProvider provider = new DataProvider();

			return provider.AddToplotni(p);
		}

		// PUT api/Toplotni/1
		public int Put(int id, [FromBody]Toplotni p)
		{
			DataProvider provider = new DataProvider();

			return provider.UpdateToplotni(id, p);
		}

		// DELETE api/Toplotni/1
		public int Delete(int id)
		{
			DataProvider provider = new DataProvider();

			return provider.RemoveToplotni(id);
		}
	}
}
