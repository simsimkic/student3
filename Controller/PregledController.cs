/***********************************************************************
 * Module:  PregledController.cs
 * Purpose: Definition of the Class Controller.PregledController
 ***********************************************************************/

using System;
using System.Collections.Generic;
using Model;
using Service;

namespace Controller
{
   public class PregledController
   {
        PregledService pregledService;
        public PregledController()
        {
            pregledService = new PregledService();
        }
      
        public List<Pregled> IzlistajPreglede()
        {
            List<Pregled> lista_pregleda = new List<Pregled>();
            lista_pregleda = pregledService.IzlistajPreglede();
            return lista_pregleda;
        }
        
        
        public /*Model.Pregled*/void OtkaziPregled()
      {
         // TODO: implement
         //return null;
      }
      
      public List<Pregled>  ZakaziPregled(String ime_pacijenta,String prezime_pacijenta,String datum_pregleda,String vreme_pregleda)
      {
            List<Pregled> lista_pregleda = new List<Pregled>();
            lista_pregleda = pregledService.ZakaziPregled(ime_pacijenta,prezime_pacijenta,datum_pregleda,vreme_pregleda);
            return lista_pregleda;
        }
   
     // public Service.PregledService pregledService;
   
   }
}