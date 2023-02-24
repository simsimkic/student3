/***********************************************************************
 * Module:  LekController.cs
 * Purpose: Definition of the Class Controller.LekController
 ***********************************************************************/

using Model;
using Service;
using System;
using System.Collections.Generic;

namespace Controller
{
   public class LekController
   {

        LekService lekService;

        public LekController()
        {
            lekService = new LekService();
        }

        public List<Lek> PronadjiLek(String naziv_unetog_leka)
        {
            List<Lek> pronadjeni_lek = new List<Lek>();
            pronadjeni_lek = lekService.PronadjiLek(naziv_unetog_leka);
            return pronadjeni_lek;
        }

        public /*Lek*/void DodajLek(/*Model.Lek lek*/)
      {
         // TODO: implement
         //return null;
      }

        public List<Lek> IzlistajLekove()
        {

            List<Lek> lista_lekova = new List<Lek>();
            lista_lekova = lekService.IzlistajLekove();
            return lista_lekova;

        }

        public Model.Lek PrikaziLekoveZaOdobravanje()
      {
         // TODO: implement
         return null;
      }
      
      public /*List<Lek>*/void ManipulisanjeZalihamaLekova()
      {
         // TODO: implement
         //return null;
      }
      
      public /*Model.Lek*/void RegistracijaNovogLeka(/*Model.Lek lek*/)
      {
         // TODO: implement
         //return null;
      }
   
      //public LekService lekService;
   
   }
}