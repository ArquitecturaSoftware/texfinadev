using System;
using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Web;
using System.Collections.Generic;

namespace Texfina.Core.Web
{
   [ToolboxData("<{0}:esdNumericTextBox Runat=server></{0}:esdNumericTextBox>")]
   public class esdNumericTextBox : TextBox, IScriptControl
   {
      private ScriptManager sm;
      [DefaultValue(NumericType.Integer)]
      public NumericType NumericType
      {
         get
         {
            if (this.ViewState["_numType"] == null)
               return NumericType.Integer;
            else
               return (NumericType)this.ViewState["_numType"];
         }
         set { this.ViewState["_numType"] = value; }
      }

      [DefaultValue(2)]
      public int DecimalPlaces
      {
         get
         {
            if (this.ViewState["_decPlace"] == null)
               return 2;
            else
               return Convert.ToInt32(this.ViewState["_decPlace"]);
         }
         set { this.ViewState["_decPlace"] = value; }
      }

      [DefaultValue(0), Browsable(false)]
      public object Value
      {
         get
         {
            if (this.Text == "")
            {
               if (this.NumericType == NumericType.Integer)
                  this.Text = "0";
               else
               {
                  this.Text = "0." + new string('0', this.DecimalPlaces);
               }
            }

            if (this.NumericType == NumericType.Integer)
               return Convert.ToInt32(this.Text);
            else
               return Convert.ToDecimal(this.Text);
         }
         set
         {
            if (this.NumericType == NumericType.Integer)
            {
               int intVal = Convert.ToInt32(value);

               this.Text = intVal.ToString();
            }
            else
            {
               decimal decVal = Convert.ToDecimal(value);
               this.Text = decVal.ToString("0." + new string('0', this.DecimalPlaces));
            }
         }
      }
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

      protected override void Render(System.Web.UI.HtmlTextWriter writer)
      {
         if (this.ReadOnly == false)
            this.CssClass = "esdNumericTextBox";
         else
            this.CssClass = "esdNumericTextBoxDisabled";

         if (string.IsNullOrEmpty(this.Text))
            this.Value = 0;

         this.Style.Add("text-align", "right");

         base.Render(writer);

         StringBuilder sb = new StringBuilder();
         sb.AppendLine("$('#" + this.ClientID + "').limitkeypress(");

         if (this.NumericType == NumericType.Integer)
            sb.AppendLine("{ rexp: /^[-+]?\\d*$/ }");
         else
            sb.AppendLine("{ rexp: /^[-+]?\\d*\\.?\\d{0," + this.DecimalPlaces + "}$/ }");

         sb.AppendLine(");");
         if (this.NumericType == NumericType.Decimal)
         {
            sb.AppendLine("$(" + '"' + "#" + this.ClientID + '"' + ").bind(" + '"' + "blur" + '"' + 
               ", function(e){if(this.value.substring(this.value.length-1, this.value.length)=='.')this.value=this.value+'" + new string('0', this.DecimalPlaces) + 
               "';else if(this.value.indexOf(" + '"' + "." + '"' + ")==-1)this.value = this.value+'." + new string('0', this.DecimalPlaces) + "';});");
         }

         sb.AppendLine("$(" + '"' + "#" + this.ClientID + '"' + ").bind(" + '"' + "focus" + '"' + ",function(e){ document.getElementById('" + this.ClientID + "').select();});");

         ScriptManager.RegisterStartupScript(this, this.GetType(), "ScriptNum" + ClientID, sb.ToString(), true);

      }
      protected virtual IEnumerable<ScriptReference> GetScriptReferences()
      {
         ScriptReference reference = new ScriptReference();
         reference.Path = ResolveClientUrl("~/Scripts/jquery.numeric.js");

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
