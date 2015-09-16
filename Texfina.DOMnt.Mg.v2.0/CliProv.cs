using System;
using System.Data;
using System.Text;
using System.Collections;
using System.Reflection;
using System.Data.SqlClient;
using Texfina.Core.Data;
using Texfina.Core.Common;
using Texfina.Entity.Mg;
using Texfina.Entity.Sy;
using Texfina.DOMnt.Sy;

namespace Texfina.DOMnt.Mg
{
   /// <summary>
   /// Data Object para Mantenimiento a la Tabla: Cliente/Proveedor (MG_CliProv)
   /// </summary>
   /// <remarks></remarks>
   public class CliProv : DataObjectBase, IDOUpdate
   {

      #region IDOUpdate Members

      public object[] Insert(IEntityBase value)
      {

         ECliProv objE = (ECliProv)value;

         //----------- Generacion de Codigos ------------------
         TablaCorre objDO = new TablaCorre();
         ETablaCorre objECorre = new ETablaCorre();

         objECorre.IdPeriodo = ConstDefaultValue.PERIODO;
         objECorre.IdEmpresa = ConstDefaultValue.EMPRESA;
         objECorre.IdTabla = "MG_CliProv";

         string strNewCode = objDO.GenNewCode(objECorre);
         objE.IdCliProv = strNewCode;

         //----------------------------------------------------
         ArrayList arrPrm = BuildParamInterface(objE);

         try
         {
            int intRes = this.ExecuteNonQuery("MG_CliProv_mnt01", arrPrm);

            return new object[] { objE.IdCliProv };

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }

      }

      public int Update(IEntityBase value)
      {

         ECliProv objE = (ECliProv)value;

         try
         {

            ArrayList arrPrm = BuildParamInterface(objE);

            int intRes = this.ExecuteNonQuery("MG_CliProv_mnt02", arrPrm);

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

         ECliProv objE = (ECliProv)value;

         try
         {

            ArrayList arrPrm = new ArrayList();


            arrPrm.Add(DataHelper.CreateParameter("@pidCliProv", SqlDbType.Char, 7, objE.IdCliProv));

            int intRes = this.ExecuteNonQuery("MG_CliProv_mnt03", arrPrm);

            return intRes;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }

      }

      private ArrayList BuildParamInterface(ECliProv value)
      {

         ArrayList arrPrm = new ArrayList();

         arrPrm.Add(DataHelper.CreateParameter("@pidCliProv", SqlDbType.Char, 7, value.IdCliProv));
         arrPrm.Add(DataHelper.CreateParameter("@pidTipoCliProv", SqlDbType.Char, 3, value.IdTipoCliProv));
         arrPrm.Add(DataHelper.CreateParameter("@pidNatuJuri", SqlDbType.Char, 3, value.IdNatuJuri));
         arrPrm.Add(DataHelper.CreateParameter("@pdsRazSocial", SqlDbType.VarChar, 150, value.DsRazSocial));
         arrPrm.Add(DataHelper.CreateParameter("@pdsRsAbrev", SqlDbType.VarChar, 50, value.DsRsAbrev));
         arrPrm.Add(DataHelper.CreateParameter("@pdsAPaterno", SqlDbType.VarChar, 50, value.DsAPaterno));
         arrPrm.Add(DataHelper.CreateParameter("@pdsAMaterno", SqlDbType.VarChar, 50, value.DsAMaterno));
         arrPrm.Add(DataHelper.CreateParameter("@pdsNombres", SqlDbType.VarChar, 50, value.DsNombres));
         arrPrm.Add(DataHelper.CreateParameter("@pidTDocIden", SqlDbType.Char, 3, value.IdTDocIden));
         arrPrm.Add(DataHelper.CreateParameter("@pnuDocIden", SqlDbType.VarChar, 20, value.NuDocIden));
         arrPrm.Add(DataHelper.CreateParameter("@pfeVenDocIden", SqlDbType.DateTime, value.FeVenDocIden));
         arrPrm.Add(DataHelper.CreateParameter("@pidPaisEmite", SqlDbType.Char, 3, value.IdPaisEmite));
         arrPrm.Add(DataHelper.CreateParameter("@pnuRuc", SqlDbType.Char, 11, value.NuRuc));
         arrPrm.Add(DataHelper.CreateParameter("@pidTipoVia", SqlDbType.Char, 3, value.IdTipoVia));
         arrPrm.Add(DataHelper.CreateParameter("@pdsNombreVia", SqlDbType.VarChar, 100, value.DsNombreVia));
         arrPrm.Add(DataHelper.CreateParameter("@pnuVia", SqlDbType.VarChar, 10, value.NuVia));
         arrPrm.Add(DataHelper.CreateParameter("@pnuDpto", SqlDbType.VarChar, 10, value.NuDpto));
         arrPrm.Add(DataHelper.CreateParameter("@pnuInterior", SqlDbType.VarChar, 10, value.NuInterior));
         arrPrm.Add(DataHelper.CreateParameter("@pdsManzana", SqlDbType.VarChar, 10, value.DsManzana));
         arrPrm.Add(DataHelper.CreateParameter("@pdsLote", SqlDbType.VarChar, 10, value.DsLote));
         arrPrm.Add(DataHelper.CreateParameter("@pdsKilometro", SqlDbType.VarChar, 10, value.DsKilometro));
         arrPrm.Add(DataHelper.CreateParameter("@pdsBlock", SqlDbType.VarChar, 10, value.DsBlock));
         arrPrm.Add(DataHelper.CreateParameter("@pdsEtapa", SqlDbType.VarChar, 10, value.DsEtapa));
         arrPrm.Add(DataHelper.CreateParameter("@pidTipoZona", SqlDbType.Char, 3, value.IdTipoZona));
         arrPrm.Add(DataHelper.CreateParameter("@pdsNombZona", SqlDbType.VarChar, 100, value.DsNombZona));
         arrPrm.Add(DataHelper.CreateParameter("@pdsReferen", SqlDbType.VarChar, 100, value.DsReferen));
         arrPrm.Add(DataHelper.CreateParameter("@pnuTelf", SqlDbType.VarChar, 15, value.NuTelf));
         arrPrm.Add(DataHelper.CreateParameter("@pnuFax", SqlDbType.VarChar, 15, value.NuFax));
         arrPrm.Add(DataHelper.CreateParameter("@pidPais", SqlDbType.Char, 4, value.IdPais));
         arrPrm.Add(DataHelper.CreateParameter("@pidDepa", SqlDbType.Char, 2, value.IdDepa));
         arrPrm.Add(DataHelper.CreateParameter("@pidProv", SqlDbType.Char, 2, value.IdProv));
         arrPrm.Add(DataHelper.CreateParameter("@pidDist", SqlDbType.Char, 2, value.IdDist));
         arrPrm.Add(DataHelper.CreateParameter("@pdsEmail", SqlDbType.VarChar, 60, value.DsEmail));
         arrPrm.Add(DataHelper.CreateParameter("@pdsWeb", SqlDbType.VarChar, 60, value.DsWeb));
         arrPrm.Add(DataHelper.CreateParameter("@pstRegSis", SqlDbType.Char, 1, value.StRegSis));

         return arrPrm;

      }

      #endregion

   }
}
