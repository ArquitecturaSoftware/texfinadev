using System;
using System.Collections;
using System.Reflection;
using System.Data;
using Texfina.Core.Data;
using Texfina.Entity.Sy;

namespace Texfina.DOMnt.Sy
{
   /// <summary>
   /// Data Object para Mantenimiento a la Tabla: Usuario - Menu (SY_UsuMenu)
   /// </summary>
   /// <remarks></remarks>
   public class UsuMenu : DataObjectBase, IDOUpdate
   {

      #region IDOUpdate Members

      public object[] Insert(IEntityBase value)
      {

         EUsuMenu objE = (EUsuMenu)value;

         ArrayList arrPrm = BuildParamInterface(objE);

         try
         {
            int intRes = this.ExecuteNonQuery("SY_UsuMenu_mnt01", arrPrm);

            return new object[] { objE.IdUser };

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }

      }

      public int Update(IEntityBase value)
      {

         EUsuMenu objE = (EUsuMenu)value;

         try
         {

            ArrayList arrPrm = BuildParamInterface(objE);

            int intRes = this.ExecuteNonQuery("SY_UsuMenu_mnt02", arrPrm);

            return intRes;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }

      }

      public int Delete(IEntityBase value)
      {

         EUsuMenu objE = (EUsuMenu)value;

         try
         {

            ArrayList arrPrm = new ArrayList();


            arrPrm.Add(DataHelper.CreateParameter("@pidUser", SqlDbType.Char, 5, objE.IdUser));
            arrPrm.Add(DataHelper.CreateParameter("@pidMenu", SqlDbType.Char, 8, objE.IdMenu));

            int intRes = this.ExecuteNonQuery("SY_UsuMenu_mnt03", arrPrm);

            return intRes;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }

      }

      private ArrayList BuildParamInterface(EUsuMenu value)
      {

         ArrayList arrPrm = new ArrayList();

         arrPrm.Add(DataHelper.CreateParameter("@pidUser", SqlDbType.Char, 5, value.IdUser));
         arrPrm.Add(DataHelper.CreateParameter("@pidMenu", SqlDbType.Char, 8, value.IdMenu));
         arrPrm.Add(DataHelper.CreateParameter("@pidDerechos", SqlDbType.Binary, value.IdDerechos));

         return arrPrm;

      }

      #endregion

   }
}