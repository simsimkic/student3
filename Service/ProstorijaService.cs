/***********************************************************************
 * Module:  ProstorijaService.cs
 * Purpose: Definition of the Class Controller.ProstorijaService
 ***********************************************************************/

using Model;
using Service;
using Controller;
using Repository;
using System;
using System.Windows.Documents;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Service
{
   public class ProstorijaService
   {
        //Model.Prostorija Prostorija;
      Repository.ProstorijaRepository prostorijaRepo;

      public ProstorijaService()
        {
            prostorijaRepo = new ProstorijaRepository();
        }
      public List<Prostorija> ZakaziRenoviranje(String oznakaProstorije, String pocetakRenoviranja, String krajRenoviranja,String tip_renoviranja)
      {
            List<Prostorija> lista_prostorija = new List<Prostorija>();
            lista_prostorija = prostorijaRepo.SetProstorija(oznakaProstorije,pocetakRenoviranja,krajRenoviranja,tip_renoviranja);
            return lista_prostorija;
        }
      
      public List<Prostorija> IzlistajSveProstorije()
      {
            List<Prostorija> lista_prostorija = new List<Prostorija>();
            lista_prostorija = prostorijaRepo.GetProstorije();
            return lista_prostorija;
      }
     
      public /*List<ZauzetostProstorije>*/void IzlistajZauzeteTermine(/*String oznakaProstorije*/)
      {
         // TODO: implement
         //return null;
      }
   
      //public ProstorijaRepository prostorijaRepository;
   
   }
}