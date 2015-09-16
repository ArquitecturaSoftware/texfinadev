using System;
using System.Data;
using System.Text;
using System.Collections;
using System.Reflection;
using System.Data.SqlClient;
using Texfina.Core.Data;
using Texfina.Entity.Sy;
using Texfina.DOMnt.Sy;
using Texfina.Core.Common;

namespace Texfina.DOMnt.Sy
{
   /// <summary>
   /// Data Object para mantenimiento a la Tabla SY_Usuario
   /// </summary>
   /// <remarks></remarks>
   public class Usuario : DataObjectBase, IDOUpdate
   {

      #region IDOUpdate Members

      public object[] Insert(IEntityBase value)
      {

         EUsuario objE = (EUsuario)value;

         //----------- Generacion de Codigos ------------------
         TablaCorreDet objDO = new TablaCorreDet();
         ETablaCorreDet objECorre = new ETablaCorreDet();

         objECorre.IdPeriodo = ConstDefaultValue.PERIODO;
         objECorre.IdEmpresa = ConstDefaultValue.EMPRESA;
         objECorre.IdTabla = "SY_Usuario";
         objECorre.IdItem = objE.StGrupo == ConstFlagEstado.ACTIVADO ? ConstSegTipoUsuario.GRUPO : ConstSegTipoUsuario.USUARIO;

         string strNewCode = objDO.GenNewCode(objECorre);
         objE.IdUser = (objE.StGrupo == ConstFlagEstado.ACTIVADO ? ConstSegTipoUsuario.GRUPO : ConstSegTipoUsuario.USUARIO) 
            + strNewCode;

         //----------------------------------------------------
         ArrayList arrPrm = BuildParamInterface(objE);

         try
         {
            int intRes = this.ExecuteNonQuery("SY_Usuario_mnt01", arrPrm);

            return new object[] { objE.IdUser };

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }

      }

      public int Update(IEntityBase value)
      {

         EUsuario objE = (EUsuario)value;

         try
         {

            ArrayList arrPrm = BuildParamInterface(objE);

            int intRes = this.ExecuteNonQuery("SY_Usuario_mnt02", arrPrm);

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

         EUsuario objE = (EUsuario)value;

         try
         {

            ArrayList arrPrm = new ArrayList();


            arrPrm.Add(DataHelper.CreateParameter("@pidUser", SqlDbType.Char, 5, objE.IdUser));

            int intRes = this.ExecuteNonQuery("SY_Usuario_mnt03", arrPrm);

            return intRes;

         }
         catch (Exception ex)
         {

            ServerObjectException objEx = (ServerObjectException)this.GetException(MethodBase.GetCurrentMethod(), ex);
            throw objEx;

         }

      }

      private ArrayList BuildParamInterface(EUsuario value)
      {

         ArrayList arrPrm = new ArrayList();

         arrPrm.Add(DataHelper.CreateParameter("@pidUser", SqlDbType.Char, 5, value.IdUser));
         arrPrm.Add(DataHelper.CreateParameter("@pidLogon", SqlDbType.VarChar, 30, value.IdLogon));
         arrPrm.Add(DataHelper.CreateParameter("@pstGrupo", SqlDbType.Char, 1, value.StGrupo));
         arrPrm.Add(DataHelper.CreateParameter("@pdsNombres", SqlDbType.VarChar, 50, value.DsNombres));
         if (value.IdPassword == null)
            arrPrm.Add(DataHelper.CreateParameter("@pidPassword", SqlDbType.Binary, DBNull.Value));
         else
            arrPrm.Add(DataHelper.CreateParameter("@pidPassword", SqlDbType.Binary, value.IdPassword));

         arrPrm.Add(DataHelper.CreateParameter("@pidClavePub", SqlDbType.Binary, value.IdClavePub));
         arrPrm.Add(DataHelper.CreateParameter("@pstCamPswPrx", SqlDbType.Char, 1, value.StCamPswPrx));
         arrPrm.Add(DataHelper.CreateParameter("@pstNoCamPsw", SqlDbType.Char, 1, value.StNoCamPsw));
         arrPrm.Add(DataHelper.CreateParameter("@pstNoExpira", SqlDbType.Char, 1, value.StNoExpira));
         arrPrm.Add(DataHelper.CreateParameter("@pfeExpira", SqlDbType.DateTime, (value.FeExpira.HasValue ? (object)value.FeExpira : DBNull.Value)));
         arrPrm.Add(DataHelper.CreateParameter("@pstRegSist", SqlDbType.Char, 1, value.StRegSist));
         arrPrm.Add(DataHelper.CreateParameter("@pstAnulado", SqlDbType.Char, 1, value.StAnulado));

         return arrPrm;

      }

      #endregion

   }
}