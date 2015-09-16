using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;

namespace Texfina.Core.Web
{
   [ToolboxData("<{0}:esdGridView Runat=server></{0}:esdGridView>")]
   public class esdGridView : GridView
   {

      [DefaultValue(true)]
      public bool Scrollable
      {
         get
         {
            if (this.ViewState["_scrollEnable"] == null)
               return true;
            else
               return Convert.ToBoolean(this.ViewState["_scrollEnable"]);
         }
         set { this.ViewState["_scrollEnable"] = value; }
      }

      [DefaultValue("250px")]
      public string ScrollHeight
      {
         get
         {
            if (this.ViewState["_scrollheight"] == null)
               return "250px";
            else
               return this.ViewState["_scrollheight"].ToString();
         }
         set { this.ViewState["_scrollheight"] = value; }
      }

      [DefaultValue("100%")]
      public string ScrollWidth
      {
         get
         {
            if (this.ViewState["_scrollwidth"] == null)
               return "100%";
            else
               return this.ViewState["_scrollwidth"].ToString();
         }
         set { this.ViewState["_scrollwidth"] = value; }
      }

      protected override void Render(System.Web.UI.HtmlTextWriter writer)
      {

         if (this.RowStyle.CssClass == "")
            this.RowStyle.CssClass = "esdGridRowStyle";
         if (this.SelectedRowStyle.CssClass == "")
            this.SelectedRowStyle.CssClass = "esdGridSelectedRowStyle";
         if (this.PagerStyle.CssClass == "")
            this.PagerStyle.CssClass = "gridPagerStyle";
         if (this.HeaderStyle.CssClass == "")
            this.HeaderStyle.CssClass = "esdGridHeaderStyle";
         if (this.AlternatingRowStyle.CssClass == "")
            this.AlternatingRowStyle.CssClass = "esdGridAlternativeRowStyle";
         this.GridLines = GridLines.None;
         this.CellPadding = 0;
         this.CellPadding = 0;

         if (this.Rows.Count > 0)
         {
            this.UseAccessibleHeader = true;
            this.HeaderRow.TableSection = TableRowSection.TableHeader;
         }

         if (this.Scrollable)
         {
            writer.Write("<div id='" + this.ClientID + "_ScrollArea' style='overflow: auto; width: " + this.ScrollWidth + "; height: " + this.ScrollHeight + "'>");
            base.Render(writer);
            writer.Write("</div>");
         }
         else
         {
            base.Render(writer);
         }

      }

   }
}
