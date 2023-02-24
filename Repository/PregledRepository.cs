/***********************************************************************
 * Module:  PregledRepository.cs
 * Purpose: Definition of the Class Repository.PregledRepository
 ***********************************************************************/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Model;

namespace Repository
{
   public class PregledRepository
   {

        public String prolazak_kroz_lekare_i_termine(String vreme_pregleda)
        {
            string path_lekari_i_termini = @"C:\Users\dejan\source\repos\WPFprojekatSIMS\WPFprojekatSIMS\Resursi\lekari_i_termini.csv";
            String[] lekari_i_termini = File.ReadAllLines(path_lekari_i_termini);
            // int lekari_i_termini_broj_redova = File.ReadAllLines(path_lekari_i_termini).Length;
            String lekar = "";
            String[] trazeni_red;
            for(int i=1;i<lekari_i_termini.Length;i++)
            {
                trazeni_red = lekari_i_termini[i].Split(',');
                if (trazeni_red[1].Equals(vreme_pregleda))
                    lekar = trazeni_red[0];

            }
            return lekar;
        }

       


      public List<Pregled> SavePregled(String ime_pacijenta,String prezime_pacijenta,String datum_pregleda,String vreme_pregleda)
      {
            List<Pregled> lista_pregleda = new List<Pregled>();
            string path_pregledi = @"C:\Users\dejan\source\repos\WPFprojekatSIMS\WPFprojekatSIMS\Resursi\pregledi.csv";
            string lekar = prolazak_kroz_lekare_i_termine(vreme_pregleda);
           
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(path_pregledi, true))
                {
                        
                        file.WriteLine(ime_pacijenta + ',' + prezime_pacijenta + ',' + datum_pregleda + ',' + vreme_pregleda + ',' + lekar);
                        
                    
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Greska", ex);
            }
            lista_pregleda = GetPregledi(); //u povratnu vrednost fje ubacimo stari sadrzaj
            return lista_pregleda;
        }



        public List<Pregled> GetPregledi()
        {
            string line;
            List<Pregled> lista_pregleda = new List<Pregled>();
            string path = @"C:\Users\dejan\source\repos\WPFprojekatSIMS\WPFprojekatSIMS\Resursi\pregledi.csv";
            using (System.IO.StreamReader File = new System.IO.StreamReader(path))
            {
                while ((line = File.ReadLine()) != null)
                {
                    Pregled pregled = new Pregled();
                    pregled.ime_pacijenta = line.Split(',')[0];
                    pregled.prezime_pacijenta = line.Split(',')[1];
                    pregled.datum_pregleda= line.Split(',')[2];
                    pregled.vreme_pregleda = line.Split(',')[3];
                    pregled.lekar = line.Split(',')[4];
                    lista_pregleda.Add(pregled);


                }

            }
            return lista_pregleda;

        }


       

    }

   

}
