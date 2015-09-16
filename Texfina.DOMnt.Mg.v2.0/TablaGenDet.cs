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
   /// Data Object para Mantenimiento a la Tabla: Tabla General Detalle (MG_TablaGenDet)
   /// </summary>
   /// <remarks></remarks>
   public class TablaGenDet : DataObjectBase, IDOUpdate
   {

      #region IDOUpdate Members

      public object[] Insert(IEntityBase value)
      {

         ETablaGenDet objE = (ETablaGenDet)value;

         //----------- Generacion de Codigos ------------------
         //TablaCorre objDO = new TablaCorre();
         //ETablaCorre objECorre = new ETablaCorre();

         //objECorre.IdPeriodo = objE.IdPeriodo;
         //objECorre.IdEmpresa = objE.IdEmpresa;
         //objECorre.IdTabla = "MG_TablaGenDet";

         //string strNewCode = objDO.GenNewCode(objECorre);
         //objE.IdTabla = strNewCode;

         //----------------------------------------------------
         ArrayList arrPrm = BuildParamInterface(objE);

         try
         {
            int intRes = this.ExecuteNonQuery("MG_TablaGenDet_mnt01", arrPrm);

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

         ETablaGenDet objE = (ETablaGenDet)value;

         try
         {

            ArrayList arrPrm = BuildParamInterface(objE);

            int intRes = this.ExecuteNonQuery("MG_TablaGenDet_mnt02", arrPrm);

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

         ETablaGenDet objE = (ETablaGenDet)value;

         try
         {

            ArrayList arrPrm = new ArrayList();


            arrPrm.Add(DataHelper.CreateParameter("@pidTabla", SqlDbType.Char, 3, objE.IdTabla));
            arrPrm.Add(DataHelper.CreateParameter("@pidCodigo", SqlDbType.Char, 3, objE.IdCodigo));

            int intRes = this.ExecuteNonQuery("MG_TablaGenDet_mnt03", arrPrm);

            return intRes;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }

      }

      private ArrayList BuildParamInterface(ETablaGenDet value)
      {

         ArrayList arrPrm = new ArrayList();

         arrPrm.Add(DataHelper.CreateParameter("@pidTabla", SqlDbType.Char, 3, value.IdTabla));
         arrPrm.Add(DataHelper.CreateParameter("@pidCodigo", SqlDbType.Char, 3, value.IdCodigo));
         arrPrm.Add(DataHelper.CreateParameter("@pdsDescrip", SqlDbType.VarChar, 100, value.DsDescrip));
         arrPrm.Add(DataHelper.CreateParameter("@pdsAbrev", SqlDbType.VarChar, 20, value.DsAbrev));
         arrPrm.Add(DataHelper.CreateParameter("@pidVar", SqlDbType.VarChar, 15, value.IdVar));
         arrPrm.Add(DataHelper.CreateParameter("@pidCodAlter", SqlDbType.VarChar, 10, value.IdCodAlter));
         arrPrm.Add(DataHelper.CreateParameter("@pmtValor", SqlDbType.Decimal, value.MtValor));

         return arrPrm;

      }

      #endregion

   }
}
