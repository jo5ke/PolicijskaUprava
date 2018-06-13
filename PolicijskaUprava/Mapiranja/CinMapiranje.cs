using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PolicijskaUprava.Entiteti;

namespace PolicijskaUprava.Mapiranja
{
	class CinMapiranje : ClassMap<PolicijskaUprava.Entiteti.Cin>
	{
		public CinMapiranje()
		{
			Table("CIN");

			Id(x => x.ID, "ID").GeneratedBy.Increment();

			Map(x => x.Naziv_cina, "NAZIV_CINA");

            HasMany(x => x.Policajci).KeyColumn("ID_CINA").LazyLoad().Cascade.All().Inverse();


        }
    }
}