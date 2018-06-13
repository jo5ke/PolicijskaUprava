using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PolicijskaUprava.Entiteti;

namespace PolicijskaUprava.Mapiranja
{
	class PozornikMapiranje : SubclassMap<PolicijskaUprava.Entiteti.Pozornik>
	{
		public PozornikMapiranje()
		{
			Table("POZORNIK");

			KeyColumn("ID");
			HasMany(x => x.Ulice).KeyColumn("ID_POLICAJCA").LazyLoad().Cascade.All().Inverse();


		}
	}
}
