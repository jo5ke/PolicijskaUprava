using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PolicijskaUprava.Entiteti;

namespace PolicijskaUprava.Mapiranja
{
    class OstaliMapiranje : ClassMap<PolicijskaUprava.Entiteti.Ostali>
    {
        public OstaliMapiranje()
        {
            Table("OSTALI");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            References(x => x.PatrolaVodje).Column("ID_VODJE").Unique();

        }
    }
}
