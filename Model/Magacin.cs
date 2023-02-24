/***********************************************************************
 * Module:  Magacin.cs
 * Purpose: Definition of the Class Model.Magacin
 ***********************************************************************/

using System;

namespace Model
{
   public class Magacin
   {
      public static /*Magacin*/ void getInstance()
      {
          /*  if (instance == NULL) {
               instance = new Magacin();
               return instance;
            }*/
      
      }
   
      private Magacin()
      {}
   
      public System.Collections.ArrayList oprema;
      public System.Collections.ArrayList lek;
      public Bolnica bolnica;
   
      /// singleton klasa pa dodajemo ovo
      private static Magacin instance;
   
   }
}