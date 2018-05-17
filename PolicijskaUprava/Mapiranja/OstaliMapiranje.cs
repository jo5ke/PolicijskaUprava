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
			DiscriminatorValue(4);

            References(x => x.PatrolaVodje).Column("ID_VODJE").Unique();
			References(x => x.RadiU).Column("ID_PATROLE");

        }
    }
}
