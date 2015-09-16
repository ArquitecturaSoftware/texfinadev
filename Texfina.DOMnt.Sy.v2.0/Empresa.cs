using System;
using System.Data;
using System.Text;
using System.Collections;
using System.Reflection;
using System.Data.SqlClient;
using Texfina.Core.Data;
using Texfina.Core.Common;
using Texfina.Entity.Sy;

namespace Texfina.DOMnt.Sy
{
   /// <summary>
   /// Data Object para mantenimiento a la Tabla SY_Empresa
   /// </summary>
   /// <remarks></remarks>
   public class Empresa : DataObjectBase, IDOUpdate
   {

      #region IDOUpdate Members

      public object[] Insert(IEntityBase value)
      {

         EEmpresa objE = (EEmpresa)value;

         //----------- Generacion de Codigos ------------------
         TablaCorre objDO = new TablaCorre();
         ETablaCorre objECorre = new ETablaCorre();

         objECorre.IdPeriodo = ConstDefaultValue.PERIODO;
         objECorre.IdEmpresa = ConstDefaultValue.EMPRESA;
         objECorre.IdTabla = "SY_Empresa";

         string strNewCode = objDO.GenNewCode(objECorre);
         objE.IdEmpresa = strNewCode;

         //----------------------------------------------------
         ArrayList arrPrm = BuildParamInterface(objE);

         try
         {
            int intRes = this.ExecuteNonQuery("SY_Empresa_mnt01", arrPrm);

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

         EEmpresa objE = (EEmpresa)value;

         try
         {

            ArrayList arrPrm = BuildParamInterface(objE);

            int intRes = this.ExecuteNonQuery("SY_Empresa_mnt02", arrPrm);

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

         EEmpresa objE = (EEmpresa)value;

         try
         {

            ArrayList arrPrm = new ArrayList();


            arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));

            int intRes = this.ExecuteNonQuery("SY_Empresa_mnt03", arrPrm);

            return intRes;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }

      }

      private ArrayList BuildParamInterface(EEmpresa value)
      {

         ArrayList arrPrm = new ArrayList();

         arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, value.IdEmpresa));
         arrPrm.Add(DataHelper.CreateParameter("@pdsEmpresa", SqlDbType.VarChar, 100, value.DsEmpresa));
         arrPrm.Add(DataHelper.CreateParameter("@pdsAbrev", SqlDbType.VarChar, 15, value.DsAbrev));
         arrPrm.Add(DataHelper.CreateParameter("@pnuRuc", SqlDbType.Char, 11, value.NuRuc));
         arrPrm.Add(DataHelper.CreateParameter("@pdsDireccion", SqlDbType.VarChar, 100, value.DsDireccion));
         arrPrm.Add(DataHelper.CreateParameter("@pfeAcogmtpe", SqlDbType.DateTime, value.FeAcogmtpe));
         arrPrm.Add(DataHelper.CreateParameter("@pnuAcogmtpe", SqlDbType.VarChar, 25, value.NuAcogmtpe));
         arrPrm.Add(DataHelper.CreateParameter("@pidRegLaboral", SqlDbType.Char, 3, value.IdRegLaboral));
         arrPrm.Add(DataHelper.CreateParameter("@pidPais", SqlDbType.Char, 4, value.IdPais));
         arrPrm.Add(DataHelper.CreateParameter("@pidDepa", SqlDbType.Char, 2, value.IdDepa));
         arrPrm.Add(DataHelper.CreateParameter("@pidProv", SqlDbType.Char, 2, value.IdProv));
         arrPrm.Add(DataHelper.CreateParameter("@pidDist", SqlDbType.Char, 2, value.IdDist));
         arrPrm.Add(DataHelper.CreateParameter("@pstAdmPublica", SqlDbType.Char, 1, value.StAdmPublica));
         arrPrm.Add(DataHelper.CreateParameter("@pstAgenEmple", SqlDbType.Char, 1, value.StAgenEmple));
         arrPrm.Add(DataHelper.CreateParameter("@pstEmpIntLab", SqlDbType.Char, 1, value.StEmpIntLab));
         arrPrm.Add(DataHelper.CreateParameter("@pstAfecSenati", SqlDbType.Char, 1, value.StAfecSenati));
         arrPrm.Add(DataHelper.CreateParameter("@pstMicroEmp", SqlDbType.Char, 3, value.StMicroEmp));
         arrPrm.Add(DataHelper.CreateParameter("@pstActivo", SqlDbType.Char, 1, value.StActivo));

         return arrPrm;

      }

      #endregion

   }
}
