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

		#region 

	}
}
