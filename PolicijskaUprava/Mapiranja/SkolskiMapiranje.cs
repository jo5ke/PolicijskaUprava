using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PolicijskaUprava.Entiteti;

namespace PolicijskaUprava.Mapiranja
{
    class SkolskiMapiranje : ClassMap<PolicijskaUprava.Entiteti.Skolski>
    {
        public SkolskiMapiranje()
        {
            Table("SKOLSKI");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.ID_Skole, "ID_SKOLE");

            References(x => x.RadiUSkoli).Column("ID_SKOLE").LazyLoad();


        }
    }
}
