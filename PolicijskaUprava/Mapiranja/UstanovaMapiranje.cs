using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PolicijskaUprava.Entiteti;

namespace PolicijskaUprava.Mapiranja
{
    class UstanovaMapiranje : ClassMap<PolicijskaUprava.Entiteti.Ustanova>
    {
        public UstanovaMapiranje()
        {
            Table("USTANOVA");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Naziv_ustanove, "NAZIV_USTANOVE");
            Map(x => x.Tip, "TIP");

            HasMany(x => x.Policajci).KeyColumn("ID_USTANOVE").LazyLoad().Cascade.All();


        }
    }
}
