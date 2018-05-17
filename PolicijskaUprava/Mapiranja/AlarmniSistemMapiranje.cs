using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PolicijskaUprava.Entiteti;

namespace PolicijskaUprava.Mapiranja
{
	class AlarmniSistemMapiranje : ClassMap<PolicijskaUprava.Entiteti.AlarmniSistem>
	{
		public AlarmniSistemMapiranje()
		{
			Table("ALARMNI_SISTEM");

			Id(x => x.Serijski_br, "SERIJSKI_BR").GeneratedBy.TriggerIdentity();
			//DiscriminateSubClassesOnColumn("TIP");

			Map(x => x.Godina_proizvodnje, "GODINA_PROIZVODNJE");
			Map(x => x.Proizvodjac, "PROIZVODJAC");
			Map(x => x.Model, "MODEL");
			Map(x => x.Opis_servisiranja, "OPIS_SERVISIRANJA");
			Map(x => x.Datum_Atesta, "DATUM_ATESTA");
			Map(x => x.Datum_Poslednjeg_Atesta, "DATUM_POSLEDNJEG_ATESTA");


        }

        class AlarmniSistemToplotniMapiranja : SubclassMap<Toplotni>
		{
			public AlarmniSistemToplotniMapiranja()
			{
				DiscriminatorValue("TOPLOTNI");
			}
		}
		class AlarmniSistemUltrazvucniMapiranja : SubclassMap<Toplotni>
		{
			public AlarmniSistemUltrazvucniMapiranja()
			{
				DiscriminatorValue("ULTRAZVUCNI");
			}
		}
		class AlarmniSistemPokretniMapiranja : SubclassMap<Toplotni>
		{
			public AlarmniSistemPokretniMapiranja()
			{
				DiscriminatorValue("POKRETNI");
			}
		}
	}
}