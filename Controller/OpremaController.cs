/***********************************************************************
 * Module:  OpremaController.cs
 * Purpose: Definition of the Class Controller.OpremaController
 ***********************************************************************/

using System;

namespace Controller
{
   public class OpremaController
   {
      public void PretrazivanjeOpreme()
      {
         // TODO: implement
      }
      
      public void ManipulisanjeZalihamaOpreme()
      {
         // TODO: implement
      }
      
      public void PremestanjeOpreme()
      {
         // TODO: implement
      }
   
      public System.Collections.ArrayList opremaService;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetOpremaService()
      {
         if (opremaService == null)
            opremaService = new System.Collections.ArrayList();
         return opremaService;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetOpremaService(/*System.Collections.ArrayList newOpremaService*/)
      {
       /*  RemoveAllOpremaService();
         foreach (OpremaService oOpremaService in newOpremaService)
            AddOpremaService(oOpremaService);*/
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddOpremaService(/*OpremaService newOpremaService*/)
      {
         /*if (newOpremaService == null)
            return;
         if (this.opremaService == null)
            this.opremaService = new System.Collections.ArrayList();
         if (!this.opremaService.Contains(newOpremaService))
            this.opremaService.Add(newOpremaService);*/
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveOpremaService(/*OpremaService oldOpremaService*/)
      {
         /*if (oldOpremaService == null)
            return;
         if (this.opremaService != null)
            if (this.opremaService.Contains(oldOpremaService))
               this.opremaService.Remove(oldOpremaService);*/
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllOpremaService()
      {
         /*if (opremaService != null)
            opremaService.Clear();*/
      }
   
   }
}