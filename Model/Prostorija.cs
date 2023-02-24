/***********************************************************************
 * Module:  Prostorija.cs
 * Purpose: Definition of the Class Model.Prostorija
 ***********************************************************************/

using System;

namespace Model
{
   public class Prostorija
   {
        public string id { get; set; }

        public string nazivProstorije { get; set; }

        public string pocetak_renoviranja { get; set; }

        public string kraj_renoviranja { get; set; }

        public string tip_renoviranja { get; set; }

        public /*Prostorija*/ Prostorija()
      {
         // TODO: implement
         //return null;
      }
      
      public void PromeniStanje(String stanjeProstorije)
      {
         // TODO: implement
      }
   
      public Bolnica bolnica;
      
      /// <pdGenerated>default parent getter</pdGenerated>
      public Bolnica GetBolnica()
      {
         return bolnica;
      }
      
      /// <pdGenerated>default parent setter</pdGenerated>
      /// <param>newBolnica</param>
      public void SetBolnica(Bolnica newBolnica)
      {
         if (this.bolnica != newBolnica)
         {
            if (this.bolnica != null)
            {
               Bolnica oldBolnica = this.bolnica;
               this.bolnica = null;
               oldBolnica.RemoveProstorija(this);
            }
            if (newBolnica != null)
            {
               this.bolnica = newBolnica;
               this.bolnica.AddProstorija(this);
            }
         }
      }
      public ZauzetostProstorije[] zauzetostProstorije;
   
      private TipProstorije NamenaProstorije;
      private String Oznaka;
      //private List<ZauzetostProstorije> ListaZauzetostiProstorije;
      //private StanjeProstorije StanjeProstorije;
   
   }
}