﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using PolicijskaUprava.Entiteti;

namespace PolicijskaUprava.Mapiranja
{
	class UpravaMapiranje : ClassMap<PolicijskaUprava.Entiteti.Uprava>
	{
		public UpravaMapiranje()
		{
			Table("UPRAVA");

			Id(x => x.ID, "ID").GeneratedBy.Increment();

			Map(x => x.Grad, "GRAD");
			//Map(x => x.ID_Nacelnika, "ID_NACELNIKA");


            HasMany(x => x.PolicijskeStanice).KeyColumn("ID_UPRAVA").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Policajci).KeyColumn("ID_UPRAVE").LazyLoad().Cascade.All().Inverse();
            //HasOne(x => x.NacelnikUprave).PropertyRef(x => x.JeNacelnikUprave);
            References(x => x.NacelnikUprave).Column("ID_NACELNIKA").Unique();



        }
    }
}
