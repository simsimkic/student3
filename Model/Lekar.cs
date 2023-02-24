/***********************************************************************
 * Module:  Lekar.cs
 * Purpose: Definition of the Class Model.Lekar
 ***********************************************************************/

using System;

namespace Model
{
   public class Lekar : Zaposleni
   {
      public void PristupanjeProfiluPacijenta()
      {
         // TODO: implement
      }
      
      public void IzdajeUputnicu()
      {
         // TODO: implement
      }
      
      public void IzdajeRecept()
      {
         // TODO: implement
      }
      
      public void PregledProstorija()
      {
         // TODO: implement
      }
      
      public void PregledRasporeda()
      {
         // TODO: implement
      }
   
      public IzvestajLekar[] izvestajLekar;
      public Pregled[] pregled;
   
      private String Specijalizacija;
      private String Biografija;
   
   }
}