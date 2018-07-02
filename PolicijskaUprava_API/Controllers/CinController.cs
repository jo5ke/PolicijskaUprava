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
    public class CinController : ApiController
    {
		// GET api/Cin
		public IEnumerable<CinView> Get()
		{
			DataProvider provider = new DataProvider();

			IEnumerable<CinView> cinovi = provider.GetCinovi();

			return cinovi;
		}

		// GET api/Cin/1
		public CinView Get(int id)
		{
			DataProvider provider = new DataProvider();

			return provider.GetCin(id);

		}

		// POST api/Cin
		public int Post([FromBody]Cin p)
		{
			DataProvider provider = new DataProvider();

			return provider.AddCin(p);
		}

		// PUT api/Cin/1
		public int Put(int id, [FromBody]Cin p)
		{
			DataProvider provider = new DataProvider();

			return provider.UpdateCin(id, p);
		}

		// DELETE api/Cin/1
		public int Delete(int id)
		{
			DataProvider provider = new DataProvider();

			return provider.RemoveCin(id);
		}
	}
}
