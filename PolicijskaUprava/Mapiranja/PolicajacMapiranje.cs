using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PolicijskaUprava.Entiteti;

namespace PolicijskaUprava.Mapiranja
{
	class PolicajacMapiranje : ClassMap<PolicijskaUprava.Entiteti.Policajac>
	{
		public PolicajacMapiranje()
		{
			Table("POLICAJAC");

			Id(x => x.ID, "ID").GeneratedBy.Increment();

			Map(x => x.Licno_ime, "LICNO_IME");
			Map(x => x.Ime_roditelja, "IME_RODITELJA");
			Map(x => x.Prezime, "PREZIME");
			Map(x => x.JMBG, "JMBG");
			Map(x => x.Pol, "POL");
			Map(x => x.Datum_rodj, "DATUM_RODJ");
			Map(x => x.Adresa, "ADRESA"); // JEDAN PREMA JENDAN
			Map(x => x.Datum_diplomiranja, "DATUM_DIPLOMIRANJA");
			Map(x => x.Datum_unapredjenja, "DATUM_UNAPREDJENJA");
            Map(x => x.Oblast, "OBLAST").Not.Insert()   // <- added this
            .Not.Update();
            Map(x => x.Tip, "TIP").Not.Insert()   // <- added this
             .Not.Update();

            References(x => x.JeZamenikUprave).Column("ID_UPRAVE").LazyLoad().Not.Insert()   // <- added this
            .Not.Update();

            References(x => x.PripadaUstanovi).Column("ID_USTANOVE");//nece
            References(x => x.ImaCin).Column("ID_CINA").LazyLoad();
            References(x => x.RadiUStanici).Column("ID_STANICE").LazyLoad();
            // References(x => x.PolicijskaStanicaSefa).Column("ID_SEFA").Unique();
            //References(x => x.PolicijskaStanicaZamenika).Column("ID_ZAMENIKA").Unique();
            //References(x => x.JeNacelnikUprave).Column("ID_NACELNIKA").Unique();
            HasOne(x => x.JeNacelnikUprave).PropertyRef(x => x.NacelnikUprave); //nece
            HasOne(x => x.PolicijskaStanicaSefa).PropertyRef(x => x.SefStanice);
            HasOne(x => x.PolicijskaStanicaZamenika).PropertyRef(x => x.ZamenikStanice);



        }
    }
}