using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PolicijskaUprava.Entiteti;

namespace PolicijskaUprava.Mapiranja
{
	class PatrolaMapiranje : ClassMap<PolicijskaUprava.Entiteti.Patrola>
	{
		public PatrolaMapiranje()
		{
			Table("PATROLA");

			Id(x => x.Redni_br, "REDNI_BR").GeneratedBy.Increment();

			//Map(x => x.Reg_oznaka_vozila, "REG_OZNAKA_VOZILA");
			Map(x => x.Vreme, "VREME");
			Map(x => x.Opis, "OPIS");
		

            References(x => x.InterveniseObjekat).Column("ID_OBJEKTA").LazyLoad();
           // HasOne(x => x.Vodja).PropertyRef(x => x.PatrolaVodje);
			References(x => x.Vodja).Column("ID_VODJE").Unique();
			//HasOne(x => x.VoziloPatrole).PropertyRef(x => x.VoziVozilo);
			References(x => x.VoziloPatrole).Column("REG_OZNAKA_VOZILA").Unique();

			HasMany(x => x.Radnici).KeyColumn("REDNI_BR_PATROLE").LazyLoad().Cascade.All().Inverse();


        }
    }
}