using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Texfina.Entity.Co;
using Texfina.Core.Data;
using System.Data;

namespace Texfina.DOQry.Co
{
    public class DDetOrdenCompra
    {
        public static void OrdenCompra_mnt03(EDetOrdenCompra oc)
        {
            DBAccess db = new DBAccess();

            db.AddParameter("@pid_periodo", oc.Id_periodo);
            db.AddParameter("@pid_op", oc.Id_op);
            db.AddParameter("@pid_ordenco", oc.Id_ordenco);
            db.AddParameter("@pnu_correla", oc.Nu_correla);
            db.AddParameter("@pnu_lote", oc.Nu_lote);
            db.AddParameter("@pid_producto", oc.Id_producto);
            db.AddParameter("@pid_prodprese", oc.Id_prodprese);
            db.AddParameter("@pqt_producto", oc.Qt_producto);
            db.AddParameter("@pqt_difcierre", oc.Qt_difcierre);
            db.AddParameter("@pid_vmoneda", oc.Id_vmoneda);
            db.AddParameter("@pqt_pesobruto", oc.Qt_pesobruto);
            db.AddParameter("@pqt_pesoneto", oc.Qt_pesoneto);
            db.AddParameter("@pmt_precuni", oc.Mt_precuni);
            db.AddParameter("@pmt_igv", oc.Mt_igv);
            db.AddParameter("@pmt_subtotal", oc.Mt_subtotal);
            db.AddParameter("@pnu_pordscto", oc.Nu_pordscto);
            db.AddParameter("@pmt_dscto", oc.Mt_dscto);

            db.AddParameter("@pid_clase", oc.Id_clase);
            db.AddParameter("@pid_tipogsto", oc.Id_tipogsto);
            db.AddParameter("@pid_ccosto", oc.Id_ccosto);
            db.AddParameter("@pid_cgasto", oc.Id_cgasto);
            
            db.AddParameter("@pid_tipgstimp", oc.Id_tipgstimp);
            db.AddParameter("@pst_gastodist", oc.St_gastodist);
            db.AddParameter("@pid_ucrearec", oc.Id_ucrearec);
            db.AddParameter("@pid_uupdarec", oc.Id_uupdarec);
            db.AddParameter("@pst_anulado", oc.St_anulado);
            db.AddParameter("@pid_empresa", oc.idEmpresa);
            db.AddParameter("@str_Observ", oc._Detalle);

            db.ExecuteNonQuery("CO_DetOrdenCompra_mnt01");

        }


        private static  EDetProducto mCargarDetOrdenCompra(IDataReader rdr)
        {
            EDetProducto oCompra = new EDetProducto();
            oCompra._Nu_Correla = rdr.IsDBNull(rdr.GetOrdinal("nu_correla")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("nu_correla"));
            oCompra._Codigo = rdr.IsDBNull(rdr.GetOrdinal("id_producto")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_producto"));
            oCompra._Pres = rdr.IsDBNull(rdr.GetOrdinal("id_prodprese")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_prodprese"));
            oCompra._Producto = rdr.IsDBNull(rdr.GetOrdinal("ds_producto")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_producto"));
            oCompra._Presenta = rdr.IsDBNull(rdr.GetOrdinal("ds_prodprese")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_prodprese"));
            oCompra._UM = rdr.IsDBNull(rdr.GetOrdinal("unimedida")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("unimedida"));
            oCompra._Peso_Bruto = rdr.IsDBNull(rdr.GetOrdinal("qt_pesobruto")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("qt_pesobruto"));
            oCompra._Lote = rdr.IsDBNull(rdr.GetOrdinal("nu_lote")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("nu_lote"));
            oCompra._fe_venc = rdr.IsDBNull(rdr.GetOrdinal("fe_venclote")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("fe_venclote"));
            oCompra._fe_Entrega =rdr.IsDBNull(rdr.GetOrdinal("fe_entrega")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("fe_entrega"));
            oCompra._OP = rdr.IsDBNull(rdr.GetOrdinal("id_op")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_op"));
            oCompra._Cant = rdr.IsDBNull(rdr.GetOrdinal("qt_producto")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("qt_producto"));
            oCompra._PreNeto = rdr.IsDBNull(rdr.GetOrdinal("qt_pesoneto")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("qt_pesoneto"));
            oCompra._PreUnit = rdr.IsDBNull(rdr.GetOrdinal("mt_precuni")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("mt_precuni"));
            oCompra._nu_pordscto = rdr.IsDBNull(rdr.GetOrdinal("pordsc")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("pordsc"));
            oCompra._Igv = rdr.IsDBNull(rdr.GetOrdinal("mt_igv")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("mt_igv"));

            oCompra._idclase = rdr.IsDBNull(rdr.GetOrdinal("id_clase")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_clase"));

            oCompra._Tipgasto = (rdr.IsDBNull(rdr.GetOrdinal("id_tipogsto")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_tipogsto"))).ToString().Trim();

            oCompra._dstg = (rdr.IsDBNull(rdr.GetOrdinal("ds_tipogsto")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_tipogsto"))).ToString().Trim();

            oCompra._id_Gasto = (rdr.IsDBNull(rdr.GetOrdinal("id_cgasto")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_cgasto"))).ToString().Trim();
            oCompra._C_Gasto = (rdr.IsDBNull(rdr.GetOrdinal("ds_cgasto")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_cgasto"))).ToString().Trim();
            oCompra._idCosto = rdr.IsDBNull(rdr.GetOrdinal("id_ccosto")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_ccosto"));
            oCompra._C_Costos = rdr.IsDBNull(rdr.GetOrdinal("ds_ccosto")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_ccosto"));
            oCompra._id_tipgstimp = rdr.IsDBNull(rdr.GetOrdinal("id_tipgstimp")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_tipgstimp"));
            oCompra._Dscto = rdr.IsDBNull(rdr.GetOrdinal("mt_dscto")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("mt_dscto"));
            oCompra._subTotal = rdr.IsDBNull(rdr.GetOrdinal("mt_subtotal")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("mt_subtotal"));
            oCompra._detalle = rdr.IsDBNull(rdr.GetOrdinal("detalle")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("detalle"));
            oCompra._clase = rdr.IsDBNull(rdr.GetOrdinal("clase")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("clase"));
            return oCompra;
        }

        public static List<EDetProducto> mListarDetOrdenCompra(EOrdenCompra oc)
        {
            DBAccess db = new DBAccess();
            db.AddParameter("@pchr_idperiodo", oc.Id_periodo);
            db.AddParameter("@pchr_idordenco", oc.Id_ordenco);
            db.AddParameter("@idEmpresa", oc.idEmpresa);

            List<EDetProducto> result = new List<EDetProducto>();

            using (IDataReader rdr = db.ExecuteReader("CO_ordencodet_qry01"))
            {
                while (rdr.Read())
                {
                    result.Add(mCargarDetOrdenCompra(rdr));
                }
            }
            return result;
        }

        private static EDetProducto mCargarDetOrdenCompraFac(IDataReader rdr)
        {
            EDetProducto oCompra = new EDetProducto();
            oCompra._Nu_Correla = rdr.IsDBNull(rdr.GetOrdinal("nu_correla")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("nu_correla")).ToString().Trim();
            oCompra._Codigo = rdr.IsDBNull(rdr.GetOrdinal("id_producto")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_producto")).ToString().Trim();

            oCompra._Pres = rdr.IsDBNull(rdr.GetOrdinal("id_prodprese")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_prodprese")).ToString().Trim();
            oCompra._Presenta = rdr.IsDBNull(rdr.GetOrdinal("ds_prodprese")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_prodprese"));

            oCompra.Id_vunicons = rdr.IsDBNull(rdr.GetOrdinal("id_vunicons")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_vunicons")).ToString().Trim();
            oCompra._Producto = rdr.IsDBNull(rdr.GetOrdinal("ds_producto")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_producto")).ToString().Trim();
            oCompra._Peso_Bruto = rdr.IsDBNull(rdr.GetOrdinal("qt_pesobruto")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("qt_pesobruto"));
            oCompra._Cant = rdr.IsDBNull(rdr.GetOrdinal("qt_producto")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("qt_producto"));
            oCompra._cantReciv = rdr.IsDBNull(rdr.GetOrdinal("qt_difcierre")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("qt_difcierre"));
            oCompra._cantReg =  oCompra._Cant - oCompra._cantReciv;
            oCompra._PreNeto = rdr.IsDBNull(rdr.GetOrdinal("qt_pesoneto")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("qt_pesoneto"));
            oCompra._PreUnit = rdr.IsDBNull(rdr.GetOrdinal("mt_precuni")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("mt_precuni"));
            oCompra._Igv = rdr.IsDBNull(rdr.GetOrdinal("mt_igv")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("mt_igv"));
            oCompra._Dscto = rdr.IsDBNull(rdr.GetOrdinal("mt_dscto")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("mt_dscto"));
            oCompra._subTotal = rdr.IsDBNull(rdr.GetOrdinal("mt_subtotal")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("mt_subtotal"));
            oCompra._nu_pordscto = rdr.IsDBNull(rdr.GetOrdinal("pordsc")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("pordsc"));
            oCompra._detalle = rdr.IsDBNull(rdr.GetOrdinal("detalle")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("detalle"));
            oCompra._clase = rdr.IsDBNull(rdr.GetOrdinal("clase")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("clase"));
            return oCompra;
        }

        public static List<EDetProducto> mListarDetOrdenCompraFac(EOrdenCompra oc)
        {
            DBAccess db = new DBAccess();
            db.AddParameter("@pchr_idperiodo", oc.Id_periodo);
            db.AddParameter("@pchr_idordenco", oc.Id_ordenco);
            db.AddParameter("@idEmpresa", oc.idEmpresa);

            List<EDetProducto> result = new List<EDetProducto>();

            using (IDataReader rdr = db.ExecuteReader("CO_ordencodet_qry02"))
            {
                while (rdr.Read())
                {
                    result.Add(mCargarDetOrdenCompraFac(rdr));
                }
            }
            return result;
        }


        public static void CO_DetOrdenCompra_mnt02(EDetOrdenCompra doc)
        {
            DBAccess db = new DBAccess();
            db.AddParameter("@pid_periodo", doc.Id_periodo);
            db.AddParameter("@pid_op", doc.Id_op);
            db.AddParameter("@pid_ordenco", doc.Id_ordenco);
            db.AddParameter("@pnu_correla", doc.Nu_correla);
            db.AddParameter("@pnu_lote", doc.Nu_lote);
            db.AddParameter("@pid_producto", doc.Id_producto);
            db.AddParameter("@pid_prodprese", doc.Id_prodprese);
            db.AddParameter("@pid_Empresa", doc.idEmpresa);
            db.ExecuteNonQuery("CO_DetOrdenCompra_mnt02");
        }

    }
}
