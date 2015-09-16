using System;
using System.Web.UI;

using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using System.IO;
using System.Reflection;
using Texfina.Core.Data;
using Texfina.Core.Common;
using System.Linq;
using System.Collections.Generic;

namespace Texfina.Core.Web
{
    public class WebHelper
    {

        public static bool IsDebug
        {
            get
            {
#if !Debug
                return false;
#else
         return true;
#endif
            }
        }
        //Incluida de Chio

        public static void LoadListControl2(DropDownList dp, object obj, string columnText, string columnValue)
        {
            try
            {

                dp.DataSource = obj;

                dp.DataTextField = columnText;

                dp.DataValueField = columnValue;

                dp.DataBind();
            }
            catch (Exception ex)
            { 
                
            }
        }
        //SYSTEM FORM
        public static void LoadListControl3(System.Windows.Forms.ComboBox dp, object obj)
        {
            try
            {
          
        
                dp.DataSource = obj;

                dp.DisplayMember = "desc";

                dp.ValueMember = "Id";

               
            }
            catch (Exception ex)
            {

            }
        }

      
        public static void LoadListControl4(System.Windows.Forms.ComboBox ctl, DataTable data, string columnText, string columnValue)
        {
            LoadListControl2(ctl, data, columnText, columnValue, false, false);
        }

        public static void LoadListControl(ListControl ctl, DataTable data, string columnText, string columnValue)
        {
            LoadListControl(ctl, data, columnText, columnValue, false, false);
        }

        public static void LoadListControl(ListControl ctl, DataTable data, string columnText, string columnValue, bool firstSelected)
        {
            LoadListControl(ctl, data, columnText, columnValue, firstSelected, false);
        }

        public static void LoadListControl(ListControl ctl, DataTable data, string columnText, string columnValue, bool firstSelected, bool firstEmptyItem)
        {
            if (firstEmptyItem)
                ctl.Items.Add(new ListItem("", ""));

            foreach (DataRow dr in data.Rows)
                ctl.Items.Add(new ListItem(dr[columnText].ToString(), dr[columnValue].ToString()));

            if (firstSelected & ctl.Items.Count > 0)
                ctl.SelectedIndex = 0;

        }
        public static void LoadListControl2(System.Windows.Forms.ComboBox ctl, DataTable data, string columnText, string columnValue, bool firstSelected, bool firstEmptyItem)
        {
            if (firstEmptyItem)
                ctl.Items.Add(new ListItem("", ""));

            foreach (DataRow dr in data.Rows)
                ctl.Items.Add(new ListItem(dr[columnText].ToString(), dr[columnValue].ToString()));

            if (firstSelected & ctl.Items.Count > 0)
                ctl.SelectedIndex = 0;

        }
        

        public static void LoadListControl(ListControl ctl, DataTable data, string columnText, string columnValue, bool firstSelected, bool firstEmptyItem, bool SortDescription)
        {
            if (firstEmptyItem)
                ctl.Items.Add(new ListItem("", ""));

            if (SortDescription)
                data.DefaultView.Sort = columnText;

            foreach (DataRow dr in data.Rows)
                ctl.Items.Add(new ListItem(dr[columnText].ToString(), dr[columnValue].ToString()));

            if (firstSelected & ctl.Items.Count > 0)
                ctl.SelectedIndex = 0;

        }

        public static void LoadListControl(ListControl ctl, DataTable data, string columnText, string columnValue, string customFirstItem)
        {
            ctl.Items.Add(new ListItem(customFirstItem, ""));

            foreach (DataRow dr in data.Rows)
                ctl.Items.Add(new ListItem(dr[columnText].ToString(), dr[columnValue].ToString()));

            if (ctl.Items.Count > 0)
                ctl.SelectedIndex = 0;

        }


        public static void LoadListControl(ListControl ctl, DataView data, string columnText, string columnValue, string customFirstItem)
        {
            ctl.Items.Add(new ListItem(customFirstItem, ""));

            foreach (DataRowView drv in data)
                ctl.Items.Add(new ListItem(drv[columnText].ToString(), drv[columnValue].ToString()));

            if (ctl.Items.Count > 0)
                ctl.SelectedIndex = 0;
        }

        public static void ListControlSetValue(ListControl ctl, string value)
        {
            ListItem objItm = ctl.Items.FindByValue(value);
            if (objItm == null)
                return;

            int intIdx = ctl.Items.IndexOf(objItm);
            ctl.SelectedIndex = intIdx;

        }

        public static void RedirectOnSessionTimeout(Page p)
        {
            StringBuilder sb = new StringBuilder();

            p.ClientScript.RegisterStartupScript(p.GetType(), "TimeoutScript", "redirectOnSessionTimeout(" + p.Session.Timeout.ToString() + ");", true);
        }

        public static object GetValueFromAttribute(IEntityBase entity, string attributeName)
        {
            Type typ = entity.GetType();

            PropertyInfo pi = typ.GetProperty(attributeName, BindingFlags.Public | BindingFlags.Instance);
            object objValue = pi.GetValue(entity, null);

            return objValue;

        }

        public static void EntityToControl(IEntityBase entity, string attributeName, Control ctl)
        {
            object objValue = GetValueFromAttribute(entity, attributeName);

            SetValueToControl(objValue, ctl);

        }

        public static void EntityToControl(IEntityBase entity, string attributeName, ListControl ctl)
        {
            object objValue = GetValueFromAttribute(entity, attributeName);

            ListControlSetValue(ctl, objValue.ToString());

        }

        public static void RowToControl(DataRow row, string colName, Control ctl)
        {
            object objValue = row[colName];

            SetValueToControl(objValue, ctl);

        }


        //public static void RowToControl(DataRow row, string colText, string colValue, Control ctl)
        //{
        //   SetTextValueToControl(row[colText].ToString(), row[colValue].ToString(), ctl);
        //}

        //public static void SetTextValueToControl(string text, string value, Control ctl)
        //{
        //   TextButton ctlTxt = CTypeDynamic<TextButton>(ctl);
        //   ctlTxt.SetTextValue(text, value);
        //}


        public static void SetValueToControl(object value, Control ctl)
        {
            if (value == null)
                return;
            if (ctl is HiddenField)
            {
                HiddenField objCtl = (HiddenField)ctl;
                objCtl.Value = value.ToString();
                return;
            }

            if (ctl is esdTextBox)
            {
                TextBox objCtl = (TextBox)ctl;
                objCtl.Text = value.ToString();
                return;
            }

            if (ctl is CheckBox)
            {
                CheckBox objCtl = (CheckBox)ctl;
                objCtl.Checked = (value.ToString() == ConstFlagEstado.ACTIVADO ? true : false);
                return;
            }

            if (ctl is esdMaskedTextBox)
            {
                esdMaskedTextBox objCtl = (esdMaskedTextBox)ctl;
                objCtl.Text = value.ToString();
                return;
            }

            if (ctl is esdNumericTextBox)
            {
                esdNumericTextBox objCtl = (esdNumericTextBox)ctl;
                objCtl.Value = value;
                return;
            }

            if (ctl is esdDateTextBox)
            {
                esdDateTextBox objCtl = (esdDateTextBox)ctl;
                if (value.ToString() != "")
                    objCtl.Text = DateTime.Parse(value.ToString()).ToShortDateString();
                return;
            }

            if (ctl is esdButtonTextBox)
            {
                esdButtonTextBox objCtl = (esdButtonTextBox)ctl;
                objCtl.Text = value.ToString();
                return;
            }

            if (ctl is DropDownList)
            {
                DropDownList objCtl = (DropDownList)ctl;
                ListControlSetValue(objCtl, value.ToString());
                return;
            }

        }


        public static void ControlToEntity(Control ctl, IEntityBase entity, string attributeName)
        {
            Type typ = entity.GetType();

            PropertyInfo pi = typ.GetProperty(attributeName, BindingFlags.Public | BindingFlags.Instance);
            object objValue = null;

            while (true)
            {

                if (ctl is DropDownList)
                {
                    objValue = ((DropDownList)ctl).SelectedItem.Value;
                    break;
                }

                if (ctl is HiddenField)
                {
                    objValue = ((HiddenField)ctl).Value;
                    break;
                }

                if (ctl is esdTextBox)
                {
                    objValue = ((TextBox)ctl).Text;
                    break;
                }

                if (ctl is CheckBox)
                {
                    CheckBox objCtl = (CheckBox)ctl;
                    objValue = objCtl.Checked ? ConstFlagEstado.ACTIVADO : ConstFlagEstado.DESACTIVADO;
                    break;
                }

                if (ctl is esdMaskedTextBox)
                {
                    objValue = ((esdMaskedTextBox)ctl).Text;
                    break;
                }

                if (ctl is esdNumericTextBox)
                {
                    objValue = ((esdNumericTextBox)ctl).Value;
                    break;
                }

                if (ctl is esdDateTextBox)
                {
                    objValue = DateTime.Parse(((esdDateTextBox)ctl).Text);
                    break;
                }

                break;
            }

            object objDefVal = pi.GetValue(entity, null);
            object objNewValue = DataHelper.ChangeType(objValue, pi.PropertyType, objDefVal);

            pi.SetValue(entity, objNewValue, null);

        }

        /// <summary>
        /// Executa el Render del GridView para generar el Codigo HTML
        /// </summary>
        /// <param name="grid">Grid</param>
        /// <returns></returns>
        /// <remarks></remarks>
        public static string GetHTMLGridView(GridView grid)
        {

            StringBuilder sb = new StringBuilder();
            StringWriter textwriter = new StringWriter(sb);
            HtmlTextWriter htmlwriter = new HtmlTextWriter(textwriter);
            grid.RenderControl(htmlwriter);
            htmlwriter.Flush();
            textwriter.Flush();
            htmlwriter.Dispose();
            textwriter.Dispose();

            return sb.ToString();

        }

    }
}