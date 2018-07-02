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
    public class UltrazvucniController : ApiController
    {
		// GET api/Ultrazvucni
		public IEnumerable<UltrazvucniView> Get()
		{
			DataProvider provider = new DataProvider();

			IEnumerable<UltrazvucniView> sistemi = provider.GetUltrazvucne();

			return sistemi;
		}

		// GET api/Ultrazvucni/1
		public UltrazvucniView Get(int id)
		{
			DataProvider provider = new DataProvider();

			return provider.GetUltrazvucni(id);

		}

		// POST api/Ultrazvucni
		public int Post([FromBody]Ultrazvucni p)
		{
			DataProvider provider = new DataProvider();

			return provider.AddUltrazvucni(p);
		}

		// PUT api/Ultrazvucni/1
		public int Put(int id, [FromBody]Ultrazvucni p)
		{
			DataProvider provider = new DataProvider();

			return provider.UpdateUltrazvucni(id, p);
		}

		// DELETE api/Ultrazvucni/1
		public int Delete(int id)
		{
			DataProvider provider = new DataProvider();

			return provider.RemoveUltrazvucni(id);
		}
	}
}
