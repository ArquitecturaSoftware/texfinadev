using System;
using System.Web.UI.WebControls;
using System.Data;
using Texfina.Core.Common;

namespace Texfina.Core.Web
{
   public class EditPage : PageBase
   {

      public FormEditAction FormEditAction
      {
         get { return (FormEditAction)this.ViewState["_formEditAc"]; }
         set { this.ViewState["_formEditAc"] = value; }
      }

      public GridEditAction GridEditAction
      {
         get { return (GridEditAction)this.ViewState["_gridEditAc"]; }
         set { this.ViewState["_gridEditAc"] = value; }
      }

      public void LoadData()
      {
         this.LoadInitialSettings();
         this.LoadListControls();
         this.DataToControls();
         this.RegisterGeneralScripts();
         this.LockControls();
      }

      public virtual object CreateEntitySet()
      {
         return null;
      }


      public virtual void SaveData(string key)
      {

      }

      public virtual bool ValidateData()
      {

         return true;
      }


      public virtual void DeleteData()
      {

      }

      public void SetInitialTitle(string str)
      {
         this.SetInitialTitle(str, "");
      }


      public void SetInitialTitle(string str, string subTitle)
      {
         Label lbl = (Label)this.Master.FindControl("lblTitle");

         switch (this.FormEditAction)
         {

            case FormEditAction.AddNew:
               lbl.Text = str + " " + ConstEditActionTitle.ADDNEW + (!string.IsNullOrEmpty(subTitle) ? " - " + subTitle : "");

               break;
            case FormEditAction.Copy:
               lbl.Text = str + " " + ConstEditActionTitle.COPY + (!string.IsNullOrEmpty(subTitle) ? " - " + subTitle : "");

               break;
            case FormEditAction.Edit:
               lbl.Text = str + " " + ConstEditActionTitle.MODIFY + (!string.IsNullOrEmpty(subTitle) ? " - " + subTitle : "");

               break;
            case FormEditAction.Delete:
               lbl.Text = str + " " + ConstEditActionTitle.DELETE + (!string.IsNullOrEmpty(subTitle) ? " - " + subTitle : "");

               break;
            default:
               lbl.Text = str;

               break;
         }

      }


      public virtual void ClearEditPopup()
      {
      }


      public virtual void LoadDataEditPopup(GridView grid, int rowIndex)
      {
      }


      public virtual void RegisterEditPopupScripts(GridView grid)
      {
      }


      public void DeletedRow(DataRow row, string column)
      {
         if (row == null)
         {
            return;
         }

         string strCheckDel = "";

         if (row.RowState == DataRowState.Added)
            strCheckDel = ConstRowDeleted.LOCAL_DELETE;
         else if(row.RowState == DataRowState.Modified | row.RowState == DataRowState.Unchanged)
            strCheckDel = ConstRowDeleted.DELETE;

         row.BeginEdit();
         if (row[column].ToString() == strCheckDel)
            row[column] = ConstRowDeleted.ACTIVE;
         else
            row[column] = strCheckDel;

         row.EndEdit();

      }

      public void ClearDeletedRow(DataTable data, string column)
      {
         DataRow[] drSel = data.Select(column + "=" + ConstRowDeleted.LOCAL_DELETE);
         if ((drSel != null))
         {
            foreach (DataRow dr in drSel)
               dr.Delete();
         }

      }


      public void MarkDeletedRow(DataRow row, string deletedColumn)
      {
         if (row[deletedColumn].ToString() == ConstFlagEstado.DESACTIVADO)
         {
            row.BeginEdit();
            row[deletedColumn] = ConstFlagEstado.ACTIVADO;
            row.EndEdit();
         }

      }

   }
}
