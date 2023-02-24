/***********************************************************************
 * Module:  Pregled.cs
 * Purpose: Definition of the Class Model.Pregled
 ***********************************************************************/

using System;

namespace Model
{
   public class Pregled
   {
        public string ime_pacijenta { get; set; }
        public string prezime_pacijenta { get; set; }
        public string datum_pregleda { get; set; }
        public string vreme_pregleda { get; set; }
      
        public string lekar { get; set; }
      public Pregled()
        {

        }


      public Sekretar sekretar;
      public Pacijent pacijent;
      public Termin termin;
      public Recept[] recept;
      public Uputnica[] uputnica;
   
      private TipPregleda VrstaPregleda;
      private String PrioritetPriZakazivanjuPregleda;

        public String SetPrioritet()
        {
            // TODO: implement
            return null;
        }



    }
}