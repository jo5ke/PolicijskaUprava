using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PolicijskaUprava.Entiteti;

namespace PolicijskaUprava.Mapiranja
{
    class VanredneSituacijeMapiranje : ClassMap<PolicijskaUprava.Entiteti.VanredneSituacije>
    {
        public VanredneSituacijeMapiranje()
        {
            Table("VANREDNE_SITUACIJE");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Naziv_vestine, "NAZIV_VESTINE");
            Map(x => x.Kurs, "KURS");
            Map(x => x.Datum_kursa, "DATUM_KURSA");
            Map(x => x.Sertifikat, "SERTIFIKAT");
            Map(x => x.Datum_sertifikata, "DATUM_SERTIFIKATA");
            

        }
    }
}
