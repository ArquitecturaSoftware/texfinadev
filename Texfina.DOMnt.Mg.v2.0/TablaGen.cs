using System;
using System.Data;
using System.Text;
using System.Collections;
using System.Reflection;
using System.Data.SqlClient;
using Texfina.Core.Data;
using Texfina.Entity.Mg;
using Texfina.Entity.Sy;
using Texfina.DOMnt.Sy;

namespace Texfina.DOMnt.Mg
{
   /// <summary>
   /// Data Object para Mantenimiento a la Tabla: Tabla General (MG_TablaGen)
   /// </summary>
   /// <remarks></remarks>
   public class TablaGen : DataObjectBase, IDOUpdate
   {

      #region IDOUpdate Members

      public object[] Insert(IEntityBase value)
      {

         ETablaGen objE = (ETablaGen)value;

         //----------- Generacion de Codigos ------------------
         //TablaCorre objDO = new TablaCorre();
         //ETablaCorre objECorre = new ETablaCorre();

         //objECorre.IdPeriodo = objE.IdPeriodo;
         //objECorre.IdEmpresa = objE.IdEmpresa;
         //objECorre.IdTabla = "MG_TablaGen";

         //string strNewCode = objDO.GenNewCode(objECorre);
         //objE.IdTabla = strNewCode;

         //----------------------------------------------------
         ArrayList arrPrm = BuildParamInterface(objE);

         try
         {
            int intRes = this.ExecuteNonQuery("MG_TablaGen_mnt01", arrPrm);

            return new object[] { objE.IdTabla };

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }

      }

      public int Update(IEntityBase value)
      {

         ETablaGen objE = (ETablaGen)value;

         try
         {

            ArrayList arrPrm = BuildParamInterface(objE);

            int intRes = this.ExecuteNonQuery("MG_TablaGen_mnt02", arrPrm);

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

         ETablaGen objE = (ETablaGen)value;

         try
         {

            ArrayList arrPrm = new ArrayList();


            arrPrm.Add(DataHelper.CreateParameter("@pidTabla", SqlDbType.Char, 3, objE.IdTabla));

            int intRes = this.ExecuteNonQuery("MG_TablaGen_mnt03", arrPrm);

            return intRes;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }

      }

      private ArrayList BuildParamInterface(ETablaGen value)
      {

         ArrayList arrPrm = new ArrayList();

         arrPrm.Add(DataHelper.CreateParameter("@pidTabla", SqlDbType.Char, 3, value.IdTabla));
         arrPrm.Add(DataHelper.CreateParameter("@pdsTabla", SqlDbType.VarChar, 40, value.DsTabla));
         arrPrm.Add(DataHelper.CreateParameter("@pstRegSist", SqlDbType.Char, 1, value.StRegSist));

         return arrPrm;

      }

      #endregion

   }
}
