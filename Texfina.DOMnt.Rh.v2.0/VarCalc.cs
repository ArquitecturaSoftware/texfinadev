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
   /// Data Object para Mantenimiento a la Tabla: RH_VarCalc (RH_VarCalc)
   /// </summary>
   /// <remarks></remarks>
   public class VarCalc : DataObjectBase, IDOUpdate
   {

      #region IDOUpdate Members

      public object[] Insert(IEntityBase value)
      {

         EVarCalc objE = (EVarCalc)value;
         ArrayList arrPrm = BuildParamInterface(objE);

         try
         {
            int intRes = this.ExecuteNonQuery("RH_VarCalc_mnt01", arrPrm);

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

         EVarCalc objE = (EVarCalc)value;

         try
         {

            ArrayList arrPrm = BuildParamInterface(objE);

            int intRes = this.ExecuteNonQuery("RH_VarCalc_mnt02", arrPrm);

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

         EVarCalc objE = (EVarCalc)value;

         try
         {

            ArrayList arrPrm = new ArrayList();


            arrPrm.Add(DataHelper.CreateParameter("@pidVarCalc", SqlDbType.VarChar, 15, objE.IdVarCalc));

            int intRes = this.ExecuteNonQuery("RH_VarCalc_mnt03", arrPrm);

            return intRes;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }

      }

      private ArrayList BuildParamInterface(EVarCalc value)
      {

         ArrayList arrPrm = new ArrayList();

         arrPrm.Add(DataHelper.CreateParameter("@pidVarCalc", SqlDbType.VarChar, 15, value.IdVarCalc));
         arrPrm.Add(DataHelper.CreateParameter("@pdsVarCalc", SqlDbType.VarChar, 25, value.DsVarCalc));
         arrPrm.Add(DataHelper.CreateParameter("@pidTipo", SqlDbType.Char, 2, value.IdTipo));
         arrPrm.Add(DataHelper.CreateParameter("@pdsCondicion", SqlDbType.VarChar, 50, value.DsCondicion));
         arrPrm.Add(DataHelper.CreateParameter("@pidTabla", SqlDbType.Char, 3, value.IdTabla));
         arrPrm.Add(DataHelper.CreateParameter("@pidAcumula", SqlDbType.Char, 3, value.IdAcumula));
         arrPrm.Add(DataHelper.CreateParameter("@pidColumn", SqlDbType.Char, 3, value.IdColumn));
         arrPrm.Add(DataHelper.CreateParameter("@pstCondic1", SqlDbType.Char, 1, value.StCondic1));
         arrPrm.Add(DataHelper.CreateParameter("@pdsCondic1", SqlDbType.VarChar, 250, value.DsCondic1));
         arrPrm.Add(DataHelper.CreateParameter("@pnuValor1", SqlDbType.Decimal, value.NuValor1));
         arrPrm.Add(DataHelper.CreateParameter("@pstCondic2", SqlDbType.Char, 1, value.StCondic2));
         arrPrm.Add(DataHelper.CreateParameter("@pdsCondic2", SqlDbType.VarChar, 250, value.DsCondic2));
         arrPrm.Add(DataHelper.CreateParameter("@pnuValor2", SqlDbType.Decimal, value.NuValor2));
         arrPrm.Add(DataHelper.CreateParameter("@pstRegSis", SqlDbType.Char, 1, value.StRegSis));
         arrPrm.Add(DataHelper.CreateParameter("@pstAnulado", SqlDbType.Char, 1, value.StAnulado));

         return arrPrm;

      }

      #endregion

   }
}