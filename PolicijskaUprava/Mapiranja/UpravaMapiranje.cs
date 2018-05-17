using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PolicijskaUprava.Entiteti;

namespace PolicijskaUprava.Mapiranja
{
	class UpravaMapiranje : ClassMap<PolicijskaUprava.Entiteti.Uprava>
	{
		public UpravaMapiranje()
		{
			Table("UPRAVA");

			Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

			Map(x => x.Grad, "GRAD");
			Map(x => x.ID_Nacelnika, "ID_NACELNIKA");

            HasMany(x => x.PolicijskeStanice).KeyColumn("ID_UPRAVE").LazyLoad().Cascade.All();
            HasMany(x => x.Policajci).KeyColumn("ID_UPRAVE").LazyLoad().Cascade.All();



        }
    }
}
