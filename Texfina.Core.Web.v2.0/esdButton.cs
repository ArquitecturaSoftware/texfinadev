using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Texfina.Core.Web
{
   [ToolboxData("<{0}:esdButton Runat=server></{0}:esdButton>")]
   public class esdButton : Button 
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
