using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Texfina.Core.Web
{
   [ToolboxData("<{0}:esdMenuToolBar Runat=server></{0}:esdMenuToolBar>")]
   public class esdMenuToolBar : Menu  
   {
      protected override void Render(HtmlTextWriter writer)
      {
         if (this.Enabled == true)
            this.CssClass = "esdButtonStyle";
         else
            this.CssClass = "esdButtonStyleDisabled";

         base.Render(writer);

      }
   }
}
