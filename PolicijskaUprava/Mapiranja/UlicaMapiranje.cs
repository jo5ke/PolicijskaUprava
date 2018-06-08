using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PolicijskaUprava.Entiteti;

namespace PolicijskaUprava.Mapiranja
{
    class UlicaMapiranje : ClassMap<PolicijskaUprava.Entiteti.Ulica>
    {
        public UlicaMapiranje()
        {
            Table("ULICA");

			Id(x => x.ID_Policajca, "ID").GeneratedBy.TriggerIdentity();

			Map(x => x.Ulica_naziv, "ULICA_NAZIV");

			References(x => x.PozornikUlice).Column("ID_POLICAJCA");
            

        }
    }
}
