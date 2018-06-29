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

			Id(x => x.Serijski_br, "SERIJSKI_BR").GeneratedBy.Increment();
            //DiscriminateSubClassesOnColumn("TIP");
          //  DiscriminateSubClassesOnColumn("TIP");


            
			Map(x => x.Godina_proizvodnje, "GODINA_PROIZVODNJE");
			Map(x => x.Proizvodjac, "PROIZVODJAC");
			Map(x => x.Model, "MODEL");
            Map(x => x.Tip, "TIP");
            Map(x => x.Datum_Atesta, "DATUM_ATESTA");
			Map(x => x.Datum_Poslednjeg_Servisiranja, "DATUM_POSLEDNJEG_SERVISIRANJA");

            Map(x => x.Opis_servisiranja, "OPIS_SERVISIRANJA");

            HasOne(x => x.TehnickoLice).PropertyRef( x=> x.Serijski_br_alarma);
		//	References(x => x.TehnickoLice).Column("SERIJSKI_BR").Unique();


           //References(x => x.ObjekatInstaliran).Column("SERIJSKI_BR").Unique();
           HasOne(x => x.ObjekatInstaliran).PropertyRef(x => x.InstaliranAlarmniSis);

        }

        class AlarmniSistemToplotniMapiranja : SubclassMap<Toplotni>
		{
			public AlarmniSistemToplotniMapiranja()
			{
                Table("TOPLOTNI");
                KeyColumn("SERIJSKI_BR");
                Map(x => x.Horizontalna_rez, "HORIZONTALNA_REZ");
                Map(x => x.Vertikalna_rez, "VERTIKALNA_REZ");
			}
		}
		class AlarmniSistemUltrazvucniMapiranja : SubclassMap<Ultrazvucni>
		{
			public AlarmniSistemUltrazvucniMapiranja()
			{
                Table("ULTRAZVUCNI");
                KeyColumn("SERIJSKI_BR");
                Map(x => x.Frekvencija, "FREKVENCIJA");
			}
		}
		class AlarmniSistemPokretniMapiranja : SubclassMap<Pokretni>
		{
			public AlarmniSistemPokretniMapiranja()
			{
                Table("POKRETNI");
                KeyColumn("SERIJSKI_BR");
                Map(x => x.Tezina, "TEZINA");
			}
		}
	}
}