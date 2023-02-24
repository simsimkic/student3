/***********************************************************************
 * Module:  LekRepository.cs
 * Purpose: Definition of the Class Repository.LekRepository
 ***********************************************************************/

using Model;
using System;
using System.Collections.Generic;

namespace Repository
{
   public class LekRepository
   {
      public /*Lek*/void GetLek(/*String sifraLeka*/)
      {
         // TODO: implement
         //return null;
      }
      
      public List<Lek> GetLekovi()
      {
            string line;
            List<Lek> lista_lekova = new List<Lek>();
            string path = @"C:\Users\dejan\source\repos\WPFprojekatSIMS\WPFprojekatSIMS\Resursi\lekovi.csv";
            using (System.IO.StreamReader File = new System.IO.StreamReader(path))
            {
                while ((line = File.ReadLine()) != null)
                {
                    Lek lek = new Lek();
                    lek.NazivLeka = line.Split(',')[0];
                    lek.Svojstva = line.Split(',')[1];
                    lek.Sifra = line.Split(',')[2];
                    lek.Sastojci = line.Split(',')[3];
                    lek.RokTrajanja = line.Split(',')[4];
                    lista_lekova.Add(lek);

                }

            }
            return lista_lekova;
        }
      
      public /*Lek*/void SetLek(/*Lek lek*/)
      {
         // TODO: implement
         //return null;
      }
      
      public /*List<String>*/void GetSastojciLeka()
      {
         // TODO: implement
         //return null;
      }
   
      public List<Lek> GetTrazeniLek(String naziv_unetog_leka)
        {
            string line;
            List<Lek> trazeni_lek = new List<Lek>();
            string path = @"C:\Users\dejan\source\repos\WPFprojekatSIMS\WPFprojekatSIMS\Resursi\lekovi.csv";
            using (System.IO.StreamReader File = new System.IO.StreamReader(path))
            {
                while ((line = File.ReadLine()) != null)
                {
                    if (line.Split(',')[0].Equals(naziv_unetog_leka))
                    {
                        Lek lek = new Lek();
                        lek.NazivLeka = line.Split(',')[0];
                        lek.Svojstva = line.Split(',')[1];
                        lek.Sifra = line.Split(',')[2];
                        lek.Sastojci = line.Split(',')[3];
                        lek.RokTrajanja = line.Split(',')[4];
                        trazeni_lek.Add(lek);
                    }

                }

            }
            return trazeni_lek;

        }
   }
}