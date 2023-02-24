/***********************************************************************
 * Module:  ProstorijaSeRenovira.cs
 * Purpose: Definition of the Class Model.ProstorijaSeRenovira
 ***********************************************************************/

using System;

namespace Model
{
   public abstract class ProstorijaSeRenovira
   {
      public abstract void OslobodiProstoriju(String oznakaProstorije);
      
      public abstract void RenovirajProstoriju(String oznakaProstorije, DateTime pocetakRenoviranja, DateTime krajRenoviranja);
   
   }
}