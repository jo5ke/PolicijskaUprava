using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PolicijskaUprava.Entiteti;

namespace PolicijskaUprava.Mapiranja
{
    class SkolaMapiranje : ClassMap<PolicijskaUprava.Entiteti.Skola>
    {
        public SkolaMapiranje()
        {
            Table("SKOLA");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Tip_skole, "TIP_SKOLE");
            Map(x => x.Naziv, "NAZIV");
            Map(x => x.Br_telefona, "BR_TELEFONA");
            Map(x => x.Adresa, "ADRESA");
            Map(x => x.Ime, "IME");
            Map(x => x.Prezime, "PREZIME");

            HasMany(x => x.Skolski).KeyColumn("ID_SKOLE").LazyLoad().Cascade.All();



        }
    }
}
