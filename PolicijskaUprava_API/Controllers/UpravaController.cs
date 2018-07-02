﻿using System;
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
		public IEnumerable<UpravaView> Get()
		{
			DataProvider provider = new DataProvider();

			IEnumerable<UpravaView> uprave = provider.GetUprave();

			//return new [] {
			//    new Vojnik() {Naziv="test"}
			//};

			return uprave;
		}

		// GET api/uprava/1
		public UpravaView Get(int id)
		{
			DataProvider provider = new DataProvider();

			return provider.GetUpravaView(id);

		}

		// POST api/uprava
		public int Post([FromBody]Uprava u)
		{
			DataProvider provider = new DataProvider();

			return provider.AddUprava(u);
		}

		// PUT api/uprava/1
		public int Put(int id, [FromBody]Uprava u)
		{
			DataProvider provider = new DataProvider();

			return provider.EditUprava(id, u);
		}

		// DELETE api/uprava/1
		public int Delete(int id)
		{
			DataProvider provider = new DataProvider();

			return provider.RemoveUprava(id);
		}



	}
}
