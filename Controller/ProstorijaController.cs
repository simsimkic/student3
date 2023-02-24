/***********************************************************************
 * Module:  ProstorijaController.cs
 * Purpose: Definition of the Class Controller.ProstorijaController
 ***********************************************************************/

using Model;
using Service;
using Controller;
using Repository;
using System;
using System.Collections.Generic;
using System.Windows.Documents;


namespace Controller
{
   public class ProstorijaController
   {
      //Model.Prostorija Prostorija;
      ProstorijaService prostorijaService;
      public ProstorijaController()
        {
            prostorijaService = new ProstorijaService();
        }
      public List<Prostorija> ZakaziRenoviranje(String oznakaProstorije, String pocetakRenoviranja, String krajRenoviranja,String tip_renoviranja)
      {
            List<Prostorija> lista_prostorija = new List<Prostorija>();
            lista_prostorija = prostorijaService.ZakaziRenoviranje(oznakaProstorije,pocetakRenoviranja,krajRenoviranja,tip_renoviranja);
            return lista_prostorija;
        }
      
      public List<Prostorija> IzlistajSveProstorije()
      {
            List<Prostorija> lista_prostorija = new List<Prostorija>();
            lista_prostorija = prostorijaService.IzlistajSveProstorije();
            return lista_prostorija ;
      }
      
      public /*List<ZauzetostProstorije>*/void IzlistajZauzeteTermine(String oznakaProstorije)
      {
         // TODO: implement
         //return null;
      }
   
     // public ProstorijaService prostorijaService;
   
   }
}