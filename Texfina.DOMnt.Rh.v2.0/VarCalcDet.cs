using System;
using System.Data;
using System.Text;
using System.Collections;
using System.Reflection;
using System.Data.SqlClient;
using Texfina.Core.Data;
using Texfina.Entity.Rh;
using Texfina.Entity.Sy;
using Texfina.DOMnt.Sy;

namespace Texfina.DOMnt.Rh
{
   /// <summary>
   /// Data Object para Mantenimiento a la Tabla: RH_VarCalcDet (RH_VarCalcDet)
   /// </summary>
   /// <remarks></remarks>
   public class VarCalcDet : DataObjectBase, IDOUpdate
   {

      #region IDOUpdate Members

      public object[] Insert(IEntityBase value)
      {

         EVarCalcDet objE = (EVarCalcDet)value;
         ArrayList arrPrm = BuildParamInterface(objE);

         try
         {
            int intRes = this.ExecuteNonQuery("RH_VarCalcDet_mnt01", arrPrm);

            return new object[] { objE.IdVarCalc };

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }

      }

      public int Update(IEntityBase value)
      {

         EVarCalcDet objE = (EVarCalcDet)value;

         try
         {

            ArrayList arrPrm = BuildParamInterface(objE);

            int intRes = this.ExecuteNonQuery("RH_VarCalcDet_mnt02", arrPrm);

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

         EVarCalcDet objE = (EVarCalcDet)value;

         try
         {

            ArrayList arrPrm = new ArrayList();


            arrPrm.Add(DataHelper.CreateParameter("@pidVarCalc", SqlDbType.VarChar, 15, objE.IdVarCalc));
            arrPrm.Add(DataHelper.CreateParameter("@pstFiltro", SqlDbType.Char, 1, objE.StFiltro));
            arrPrm.Add(DataHelper.CreateParameter("@pnuValor", SqlDbType.VarChar, 15, objE.NuValor));

            int intRes = this.ExecuteNonQuery("RH_VarCalcDet_mnt03", arrPrm);

            return intRes;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }

      }

      private ArrayList BuildParamInterface(EVarCalcDet value)
      {

         ArrayList arrPrm = new ArrayList();

         arrPrm.Add(DataHelper.CreateParameter("@pidVarCalc", SqlDbType.VarChar, 15, value.IdVarCalc));
         arrPrm.Add(DataHelper.CreateParameter("@pstFiltro", SqlDbType.Char, 1, value.StFiltro));
         arrPrm.Add(DataHelper.CreateParameter("@pnuValor", SqlDbType.VarChar, 15, value.NuValor));

         return arrPrm;

      }

      #endregion

   }
}
