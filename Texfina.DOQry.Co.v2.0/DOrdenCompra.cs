using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Texfina.Entity.Co;
using Texfina.Core.Data;
using System.Collections;

namespace Texfina.DOQry.Co
{
    public class DOrdenCompra
    {
        /// <summary>
        /// LLENAR LISTADO DE OC PARA AUTORIZAR
        /// </summary>
        /// <param name="oc"></param>
        /// <returns></returns>
        public static DataSet OrdenCompra_qry01(EOrdenCompra oc)
        {
            DBAccess db = new DBAccess();

            db.AddParameter("@pdte_feordencoini", oc.Fe_ordenco_ini);
            db.AddParameter("@pdte_feordencofin", oc.Fe_ordenco_fin);
            db.AddParameter("@pdte_empresa", oc.Id_Empresa);
            db.AddParameter("@pdte_periodo", oc.Id_periodo);
            db.AddParameter("@pdte_Emitido", oc.strEmitido);
            db.AddParameter("@pdte_Estado", oc.Estado);
            db.AddParameter("@id_ordenco", oc.Id_ordenco);
            return db.ExecuteDataSet("CO_OrdenCompra_qry01");
        }


        public static DataSet OrdenCompra_qry001(EOrdenCompra oc)
        {
            DBAccess db = new DBAccess();
            db.AddParameter("@pdte_empresa", oc.Id_Empresa);
            db.AddParameter("@pdte_periodo", oc.Id_periodo);

            db.AddParameter("@pdte_Estado", oc.Estado);
            return db.ExecuteDataSet("CO_OrdenCompra_qry001");
        }

        /// <summary>
        /// CARGAR LISTADO DE APROBACIONES DE OC
        /// </summary>
        /// <param name="oc"></param>
        /// <returns></returns>

        public static DataSet OrdenCompra_qry02(EOrdenCompra oc)
        {
            DBAccess db = new DBAccess();

            db.AddParameter("@pdte_feordencoini", oc.Fe_ordenco_ini);
            db.AddParameter("@pdte_feordencofin", oc.Fe_ordenco_fin);
            db.AddParameter("@pdte_empresa", oc.Id_Empresa);
            db.AddParameter("@pdte_periodo", oc.Id_periodo);
            db.AddParameter("@pdte_Emitido", oc.strEmitido);
            db.AddParameter("@pdte_Estado", oc.Estado);
            db.AddParameter("@id_ordenco", oc.Id_ordenco);
            return db.ExecuteDataSet("CO_OrdenCompra_qry02");
        }


        public static DataSet OrdenCompra_qry002(EOrdenCompra oc) 
        {
            DBAccess db = new DBAccess();

            db.AddParameter("@pdte_empresa", oc.Id_Empresa);
            db.AddParameter("@pdte_periodo", oc.Id_periodo);
            db.AddParameter("@pdte_Estado", oc.Estado);

            return db.ExecuteDataSet("CO_OrdenCompra_qry002");
        }


        public static DataSet OrdenCompra_qry04(EParOCFillrpt parametro)
        {
            DBAccess db = new DBAccess();

            db.AddParameter("@psintypesel", parametro.psintypesel);
            db.AddParameter("@idPeriodo", parametro.IdAnio);
            db.AddParameter("@idEmpresa", parametro.IdEmpresa);
            db.AddParameter("@idOrdenCompra", parametro.IdOrdenCompra);
            db.AddParameter("@dsRazonSoc", parametro.dsRazonSoc);
            db.AddParameter("@fechaIni", parametro.fechaini);
            db.AddParameter("@fechaFin", parametro.fechaFin);
            db.AddParameter("@local", parametro.local);
            db.AddParameter("@dsproducto", parametro.idProducto);
                
            //db.AddParameter("@pdte_Estado", estado);
           return db.ExecuteDataSet("CO_OrdenCompra_qry03");
         
        }

        /// <summary>
        /// AUTORIZACION DE OC
        /// </summary>
        /// <param name="oc"></param>
        /// <returns></returns>

        public static DataSet OrdenCompra_mnt01(EOrdenCompra oc)
        {
            DBAccess db = new DBAccess();

            db.AddParameter("@psin_typeupd", oc.psin_typeupd);
            db.AddParameter("@pchr_idordenco", oc.Id_ordenco);
            db.AddParameter("@pchr_stordenco", oc.stordenco);
            db.AddParameter("@pchr_idautoriza", oc.Id_autoriza);
            db.AddParameter("@pvch_user", oc.Id_uupdarec);
            db.AddParameter("@pchr_idEmpresa", oc.Id_Empresa);
            db.AddParameter("@pchr_idPeriodo", oc.Id_periodo);


            return db.ExecuteDataSet("CO_OcCambioEstado");
        }


        public static DataSet OrdenCompra_Habilitar(EOrdenCompra oc)
        {
            DBAccess db = new DBAccess();


            db.AddParameter("@id_ordenco", oc.Id_ordenco);
            db.AddParameter("@id_Empresa", oc.Id_Empresa);
            db.AddParameter("@id_periodo", oc.Id_periodo);


            return db.ExecuteDataSet("CO_OrdenCompra_Habilitar");
        }
        /// <summary>
        /// APROBACION DE OC
        /// </summary>
        /// <param name="oc"></param>
        /// <returns></returns>

        public static DataSet OrdenCompra_mnt02(EOrdenCompra oc)
        {
            DBAccess db = new DBAccess();

            db.AddParameter("@psin_typeupd", oc.psin_typeupd);
            db.AddParameter("@pchr_idordenco", oc.Id_ordenco);
            db.AddParameter("@pchr_stordenco", oc.stordenco);
            db.AddParameter("@pchr_idautoriza", oc.Id_aprueba);
            db.AddParameter("@pvch_user", oc.Id_uupdarec);
            db.AddParameter("@pchr_idEmpresa", oc.Id_Empresa);
            db.AddParameter("@pchr_idPeriodo", oc.Id_periodo);


            return db.ExecuteDataSet("CO_OcCambioEstado");
        }

        //generar codigo para la OC
        public static IDataReader OrdenCompra_qry03(string idPeriodo, string idEmpresa)
        {
            DBAccess db = new DBAccess();
            db.AddParameter("@idPeriodo", idPeriodo);
            db.AddParameter("@idEmpresa", idEmpresa);
            return db.ExecuteReader("MG_GencodigoComp");
        }

        // genera codigo de la oc en descktop

        public static List<Dato> OrdenCompra_qry03_(string commandtext, string par1,string idPeriodo, string idEmpresa)
        {
            List<Dato> _lista = new List<Dato>();

            DBAccess db = new DBAccess();
            db.AddParameter("@idPeriodo",idPeriodo);
            db.AddParameter("@idEmpresa", idEmpresa);

            IDataReader reader = db.ExecuteReader(commandtext);

            while (reader.Read())
            {
                Dato _dato = new Dato();

                _dato.id = reader[par1].ToString();
               
                _lista.Add(_dato);
            }
            return _lista;
        }

        // obtener el usuario para la oc - (campo emitido por) 

        public static IDataReader OrdenCompra_Usuario_qry(string dsRS)
        {
            DBAccess db = new DBAccess();
            db.AddParameter("@dsRazonSocial", dsRS);
            return db.ExecuteReader("CO_UsuarioPersonal");
        }
        /// <summary>
        /// codigo para desktop OrdenCompra_Usuario_qry_
        /// </summary>
       
        /// <returns></returns>

        public static List<Dato> OrdenCompra_Usuario_qry_(String dsRS)
        {
            List<Dato> _lista = new List<Dato>();

            DBAccess db = new DBAccess();
            db.AddParameter("@dsRazonSocial", dsRS);
           

            IDataReader reader = db.ExecuteReader("CO_UsuarioPersonal");

            while (reader.Read())
            {
                Dato _dato = new Dato();

                _dato.id = reader["idPersonal"].ToString();
                _dato.desc = reader["dsRazSocial"].ToString();
                _lista.Add(_dato);
            }
            return _lista;
        }


        //Insertar la oc

        public static void OrdenCompra_mnt03(EOrdenCompra oc)
        {
            DBAccess db = new DBAccess();

            db.AddParameter("@pid_periodo", oc.Id_periodo);
            db.AddParameter("@pid_ordenco", oc.Id_ordenco);
            db.AddParameter("@pid_importa", oc.Id_importa);
            db.AddParameter("@pid_Exporta", oc.Id_Exporta);
            db.AddParameter("@pid_cotiza", oc.Id_cotiza);
            db.AddParameter("@pfe_ordenco", oc.Fe_ordenco);
            db.AddParameter("@pfe_entrega", oc.Fe_entrega);
            db.AddParameter("@pid_docucom", oc.Id_docucom);
            db.AddParameter("@pnu_docu", oc.Nu_docu);
            db.AddParameter("@pid_clipro", oc.Id_clipro);
            db.AddParameter("@pid_clipro2", oc.Id_clipro2);
            db.AddParameter("@pid_clipro3", oc.Id_clipro3);
            db.AddParameter("@pid_condpago", oc.Id_condpago);
            db.AddParameter("@pid_personal", oc.Id_personal);
            db.AddParameter("@pid_local", oc.Id_local);
            db.AddParameter("@pid_local2", oc.Id_local2);
            db.AddParameter("@pid_personal2", oc.Id_personal2);
            db.AddParameter("@pds_observa", oc.Ds_observa);
            db.AddParameter("@pid_vmoneda", oc.Id_vmoneda);
            db.AddParameter("@pmt_total", oc.Mt_total);
            db.AddParameter("@pmt_tc", oc.Mt_tc);
            db.AddParameter("@pid_modcomp", oc.Id_modcomp);
            db.AddParameter("@pid_tipcomp", oc.Id_tipcomp);
            db.AddParameter("@pid_prioridad", oc.Id_prioridad);
            db.AddParameter("@pid_aprueba", oc.Id_aprueba);
            db.AddParameter("@pst_aprueba", oc.St_aprueba);
            db.AddParameter("@pid_autoriza", oc.Id_autoriza);
            db.AddParameter("@pst_ordenco", oc.St_ordenco);
            db.AddParameter("@pid_ucrearec", oc.Id_ucrearec);
            db.AddParameter("@pid_uupdarec", oc.Id_uupdarec);
            db.AddParameter("@pst_anulado", oc.St_anulado);
            db.AddParameter("@pid_empresa", oc.Id_Empresa);
            db.AddParameter("@pid_stfactura", oc.stfactura);

            db.ExecuteNonQuery("CO_Ordencompra_mmt01");

        }

        public static EOrdenCompra mObtenerOCompra(EOrdenCompra ocOmpra)
        {
            DBAccess db = new DBAccess();
            db.AddParameter("@pchr_idperiodo", ocOmpra.Id_periodo);
            db.AddParameter("@pchr_idordenco", ocOmpra.Id_ordenco);
            db.AddParameter("@pdte_empresa", ocOmpra.idEmpresa);

            List<EOrdenCompra> result = new List<EOrdenCompra>();
            using (IDataReader rd = db.ExecuteReader("CO_OrdenCompraGetQrt01"))
            {
                while (rd.Read())
                {
                    return mCargarOC(rd);
                }
            }

            return ocOmpra;
        }


        public static EOrdenCompra mObtenerOCompraEstado(EOrdenCompra ocOmpra)
        {
            DBAccess db = new DBAccess();
            db.AddParameter("@pid_periodo", ocOmpra.Id_periodo);
            db.AddParameter("@pid_empresa", ocOmpra.idEmpresa);
            db.AddParameter("@pid_ordenco", ocOmpra.Id_ordenco);

            List<EOrdenCompra> result = new List<EOrdenCompra>();
            using (IDataReader rd = db.ExecuteReader("CO_OrdenCompra_Estado"))
            {
                while (rd.Read())
                {
                    return mCargarOCEstado(rd);
                }
            }

            return ocOmpra;
        }

        private static EOrdenCompra mCargarOCEstado(IDataReader rdr)
        {
            EOrdenCompra oCompra = new EOrdenCompra();
            oCompra.estadoOC = rdr.IsDBNull(rdr.GetOrdinal("ESTADO")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ESTADO"));
          
            return oCompra;
        }

        private static EOrdenCompra mCargarOC(IDataReader rdr)
        {
            EOrdenCompra oCompra = new EOrdenCompra();
            oCompra.Id_ordenco = rdr.IsDBNull(rdr.GetOrdinal("id_ordenco")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_ordenco"));
            oCompra.Fe_ordenco = rdr.IsDBNull(rdr.GetOrdinal("fe_ordenco")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("fe_ordenco"));
            oCompra.Id_clipro = rdr.IsDBNull(rdr.GetOrdinal("id_clipro")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_clipro"));
            oCompra.clipro = rdr.IsDBNull(rdr.GetOrdinal("clipro")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("clipro"));
            oCompra.Id_local = rdr.IsDBNull(rdr.GetOrdinal("id_local")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_local"));
            oCompra.Id_personal = rdr.IsDBNull(rdr.GetOrdinal("id_personal")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_personal"));
            oCompra.Pedidop = rdr.IsDBNull(rdr.GetOrdinal("pedidop")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("pedidop"));
            oCompra.Id_local2 = rdr.IsDBNull(rdr.GetOrdinal("id_local2")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_local2"));
            oCompra.Id_personal2 = rdr.IsDBNull(rdr.GetOrdinal("id_personal2")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_personal2"));
            oCompra.Emitidap = rdr.IsDBNull(rdr.GetOrdinal("emitidap")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("emitidap"));
            oCompra.Id_prioridad = rdr.IsDBNull(rdr.GetOrdinal("id_prioridad")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_prioridad"));
            oCompra.Ds_observa = rdr.IsDBNull(rdr.GetOrdinal("ds_observa")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_observa"));
            oCompra.Id_condpago = rdr.IsDBNull(rdr.GetOrdinal("id_condpago")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_condpago"));
            oCompra.dsCondPago = rdr.IsDBNull(rdr.GetOrdinal("condpago")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("condpago"));
            oCompra.Id_tipcomp = rdr.IsDBNull(rdr.GetOrdinal("id_tipcomp")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_tipcomp"));
            oCompra.Id_modcomp = rdr.IsDBNull(rdr.GetOrdinal("id_modcomp")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_modcomp"));
            oCompra.Id_importa = rdr.IsDBNull(rdr.GetOrdinal("id_importa")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_importa"));
            oCompra.Ds_importa = rdr.IsDBNull(rdr.GetOrdinal("ds_importa")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_importa"));

            oCompra.Id_Exporta = rdr.IsDBNull(rdr.GetOrdinal("id_Exporta")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_Exporta"));
            oCompra.Ds_Exporta = rdr.IsDBNull(rdr.GetOrdinal("ds_Exporta")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_Exporta"));

            oCompra.Id_vmoneda = rdr.IsDBNull(rdr.GetOrdinal("id_vmoneda")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_vmoneda"));

            oCompra.Mt_tc = rdr.IsDBNull(rdr.GetOrdinal("mt_tc")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("mt_tc"));
            oCompra.Fe_entrega = rdr.IsDBNull(rdr.GetOrdinal("fe_entrega")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("fe_entrega"));
            oCompra.Mt_total = rdr.IsDBNull(rdr.GetOrdinal("mt_total")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("mt_total"));

            oCompra.Nu_docu = rdr.IsDBNull(rdr.GetOrdinal("nu_factura")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("nu_factura"));

            oCompra.stordenco = rdr.IsDBNull(rdr.GetOrdinal("st_ordenco")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("st_ordenco"));

            return oCompra;
        }

        public static EOrdenCompra mObtenerOCompra_(EOrdenCompra ocOmpra) //obtiene la consulta de factura
        {
            DBAccess db = new DBAccess();
            db.AddParameter("@pchr_idperiodo", ocOmpra.Id_periodo);
            db.AddParameter("@pchr_idordenco", ocOmpra.Id_ordenco);
            db.AddParameter("@pdte_empresa", ocOmpra.idEmpresa);

            List<EOrdenCompra> result = new List<EOrdenCompra>();
            using (IDataReader rd = db.ExecuteReader("CO_OrdenCompraGetQrt01"))
            {
                while (rd.Read())
                {
                    return mCargarOC_(rd);
                }
            }

            return ocOmpra;
        }

        private static EOrdenCompra mCargarOC_(IDataReader rdr) // consulta para cargar la factura
        {
            EOrdenCompra oCompra = new EOrdenCompra();
            oCompra.Id_ordenco = rdr.IsDBNull(rdr.GetOrdinal("id_ordenco")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_ordenco"));
            oCompra.Fe_ordenco = rdr.IsDBNull(rdr.GetOrdinal("fe_ordenco")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("fe_ordenco"));
            oCompra.Id_clipro = rdr.IsDBNull(rdr.GetOrdinal("id_clipro")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_clipro"));
            oCompra.clipro = rdr.IsDBNull(rdr.GetOrdinal("clipro")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("clipro"));
            oCompra.Ds_observa = rdr.IsDBNull(rdr.GetOrdinal("ds_observa")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_observa"));
            oCompra.Mt_total = rdr.IsDBNull(rdr.GetOrdinal("mt_total")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("mt_total"));
            oCompra.Id_vmoneda = rdr.IsDBNull(rdr.GetOrdinal("id_vmoneda")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_vmoneda"));


            oCompra.stordenco = rdr.IsDBNull(rdr.GetOrdinal("st_ordenco")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("st_ordenco")); // aprobado

            oCompra.st_autorizado = rdr.IsDBNull(rdr.GetOrdinal("st_autorizado")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("st_autorizado")); // Autorizado


            return oCompra;
        }

        //----------------------------------REPORTES---------------------------------------------------------------------------------------------------------------


        public DataTable GetOrdenCompra_rpt01(EParOCFillrpt oc)
        {
            DBAccess db = new DBAccess();
            ArrayList arrPrm = new ArrayList();

            arrPrm.Add(DBAccess.CreateParameter("@idEmpresa", SqlDbType.Char, 3, oc.IdEmpresa));
            arrPrm.Add(DBAccess.CreateParameter("@anio", SqlDbType.VarChar, 5, oc.IdAnio));
            arrPrm.Add(DBAccess.CreateParameter("@mes", SqlDbType.VarChar, 16, oc.IdMesIni));


            DataTable dt = db.ExecuteDatatable("CO_OrdenCompra_qry01_rpt", arrPrm);
            return dt;
        }



        public DataTable GetOrdenCompra_rpt02(EParOCFillrpt oc)
        {
            DBAccess db = new DBAccess();
            ArrayList arrPrm = new ArrayList();

            arrPrm.Add(DBAccess.CreateParameter("@pchr_idperiodo", SqlDbType.Char, 4, oc.IdAnio));
            arrPrm.Add(DBAccess.CreateParameter("@pchr_idordenco", SqlDbType.Char, 7, oc.IdOrdenCompra));
            arrPrm.Add(DBAccess.CreateParameter("@pdte_empresa", SqlDbType.Char, 3, oc.IdEmpresa));

            DataTable dt = db.ExecuteDatatable("RPT_OrdenCompra", arrPrm);
            return dt;
        }

        // orden de compra por proveedor
        public DataTable GetOrdenCompra_rpt03(EParOCFillrpt oc)
        {
            DBAccess db = new DBAccess();
            ArrayList arrPrm = new ArrayList();


            arrPrm.Add(DBAccess.CreateParameter("@idEmpresa", SqlDbType.Char, 3, oc.IdEmpresa));
            arrPrm.Add(DBAccess.CreateParameter("@fechaIni", SqlDbType.DateTime, oc.fechaini));
            arrPrm.Add(DBAccess.CreateParameter("@fechaFin", SqlDbType.DateTime, oc.fechaFin));
            arrPrm.Add(DBAccess.CreateParameter("@idcliprov", SqlDbType.VarChar, oc.idProv));


            DataTable dt = db.ExecuteDatatable("CO_OrdenCompraXprov_qry03_rpt", arrPrm);
            return dt;
        }


        //reprote de orden de compra por proveedor
        public DataTable GetOrdenCompra_rpt04(EParOCFillrpt oc)
        {
            DBAccess db = new DBAccess();
            ArrayList arrPrm = new ArrayList();

            arrPrm.Add(DBAccess.CreateParameter("@idEmpresa", SqlDbType.Char, 3, oc.IdEmpresa));
            arrPrm.Add(DBAccess.CreateParameter("@año", SqlDbType.VarChar, 5, oc.IdAnio));
            arrPrm.Add(DBAccess.CreateParameter("@mes", SqlDbType.VarChar, 16, oc.IdMesIni));
            arrPrm.Add(DBAccess.CreateParameter("@prov", SqlDbType.VarChar, 6, oc.idProv));
            arrPrm.Add(DBAccess.CreateParameter("@fac", SqlDbType.VarChar, 8, oc.nuFactura));
            arrPrm.Add(DBAccess.CreateParameter("@impotacion", SqlDbType.VarChar, 10, oc.nuImportacion));
            arrPrm.Add(DBAccess.CreateParameter("@Expotacion", SqlDbType.VarChar, 10, oc.nuExportacion));

            DataTable dt = db.ExecuteDatatable("CO_OrdenCompra_qry02_rpt", arrPrm);
            return dt;
        }



        private static EOrdenCompra mCargarExistenciaOc(IDataReader rdr)
        {
            EOrdenCompra oOC = new EOrdenCompra();
            oOC.existe = rdr.IsDBNull(rdr.GetOrdinal("existe")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("existe"));
            return oOC;
        }

        public static List<EOrdenCompra> CO_OrdenCompra_qry05(EOrdenCompra oOC)
        {
            DBAccess db = new DBAccess();
            db.AddParameter("@pid_periodo", oOC.Id_periodo);
            db.AddParameter("@pid_ordenco", oOC.Id_ordenco);
            db.AddParameter("@pidEmpresa", oOC.idEmpresa);


            List<EOrdenCompra> result = new List<EOrdenCompra>();

            using (IDataReader rdr = db.ExecuteReader("CO_OrdenCompra_qry05"))
            {
                while (rdr.Read())
                {
                    result.Add(mCargarExistenciaOc(rdr));
                }
            }
            return result;
        }


        //public DataTable CO_OrdenCompra_qry07_rpt(EParOCFillrpt oc)
        //{
        //    DBAccess db = new DBAccess();
        //    ArrayList arrPrm = new ArrayList();

        //    arrPrm.Add(DBAccess.CreateParameter("@idEmpresa", SqlDbType.Char, 3, oc.IdEmpresa));
        //    arrPrm.Add(DBAccess.CreateParameter("@anio", SqlDbType.VarChar, 5, oc.IdAnio));
        //    arrPrm.Add(DBAccess.CreateParameter("@mesIni", SqlDbType.VarChar, 16, oc.IdMesIni));
        //    arrPrm.Add(DBAccess.CreateParameter("@mesFin", SqlDbType.VarChar, 16, oc.IdMesfin));
        //    arrPrm.Add(DBAccess.CreateParameter("@st_aprueba", SqlDbType.VarChar, 1, oc.st_aprueba));

        //    DataTable dt = db.ExecuteDatatable("CO_OrdenCompra_qry07_rpt", arrPrm);
        //    return dt;
        //}

        public static void CO_OrdenCompra_qry07_rpt(EParOCFillrpt oc)
        {
            DBAccess db = new DBAccess();

            db.AddParameter("@idEmpresa", oc.IdEmpresa);
            db.AddParameter("@anio", oc.IdAnio);
            db.AddParameter("@mesIni", oc.IdMesIni);
            db.AddParameter("@mesFin", oc.IdMesfin);
            db.AddParameter("@st_aprueba", oc.st_aprueba);
            db.ExecuteNonQuery("CO_OrdenCompra_qry07_rpt");

        }





        public DataTable CO_OrdenCompra_qry06_rpt(EParOCFillrpt oc)
        {
            DBAccess db = new DBAccess();
            ArrayList arrPrm = new ArrayList();

            arrPrm.Add(DBAccess.CreateParameter("@idEmpresa", SqlDbType.Char, 3, oc.IdEmpresa));
            arrPrm.Add(DBAccess.CreateParameter("@anio", SqlDbType.VarChar, 4, oc.IdAnio));
            arrPrm.Add(DBAccess.CreateParameter("@mesIni", SqlDbType.VarChar, 2, oc.IdMesIni));
            arrPrm.Add(DBAccess.CreateParameter("@mesFin", SqlDbType.VarChar, 2, oc.IdMesfin));
            arrPrm.Add(DBAccess.CreateParameter("@st_aprueba", SqlDbType.VarChar, 1, oc.st_aprueba));

            DataTable dt = db.ExecuteDatatable("CO_OrdenCompra_qry06_rpt", arrPrm);
            return dt;
        }



        public DataTable CO_OrdenCompra_qry08_rpt(EParOCFillrpt oc)
        {
            DBAccess db = new DBAccess();
            ArrayList arrPrm = new ArrayList();

            arrPrm.Add(DBAccess.CreateParameter("@idEmpresa", SqlDbType.Char, 3, oc.IdEmpresa));
            arrPrm.Add(DBAccess.CreateParameter("@anio", SqlDbType.VarChar, 4, oc.IdAnio));
            arrPrm.Add(DBAccess.CreateParameter("@mesIni", SqlDbType.VarChar, 2, oc.IdMesIni));
            arrPrm.Add(DBAccess.CreateParameter("@mesFin", SqlDbType.VarChar, 2, oc.IdMesfin));
            arrPrm.Add(DBAccess.CreateParameter("@st_aprueba", SqlDbType.VarChar, 1, oc.st_aprueba));

            DataTable dt = db.ExecuteDatatable("CO_OrdenCompra_qry08_rpt", arrPrm);
            return dt;
        }


        public DataTable CO_OrdenCompra_qry09_rpt(EParOCFillrpt oc)
        {
            DBAccess db = new DBAccess();
            ArrayList arrPrm = new ArrayList();

            arrPrm.Add(DBAccess.CreateParameter("@idEmpresa", SqlDbType.Char, 3, oc.IdEmpresa));
            arrPrm.Add(DBAccess.CreateParameter("@anio", SqlDbType.VarChar, 4, oc.IdAnio));
            arrPrm.Add(DBAccess.CreateParameter("@mesIni", SqlDbType.VarChar, 2, oc.IdMesIni));
            arrPrm.Add(DBAccess.CreateParameter("@mesFin", SqlDbType.VarChar, 2, oc.IdMesfin));
            arrPrm.Add(DBAccess.CreateParameter("@st_aprueba", SqlDbType.VarChar, 1, oc.st_aprueba));

            DataTable dt = db.ExecuteDatatable("CO_OrdenCompra_qry09_rpt", arrPrm);
            return dt;
        }


        /*MODIFICACION*/
        //public DataTable CO_OrdenCompra_qry07_rpt(EParOCFillrpt oc)
        //{
        //    DBAccess db = new DBAccess();
        //    ArrayList arrPrm = new ArrayList();

        //    arrPrm.Add(DBAccess.CreateParameter("@idEmpresa", SqlDbType.Char, 3, oc.IdEmpresa));
        //    arrPrm.Add(DBAccess.CreateParameter("@anio", SqlDbType.VarChar, 4, oc.IdAnio));
        //    arrPrm.Add(DBAccess.CreateParameter("@mesIni", SqlDbType.VarChar, 2, oc.IdMesIni));
        //    arrPrm.Add(DBAccess.CreateParameter("@mesFin", SqlDbType.VarChar, 2, oc.IdMesfin));
        //    arrPrm.Add(DBAccess.CreateParameter("@st_aprueba", SqlDbType.VarChar, 1, oc.st_aprueba));

        //    DataTable dt = db.ExecuteDatatable("VE_OrdenPedido_qry07 ", arrPrm);
        //    return dt;
        //}
        /*MODIFICACION*/


    }

}
