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

			Id(x => x.Redni_br, "REDNI_BR").GeneratedBy.TriggerIdentity();

			Map(x => x.Reg_oznaka_vozila, "REG_OZNAKA_VOZILA");
			Map(x => x.Vreme, "VREME");
			Map(x => x.Opis, "OPIS");
			Map(x => x.ID_Vodje, "ID_VODJE");
			Map(x => x.ID_Objekta, "ID_OBJEKTA");

            References(x => x.InterveniseObjekat).Column("ID_OBJEKTA");


        }
    }
}