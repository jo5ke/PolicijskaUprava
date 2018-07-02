using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Linq;
using PolicijskaUprava.DTOs;
using NHibernate;
using PolicijskaUprava.Entiteti;

namespace PolicijskaUprava
{
	public class DataProvider
	{

        #region UpravaCRUD  
	
		public IList<UpravaView> GetUprave()
		{
			ISession s = DataLayer.GetSession();

			IEnumerable<Uprava> uprave = s.Query<Uprava>()
												//.Where(p => (p.Tip == "LUTKE" || p.Tip == "DODACI ZA LUTKE"))
												//.OrderBy(p => p.Tip).ThenBy(p => p.Naziv.Length)
												.Select(p => p);
			IList<UpravaView> upraveView = new List<UpravaView>();

			foreach(Uprava u in uprave)
			{
				upraveView.Add(new UpravaView(u));
			}
			return upraveView;
		}

		public UpravaView GetUpravaView(int id)
		{
			ISession s = DataLayer.GetSession();

			Uprava upr = s.Query<Uprava>()
				.Where(u => u.ID == id).Select(p => p).FirstOrDefault();

			if (upr == null) return new UpravaView();

			return new UpravaView(upr);
		}

		public int AddUprava(Uprava u)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				s.Save(u);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception ec)
			{
				return -1;
			}
		}

		public int EditUprava(int id,Uprava u)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				Uprava upr = s.Query<Uprava>()
					.Where(up => up.ID == id).Select(p => p).FirstOrDefault();
				//Uprava upr = s.Load<Uprava>(id);
				upr.Grad = u.Grad;

				//s.SaveOrUpdate(upr);
				s.Save(upr);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception exc)
			{
				return -1;
			}

		}

		public int RemoveUprava(int id)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				Uprava u = s.Load<Uprava>(id);

				s.Delete(u);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception exc)
			{
				return -1;
			}

		}

		#endregion UpravaCRUD

		#region PolicajacCRUD

		public IList<PolicajacView> GetPolicajci()
		{
			ISession s = DataLayer.GetSession();

			IEnumerable<Policajac> policajci = s.Query<Policajac>()
												//.Where(p => (p.Tip == "LUTKE" || p.Tip == "DODACI ZA LUTKE"))
												//.OrderBy(p => p.Tip).ThenBy(p => p.Naziv.Length)
												.Select(p => p);
			IList<PolicajacView> policajciView = new List<PolicajacView>();

			foreach (Policajac p in policajci)
			{
				policajciView.Add(new PolicajacView(p));
			}
			return policajciView;
		}

		public PolicajacView GetPolicajacView(int id)
		{
			ISession s = DataLayer.GetSession();

			Policajac pol = s.Query<Policajac>()
				.Where(p => p.ID == id).Select(p => p).FirstOrDefault();

			if (pol == null) return new PolicajacView();

			return new PolicajacView(pol);
		}

		public int AddPolicajac(Policajac p)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				s.Save(p);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception ec)
			{
				return -1;
			}
		}

		public int UpdatePolicajac(int id, Policajac p)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				Policajac pol = s.Query<Policajac>()
					.Where(po => po.ID == id).Select(o => o).FirstOrDefault();
				//Uprava upr = s.Load<Uprava>(id);
				if (p.Licno_ime != null)
					pol.Licno_ime = p.Licno_ime;
				if (p.Tip != null)
					pol.Tip = p.Tip;
				if (p.Ime_roditelja != null)
					pol.Ime_roditelja = p.Ime_roditelja;
				if (p.Prezime != null)
					pol.Prezime = p.Prezime;
				if(p.JMBG != 0)
					pol.JMBG = p.JMBG;
				if (p.Pol != 0)
					pol.Pol = p.Pol;
				if (p.Adresa != null)
					pol.Adresa = p.Adresa;
				if (p.Oblast != null)
					pol.Oblast = p.Oblast;
				pol.Datum_rodj = p.Datum_rodj;
				pol.Datum_diplomiranja = p.Datum_diplomiranja;
				pol.Datum_unapredjenja = p.Datum_unapredjenja;

				//s.SaveOrUpdate(upr);
				s.Save(pol);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception exc)
			{
				return -1;
			}

		}

		public int RemovePolicajac(int id)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				Policajac p = s.Load<Policajac>(id);

				s.Delete(p);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception exc)
			{
				return -1;
			}

		}

		#endregion PolicajacCRUD

		#region PolicijskaStanicaCRUD

		public IList<PolicijskaStanicaView> GetPolicijskeStanice()
		{
			ISession s = DataLayer.GetSession();

			IEnumerable<PolicijskaStanica> stanice = s.Query<PolicijskaStanica>()
												//.Where(p => (p.Tip == "LUTKE" || p.Tip == "DODACI ZA LUTKE"))
												//.OrderBy(p => p.Tip).ThenBy(p => p.Naziv.Length)
												.Select(p => p);
			IList<PolicijskaStanicaView> staniceView = new List<PolicijskaStanicaView>();

			foreach (PolicijskaStanica ps in stanice)
			{
				staniceView.Add(new PolicijskaStanicaView(ps));
			}
			return staniceView;
		}

		public PolicijskaStanicaView GetPolicijskaStanica(int id)
		{
			ISession s = DataLayer.GetSession();

			PolicijskaStanica ps = s.Query<PolicijskaStanica>()
				.Where(p => p.ID == id).Select(p => p).FirstOrDefault();

			if (ps == null) return new PolicijskaStanicaView();

			return new PolicijskaStanicaView(ps);
		}

		public int AddPolicijskaStanica(PolicijskaStanica p)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				s.Save(p);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception ec)
			{
				return -1;
			}
		}

		public int UpdatePolicijskaStanica(int id, PolicijskaStanica p)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				PolicijskaStanica ps = s.Query<PolicijskaStanica>()
					.Where(po => po.ID == id).Select(o => o).FirstOrDefault();
				//Uprava upr = s.Load<Uprava>(id);
				if (p.Adresa != null)
					ps.Adresa = p.Adresa;
				if (p.Opstina != null)
					ps.Opstina = p.Opstina;
				if (p.Naziv != null)
					ps.Naziv = p.Naziv;
				ps.Datum_osnivanja = p.Datum_osnivanja;
				if (p.PripadaUpravi.ID != 0)
					ps.PripadaUpravi = p.PripadaUpravi;
				if (p.SefStanice.ID != 0)
					ps.SefStanice = p.SefStanice;
				if (p.ZamenikStanice.ID != 0)
					ps.ZamenikStanice = p.ZamenikStanice;

				//s.SaveOrUpdate(upr);
				s.Save(ps);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception exc)
			{
				return -1;
			}

		}

		public int RemovePolicijskaStanica(int id)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				PolicijskaStanica p = s.Load<PolicijskaStanica>(id);

				s.Delete(p);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception exc)
			{
				return -1;
			}

		}

		#endregion

		#region ObjekatCRUD

		public IList<ObjekatView> GetObjekti()
		{
			ISession s = DataLayer.GetSession();

			IEnumerable<Objekat> objekti = s.Query<Objekat>()
												//.Where(p => (p.Tip == "LUTKE" || p.Tip == "DODACI ZA LUTKE"))
												//.OrderBy(p => p.Tip).ThenBy(p => p.Naziv.Length)
												.Select(p => p);
			IList<ObjekatView> objektiView = new List<ObjekatView>();

			foreach(Objekat o in objekti)
			{
				objektiView.Add(new ObjekatView(o));
			}
			return objektiView;
		}

		public ObjekatView GetObjekat(int id)
		{
			ISession s = DataLayer.GetSession();

			Objekat o = s.Query<Objekat>()
				.Where(p => p.ID == id).Select(p => p).FirstOrDefault();

			if (o == null) return new ObjekatView();

			return new ObjekatView(o);
		}

		public int AddObjekat(Objekat p)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				s.Save(p);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception ec)
			{
				return -1;
			}
		}

		public int UpdateObjekat(int id, Objekat p)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				Objekat ob = s.Query<Objekat>()
					.Where(po => po.ID == id).Select(o => o).FirstOrDefault();
				//Uprava upr = s.Load<Uprava>(id);
				if (p.Tip != null)
					ob.Tip = p.Tip;
				if (p.Adresa != null)
					ob.Adresa = p.Adresa;
				if (p.Ime != null)
					ob.Ime = p.Ime;
				if (p.Prezime != null)
					ob.Prezime = p.Prezime;
				if (p.Povrsina != 0)
					ob.Povrsina = p.Povrsina;
				if (p.Br_telefona != 0)
					ob.Br_telefona = p.Br_telefona;
				ob.Datum_instalacije = p.Datum_instalacije;

				if (p.InstaliranAlarmniSis.Serijski_br != 0)
					ob.InstaliranAlarmniSis = p.InstaliranAlarmniSis;
				if (p.NadzireStanica.ID != 0)
					ob.NadzireStanica = p.NadzireStanica;

				//s.SaveOrUpdate(upr);
				s.Save(ob);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception exc)
			{
				return -1;
			}

		}

		public int RemoveObjekat(int id)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				Objekat p = s.Load<Objekat>(id);

				s.Delete(p);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception exc)
			{
				return -1;
			}

		}

		#endregion

		#region VoziloCRUD

		public IList<VoziloView> GetVozila()
		{
			ISession s = DataLayer.GetSession();

			IEnumerable<Vozilo> vozila = s.Query<Vozilo>()
												//.Where(p => (p.Tip == "LUTKE" || p.Tip == "DODACI ZA LUTKE"))
												//.OrderBy(p => p.Tip).ThenBy(p => p.Naziv.Length)
												.Select(p => p);
			IList<VoziloView> vozilaView = new List<VoziloView>();

			foreach (Vozilo o in vozila)
			{
				vozilaView.Add(new VoziloView(o));
			}
			return vozilaView;
		}

		public VoziloView GetVozilo(int id)
		{
			ISession s = DataLayer.GetSession();

			Vozilo o = s.Query<Vozilo>()
				.Where(p => p.Reg_oznaka == id).Select(p => p).FirstOrDefault();

			if (o == null) return new VoziloView();

			return new VoziloView(o);
		}

		public int AddVozilo(Vozilo p)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				s.Save(p);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception ec)
			{
				return -1;
			}
		}

		public int UpdateVozilo(int id, Vozilo p)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				Vozilo voz = s.Query<Vozilo>()
					.Where(po => po.Reg_oznaka == id).Select(o => o).FirstOrDefault();
				//Uprava upr = s.Load<Uprava>(id);
				if (p.Tip != null)
					voz.Tip = p.Tip;
				if (p.Boja != null)
					voz.Boja = p.Boja;
				if (p.Model != null)
					voz.Model = p.Model;
				if (p.Proizvodjac != null)
					voz.Proizvodjac = p.Proizvodjac;

				//s.SaveOrUpdate(upr);
				s.Save(voz);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception exc)
			{
				return -1;
			}

		}

		public int RemoveVozilo(int id)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				Vozilo p = s.Load<Vozilo>(id);

				s.Delete(p);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception exc)
			{
				return -1;
			}

		}

		#endregion

		#region PatrolaCRUD

		public IList<PatrolaView> GetPatrole()
		{
			ISession s = DataLayer.GetSession();

			IEnumerable<Patrola> patrole = s.Query<Patrola>()
												//.Where(p => (p.Tip == "LUTKE" || p.Tip == "DODACI ZA LUTKE"))
												//.OrderBy(p => p.Tip).ThenBy(p => p.Naziv.Length)
												.Select(p => p);
			IList<PatrolaView> patroleView = new List<PatrolaView>();

			foreach (Patrola o in patrole)
			{
				patroleView.Add(new PatrolaView(o));
			}
			return patroleView;
		}

		public PatrolaView GetPatrola(int id)
		{
			ISession s = DataLayer.GetSession();

			Patrola o = s.Query<Patrola>()
				.Where(p => p.Redni_br == id).Select(p => p).FirstOrDefault();

			if (o == null) return new PatrolaView();

			return new PatrolaView(o);
		}

		public int AddPatrola(Patrola p)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				s.Save(p);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception ec)
			{
				return -1;
			}
		}

		public int UpdatePatrola(int id, Patrola p)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				Patrola pat = s.Query<Patrola>()
					.Where(po => po.Redni_br == id).Select(o => o).FirstOrDefault();
				//Uprava upr = s.Load<Uprava>(id);
				if (p.Opis != null)
					pat.Opis = p.Opis;
				pat.Vreme = p.Vreme;

				//s.SaveOrUpdate(upr);
				s.Save(pat);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception exc)
			{
				return -1;
			}

		}

		public int RemovePatrola(int id)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				Patrola p = s.Load<Patrola>(id);

				s.Delete(p);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception exc)
			{
				return -1;
			}

		}

		#endregion

		#region AlarmniSistemCRUD

		public IList<AlarmniSistemView> GetAlarmniSistemi()
		{
			ISession s = DataLayer.GetSession();

			IEnumerable<AlarmniSistem> sistemi = s.Query<AlarmniSistem>()
												//.Where(p => (p.Tip == "LUTKE" || p.Tip == "DODACI ZA LUTKE"))
												//.OrderBy(p => p.Tip).ThenBy(p => p.Naziv.Length)
												.Select(p => p);
			IList<AlarmniSistemView> sistemiView = new List<AlarmniSistemView>();

			foreach (AlarmniSistem o in sistemi)
			{
				sistemiView.Add(new AlarmniSistemView(o));
			}
			return sistemiView;
		}

		public AlarmniSistemView GetAlarmniSistem(int id)
		{
			ISession s = DataLayer.GetSession();

			AlarmniSistem o = s.Query<AlarmniSistem>()
				.Where(p => p.Serijski_br == id).Select(p => p).FirstOrDefault();

			if (o == null) return new AlarmniSistemView();

			return new AlarmniSistemView(o);
		}

		public int AddAlarmniSistem(AlarmniSistem p)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				s.Save(p);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception ec)
			{
				return -1;
			}
		}

		public int UpdateAlarmniSistem(int id, AlarmniSistem p)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				AlarmniSistem sis = s.Query<AlarmniSistem>()
					.Where(po => po.Serijski_br == id).Select(o => o).FirstOrDefault();
				//Uprava upr = s.Load<Uprava>(id);
				if (p.Proizvodjac != null)
					sis.Proizvodjac = p.Proizvodjac;
				if (p.Model != null)
					sis.Model = p.Model;
				if (p.Opis_servisiranja != null)
					sis.Opis_servisiranja = p.Opis_servisiranja;
				if (p.Tip != null)
					sis.Tip = p.Tip;
				if (p.Godina_proizvodnje != 0)
					sis.Godina_proizvodnje = p.Godina_proizvodnje;

				sis.Datum_Atesta = p.Datum_Atesta;
				sis.Datum_Poslednjeg_Servisiranja = p.Datum_Poslednjeg_Servisiranja;

				//s.SaveOrUpdate(upr);
				s.Save(sis);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception exc)
			{
				return -1;
			}

		}

		public int RemoveAlarmniSistem(int id)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				AlarmniSistem p = s.Load<AlarmniSistem>(id);

				s.Delete(p);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception exc)
			{
				return -1;
			}

		}

		#endregion

		#region CinCRUD

		public IList<CinView> GetCinovi()
		{
			ISession s = DataLayer.GetSession();

			IEnumerable<Cin> cinovi = s.Query<Cin>()
												//.Where(p => (p.Tip == "LUTKE" || p.Tip == "DODACI ZA LUTKE"))
												//.OrderBy(p => p.Tip).ThenBy(p => p.Naziv.Length)
												.Select(p => p);
			IList<CinView> cinoviView = new List<CinView>();

			foreach (Cin o in cinovi)
			{
				cinoviView.Add(new CinView(o));
			}
			return cinoviView;
		}

		public CinView GetCin(int id)
		{
			ISession s = DataLayer.GetSession();

			Cin o = s.Query<Cin>()
				.Where(p => p.ID == id).Select(p => p).FirstOrDefault();

			if (o == null) return new CinView();

			return new CinView(o);
		}

		public int AddCin(Cin p)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				s.Save(p);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception ec)
			{
				return -1;
			}
		}

		public int UpdateCin(int id, Cin p)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				Cin cin = s.Query<Cin>()
					.Where(po => po.ID == id).Select(o => o).FirstOrDefault();
				//Uprava upr = s.Load<Uprava>(id);
				if (p.Naziv_cina != null)
					cin.Naziv_cina = p.Naziv_cina;
	
				//s.SaveOrUpdate(upr);
				s.Save(cin);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception exc)
			{
				return -1;
			}

		}

		public int RemoveCin(int id)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				Cin p = s.Load<Cin>(id);

				s.Delete(p);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception exc)
			{
				return -1;
			}

		}

		#endregion

		#region SkolaCRUD

		public IList<SkolaView> GetSkole()
		{
			ISession s = DataLayer.GetSession();

			IEnumerable<Skola> skole = s.Query<Skola>()
												.Select(p => p);
			IList<SkolaView> skoleView = new List<SkolaView>();

			foreach (Skola o in skole)
			{
				skoleView.Add(new SkolaView(o));
			}
			return skoleView;
		}

		public SkolaView GetSkola(int id)
		{
			ISession s = DataLayer.GetSession();

			Skola o = s.Query<Skola>()
				.Where(p => p.ID == id).Select(p => p).FirstOrDefault();

			if (o == null) return new SkolaView();

			return new SkolaView(o);
		}

		public int AddSkola(Skola p)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				s.Save(p);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception ec)
			{
				return -1;
			}
		}

		public int UpdateSkola(int id, Skola p)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				Skola sk = s.Query<Skola>()
					.Where(po => po.ID == id).Select(o => o).FirstOrDefault();

				if (p.Tip_skole != null)
					sk.Tip_skole = p.Tip_skole;
				if (p.Naziv != null)
					sk.Naziv = p.Naziv;
				if (p.Adresa != null)
					sk.Adresa = p.Adresa;
				if (p.Ime != null)
					sk.Ime = p.Ime;
				if (p.Prezime != null)
					sk.Prezime = p.Prezime;
				if (p.Br_telefona != 0)
					sk.Br_telefona = p.Br_telefona;

				//s.SaveOrUpdate(upr);
				s.Save(sk);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception exc)
			{
				return -1;
			}

		}

		public int RemoveSkola(int id)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				Skola p = s.Load<Skola>(id);

				s.Delete(p);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception exc)
			{
				return -1;
			}

		}

		#endregion

		#region UlicaCRUD

		public IList<UlicaView> GetUlice()
		{
			ISession s = DataLayer.GetSession();

			IEnumerable<Ulica> ulice = s.Query<Ulica>()
												.Select(p => p);
			IList<UlicaView> uliceView = new List<UlicaView>();

			foreach (Ulica o in ulice)
			{
				uliceView.Add(new UlicaView(o));
			}
			return uliceView;
		}

		public UlicaView GetUlica(int id)
		{
			ISession s = DataLayer.GetSession();

			Ulica o = s.Query<Ulica>()
				.Where(p => p.ID == id).Select(p => p).FirstOrDefault();

			if (o == null) return new UlicaView();

			return new UlicaView(o);
		}

		public int AddUlica(Ulica p)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				s.Save(p);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception ec)
			{
				return -1;
			}
		}

		public int UpdateUlica(int id, Ulica p)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				Ulica ul = s.Query<Ulica>()
					.Where(po => po.ID == id).Select(o => o).FirstOrDefault();

				if (p.Naziv != null)
					ul.Naziv = p.Naziv;
				if (p.PozornikUlice != null)
					ul.PozornikUlice = p.PozornikUlice;

				//s.SaveOrUpdate(upr);
				s.Save(ul);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception exc)
			{
				return -1;
			}

		}

		public int RemoveUlica(int id)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				Ulica p = s.Load<Ulica>(id);

				s.Delete(p);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception exc)
			{
				return -1;
			}

		}

		#endregion

		#region UstanovaCRUD

		public IList<UstanovaView> GetUstanove()
		{
			ISession s = DataLayer.GetSession();

			IEnumerable<Ustanova> ustanove = s.Query<Ustanova>()
												.Select(p => p);
			IList<UstanovaView> ustanoveView = new List<UstanovaView>();

			foreach (Ustanova o in ustanove)
			{
				ustanoveView.Add(new UstanovaView(o));
			}
			return ustanoveView;
		}

		public UstanovaView GetUstanova(int id)
		{
			ISession s = DataLayer.GetSession();

			Ustanova o = s.Query<Ustanova>()
				.Where(p => p.ID == id).Select(p => p).FirstOrDefault();

			if (o == null) return new UstanovaView();

			return new UstanovaView(o);
		}

		public int AddUstanova(Ustanova p)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				s.Save(p);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception ec)
			{
				return -1;
			}
		}

		public int UpdateUstanova(int id, Ustanova p)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				Ustanova us = s.Query<Ustanova>()
					.Where(po => po.ID == id).Select(o => o).FirstOrDefault();

				if (p.Naziv_ustanove != null)
					us.Naziv_ustanove = p.Naziv_ustanove;
				if (p.Tip != null)
					us.Tip = p.Tip;

				//s.SaveOrUpdate(upr);
				s.Save(us);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception exc)
			{
				return -1;
			}

		}

		public int RemoveUstanova(int id)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				Ustanova p = s.Load<Ustanova>(id);

				s.Delete(p);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception exc)
			{
				return -1;
			}

		}

		#endregion

		#region TehnickoLiceCRUD

		public IList<TehnickoLiceView> GetTehnickaLica()
		{
			ISession s = DataLayer.GetSession();

			IEnumerable<TehnickoLice> tlica = s.Query<TehnickoLice>()
												.Select(p => p);
			IList<TehnickoLiceView> tlicaView = new List<TehnickoLiceView>();

			foreach (TehnickoLice o in tlica)
			{
				tlicaView.Add(new TehnickoLiceView(o));
			}
			return tlicaView;
		}

		public TehnickoLiceView GetTehnickoLice(int id)
		{
			ISession s = DataLayer.GetSession();

			TehnickoLice o = s.Query<TehnickoLice>()
				.Where(p => p.Id == id).Select(p => p).FirstOrDefault();

			if (o == null) return new TehnickoLiceView();

			return new TehnickoLiceView(o);
		}

		public int AddTehnickoLice(TehnickoLice p)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				s.Save(p);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception ec)
			{
				return -1;
			}
		}

		public int UpdateTehnickoLice(int id, TehnickoLice p)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				TehnickoLice tl = s.Query<TehnickoLice>()
					.Where(po => po.Id == id).Select(o => o).FirstOrDefault();

				if (p.Ime != null)
					tl.Ime = p.Ime;
				if (p.Serijski_br_alarma != null)
					tl.Serijski_br_alarma = p.Serijski_br_alarma;

				//s.SaveOrUpdate(upr);
				s.Save(tl);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception exc)
			{
				return -1;
			}

		}

		public int RemoveTehnickoLice(int id)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				TehnickoLice p = s.Load<TehnickoLice>(id);

				s.Delete(p);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception exc)
			{
				return -1;
			}

		}

		#endregion

		#region Policajac:OstaliCRUD

		public IList<OstaliView> GetOstale()
		{
			ISession s = DataLayer.GetSession();

			IEnumerable<Ostali> ostali = s.Query<Ostali>()
												.Select(p => p);
			IList<OstaliView> ostaliView = new List<OstaliView>();

			foreach (Ostali o in ostali)
			{
				ostaliView.Add(new OstaliView(o));
			}
			return ostaliView;
		}

		public OstaliView GetOstali(int id)
		{
			ISession s = DataLayer.GetSession();

			Ostali o = s.Query<Ostali>()
				.Where(p => p.ID == id).Select(p => p).FirstOrDefault();

			if (o == null) return new OstaliView();

			return new OstaliView(o);
		}

		public int AddOstali(Ostali p)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				s.Save(p);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception ec)
			{
				return -1;
			}
		}

		public int UpdateOstali(int id, Ostali p)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				Ostali os = s.Query<Ostali>()
					.Where(po => po.ID == id).Select(o => o).FirstOrDefault();

				if (p.RadiU != null)
					os.RadiU = p.RadiU;
				//Policajac
				if (p.Licno_ime != null)
					os.Licno_ime = p.Licno_ime;
				if (p.Ime_roditelja != null)
					os.Ime_roditelja = p.Ime_roditelja;
				if (p.Prezime != null)
					os.Prezime = p.Prezime;
				if (p.JMBG != 0)
					os.JMBG = p.JMBG;
				if (p.Pol != 0)
					os.Pol = p.Pol;
				if (p.Adresa != null)
					os.Adresa = p.Adresa;
				if (p.Oblast != null)
					os.Oblast = p.Oblast;
				os.Datum_rodj = p.Datum_rodj;
				os.Datum_diplomiranja = p.Datum_diplomiranja;
				os.Datum_unapredjenja = p.Datum_unapredjenja;

				//s.SaveOrUpdate(upr);
				s.Save(os);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception exc)
			{
				return -1;
			}

		}

		public int RemoveOstali(int id)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				Ostali o = s.Load<Ostali>(id);

				s.Delete(o);

				Policajac p = s.Load<Policajac>(id);

				s.Delete(p);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception exc)
			{
				return -1;
			}

		}

		#endregion

		#region Policajac:PozornikCRUD

		public IList<PozornikView> GetPozornici()
		{
			ISession s = DataLayer.GetSession();

			IEnumerable<Pozornik> pozornici = s.Query<Pozornik>()
												.Select(p => p);
			IList<PozornikView> pozorniciView = new List<PozornikView>();

			foreach (Pozornik o in pozornici)
			{
				pozorniciView.Add(new PozornikView(o));
			}
			return pozorniciView;
		}

		public PozornikView GetPozornik(int id)
		{
			ISession s = DataLayer.GetSession();

			Pozornik o = s.Query<Pozornik>()
				.Where(p => p.ID == id).Select(p => p).FirstOrDefault();

			if (o == null) return new PozornikView();

			return new PozornikView(o);
		}

		public int AddPozornik(Pozornik p)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				s.Save(p);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception ec)
			{
				return -1;
			}
		}

		public int UpdatePozornik(int id, Pozornik p)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				Pozornik poz = s.Query<Pozornik>()
					.Where(po => po.ID == id).Select(o => o).FirstOrDefault();

				if (p.Licno_ime != null)
					poz.Licno_ime = p.Licno_ime;

				if (p.Ime_roditelja != null)
					poz.Ime_roditelja = p.Ime_roditelja;
				if (p.Prezime != null)
					poz.Prezime = p.Prezime;
				if (p.JMBG != 0)
					poz.JMBG = p.JMBG;
				if (p.Pol != 0)
					poz.Pol = p.Pol;
				if (p.Adresa != null)
					poz.Adresa = p.Adresa;
				if (p.Oblast != null)
					poz.Oblast = p.Oblast;
				poz.Datum_rodj = p.Datum_rodj;
				poz.Datum_diplomiranja = p.Datum_diplomiranja;
				poz.Datum_unapredjenja = p.Datum_unapredjenja;
				//s.SaveOrUpdate(upr);
				s.Save(poz);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception exc)
			{
				return -1;
			}

		}

		public int RemovePozornik(int id)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				Pozornik o = s.Load<Pozornik>(id);

				s.Delete(o);

				Policajac p = s.Load<Policajac>(id);

				s.Delete(p);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception exc)
			{
				return -1;
			}

		}

		#endregion

		#region Policajac:SkolskiCRUD

		public IList<SkolskiView> GetSkolske()
		{
			ISession s = DataLayer.GetSession();

			IEnumerable<Skolski> skolski = s.Query<Skolski>()
												.Select(p => p);
			IList<SkolskiView> skolskiView = new List<SkolskiView>();

			foreach (Skolski o in skolski)
			{
				skolskiView.Add(new SkolskiView(o));
			}
			return skolskiView;
		}

		public SkolskiView GetSkolski(int id)
		{
			ISession s = DataLayer.GetSession();

			Skolski o = s.Query<Skolski>()
				.Where(p => p.ID == id).Select(p => p).FirstOrDefault();

			if (o == null) return new SkolskiView();

			return new SkolskiView(o);
		}

		public int AddSkolski(Skolski p)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				s.Save(p);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception ec)
			{
				return -1;
			}
		}

		public int UpdateSkolski(int id, Skolski p)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				Skolski sko = s.Query<Skolski>()
					.Where(po => po.ID == id).Select(o => o).FirstOrDefault();

				if (p.RadiUSkoli != null)
					sko.RadiUSkoli = p.RadiUSkoli;

				if (p.Licno_ime != null)
					sko.Licno_ime = p.Licno_ime;

				if (p.Ime_roditelja != null)
					sko.Ime_roditelja = p.Ime_roditelja;
				if (p.Prezime != null)
					sko.Prezime = p.Prezime;
				if (p.JMBG != 0)
					sko.JMBG = p.JMBG;
				if (p.Pol != 0)
					sko.Pol = p.Pol;
				if (p.Adresa != null)
					sko.Adresa = p.Adresa;
				if (p.Oblast != null)
					sko.Oblast = p.Oblast;
				sko.Datum_rodj = p.Datum_rodj;
				sko.Datum_diplomiranja = p.Datum_diplomiranja;
				sko.Datum_unapredjenja = p.Datum_unapredjenja;
				//s.SaveOrUpdate(upr);
				s.Save(sko);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception exc)
			{
				return -1;
			}

		}

		public int RemoveSkolski(int id)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				Skolski o = s.Load<Skolski>(id);

				s.Delete(o);

				Policajac p = s.Load<Policajac>(id);

				s.Delete(p);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception exc)
			{
				return -1;
			}

		}

		#endregion

		#region Policajac:VanredneSituacijeCRUD

		public IList<VanredneSituacijeView> GetVanredneSituacije()
		{
			ISession s = DataLayer.GetSession();

			IEnumerable<VanredneSituacije> vsituacije = s.Query<VanredneSituacije>()
												.Select(p => p);
			IList<VanredneSituacijeView> vsituacijeView = new List<VanredneSituacijeView>();

			foreach (VanredneSituacije o in vsituacije)
			{
				vsituacijeView.Add(new VanredneSituacijeView(o));
			}
			return vsituacijeView;
		}

		public VanredneSituacijeView GetVanrednaSituacija(int id)
		{
			ISession s = DataLayer.GetSession();

			VanredneSituacije o = s.Query<VanredneSituacije>()
				.Where(p => p.ID == id).Select(p => p).FirstOrDefault();

			if (o == null) return new VanredneSituacijeView();

			return new VanredneSituacijeView(o);
		}

		public int AddVanredneSituacije(VanredneSituacije p)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				s.Save(p);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception ec)
			{
				return -1;
			}
		}

		public int UpdateVanredneSituacije(int id, VanredneSituacije p)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				VanredneSituacije vs = s.Query<VanredneSituacije>()
					.Where(po => po.ID == id).Select(o => o).FirstOrDefault();

				if (p.Naziv_vestine != null)
					vs.Naziv_vestine = p.Naziv_vestine;
				if (p.Kurs != null)
					vs.Kurs = p.Kurs;
				if (p.Sertifikat != null)
					vs.Sertifikat = p.Sertifikat;
				vs.Datum_sertifikata = p.Datum_sertifikata;
				vs.Datum_kursa = p.Datum_kursa;

				//Policajac
				if (p.Licno_ime != null)
					vs.Licno_ime = p.Licno_ime;
				if (p.Ime_roditelja != null)
					vs.Ime_roditelja = p.Ime_roditelja;
				if (p.Prezime != null)
					vs.Prezime = p.Prezime;
				if (p.JMBG != 0)
					vs.JMBG = p.JMBG;
				if (p.Pol != 0)
					vs.Pol = p.Pol;
				if (p.Adresa != null)
					vs.Adresa = p.Adresa;
				if (p.Oblast != null)
					vs.Oblast = p.Oblast;
				vs.Datum_rodj = p.Datum_rodj;
				vs.Datum_diplomiranja = p.Datum_diplomiranja;
				vs.Datum_unapredjenja = p.Datum_unapredjenja;
				//s.SaveOrUpdate(upr);
				s.Save(vs);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception exc)
			{
				return -1;
			}

		}

		public int RemoveVanredneSituacije(int id)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				VanredneSituacije o = s.Load<VanredneSituacije>(id);

				s.Delete(o);

				Policajac p = s.Load<Policajac>(id);

				s.Delete(p);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception exc)
			{
				return -1;
			}

		}

		#endregion

		#region AlarmniSistem:ToplotniCRUD

		public IList<ToplotniView> GetToplotne()
		{
			ISession s = DataLayer.GetSession();

			IEnumerable<Toplotni> sistemi = s.Query<Toplotni>()
												//.Where(p => (p.Tip == "LUTKE" || p.Tip == "DODACI ZA LUTKE"))
												//.OrderBy(p => p.Tip).ThenBy(p => p.Naziv.Length)
												.Select(p => p);
			IList<ToplotniView> sistemiView = new List<ToplotniView>();

			foreach (Toplotni o in sistemi)
			{
				sistemiView.Add(new ToplotniView(o));
			}
			return sistemiView;
		}

		public ToplotniView GetToplotni(int id)
		{
			ISession s = DataLayer.GetSession();

			Toplotni o = s.Query<Toplotni>()
				.Where(p => p.Serijski_br == id).Select(p => p).FirstOrDefault();

			if (o == null) return new ToplotniView();

			return new ToplotniView(o);
		}

		public int AddToplotni(Toplotni p)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				s.Save(p);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception ec)
			{
				return -1;
			}
		}

		public int UpdateToplotni(int id, Toplotni p)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				Toplotni sis = s.Query<Toplotni>()
					.Where(po => po.Serijski_br == id).Select(o => o).FirstOrDefault();

				if (p.Horizontalna_rez != 0)
					sis.Horizontalna_rez = p.Horizontalna_rez;
				if (p.Vertikalna_rez != 0)
					sis.Vertikalna_rez = p.Vertikalna_rez;

				//AlarmniSistem
				if (p.Proizvodjac != null)
					sis.Proizvodjac = p.Proizvodjac;
				if (p.Model != null)
					sis.Model = p.Model;
				if (p.Opis_servisiranja != null)
					sis.Opis_servisiranja = p.Opis_servisiranja;
				if (p.Tip != null)
					sis.Tip = p.Tip;
				if (p.Godina_proizvodnje != 0)
					sis.Godina_proizvodnje = p.Godina_proizvodnje;

				sis.Datum_Atesta = p.Datum_Atesta;
				sis.Datum_Poslednjeg_Servisiranja = p.Datum_Poslednjeg_Servisiranja;

				//s.SaveOrUpdate(upr);
				s.Save(sis);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception exc)
			{
				return -1;
			}

		}

		public int RemoveToplotni(int id)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				Toplotni p = s.Load<Toplotni>(id);

				s.Delete(p);

				AlarmniSistem a = s.Load<AlarmniSistem>(id);

				s.Delete(a);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception exc)
			{
				return -1;
			}

		}

		#endregion

		#region AlarmniSistem:PokretniCRUD

		public IList<PokretniView> GetPokretne()
		{
			ISession s = DataLayer.GetSession();

			IEnumerable<Pokretni> sistemi = s.Query<Pokretni>()
												//.Where(p => (p.Tip == "LUTKE" || p.Tip == "DODACI ZA LUTKE"))
												//.OrderBy(p => p.Tip).ThenBy(p => p.Naziv.Length)
												.Select(p => p);
			IList<PokretniView> sistemiView = new List<PokretniView>();

			foreach (Pokretni o in sistemi)
			{
				sistemiView.Add(new PokretniView(o));
			}
			return sistemiView;
		}

		public PokretniView GetPokretni(int id)
		{
			ISession s = DataLayer.GetSession();

			Pokretni o = s.Query<Pokretni>()
				.Where(p => p.Serijski_br == id).Select(p => p).FirstOrDefault();

			if (o == null) return new PokretniView();

			return new PokretniView(o);
		}

		public int AddPokretni(Pokretni p)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				s.Save(p);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception ec)
			{
				return -1;
			}
		}

		public int UpdatePokretni(int id, Pokretni p)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				Pokretni sis = s.Query<Pokretni>()
					.Where(po => po.Serijski_br == id).Select(o => o).FirstOrDefault();

				if (p.Tezina != 0)
					sis.Tezina = p.Tezina;

				//AlarmniSistem
				if (p.Proizvodjac != null)
					sis.Proizvodjac = p.Proizvodjac;
				if (p.Model != null)
					sis.Model = p.Model;
				if (p.Opis_servisiranja != null)
					sis.Opis_servisiranja = p.Opis_servisiranja;
				if (p.Tip != null)
					sis.Tip = p.Tip;
				if (p.Godina_proizvodnje != 0)
					sis.Godina_proizvodnje = p.Godina_proizvodnje;

				sis.Datum_Atesta = p.Datum_Atesta;
				sis.Datum_Poslednjeg_Servisiranja = p.Datum_Poslednjeg_Servisiranja;

				//s.SaveOrUpdate(upr);
				s.Save(sis);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception exc)
			{
				return -1;
			}

		}

		public int RemovePokretni(int id)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				Pokretni p = s.Load<Pokretni>(id);

				s.Delete(p);

				AlarmniSistem a = s.Load<AlarmniSistem>(id);

				s.Delete(a);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception exc)
			{
				return -1;
			}

		}

		#endregion

		#region AlarmniSistem:UltrazvucniCRUD

		public IList<UltrazvucniView> GetUltrazvucne()
		{
			ISession s = DataLayer.GetSession();

			IEnumerable<Ultrazvucni> sistemi = s.Query<Ultrazvucni>()
												//.Where(p => (p.Tip == "LUTKE" || p.Tip == "DODACI ZA LUTKE"))
												//.OrderBy(p => p.Tip).ThenBy(p => p.Naziv.Length)
												.Select(p => p);
			IList<UltrazvucniView> sistemiView = new List<UltrazvucniView>();

			foreach (Ultrazvucni o in sistemi)
			{
				sistemiView.Add(new UltrazvucniView(o));
			}
			return sistemiView;
		}

		public UltrazvucniView GetUltrazvucni(int id)
		{
			ISession s = DataLayer.GetSession();

			Ultrazvucni o = s.Query<Ultrazvucni>()
				.Where(p => p.Serijski_br == id).Select(p => p).FirstOrDefault();

			if (o == null) return new UltrazvucniView();

			return new UltrazvucniView(o);
		}

		public int AddUltrazvucni(Ultrazvucni p)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				s.Save(p);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception ec)
			{
				return -1;
			}
		}

		public int UpdateUltrazvucni(int id, Ultrazvucni p)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				Ultrazvucni sis = s.Query<Ultrazvucni>()
					.Where(po => po.Serijski_br == id).Select(o => o).FirstOrDefault();

				if (p.Frekvencija != 0)
					sis.Frekvencija = p.Frekvencija;

				//AlarmniSistem
				if (p.Proizvodjac != null)
					sis.Proizvodjac = p.Proizvodjac;
				if (p.Model != null)
					sis.Model = p.Model;
				if (p.Opis_servisiranja != null)
					sis.Opis_servisiranja = p.Opis_servisiranja;
				if (p.Tip != null)
					sis.Tip = p.Tip;
				if (p.Godina_proizvodnje != 0)
					sis.Godina_proizvodnje = p.Godina_proizvodnje;

				sis.Datum_Atesta = p.Datum_Atesta;
				sis.Datum_Poslednjeg_Servisiranja = p.Datum_Poslednjeg_Servisiranja;

				//s.SaveOrUpdate(upr);
				s.Save(sis);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception exc)
			{
				return -1;
			}

		}

		public int RemoveUltrazvucni(int id)
		{
			try
			{
				ISession s = DataLayer.GetSession();

				Ultrazvucni p = s.Load<Ultrazvucni>(id);

				s.Delete(p);

				AlarmniSistem a = s.Load<AlarmniSistem>(id);

				s.Delete(a);

				s.Flush();
				s.Close();

				return 1;
			}
			catch (Exception exc)
			{
				return -1;
			}

		}

		#endregion
	}
}
