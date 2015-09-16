using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;

namespace Texfina.Core.Web
{
   [ToolboxData("<{0}:esdButtonTextBox Runat=server></{0}:esdButtonTextBox>")]
   public class esdButtonTextBox : TextBox
   {

      [DefaultValue("")]
      public string OnClientClick
      {
         get
         {
            if (this.ViewState["_OnClientClick"] == null)
               return "";
            else
            {
               return this.ViewState["_OnClientClick"].ToString();
            }
         }
         set { this.ViewState["_OnClientClick"] = value; }
      }

      [DefaultValue(true)]
      public bool ShowButton
      {
         get
         {
            if (this.ViewState["_showButton"] == null)
               return true;
            else
               return Convert.ToBoolean(this.ViewState["_showButton"]);
         }
         set { this.ViewState["_showButton"] = value; }
      }

      [DefaultValue(true)]
      public bool EnabledButton
      {
         get
         {
            if (this.ViewState["_EnabledButton"] == null)
               return true;
            else
               return Convert.ToBoolean(this.ViewState["_EnabledButton"]);
         }
         set { this.ViewState["_EnabledButton"] = value; }
      }

      protected override void Render(System.Web.UI.HtmlTextWriter writer)
      {
         this.ReadOnly = true;
         if (this.ReadOnly == false)
            this.CssClass = "esdButtonTextBox";
         else
            this.CssClass = "esdButtonTextBoxDisabled";

         base.Render(writer);

         string strImgbtn = "esdtextbutton";
         string strbtn = "";
         if (!EnabledButton)
         {
            strbtn = "disabled=" + '"' + "true" + '"';
            strImgbtn = "esdtextbuttonDisabled";
         }
         if (ShowButton)
         {
            writer.Write("<div " + strbtn + " class=" + '"' + strImgbtn + '"' + " id=" + '"' + "" + ClientID + "_button" + '"');

            if (!string.IsNullOrEmpty(this.OnClientClick))
               writer.Write(" OnClick=" + '"' + OnClientClick + '"');

            writer.Write("></div>");

         }

      }

   }
}
