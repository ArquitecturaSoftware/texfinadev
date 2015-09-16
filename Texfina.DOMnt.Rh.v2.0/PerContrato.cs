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
   /// Data Object para Mantenimiento a la Tabla: RH_PerContrato (RH_PerContrato)
   /// </summary>
   /// <remarks></remarks>
   public class PerContrato : DataObjectBase, IDOUpdate
   {

      #region IDOUpdate Members

      public object[] Insert(IEntityBase value)
      {

         EPerContrato objE = (EPerContrato)value;
         ArrayList arrPrm = BuildParamInterface(objE);

         try
         {
            int intRes = this.ExecuteNonQuery("RH_PerContrato_mnt01", arrPrm);

            return new object[] { objE.IdEmpresa };

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }

      }

      public int Update(IEntityBase value)
      {

         EPerContrato objE = (EPerContrato)value;

         try
         {

            ArrayList arrPrm = BuildParamInterface(objE);

            int intRes = this.ExecuteNonQuery("RH_PerContrato_mnt02", arrPrm);

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

         EPerContrato objE = (EPerContrato)value;

         try
         {

            ArrayList arrPrm = new ArrayList();


            arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
            arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char, 7, objE.IdPersonal));
            arrPrm.Add(DataHelper.CreateParameter("@pnuSecuen", SqlDbType.SmallInt, objE.NuSecuen));

            int intRes = this.ExecuteNonQuery("RH_PerContrato_mnt03", arrPrm);

            return intRes;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }

      }

      private ArrayList BuildParamInterface(EPerContrato value)
      {

         ArrayList arrPrm = new ArrayList();

         arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, value.IdEmpresa));
         arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char, 7, value.IdPersonal));
         arrPrm.Add(DataHelper.CreateParameter("@pnuSecuen", SqlDbType.SmallInt, value.NuSecuen));
         arrPrm.Add(DataHelper.CreateParameter("@pfeSuscripcion", SqlDbType.DateTime, value.FeSuscripcion));
         arrPrm.Add(DataHelper.CreateParameter("@pfeInicio", SqlDbType.DateTime, value.FeInicio));
         arrPrm.Add(DataHelper.CreateParameter("@pfeFin", SqlDbType.DateTime, value.FeFin));
         arrPrm.Add(DataHelper.CreateParameter("@pidMotivFin", SqlDbType.Char, 3, value.IdMotivFin));
         arrPrm.Add(DataHelper.CreateParameter("@pfeCese", SqlDbType.DateTime, (value.FeCese.HasValue ? (object)value.FeCese : DBNull.Value)));
         arrPrm.Add(DataHelper.CreateParameter("@pdsObservacion", SqlDbType.Text, value.DsObservacion));
         arrPrm.Add(DataHelper.CreateParameter("@pidPuesto", SqlDbType.Char, 3, value.IdPuesto));
         arrPrm.Add(DataHelper.CreateParameter("@pdsFuncion", SqlDbType.VarChar, 300, value.DsFuncion));
         arrPrm.Add(DataHelper.CreateParameter("@pidRegLaboral", SqlDbType.Char, 3, value.IdRegLaboral));
         arrPrm.Add(DataHelper.CreateParameter("@pstMype", SqlDbType.Char, 1, value.StMype));
         arrPrm.Add(DataHelper.CreateParameter("@pstDiscapacid", SqlDbType.Char, 1, value.StDiscapacid));
         arrPrm.Add(DataHelper.CreateParameter("@pidModalidad", SqlDbType.Char, 3, value.IdModalidad));
         arrPrm.Add(DataHelper.CreateParameter("@pidSubModal", SqlDbType.Char, 3, value.IdSubModal));
         arrPrm.Add(DataHelper.CreateParameter("@pidTipo", SqlDbType.Char, 3, value.IdTipo));
         arrPrm.Add(DataHelper.CreateParameter("@pidGrpOcupac", SqlDbType.Char, 3, value.IdGrpOcupac));
         arrPrm.Add(DataHelper.CreateParameter("@pidMoneda", SqlDbType.Char, 3, value.IdMoneda));
         arrPrm.Add(DataHelper.CreateParameter("@pidPeriRemu", SqlDbType.Char, 3, value.IdPeriRemu));
         arrPrm.Add(DataHelper.CreateParameter("@pmtRemunera", SqlDbType.Decimal, value.MtRemunera));
         arrPrm.Add(DataHelper.CreateParameter("@pidRemVariable", SqlDbType.Char, 3, value.IdRemVariable));
         arrPrm.Add(DataHelper.CreateParameter("@pstRemuEspecie", SqlDbType.Char, 1, value.StRemuEspecie));
         arrPrm.Add(DataHelper.CreateParameter("@pstRemuMinima", SqlDbType.Char, 1, value.StRemuMinima));
         arrPrm.Add(DataHelper.CreateParameter("@pstProrroga", SqlDbType.Char, 1, value.StProrroga));
         arrPrm.Add(DataHelper.CreateParameter("@pstContrato", SqlDbType.Char, 1, value.StContrato));
         arrPrm.Add(DataHelper.CreateParameter("@pstAnulado", SqlDbType.Char, 1, value.StAnulado));
         arrPrm.Add(DataHelper.CreateParameter("@pdsAdenda", SqlDbType.NVarChar, 4000, value.DsAdenda));
         return arrPrm;

      }

      #endregion

   }
}
