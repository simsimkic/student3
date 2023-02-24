/***********************************************************************
 * Module:  Pacijent.cs
 * Purpose: Definition of the Class Model.Pacijent
 ***********************************************************************/

using System;

namespace Model
{
   public class Pacijent : Korisnik
   {
      public string ime_pacijenta { get; set; }
      public string prezime_pacijenta { get; set; }
        public String vremeoperacije { get; set; }
        public String datumoperacije { get; set; }
        public String oznaka { get; set; }


        public Pacijent() { }

        public void SamostalnaRegistracija()
      {
         // TODO: implement
      }
      
      public void PregledaProfilLekara()
      {
         // TODO: implement
      }
   
      public Pregled[] pregled;
      public Karton karton;
   
      public String Adresa;
      public DateTime DatumRodjenja;
      public long Jmbg;
   
   }
}