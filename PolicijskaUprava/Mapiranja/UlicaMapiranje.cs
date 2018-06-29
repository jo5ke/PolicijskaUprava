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

			Id(x => x.ID, "ID").GeneratedBy.Increment();

			Map(x => x.Naziv, "NAZIV");

            References(x => x.PozornikUlice).Column("ID_POLICAJCA").LazyLoad();

            //HasMany(x => x.PozornikUlice).KeyColumn("ID_STANICE_OBJEKTA").LazyLoad().Cascade.All().Inverse();


        }    }
}
