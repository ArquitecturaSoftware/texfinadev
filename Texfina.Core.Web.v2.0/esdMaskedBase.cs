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
   public class esdMaskedBase : TextBox
   {
   
      [DefaultValue("")]
      public string Mask
      {
         get
         {
            if (this.ViewState["_mask"] == null)
               return "";
            else
               return this.ViewState["_mask"].ToString();
         }
         set { this.ViewState["_mask"] = value; }
      }

      protected override void Render(HtmlTextWriter writer)
      {
         //if (!this.DesignMode)
         //   sm.RegisterScriptDescriptors(this);
          
         if (this.ReadOnly == false)
            this.CssClass = "esdMaskedTextBox";
         else
            this.CssClass = "esdMaskedTextBoxDisabled";

         base.Render(writer);
         if (!string.IsNullOrEmpty(Mask))
         {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "ScriptMask" + ClientID, "jQuery(function ($) { $('#" + ClientID + "').mask(" + 
               '"' + Mask + '"' + "); });", true);
         }

      }

   }
}
