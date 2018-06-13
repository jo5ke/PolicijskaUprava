using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PolicijskaUprava.Entiteti;

namespace PolicijskaUprava.Mapiranja
{
    class SkolskiMapiranje : SubclassMap<PolicijskaUprava.Entiteti.Skolski>
    {
        public SkolskiMapiranje()
        {
            Table("SKOLSKI");

            KeyColumn("ID");
            References(x => x.RadiUSkoli).Column("ID_SKOLE").LazyLoad();


        }
    }
}
