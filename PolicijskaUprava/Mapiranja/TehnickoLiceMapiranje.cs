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

            Id(x => x.Serijski_br_alarma).Column("SERIJSKI_BR_ALARMA").GeneratedBy.TriggerIdentity(); //Da sluzi kao id

            Map(x => x.Ime, "IME");
            

        }
    }
}
