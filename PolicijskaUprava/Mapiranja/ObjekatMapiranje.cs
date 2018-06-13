using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PolicijskaUprava.Entiteti;

namespace PolicijskaUprava.Mapiranja
{
	class ObjekatMapiranje : ClassMap<PolicijskaUprava.Entiteti.Objekat>
	{
		public ObjekatMapiranje()
		{
			Table("OBJEKAT");

			Id(x => x.ID, "ID").GeneratedBy.Increment();

			Map(x => x.Tip, "TIP");
			Map(x => x.Povrsina, "POVRSINA");
			Map(x => x.Prezime, "PREZIME");
			Map(x => x.Ime, "IME");
			Map(x => x.Br_telefona, "BR_TELEFONA");
			Map(x => x.Adresa, "ADRESA"); 
			Map(x => x.Datum_instalacije, "DATUM_INSTALACIJE");


            References(x => x.NadzireStanica).Column("ID_STANICE_OBJEKTA");
            HasMany(x => x.Patrole).KeyColumn("ID_OBJEKTA").LazyLoad().Cascade.All();
          References(x => x.InstaliranAlarmniSis).Column("SERIJSKI_BR_ALARMA").Unique();
         //HasOne(x => x.InstaliranAlarmniSis).PropertyRef(x => x.ObjekatInstaliran);



        }
    }
}