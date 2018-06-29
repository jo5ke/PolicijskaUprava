using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PolicijskaUprava.Entiteti;

namespace PolicijskaUprava.Mapiranja
{
	class PolicijskaStanicaMapiranje : ClassMap<PolicijskaUprava.Entiteti.PolicijskaStanica>
	{
		public PolicijskaStanicaMapiranje()
		{
		
			Table("POLICIJSKA_STANICA");

			Id(x => x.ID, "ID").GeneratedBy.Increment();

			Map(x => x.Adresa, "ADRESA");
			Map(x => x.Opstina, "OPSTINA");
			Map(x => x.Naziv, "NAZIV");
			Map(x => x.Datum_osnivanja, "DATUM_OSNIVANJA");


			References(x => x.PripadaUpravi).Column("ID_UPRAVA").LazyLoad().Not.Insert()   // <- added this
   .Not.Update();

            HasMany(x => x.Vozila).KeyColumn("ID_STANICE").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Objekti).KeyColumn("ID_STANICE_OBJEKTA").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Policajci).KeyColumn("ID_STANICE").LazyLoad().Cascade.All().Inverse();
            // HasOne(x => x.SefStanice).PropertyRef(x => x.PolicijskaStanicaSefa);
            // HasOne(x => x.ZamenikStanice).PropertyRef(x => x.PolicijskaStanicaZamenika);
           References(x => x.SefStanice).Column("ID_SEFA").Unique();
            References(x => x.ZamenikStanice).Column("ID_ZAMENIKA").Unique();

			//HasOne(x => x.PolicijskaStanicaSefa).PropertyRef(x => x.SefStanice);
			//HasOne(x => x.PolicijskaStanicaZamenika).PropertyRef(x => x.ZamenikStanice);
//


		}
    }
}