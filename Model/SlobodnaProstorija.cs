/***********************************************************************
 * Module:  SlobodnaProstorija.cs
 * Purpose: Definition of the Class Model.SlobodnaProstorija
 ***********************************************************************/

using System;

namespace Model
{
   public abstract class SlobodnaProstorija
   {
      public abstract void ZauzmiProstoriju(String oznakaProstorije);
      
      public abstract void RenovirajProstoriju(String oznakaProstorije, DateTime pocetakRenoviranja, DateTime krajRenoviranja);
   
   }
}