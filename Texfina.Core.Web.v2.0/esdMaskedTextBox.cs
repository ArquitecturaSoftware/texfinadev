using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;
using System.ComponentModel; 

namespace Texfina.Core.Web
{
   [ToolboxData("<{0}:esdMaskedTextBox Runat=server></{0}:esdMaskedTextBox>")]
   public class esdMaskedTextBox : esdMaskedBase, IScriptControl
   {
      private ScriptManager sm;
                
      protected override void OnPreRender(EventArgs e)
      {
         if (!this.DesignMode)
         {
            // Test for ScriptManager and register if it exists
            sm = ScriptManager.GetCurrent(Page);

            if (sm == null)
               throw new HttpException("A ScriptManager control must exist on the current page.");

            sm.RegisterScriptControl(this);
         }

         base.OnPreRender(e);
      }
      
      protected virtual IEnumerable<ScriptReference> GetScriptReferences()
      {
         ScriptReference reference = new ScriptReference();
         reference.Path = ResolveClientUrl("~/Scripts/jquery.maskedinput.min.js");
         
         return new ScriptReference[] { reference };
      }

      protected virtual IEnumerable<ScriptDescriptor> GetScriptDescriptors()
      {
         return null; 
      }

      IEnumerable<ScriptReference> IScriptControl.GetScriptReferences()
      {
         return GetScriptReferences();
      }

      IEnumerable<ScriptDescriptor> IScriptControl.GetScriptDescriptors()
      {
         return GetScriptDescriptors();
      }

   }
}
