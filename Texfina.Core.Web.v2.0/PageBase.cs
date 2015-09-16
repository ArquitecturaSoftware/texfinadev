using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.IO;
using Texfina.Core.Common;
using System.Collections.Generic;

namespace Texfina.Core.Web
{
   public class PageBase : Page
   {
       private List<string> _ResultCallback = new List<string>();
       /// <summary>
       /// Guarda el estado de un DataTable, se usa unicamente cuando la pagina tiene un GridView
       /// </summary>
       /// <value></value>
       /// <returns></returns>
       /// 
       /// 
      /// <summary>
      /// Guarda el estado de un DataTable, se usa unicamente cuando la pagina tiene un GridView
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      public DataTable DataSource
      {
         get { return (DataTable)this.ViewState["_ds"]; }
         set { this.ViewState["_ds"] = value; }
      }

      /// <summary>
      /// Guarda el Indice del Registro en Edicion en un GridView
      /// </summary>
      /// <value></value>
      /// <returns></returns>
      public int EditRowIndex
      {
         get { return Convert.ToInt32(this.ViewState["_erowIdx"]); }
         set { this.ViewState["_erowIdx"] = value.ToString(); }
      }

      public virtual void RegisterGeneralScripts()
      {
      }

      public virtual void LoadInitialSettings()
      {
      }

      public virtual void LoadListControls()
      {
      }

      public virtual void DataToControls()
      {
      }

      public virtual void LockControls()
      {
      }

      public virtual void LoadInPostBack()
      {
      }

      /// <summary>
      /// Si el DataTable esta vacio, le agrega un registro en blanco
      /// </summary>
      /// <param name="data"></param>
      public DataTable CreateEmptyData(DataTable data)
      {

         if (data.Rows.Count == 0)
         {
            DataRow dr = data.NewRow();
            data.Rows.Add(dr);
         }

         return data;
      }

      /// <summary>
      /// Enlaza un Datatable a un GridView
      /// </summary>
      /// <param name="grid"></param>
      /// <param name="data"></param>
      public void GridSetDataBinding(GridView grid, DataTable data)
      {
         grid.DataSource = data;
         grid.DataBind();

         this.DataSource = data;
      }

      /// <summary>
      /// Crea un mensaje que se mostrara en el Postback
      /// </summary>
      /// <param name="msgType"></param>
      /// <param name="msg"></param>
      /// <param name="url"></param>
      /// <returns></returns>
      public string CreatePostbackMessage(int msgType, string msg, string url)
      {
         return msgType.ToString() + ";" + msg + ";" + url;
      }

      /// <summary>
      /// Obtiene un DataRow en base a los DataKeyNames definidos en un GridView
      /// </summary>
      /// <param name="data"></param>
      /// <param name="grid"></param>
      /// <returns></returns>
      /// <remarks></remarks>
      public DataRow GridGetRowFromDataKey(DataTable data, GridView grid, int rowIndex)
      {

         StringBuilder sb = new StringBuilder();
         int intKey = 0;

         if (rowIndex == -1)
            return null;

         for (intKey = 0; intKey <= grid.DataKeyNames.Length - 1; intKey++)
         {
            object obj = grid.DataKeys[rowIndex].Values[intKey];
            sb.Append(grid.DataKeyNames[intKey]);

            if(obj.GetType() == typeof(string))
               sb.Append(" = '" + obj.ToString() + "'");
            else
               sb.Append(" = " + obj.ToString());

            if (intKey < grid.DataKeyNames.Length - 1)
               sb.Append(" AND ");
         }

         DataRow[] drArr = data.Select(sb.ToString());
         DataRow dr = null;

         if (drArr.Length > 0)
            dr = drArr[0];

         return dr;
      }

      /// <summary>
      /// Obtiene un DataRow en base a los DataKeyNames definidos en un GridView
      /// </summary>
      /// <param name="grid"></param>
      /// <returns></returns>
      /// <remarks></remarks>
      public DataRow GridGetRowFromDataKey(GridView grid, int rowIndex)
      {

         return GridGetRowFromDataKey(this.DataSource, grid, rowIndex);
      }

      /// <summary>
      /// Registra javascript evaluando si esta en una llamada asincrona o no
      /// </summary>
      /// <param name="key"></param>
      /// <param name="script"></param>
      public void CustomRegisterStartupScript(string key, string script, bool forceSync)
      {
         ScriptManager scriptMngr = ScriptManager.GetCurrent(this.Page);

         if (forceSync)
         {
            this.Page.ClientScript.RegisterStartupScript(Page.GetType(), key, script, true);
            return;
         }

         if ((scriptMngr != null) & scriptMngr.IsInAsyncPostBack)
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), key, script, true);
         else
            this.Page.ClientScript.RegisterStartupScript(Page.GetType(), key, script, true);

      }

      public void CustomRegisterStartupScript(string key, string script)
      {
         CustomRegisterStartupScript(key, script, false);
      }

      public void WriteTraceLog(string contents)
      {
         string strPath = "";
#if DEBUG
         strPath = AppDomain.CurrentDomain.RelativeSearchPath.Replace("\\bin", "\\Logs");
#else
		   strPath = AppHelper.DirectoryName;
#endif

         File.AppendAllText(Path.Combine(strPath, "Trace.txt"), contents);
      }

      public virtual void PrintReport(string key)
      {
      }

      public virtual void ExportReport(string key)
      {
      }

      public virtual object GetDataReport(string key)
      {
         return null;
      }

      public bool IsGridRowDeleted(TableCell cell)
      {

         if (cell.Text == ConstRowDeleted.LOCAL_DELETE | cell.Text == ConstRowDeleted.DELETE)
            return true;

         return false;
      }

      /// <summary>
      /// Ordena la Grilla
      /// </summary>
      /// <param name="grid"></param>
      /// <param name="column"></param>
      /// <param name="sortDirection"></param>
      public void GridSort(GridView grid, string column, SortDirection sortDirection)
      {
         DataTable dt = (DataTable)grid.DataSource;
         string strSortSQL = "";

         if (sortDirection == SortDirection.Ascending)
            strSortSQL = "ASC";
         else
            strSortSQL = "DESC";

         dt.DefaultView.Sort = column + " " + strSortSQL;

         grid.DataSource = dt;
         grid.DataBind();

      }

      public string GetRootIconsPath(string iconName)
      {
         return GetRootIconsPath(true, iconName);
      }

      public string GetRootIconsPath(bool state, string iconName)
      {
         string strBase = "";
         if (state)
            strBase = ConstSistema.ROOT_ENA_ICONS_PATH;
         else
            strBase = ConstSistema.ROOT_DIS_ICONS_PATH;

         if (iconName == "")
            return this.ResolveUrl(strBase);

         return this.ResolveUrl(strBase + "/"+ iconName);
      }

       /// <summary>
       /// Chio Update Compras
       /// </summary>
       /// <param name="control"></param>

      public void AddCallbackControl(Control control)
      {
          if (IsCallback)
          {
              _ResultCallback.Add(GetHtmlControl(control));
          }
      }

      public static string GetHtmlControl(Control Control)
      {
          string output = "";
          if (Control == null) return output;
          using (StringWriter swControl = new StringWriter())
          {
              using (HtmlTextWriter htwControl = new HtmlTextWriter(swControl))
              {
                  Control.RenderControl(htwControl);
              }
              output = swControl.ToString();
          }
          return output;
      }
   }
}
