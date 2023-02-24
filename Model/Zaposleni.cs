/***********************************************************************
 * Module:  Zaposleni.cs
 * Purpose: Definition of the Class Model.Zaposleni
 ***********************************************************************/

using System;

namespace Model
{
   public class Zaposleni : Korisnik
   {
      public RadnoVreme radnoVreme;
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
               oldBolnica.RemoveZaposleni(this);
            }
            if (newBolnica != null)
            {
               this.bolnica = newBolnica;
               this.bolnica.AddZaposleni(this);
            }
         }
      }
   
      private int Plata;
   
   }
}