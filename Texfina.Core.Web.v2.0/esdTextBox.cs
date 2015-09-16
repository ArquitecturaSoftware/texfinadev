using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Texfina.Core.Web
{
   [ToolboxData("<{0}:esdTextBox Runat=server></{0}:esdTextBox>")]
   public class esdTextBox : TextBox
   {
      protected override void Render(HtmlTextWriter writer)
      {
         if (this.ReadOnly == false)
            this.CssClass = "esdTextBox";

         else
            this.CssClass = "esdTextBoxDisabled";

         base.Render(writer);
      }
   }
}
