/***********************************************************************
 * Module:  ProstorijaRepository.cs
 * Purpose: Definition of the Class Repository.ProstorijaRepository
 ***********************************************************************/

using Model;
using Service;
using Controller;
using Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Repository
{
   public  class ProstorijaRepository
   {
      //Model.Prostorija   Prostorija;

      public  List<Prostorija> GetProstorije()
      {
            string line;
            List<Prostorija> lista_prostorija = new List<Prostorija>();
            string path = @"C:\Users\dejan\source\repos\WPFprojekatSIMS\WPFprojekatSIMS\Resursi\prostorije.csv";
            using(System.IO.StreamReader File = new System.IO.StreamReader(path))
            {
                while ((line = File.ReadLine()) != null)
                {
                    Prostorija prostorija = new Prostorija();
                    prostorija.id =line.Split(',')[0];
                    prostorija.nazivProstorije = line.Split(',')[1];
                    prostorija.pocetak_renoviranja =line.Split(',')[2];
                    prostorija.kraj_renoviranja = line.Split(',')[3];
                    prostorija.tip_renoviranja = line.Split(',')[4];
                    lista_prostorija.Add(prostorija);

                }    

            }
            return lista_prostorija;

        }

      



        public /*Prostorija*/void GetProstorija()
      {
         // TODO: implement
         //return null;
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

        public List<Prostorija> SetProstorija(String id_prostorije,String pocetak_ren,String kraj_renov,String tip_renov)
      {
            
            
            List<Prostorija> lista_prostorija = new List<Prostorija>();
            string path = @"C:\Users\dejan\source\repos\WPFprojekatSIMS\WPFprojekatSIMS\Resursi\prostorije.csv";

            var DataContext = File.ReadAllLines(path);
            Prostorija prostorija = new Prostorija();



           
           
            int br_reda_csv = -1; //pomocna promenljiva da znam u kom se redu nalazim
            foreach (var line in DataContext)
            {
                br_reda_csv += 1; // kad prvi put udje bice 0. red   
                if (line.Split(',')[0].Equals(id_prostorije))
                {
                    prostorija.id = line.Split(',')[0];
                    prostorija.nazivProstorije = line.Split(',')[1];
                    prostorija.pocetak_renoviranja = pocetak_ren;
                    prostorija.kraj_renoviranja = kraj_renov;
                    prostorija.tip_renoviranja = tip_renov;
                    lista_prostorija = GetProstorije(); //u povratnu vrednost fje ubacimo stari sadrzaj

                    lista_prostorija.RemoveAt(br_reda_csv); //prvo uklonimo staru vrednost
                    lista_prostorija.Insert(br_reda_csv, prostorija);
                    File.Delete(path);
                    pisi_u_csv(lista_prostorija, path);

                    lista_prostorija = GetProstorije();
                    break;
                }
                else 
                {
                    continue;
                }
            }
            return lista_prostorija;
        }


       

        public /*List<ZauzetostProstorije>*/void GetZauzeteTermine()
      {
         // TODO: implement
         //return null;
      }
   
   }
}