using System;

namespace Texfina.Core.Web
{
   public class SearchPage : PageBase
   {

      public void LoadData()
      {
         this.LoadListControls();
         this.RegisterGeneralScripts();
         this.SearchData();
         this.LockControls();
      }

      public virtual void SearchData()
      {
      }

   }
}
