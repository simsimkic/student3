/***********************************************************************
 * Module:  Bolnica.cs
 * Purpose: Definition of the Class Model.Bolnica
 ***********************************************************************/

using System;

namespace Model
{
   public class Bolnica
   {
      public System.Collections.ArrayList prostorija;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetProstorija()
      {
         if (prostorija == null)
            prostorija = new System.Collections.ArrayList();
         return prostorija;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetProstorija(System.Collections.ArrayList newProstorija)
      {
         RemoveAllProstorija();
         foreach (Prostorija oProstorija in newProstorija)
            AddProstorija(oProstorija);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddProstorija(Prostorija newProstorija)
      {
         if (newProstorija == null)
            return;
         if (this.prostorija == null)
            this.prostorija = new System.Collections.ArrayList();
         if (!this.prostorija.Contains(newProstorija))
         {
            this.prostorija.Add(newProstorija);
            newProstorija.SetBolnica(this);      
         }
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveProstorija(Prostorija oldProstorija)
      {
         if (oldProstorija == null)
            return;
         if (this.prostorija != null)
            if (this.prostorija.Contains(oldProstorija))
            {
               this.prostorija.Remove(oldProstorija);
               oldProstorija.SetBolnica((Bolnica)null);
            }
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllProstorija()
      {
         if (prostorija != null)
         {
            System.Collections.ArrayList tmpProstorija = new System.Collections.ArrayList();
            foreach (Prostorija oldProstorija in prostorija)
               tmpProstorija.Add(oldProstorija);
            prostorija.Clear();
            foreach (Prostorija oldProstorija in tmpProstorija)
               oldProstorija.SetBolnica((Bolnica)null);
            tmpProstorija.Clear();
         }
      }
      public Magacin magacin;
      public System.Collections.ArrayList zaposleni;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetZaposleni()
      {
         if (zaposleni == null)
            zaposleni = new System.Collections.ArrayList();
         return zaposleni;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetZaposleni(System.Collections.ArrayList newZaposleni)
      {
         RemoveAllZaposleni();
         foreach (Zaposleni oZaposleni in newZaposleni)
            AddZaposleni(oZaposleni);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddZaposleni(Zaposleni newZaposleni)
      {
         if (newZaposleni == null)
            return;
         if (this.zaposleni == null)
            this.zaposleni = new System.Collections.ArrayList();
         if (!this.zaposleni.Contains(newZaposleni))
         {
            this.zaposleni.Add(newZaposleni);
            newZaposleni.SetBolnica(this);      
         }
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveZaposleni(Zaposleni oldZaposleni)
      {
         if (oldZaposleni == null)
            return;
         if (this.zaposleni != null)
            if (this.zaposleni.Contains(oldZaposleni))
            {
               this.zaposleni.Remove(oldZaposleni);
               oldZaposleni.SetBolnica((Bolnica)null);
            }
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllZaposleni()
      {
         if (zaposleni != null)
         {
            System.Collections.ArrayList tmpZaposleni = new System.Collections.ArrayList();
            foreach (Zaposleni oldZaposleni in zaposleni)
               tmpZaposleni.Add(oldZaposleni);
            zaposleni.Clear();
            foreach (Zaposleni oldZaposleni in tmpZaposleni)
               oldZaposleni.SetBolnica((Bolnica)null);
            tmpZaposleni.Clear();
         }
      }
      public Upravnik upravnik;
   
      private String Mesto;
      private String Adresa;
      private String Naziv;
   
   }
}