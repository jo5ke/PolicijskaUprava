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
    public class AlarmniSistemController : ApiController
    {
		// GET api/AlarmniSistem
		public IEnumerable<AlarmniSistemView> Get()
		{
			DataProvider provider = new DataProvider();

			IEnumerable<AlarmniSistemView> sistemi = provider.GetAlarmniSistemi();

			return sistemi;
		}

		// GET api/AlarmniSistem/1
		public AlarmniSistemView Get(int id)
		{
			DataProvider provider = new DataProvider();

			return provider.GetAlarmniSistem(id);

		}

		// POST api/AlarmniSistem
		public int Post([FromBody]AlarmniSistem p)
		{
			DataProvider provider = new DataProvider();

			return provider.AddAlarmniSistem(p);
		}

		// PUT api/AlarmniSistem/1
		public int Put(int id, [FromBody]AlarmniSistem p)
		{
			DataProvider provider = new DataProvider();

			return provider.UpdateAlarmniSistem(id, p);
		}

		// DELETE api/AlarmniSistem/1
		public int Delete(int id)
		{
			DataProvider provider = new DataProvider();

			return provider.RemoveAlarmniSistem(id);
		}
	}
}
