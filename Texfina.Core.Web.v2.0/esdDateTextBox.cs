using System;
using System.Web.UI;
using System.ComponentModel;
using System.Text;
using System.Web;
using System.Collections.Generic;

namespace Texfina.Core.Web
{
    [ToolboxData("<{0}:esdDateTextBox Runat=server></{0}:esdDateTextBox>")]
    public class esdDateTextBox : esdMaskedBase, IScriptControl
    {
        private ScriptManager sm;
        [DefaultValue(DateTimeType.Date)]
        public DateTimeType DateTimeType
        {
            get
            {
                if (ViewState["_dateType"] != null)
                    return (DateTimeType)ViewState["_dateType"];
                else
                    return DateTimeType.Date;
            }
            set { ViewState["_dateType"] = value; }
        }

        public Nullable<DateTime> DateMin
        {
            get
            {
                if (ViewState["_dateMin"] != null)
                    return (DateTime)ViewState["_dateMin"];
                else
                    return null;
            }
            set { ViewState["_dateMin"] = value; }
        }

        public Nullable<DateTime> DateMax
        {
            get
            {
                if (ViewState["_dateMax"] != null)
                    return (DateTime)ViewState["_dateMax"];
                else
                    return null;
            }
            set { ViewState["_dateMax"] = value; }
        }

        public string OnClientClickDay
        {
            get
            {
                if (ViewState["_fnScriptDay"] != null)
                    return (string)ViewState["_fnScriptDay"];
                else
                    return "";
            }
            set { ViewState["_fnScriptDay"] = value; }
        }

        public string OnClientClickButton
        {
            get
            {
                if (ViewState["_fnScriptbutton"] != null)
                    return (string)ViewState["_fnScriptbutton"];
                else
                    return "";
            }
            set { ViewState["_fnScriptbutton"] = value; }
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
                this.CssClass = "esdDateTextBox";
            else
                this.CssClass = "esdDateTextBoxDisabled";

            if (this.DateTimeType == DateTimeType.Date)
                this.Mask = "99/99/9999";
            else
            {
                //h = Horas [0-1]
                //t = minutos [0-5]
                this.Mask = "99/99/9999 h9:t9";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "ScriptMaskDate" + ClientID, "jQuery(function($){ $.mask.definitions['h']='[012]'; $.mask.definitions['t']='[012345]';});", true);
            }

            base.Render(writer);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("$(function() {$( " + '"' + "#" + ClientID + '"' + " ).datepicker({");

            if (this.DateMin != null)
                sb.AppendLine("minDate: new Date(" + this.DateMin.Value.Year + ", " + this.DateMin.Value.Month + " - 1, " + this.DateMin.Value.Day + " + 1),");

            if (this.DateMax != null)
                sb.AppendLine("maxDate: new Date(" + this.DateMax.Value.Year + ", " + this.DateMax.Value.Month + " - 1, " + this.DateMax.Value.Day + "),");

            string strImage = "";

            if (this.ReadOnly == true || this.Enabled == false)
                strImage = "../Images/Controls/calendarDisabled.gif";
            else
                strImage = "../Images/Controls/calendar.gif";

            sb.AppendLine("dateFormat: 'dd/mm/yy',changeMonth: true,changeYear: true ,showOn: " +
               '"' + "button" + '"' + ",buttonImage: " + '"' + strImage + '"' +
               ",buttonImageOnly: true,onSelect:function(dateText, inst) { if('" + this.Mask + "'=='99/99/9999 h9:t9'){this.value= dateText + ' 00:00';} ");

            if (this.OnClientClickDay != "")
                sb.AppendLine(this.OnClientClickDay);

            if (this.OnClientClickButton != "")
                sb.AppendLine("} }).click(function() { " + this.OnClientClickButton + "});;");
            else
                sb.AppendLine("} });");

            if (this.ReadOnly == true || this.Enabled == false)
                sb.AppendLine("$('#" + this.ClientID + "').datepicker('disable');");

            sb.AppendLine("});");

            ScriptManager.RegisterStartupScript(this, this.GetType(), "Scriptdate" + ClientID, sb.ToString(), true);
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Scriptdateval" + ClientID, "$(" + '"' + "#" + ClientID + '"' + ").bind(" + '"' + "blur" + '"' +
               ", function(e){ if(isValidDate(this.value,true)==false){this.value='';}});", true);

        }

        protected virtual IEnumerable<ScriptReference> GetScriptReferences()
        {
            ScriptReference referenceMask = new ScriptReference();
            referenceMask.Path = ResolveClientUrl("~/Scripts/jquery.maskedinput.min.js");

            ScriptReference reference = new ScriptReference();
            reference.Path = ResolveClientUrl("~/Scripts/jquery-ui.min.js");

            return new ScriptReference[] { referenceMask, reference };
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
