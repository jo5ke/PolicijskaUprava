using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PolicijskaUprava.Entiteti;

namespace PolicijskaUprava.Mapiranja
{
    class VoziloMapiranje : ClassMap<PolicijskaUprava.Entiteti.Vozilo>
    {
        public VoziloMapiranje()
        {

            Table("VOZILO");

            Id(x => x.Reg_oznaka).Column("REG_OZNAKA").GeneratedBy.Increment(); //Da sluzi kao id

            Map(x => x.Boja, "BOJA");
            Map(x => x.Tip, "TIP");
            Map(x => x.Model, "MODEL");
            Map(x => x.Proizvodjac, "PROIZVODJAC");

            References(x => x.PosedujeStanica).Column("ID_STANICE").LazyLoad();
           // References(x => x.VoziVozilo).Column("REG_OZNAKA").Unique();
			HasOne(x => x.VoziVozilo).PropertyRef(x => x.VoziloPatrole);

		}
    }
}
