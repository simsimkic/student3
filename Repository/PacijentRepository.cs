/***********************************************************************
 * Module:  PacijentRepository.cs
 * Purpose: Definition of the Class Repository.PacijentRepository
 ***********************************************************************/

using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Repository
{
   public class PacijentRepository
   {
      public /*Model.Pacijent*/void GetPacijent()
      {
         // TODO: implement
         //return null;
      }

        public List<Feedback> GetKomentari()
        {
            string line;
            List<Feedback> lista_komentara = new List<Feedback>();
            string path = @"C:\Users\dejan\source\repos\WPFprojekatSIMS\WPFprojekatSIMS\Resursi\komentari.csv";
            using (System.IO.StreamReader File = new System.IO.StreamReader(path))
            {
                while ((line = File.ReadLine()) != null)
                {
                    Feedback feedback = new Feedback();
                    feedback.komentar = line.Split(',')[0];
                    feedback.korisnik = line.Split(',')[1];
                    lista_komentara.Add(feedback);


                }

            }
            return lista_komentara;

        }


        public List<Feedback> AddKomentar(String uneti_komentar)
        {
            List<Feedback> lista_komentara = new List<Feedback>();
            string path_komentari = @"C:\Users\dejan\source\repos\WPFprojekatSIMS\WPFprojekatSIMS\Resursi\komentari.csv";

            

            string ime_prezime_ulogovanog = GetTrenutnoUlogovaniKorisnik();
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(path_komentari, true))
                {

                    file.WriteLine(uneti_komentar + ',' + ime_prezime_ulogovanog);


                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Greska", ex);
            }
            lista_komentara = GetKomentari(); //u povratnu vrednost fje ubacimo stari sadrzaj
            return lista_komentara;
        }


        public String GetUlogovaniKorisnik()
        {
            string path_login = @"C:\Users\dejan\source\repos\WPFprojekatSIMS\WPFprojekatSIMS\Resursi\login.csv";

            using (StreamReader sr = File.OpenText(path_login))
            {
                string loggedIdText = sr.ReadLine();

                loggedIdText = loggedIdText.Split(',')[0] + ' ' + loggedIdText.Split(',')[1];
                return loggedIdText;
            }
        }


        public String GetTrenutnoUlogovaniKorisnik()
        {
            string path_login = @"C:\Users\dejan\source\repos\WPFprojekatSIMS\WPFprojekatSIMS\Resursi\trenutno_ulogovani.csv";

            using (StreamReader sr = File.OpenText(path_login))
            {
                string loggedIdText = sr.ReadLine();

                loggedIdText = loggedIdText.Split(',')[0] + ' ' + loggedIdText.Split(',')[1];
                return loggedIdText;
            }
        }

        public  void DodajPacijenta_u_trenutno_ulogovane(String korisnicko, String lozinka, String filepath)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filepath, true))
                {
                    file.WriteLine(korisnicko + ',' + lozinka);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Greska", ex);
            }
        }

        public void ObrisiTrenutnoUlogovani()
        {
            File.Delete(path_trenutni_login_csv);
        }



        public static void DodajPacijenta_u_login(String korisnicko, String lozinka, String uloga, String filepath)
          {
              try
              {
                  using (System.IO.StreamWriter file = new System.IO.StreamWriter(filepath, true))
                  {
                      file.WriteLine(korisnicko + ',' + lozinka + ',' + uloga);
                  }
              }
              catch (Exception ex)
              {
                  throw new ApplicationException("Greska", ex);
              }
          }

          public static void DodajPacijenta_u_pacijente(String ime, String prezime, String mail, String korisnicko, String lozinka, String uloga, String filepath)
          {
              try
              {
                  using (System.IO.StreamWriter file = new System.IO.StreamWriter(filepath, true))
                  {
                      file.WriteLine(ime + ',' + prezime + ',' + mail + ',' + korisnicko + ',' + lozinka +  ',' + uloga);
                  }
              }
              catch (Exception ex)
              {
                  throw new ApplicationException("Greska", ex);
              }
          }


        string path_login_csv = @"C:\Users\dejan\source\repos\WPFprojekatSIMS\WPFprojekatSIMS\Resursi\login.csv";
        string path_trenutni_login_csv = @"C:\Users\dejan\source\repos\WPFprojekatSIMS\WPFprojekatSIMS\Resursi\trenutno_ulogovani.csv";
        string path_pacijenti_csv = @"C:\Users\dejan\source\repos\WPFprojekatSIMS\WPFprojekatSIMS\Resursi\pacijenti.csv";
        string uloga_tek_regist_kor = "pacijent";
        string path_reg_pacijenti_csv = @"C:\Users\dejan\source\repos\WPFprojekatSIMS\WPFprojekatSIMS\Resursi\registrovaniPacijenti.csv";


        public static void dodaj_lozinku_u_csv( String lozinka, String filepath)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filepath, true))
                {
                    
                    file.WriteLine( lozinka + ',');
                    
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Greska", ex);
            }
        }
        public void SetPacijent(String ime, String prezime, String email, String korisnicko_ime, String lozinka)
      {
             DodajPacijenta_u_login(korisnicko_ime, lozinka, uloga_tek_regist_kor, path_login_csv);
             DodajPacijenta_u_pacijente(ime, prezime, email, korisnicko_ime, lozinka, uloga_tek_regist_kor, path_pacijenti_csv);
            DodajPacijentaUreg(ime, prezime, path_reg_pacijenti_csv);

        }



        public static void DodajPacijentaUreg(String ime, String prezime, String filepath)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filepath, true))
                {
                    file.WriteLine(ime + ',' + prezime + ',' + ',' + ',');
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Greska", ex);
            }
        }


        public List<Pacijent> GetPacijenti()
        {
            string line;
            List<Pacijent> lista_pacijenata = new List<Pacijent>();
            string path = @"C:\Users\dejan\source\repos\WPFprojekatSIMS\WPFprojekatSIMS\Resursi\registrovaniPacijenti.csv";
            using (System.IO.StreamReader File = new System.IO.StreamReader(path))
            {
                while ((line = File.ReadLine()) != null)
                {
                    Pacijent pacijent = new Pacijent();
                    pacijent.ime_pacijenta = line.Split(',')[0];
                    pacijent.prezime_pacijenta = line.Split(',')[1];
                    pacijent.vremeoperacije = line.Split(',')[2];
                    pacijent.datumoperacije = line.Split(',')[3];
                    pacijent.oznaka = line.Split(',')[4];


                    lista_pacijenata.Add(pacijent);

                }

            }
            return lista_pacijenata;

        }

        public List<Pacijent> SetPacijente(String ime, String prezime, String datumoperacije, String vremeoperacije, String oznaka)
        {


            List<Pacijent> lista_pacijenata = new List<Pacijent>();
            string path = @"C:\Users\dejan\source\repos\WPFprojekatSIMS\WPFprojekatSIMS\Resursi\registrovaniPacijenti.csv";

            var DataContext = File.ReadAllLines(path);
            Pacijent pacijent = new Pacijent();

            int br_reda_csv = -1; //pomocna promenljiva da znam u kom se redu nalazim
            foreach (var line in DataContext)
            {
                br_reda_csv += 1; // kad prvi put udje bice 0. red   
                if (line.Split(',')[0].Equals(ime))
                {
                    pacijent.ime_pacijenta = line.Split(',')[0];
                    pacijent.prezime_pacijenta = line.Split(',')[1];
                    pacijent.datumoperacije = datumoperacije;
                    pacijent.vremeoperacije = vremeoperacije;
                    pacijent.oznaka = oznaka;
                    lista_pacijenata = GetPacijenti(); //u povratnu vrednost fje ubacimo stari sadrzaj

                    lista_pacijenata.RemoveAt(br_reda_csv); //prvo uklonimo staru vrednost
                    lista_pacijenata.Insert(br_reda_csv, pacijent);
                    File.Delete(path);
                    pisi_u_csv(lista_pacijenata, path);

                    lista_pacijenata = GetPacijenti();
                    break;
                }
                else
                {
                    continue;
                }
            }
            return lista_pacijenata;
        }

        public void pisi_u_csv<T>(IEnumerable<T> items, string path) //pomocna funkcija za upis liste objekata u csv fajl
        {
            Type itemType = typeof(T);
            var props = itemType.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            using (var writer = new StreamWriter(path))
            {
                // writer.WriteLine(string.Join(", ", props.Select(p => p.Name)));

                foreach (var item in items)
                {
                    writer.WriteLine(string.Join(",", props.Select(p => p.GetValue(item, null))));
                }
            }
        }



        //private String Path;

    }
}