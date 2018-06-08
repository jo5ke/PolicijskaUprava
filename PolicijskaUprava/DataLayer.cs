﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using PolicijskaUprava.Mapiranja;

namespace PolicijskaUprava
{
	class DataLayer
	{
		private static ISessionFactory _factory = null;
		private static object objLock = new object();


		//funkcija na zahtev otvara sesiju
		public static ISession GetSession()
		{
			//ukoliko session factory nije kreiran
			if (_factory == null)
			{
				lock (objLock)
				{
					if (_factory == null)
						_factory = CreateSessionFactory();
				}
			}

			return _factory.OpenSession();
		}

		//konfiguracija i kreiranje session factory
		private static ISessionFactory CreateSessionFactory()
		{
			try
			{
				var cfg = OracleClientConfiguration.Oracle10
				.ShowSql()
				.ConnectionString(c =>
					c.Is("Data Source=gislab-oracle.elfak.ni.ac.rs:1521/SBP_PDB;User Id=S15844;Password=S15844"));

				return Fluently.Configure()
					.Database(cfg)
					.Mappings(m => m.FluentMappings.AddFromAssemblyOf<UpravaMapiranje>())
					.BuildSessionFactory();
			}
			catch (Exception ec)
			{
				//System.Windows.Forms.MessageBox.Show(ec.Message);
				System.Windows.Forms.MessageBox.Show(ec.InnerException.ToString());
				return null;
			}

		}
	}
}
