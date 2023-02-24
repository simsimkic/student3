/***********************************************************************
 * Module:  LekService.cs
 * Purpose: Definition of the Class Service.LekService
 ***********************************************************************/

using Model;
using Repository;
using System;
using System.Collections.Generic;

namespace Service
{
   public class LekService
   {
        LekRepository lekRepository;

        public LekService()
        {
            lekRepository = new LekRepository();
        }

        public List<Lek> PronadjiLek(String naziv_unetog_leka)
        {
            List<Lek> pronadjeni_lek = new List<Lek>();
            pronadjeni_lek = lekRepository.GetTrazeniLek(naziv_unetog_leka);
            return pronadjeni_lek;
        }

        public /*Model.Lek*/void RegistracijaNovogLeka(/*Model.Lek lek*/)
      {
         // TODO: implement
         //return null;
      }
      
      public /*List<Lek>*/void ManipulisanjeZalihamaLekova()
      {
         // TODO: implement
         //return null;
      }
      
      public /*Lek*/void DodajLek(/*Model.Lek lek*/)
      {
         // TODO: implement
         //return null;
      }

        public List<Lek> IzlistajLekove()
        {
            List<Lek> lista_lekova = new List<Lek>();
            lista_lekova = lekRepository.GetLekovi();
            return lista_lekova;
        }

        public /*Model.Lek*/void PrikaziLekoveZaOdobravanje()
      {
         // TODO: implement
         //return null;
      }
   
      //public LekRepository lekRepository;
   
   }
}