using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PolicijskaUprava;
using PolicijskaUprava.DTOs;
using PolicijskaUprava.Entiteti;
using System.Data.Entity;


namespace PolicijskaUprava_API.Controllers
{
    public class UpravaController : ApiController
    {
		// GET api/uprava
		public IEnumerable<Uprava> Get()
		{
			DataProvider provider = new DataProvider();

			IEnumerable<Uprava> uprave = provider.GetUprave();

			//return new [] {
			//    new Vojnik() {Naziv="test"}
			//};

			return uprave;
		}

		public UpravaView Get(int id)
		{
			DataProvider provider = new DataProvider();

			return provider.GetUpravaView(id);

		}
	}
}
