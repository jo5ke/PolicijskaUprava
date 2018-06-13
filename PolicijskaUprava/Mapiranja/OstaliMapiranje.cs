using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PolicijskaUprava.Entiteti;

namespace PolicijskaUprava.Mapiranja
{
    class OstaliMapiranje : SubclassMap<PolicijskaUprava.Entiteti.Ostali>
    {
        public OstaliMapiranje()
        {
            Table("OSTALI");
            KeyColumn("ID");

			//References(x => x.PatrolaVodje).Column("ID_VODJE").Unique();
			HasOne(x => x.PatrolaVodje).PropertyRef(x => x.Vodja);
			References(x => x.RadiU).Column("REDNI_BR_PATROLE").LazyLoad();

        }
    }
}
