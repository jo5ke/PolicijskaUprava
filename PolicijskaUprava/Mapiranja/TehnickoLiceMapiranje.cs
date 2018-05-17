using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PolicijskaUprava.Entiteti;

namespace PolicijskaUprava.Mapiranja
{
    class TehnickoLiceMapiranje : ClassMap<PolicijskaUprava.Entiteti.TehnickoLice>
    {
        public TehnickoLiceMapiranje()
        {

            Table("TEHNICKO_LICE");

		

			CompositeId().KeyProperty(x => x.Ime, "IME")
			            .KeyReference(x => x.Serijski_br_alarma, "SERIJSKI_BR_ALARMA");

			Map(x => x.Ime).Column("IME");

		






		}
	}
}
