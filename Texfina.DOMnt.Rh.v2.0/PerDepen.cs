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
   /// Data Object para Mantenimiento a la Tabla: Personal DerechoHabientes (RH_PerDepen)
   /// </summary>
   /// <remarks></remarks>
   public class PerDepen : DataObjectBase, IDOUpdate
   {

      #region IDOUpdate Members

      public object[] Insert(IEntityBase value)
      {

         EPerDepen objE = (EPerDepen)value;
         ArrayList arrPrm = BuildParamInterface(objE);

         try
         {
            int intRes = this.ExecuteNonQuery("RH_PerDepen_mnt01", arrPrm);

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

         EPerDepen objE = (EPerDepen)value;

         try
         {

            ArrayList arrPrm = BuildParamInterface(objE);

            int intRes = this.ExecuteNonQuery("RH_PerDepen_mnt02", arrPrm);

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

         EPerDepen objE = (EPerDepen)value;

         try
         {

            ArrayList arrPrm = new ArrayList();


            arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
            arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char, 7, objE.IdPersonal));
            arrPrm.Add(DataHelper.CreateParameter("@pnuSecuen", SqlDbType.SmallInt, objE.NuSecuen));

            int intRes = this.ExecuteNonQuery("RH_PerDepen_mnt03", arrPrm);

            return intRes;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }

      }

      private ArrayList BuildParamInterface(EPerDepen value)
      {

         ArrayList arrPrm = new ArrayList();

         arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, value.IdEmpresa));
         arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char, 7, value.IdPersonal));
         arrPrm.Add(DataHelper.CreateParameter("@pnuSecuen", SqlDbType.SmallInt, value.NuSecuen));
         arrPrm.Add(DataHelper.CreateParameter("@pidTDocIden", SqlDbType.Char, 3, value.IdTDocIden));
         arrPrm.Add(DataHelper.CreateParameter("@pnuDocIden", SqlDbType.VarChar, 15, value.NuDocIden));
         arrPrm.Add(DataHelper.CreateParameter("@pidPaisEmiDoc", SqlDbType.Char, 3, value.IdPaisEmiDoc));
         arrPrm.Add(DataHelper.CreateParameter("@pfeNacimien", SqlDbType.DateTime, value.FeNacimien));
         arrPrm.Add(DataHelper.CreateParameter("@pdsAPaterno", SqlDbType.VarChar, 40, value.DsAPaterno));
         arrPrm.Add(DataHelper.CreateParameter("@pdsAMaterno", SqlDbType.VarChar, 40, value.DsAMaterno));
         arrPrm.Add(DataHelper.CreateParameter("@pdsNombres", SqlDbType.VarChar, 40, value.DsNombres));
         arrPrm.Add(DataHelper.CreateParameter("@pidSexo", SqlDbType.Char, 3, value.IdSexo));
         arrPrm.Add(DataHelper.CreateParameter("@pidVincFam", SqlDbType.Char, 3, value.IdVincFam));
         arrPrm.Add(DataHelper.CreateParameter("@pidTipoDocAcre", SqlDbType.Char, 3, value.IdTipoDocAcre));
         arrPrm.Add(DataHelper.CreateParameter("@pnuDocAcre", SqlDbType.VarChar, 20, value.NuDocAcre));
         arrPrm.Add(DataHelper.CreateParameter("@pnuMesConcep", SqlDbType.Char, 6, value.NuMesConcep));
         arrPrm.Add(DataHelper.CreateParameter("@pidTipoVia1", SqlDbType.Char, 3, value.IdTipoVia1));
         arrPrm.Add(DataHelper.CreateParameter("@pdsNombreVia1", SqlDbType.VarChar, 20, value.DsNombreVia1));
         arrPrm.Add(DataHelper.CreateParameter("@pnuVia1", SqlDbType.Char, 4, value.NuVia1));
         arrPrm.Add(DataHelper.CreateParameter("@pnuDepa1", SqlDbType.Char, 4, value.NuDepa1));
         arrPrm.Add(DataHelper.CreateParameter("@pnuInterior1", SqlDbType.VarChar, 4, value.NuInterior1));
         arrPrm.Add(DataHelper.CreateParameter("@pnuMz1", SqlDbType.Char, 4, value.NuMz1));
         arrPrm.Add(DataHelper.CreateParameter("@pnuLote1", SqlDbType.Char, 4, value.NuLote1));
         arrPrm.Add(DataHelper.CreateParameter("@pnuKm1", SqlDbType.Char, 4, value.NuKm1));
         arrPrm.Add(DataHelper.CreateParameter("@pnuBlock1", SqlDbType.Char, 4, value.NuBlock1));
         arrPrm.Add(DataHelper.CreateParameter("@pdsEtapa1", SqlDbType.Char, 4, value.DsEtapa1));
         arrPrm.Add(DataHelper.CreateParameter("@pidTipoZona1", SqlDbType.Char, 3, value.IdTipoZona1));
         arrPrm.Add(DataHelper.CreateParameter("@pdsNombZona1", SqlDbType.VarChar, 20, value.DsNombZona1));
         arrPrm.Add(DataHelper.CreateParameter("@pdsReferen1", SqlDbType.VarChar, 40, value.DsReferen1));
         arrPrm.Add(DataHelper.CreateParameter("@pidPais1", SqlDbType.Char, 4, value.IdPais1));
         arrPrm.Add(DataHelper.CreateParameter("@pidDepa1", SqlDbType.Char, 2, value.IdDepa1));
         arrPrm.Add(DataHelper.CreateParameter("@pidProv1", SqlDbType.Char, 2, value.IdProv1));
         arrPrm.Add(DataHelper.CreateParameter("@pidDist1", SqlDbType.Char, 2, value.IdDist1));
         arrPrm.Add(DataHelper.CreateParameter("@pidTipoVia2", SqlDbType.Char, 3, value.IdTipoVia2));
         arrPrm.Add(DataHelper.CreateParameter("@pdsNombreVia2", SqlDbType.VarChar, 20, value.DsNombreVia2));
         arrPrm.Add(DataHelper.CreateParameter("@pnuVia2", SqlDbType.Char, 4, value.NuVia2));
         arrPrm.Add(DataHelper.CreateParameter("@pnuDepa2", SqlDbType.Char, 4, value.NuDepa2));
         arrPrm.Add(DataHelper.CreateParameter("@pnuInterior2", SqlDbType.Char, 4, value.NuInterior2));
         arrPrm.Add(DataHelper.CreateParameter("@pnuMz2", SqlDbType.Char, 4, value.NuMz2));
         arrPrm.Add(DataHelper.CreateParameter("@pnuLote2", SqlDbType.Char, 4, value.NuLote2));
         arrPrm.Add(DataHelper.CreateParameter("@pnuKm2", SqlDbType.Char, 4, value.NuKm2));
         arrPrm.Add(DataHelper.CreateParameter("@pnuBlock2", SqlDbType.Char, 4, value.NuBlock2));
         arrPrm.Add(DataHelper.CreateParameter("@pdsEtapa2", SqlDbType.Char, 4, value.DsEtapa2));
         arrPrm.Add(DataHelper.CreateParameter("@pidTipoZona2", SqlDbType.Char, 3, value.IdTipoZona2));
         arrPrm.Add(DataHelper.CreateParameter("@pdsNombZona2", SqlDbType.Char, 20, value.DsNombZona2));
         arrPrm.Add(DataHelper.CreateParameter("@pdsReferen2", SqlDbType.VarChar, 40, value.DsReferen2));
         arrPrm.Add(DataHelper.CreateParameter("@pidPais2", SqlDbType.Char, 4, value.IdPais2));
         arrPrm.Add(DataHelper.CreateParameter("@pidDepa2", SqlDbType.Char, 2, value.IdDepa2));
         arrPrm.Add(DataHelper.CreateParameter("@pidProv2", SqlDbType.Char, 2, value.IdProv2));
         arrPrm.Add(DataHelper.CreateParameter("@pidDist2", SqlDbType.Char, 2, value.IdDist2));
         arrPrm.Add(DataHelper.CreateParameter("@pstAsisEsSalud", SqlDbType.Char, 1, value.StAsisEsSalud));
         arrPrm.Add(DataHelper.CreateParameter("@pnuTlfCodLDN", SqlDbType.Char, 3, value.NuTlfCodLDN));
         arrPrm.Add(DataHelper.CreateParameter("@pnuTelf", SqlDbType.VarChar, 10, value.NuTelf));
         arrPrm.Add(DataHelper.CreateParameter("@pdsEmail", SqlDbType.VarChar, 50, value.DsEmail));
         arrPrm.Add(DataHelper.CreateParameter("@pfeBaja", SqlDbType.DateTime, (value.FeBaja.HasValue ? (object)value.FeBaja : DBNull.Value)));
         arrPrm.Add(DataHelper.CreateParameter("@pidMotivBaja", SqlDbType.Char, 3, (value.IdMotivBaja != null ? value.IdMotivBaja : null)));
         arrPrm.Add(DataHelper.CreateParameter("@pstAnulado", SqlDbType.Char, 1, value.StAnulado));

         return arrPrm;

      }

      #endregion

   }
}
