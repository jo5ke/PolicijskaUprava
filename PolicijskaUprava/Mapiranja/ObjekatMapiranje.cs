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

			Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

			Map(x => x.Tip, "TIP");
			Map(x => x.Povrsina, "POVRSINA");
			Map(x => x.Prezime, "PREZIME");
			Map(x => x.Ime, "IME");
			Map(x => x.Br_telefona, "BR_TELEFONA");
			Map(x => x.Serijski_br_alarma, "SERIJSKI_BR_ALARMA");
			Map(x => x.Adresa, "ADRESA"); 
			Map(x => x.Datum_instalacije, "DATUM_INSTALACIJE");
			Map(x => x.ID_Stanice, "ID_STANICE");

            References(x => x.NadzireStanica).Column("ID_STANICE");
            HasMany(x => x.Patrole).KeyColumn("ID_OBJEKTA").LazyLoad().Cascade.All();




        }
    }
}