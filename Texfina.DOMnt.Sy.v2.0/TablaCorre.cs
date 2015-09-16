using System;
using System.Data;
using System.Text;
using System.Collections;
using System.Reflection;
using System.Data.SqlClient;
using Texfina.Core.Data;
using Texfina.Entity.Sy;

namespace Texfina.DOMnt.Sy
{
   /// <summary>
   /// Data Object para Mantenimiento a la Tabla: Tabla Correlativo (SY_TablaCorre)
   /// </summary>
   /// <remarks></remarks>
   public class TablaCorre : DataObjectBase, IDOUpdate
   {

      #region IDOUpdate Members

      public object[] Insert(IEntityBase value)
      {

         ETablaCorre objE = (ETablaCorre)value;

         ArrayList arrPrm = BuildParamInterface(objE);

         try
         {
            int intRes = this.ExecuteNonQuery("SY_TablaCorre_mnt01", arrPrm);

            return new object[] { objE.IdPeriodo };

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }

      }

      public int Update(IEntityBase value)
      {

         ETablaCorre objE = (ETablaCorre)value;

         try
         {

            ArrayList arrPrm = BuildParamInterface(objE);

            int intRes = this.ExecuteNonQuery("SY_TablaCorre_mnt02", arrPrm);

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

         ETablaCorre objE = (ETablaCorre)value;

         try
         {

            ArrayList arrPrm = new ArrayList();


            arrPrm.Add(DataHelper.CreateParameter("@pidPeriodo", SqlDbType.Char, 4, objE.IdPeriodo));
            arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
            arrPrm.Add(DataHelper.CreateParameter("@pidTabla", SqlDbType.VarChar, 10, objE.IdTabla));

            int intRes = this.ExecuteNonQuery("SY_TablaCorre_mnt03", arrPrm);

            return intRes;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }

      }

      private ArrayList BuildParamInterface(ETablaCorre value)
      {

         ArrayList arrPrm = new ArrayList();

         arrPrm.Add(DataHelper.CreateParameter("@pidPeriodo", SqlDbType.Char, 4, value.IdPeriodo));
         arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, value.IdEmpresa));
         arrPrm.Add(DataHelper.CreateParameter("@pidTabla", SqlDbType.VarChar, 30, value.IdTabla));
         arrPrm.Add(DataHelper.CreateParameter("@pnuIni", SqlDbType.Int, value.NuIni));
         arrPrm.Add(DataHelper.CreateParameter("@pnuFin", SqlDbType.Int, value.NuFin));
         arrPrm.Add(DataHelper.CreateParameter("@pnuIntervalo", SqlDbType.Int, value.NuIntervalo));
         arrPrm.Add(DataHelper.CreateParameter("@pnuUltGen", SqlDbType.Int, value.NuUltGen));
         arrPrm.Add(DataHelper.CreateParameter("@pdsFormato", SqlDbType.VarChar, 10, value.DsFormato));

         return arrPrm;

      }

      #endregion

      public string GenNewCode(IEntityBase value)
      {

         ETablaCorre objE = (ETablaCorre)value;

         try
         {
            ArrayList arrPrm = new ArrayList();

            arrPrm.Add(DataHelper.CreateParameter("@pidPeriodo", SqlDbType.Char, 4, objE.IdPeriodo));
            arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
            arrPrm.Add(DataHelper.CreateParameter("@pidTabla", SqlDbType.VarChar, 25, objE.IdTabla));

            DataTable dt = this.ExecuteDatatable("SY_TablaCorre_mnt10", arrPrm);

            int intCode = 0;
            string strFmt = "";

            foreach (DataRow dr in dt.Rows)
            {
               intCode = Convert.ToInt32(dr[0]);
               strFmt = dr[1].ToString();
            }

            return intCode.ToString(strFmt);

         }
         catch (Exception ex)
         {
            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }

      }

   }
}
