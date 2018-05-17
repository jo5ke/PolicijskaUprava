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

			Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

			Map(x => x.Adresa, "ADRESA");
			Map(x => x.Opstina, "OPSTINA");
			Map(x => x.Naziv, "NAZIV");
			Map(x => x.Datum_osnivanja, "DATUM_OSNIVANJA");
			Map(x => x.ID_Sefa, "ID_SEFA");
			Map(x => x.ID_Zamenika, "ID_ZAMENIKA");
			Map(x => x.ID_Uprave, "ID_UPRAVE"); // JEDAN PREMA JENDAN

            References(x => x.PripadaUpravi).Column("ID_UPRAVE").LazyLoad();

            HasMany(x => x.Objekti).KeyColumn("ID_STANICE").LazyLoad().Cascade.All();
            HasMany(x => x.Policajci).KeyColumn("ID_STANICE").LazyLoad().Cascade.All();
            HasOne(x => x.SefStanice).PropertyRef(x => x.PolicijskaStanicaSefa);



        }
    }
}