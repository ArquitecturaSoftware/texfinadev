using System;
using System.Data;
using System.Text;
using System.Collections;
using System.Reflection;
using System.Data.SqlClient;
using Texfina.Core.Data;
using Texfina.Core.Common;
using Texfina.Entity.Rh;
using Texfina.Entity.Sy;
using Texfina.DOMnt.Sy;

namespace Texfina.DOMnt.Rh
{
   /// <summary>
   /// Data Object para Mantenimiento a la Tabla: Personal (RH_Personal)
   /// </summary>
   /// <remarks></remarks>
   public class Personal : DataObjectBase, IDOUpdate
   {

      #region IDOUpdate Members

      public object[] Insert(IEntityBase value)
      {

         EPersonal objE = (EPersonal)value;

         //----------- Generacion de Codigos ------------------
         TablaCorre objDO = new TablaCorre();
         ETablaCorre objECorre = new ETablaCorre();

         objECorre.IdPeriodo = ConstDefaultValue.PERIODO;
         objECorre.IdEmpresa = objE.IdEmpresa;
         objECorre.IdTabla = "RH_Personal";

         string strNewCode = objDO.GenNewCode(objECorre);
         objE.IdPersonal = strNewCode;

         //----------------------------------------------------
         ArrayList arrPrm = BuildParamInterface(objE);

         try
         {
            int intRes = this.ExecuteNonQuery("RH_Personal_mnt01", arrPrm);

            return new object[] { objE.IdPersonal };

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }

      }

      public int Update(IEntityBase value)
      {

         EPersonal objE = (EPersonal)value;

         try
         {

            ArrayList arrPrm = BuildParamInterface(objE);

            int intRes = this.ExecuteNonQuery("RH_Personal_mnt02", arrPrm);

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

         EPersonal objE = (EPersonal)value;

         try
         {

            ArrayList arrPrm = new ArrayList();


            arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
            arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char, 7, objE.IdPersonal));

            int intRes = this.ExecuteNonQuery("RH_Personal_mnt03", arrPrm);

            return intRes;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }

      }

      private ArrayList BuildParamInterface(EPersonal value)
      {

         ArrayList arrPrm = new ArrayList();

         arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, value.IdEmpresa));
         arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char, 7, value.IdPersonal));
         arrPrm.Add(DataHelper.CreateParameter("@pidCliProv", SqlDbType.Char, 7, value.IdCliProv));
         arrPrm.Add(DataHelper.CreateParameter("@pnuFotocheck", SqlDbType.VarChar, 15, value.NuFotocheck));
         arrPrm.Add(DataHelper.CreateParameter("@pidEstable", SqlDbType.Char, 4, value.IdEstable));
         arrPrm.Add(DataHelper.CreateParameter("@pidSexo", SqlDbType.Char, 3, value.IdSexo));
         arrPrm.Add(DataHelper.CreateParameter("@pfeNacimien", SqlDbType.DateTime, value.FeNacimien));
         arrPrm.Add(DataHelper.CreateParameter("@pidNacional", SqlDbType.Char, 6, value.IdNacional));
         arrPrm.Add(DataHelper.CreateParameter("@pnuRUC", SqlDbType.Char, 11, value.NuRUC));
         arrPrm.Add(DataHelper.CreateParameter("@pstEsSalud", SqlDbType.Char, 1, value.StEsSalud));
         arrPrm.Add(DataHelper.CreateParameter("@pstDomiciliado", SqlDbType.Char, 1, value.StDomiciliado));
         arrPrm.Add(DataHelper.CreateParameter("@pidCateTrab", SqlDbType.Char, 3, value.IdCateTrab));
         arrPrm.Add(DataHelper.CreateParameter("@pidTipoTrab", SqlDbType.Char, 3, value.IdTipoTrab));
         arrPrm.Add(DataHelper.CreateParameter("@pidCateOcupa", SqlDbType.Char, 3, value.IdCateOcupa));
         arrPrm.Add(DataHelper.CreateParameter("@pidRegLaboral", SqlDbType.Char, 3, value.IdRegLaboral));
         arrPrm.Add(DataHelper.CreateParameter("@pidNivEduc", SqlDbType.Char, 3, value.IdNivEduc));
         arrPrm.Add(DataHelper.CreateParameter("@pidOcupa", SqlDbType.Char, 6, value.IdOcupa));
         arrPrm.Add(DataHelper.CreateParameter("@pstDiscapa", SqlDbType.Char, 1, value.StDiscapa));
         arrPrm.Add(DataHelper.CreateParameter("@pidRegPensi", SqlDbType.Char, 3, value.IdRegPensi));
         arrPrm.Add(DataHelper.CreateParameter("@pfeInscRegPen", SqlDbType.DateTime, (value.FeInscRegPen.HasValue ? (object)value.FeInscRegPen : DBNull.Value)));
         arrPrm.Add(DataHelper.CreateParameter("@pnuCuspp", SqlDbType.Char, 15, value.NuCuspp));
         arrPrm.Add(DataHelper.CreateParameter("@pidSctrSalud", SqlDbType.Char, 3, value.IdSctrSalud));
         arrPrm.Add(DataHelper.CreateParameter("@pidSctrPens", SqlDbType.Char, 3, value.IdSctrPens));
         arrPrm.Add(DataHelper.CreateParameter("@pidTipoCont", SqlDbType.Char, 3, value.IdTipoCont));
         arrPrm.Add(DataHelper.CreateParameter("@pstSujRegAlter", SqlDbType.Char, 1, value.StSujRegAlter));
         arrPrm.Add(DataHelper.CreateParameter("@pstJTMaxima", SqlDbType.Char, 1, value.StJTMaxima));
         arrPrm.Add(DataHelper.CreateParameter("@pstJTHoraNoc", SqlDbType.Char, 1, value.StJTHoraNoc));
         arrPrm.Add(DataHelper.CreateParameter("@pstJTAtipico", SqlDbType.Char, 1, value.StJTAtipico));
         arrPrm.Add(DataHelper.CreateParameter("@pstOtrosIng5ta", SqlDbType.Char, 1, value.StOtrosIng5ta));
         arrPrm.Add(DataHelper.CreateParameter("@pstSindical", SqlDbType.Char, 1, value.StSindical));
         arrPrm.Add(DataHelper.CreateParameter("@pidPeriRemu", SqlDbType.Char, 3, value.IdPeriRemu));
         arrPrm.Add(DataHelper.CreateParameter("@pidSegMedi", SqlDbType.Char, 3, value.IdSegMedi));
         arrPrm.Add(DataHelper.CreateParameter("@pidEmpEps", SqlDbType.Char, 3, value.IdEmpEps));
         arrPrm.Add(DataHelper.CreateParameter("@pidSituEmple", SqlDbType.Char, 3, value.IdSituEmple));
         arrPrm.Add(DataHelper.CreateParameter("@pst5taExon", SqlDbType.Char, 1, value.St5taExon));
         arrPrm.Add(DataHelper.CreateParameter("@pidSitEspTrab", SqlDbType.Char, 3, value.IdSitEspTrab));
         arrPrm.Add(DataHelper.CreateParameter("@pidTipoRemu", SqlDbType.Char, 3, value.IdTipoRemu));
         arrPrm.Add(DataHelper.CreateParameter("@pfeIngpla", SqlDbType.DateTime, (value.FeIngpla.HasValue ? (object)value.FeIngpla : DBNull.Value)));
         arrPrm.Add(DataHelper.CreateParameter("@pfeCese", SqlDbType.DateTime, (value.FeCese.HasValue ? (object)value.FeCese : DBNull.Value)));
         arrPrm.Add(DataHelper.CreateParameter("@pidMotivFin", SqlDbType.Char, 3, value.IdMotivFin));
         arrPrm.Add(DataHelper.CreateParameter("@pstMadreResp", SqlDbType.Char, 1, value.StMadreResp));
         arrPrm.Add(DataHelper.CreateParameter("@pidTipoCenFP", SqlDbType.Char, 3, value.IdTipoCenFP));
         arrPrm.Add(DataHelper.CreateParameter("@pidCentroFP", SqlDbType.Char, 3, value.IdCentroFP));
         arrPrm.Add(DataHelper.CreateParameter("@pidProvDest", SqlDbType.Char, 7, value.IdProvDest));
         arrPrm.Add(DataHelper.CreateParameter("@pidEstaCivil", SqlDbType.Char, 3, value.IdEstaCivil));
         arrPrm.Add(DataHelper.CreateParameter("@pidBcoAbono", SqlDbType.Char, 3, value.IdBcoAbono));
         arrPrm.Add(DataHelper.CreateParameter("@pidTipoCtaAbo", SqlDbType.Char, 3, value.IdTipoCtaAbo));
         arrPrm.Add(DataHelper.CreateParameter("@pnuCtaAbono", SqlDbType.VarChar, 30, value.NuCtaAbono));
         arrPrm.Add(DataHelper.CreateParameter("@pstAsigFami", SqlDbType.Char, 1, value.StAsigFami));
         arrPrm.Add(DataHelper.CreateParameter("@pidBcoCts", SqlDbType.Char, 3, value.IdBcoCts));
         arrPrm.Add(DataHelper.CreateParameter("@pnuCtaCts", SqlDbType.VarChar, 30, value.NuCtaCts));
         arrPrm.Add(DataHelper.CreateParameter("@pidUNegocio", SqlDbType.Char, 3, value.IdUNegocio));
         arrPrm.Add(DataHelper.CreateParameter("@pidCCosto", SqlDbType.Char, 15, value.IdCCosto));
         arrPrm.Add(DataHelper.CreateParameter("@pidTipoSangre", SqlDbType.Char, 3, value.IdTipoSangre));
         arrPrm.Add(DataHelper.CreateParameter("@pdsEnfermedad", SqlDbType.VarChar, 50, value.DsEnfermedad));
         arrPrm.Add(DataHelper.CreateParameter("@pdsAlergia", SqlDbType.VarChar, 50, value.DsAlergia));
         arrPrm.Add(DataHelper.CreateParameter("@pdsPriAuxilios", SqlDbType.VarChar, 50, value.DsPriAuxilios));
         arrPrm.Add(DataHelper.CreateParameter("@pnuTalla", SqlDbType.Decimal, value.NuTalla));
         arrPrm.Add(DataHelper.CreateParameter("@pnuPeso", SqlDbType.Decimal, value.NuPeso));
         arrPrm.Add(DataHelper.CreateParameter("@pdsTallaCalza", SqlDbType.VarChar, 10, value.DsTallaCalza));
         arrPrm.Add(DataHelper.CreateParameter("@pdsTallaPanta", SqlDbType.VarChar, 10, value.DsTallaPanta));
         arrPrm.Add(DataHelper.CreateParameter("@pdsTallaCamisa", SqlDbType.VarChar, 10, value.DsTallaCamisa));
         arrPrm.Add(DataHelper.CreateParameter("@pdsClubSoDe", SqlDbType.VarChar, 80, value.DsClubSoDe));
         arrPrm.Add(DataHelper.CreateParameter("@pdsHobby", SqlDbType.VarChar, 50, value.DsHobby));
         arrPrm.Add(DataHelper.CreateParameter("@pdsReligion", SqlDbType.VarChar, 50, value.DsReligion));
         arrPrm.Add(DataHelper.CreateParameter("@pidEstado", SqlDbType.Char, 3, value.IdEstado));
         arrPrm.Add(DataHelper.CreateParameter("@pnuUltGen01", SqlDbType.Int, value.NuUltGen01));
         arrPrm.Add(DataHelper.CreateParameter("@pstAnulado", SqlDbType.Char, 1, value.StAnulado));


         return arrPrm;

      }

      #endregion

      #region Metodos Personalizados Personal Members

      public int UpdateEstadoFechaCese(IEntityBase value)
      {

          EPersonal objE = (EPersonal)value;

          try
          {

              ArrayList arrPrm = new ArrayList();

              arrPrm.Add(DataHelper.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, objE.IdEmpresa));
              arrPrm.Add(DataHelper.CreateParameter("@pidPersonal", SqlDbType.Char, 7, objE.IdPersonal));
              arrPrm.Add(DataHelper.CreateParameter("@pidSituEmple", SqlDbType.Char, 3, objE.IdSituEmple));
              arrPrm.Add(DataHelper.CreateParameter("@pfeCese", SqlDbType.DateTime, (objE.FeCese.HasValue ? (object)objE.FeCese : DBNull.Value)));
              arrPrm.Add(DataHelper.CreateParameter("@pfeIngPla", SqlDbType.DateTime, (objE.FeIngpla.HasValue ? (object)objE.FeIngpla : DBNull.Value)));
              arrPrm.Add(DataHelper.CreateParameter("@pidMotivFin", SqlDbType.Char, 3, objE.IdMotivFin));

              int intRes = this.ExecuteNonQuery("RH_Personal_mnt10", arrPrm);

              return intRes;

          }
          catch (Exception ex)
          {

              ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
              throw objEx;

          }

      }



       #endregion
   }
}
