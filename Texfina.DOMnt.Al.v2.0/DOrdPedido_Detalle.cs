using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Texfina.Core.Data;
using Texfina.Entity.Al;

namespace Texfina.DOMnt.Al
{
    public class DOrdPedido_Detalle
    {
        public static void VE_OrdPedido_Detalle_mnt01(EOrdPedido_Detalle obj)
        {
            DBAccess db = new DBAccess();

            db.AddParameter("@pidreqsalida", obj.Idreqsalida);
            db.AddParameter("@pidEmpresa", obj.IdEmpresa);
            db.AddParameter("@pidPeriodo", obj.IdPeriodo);
            db.AddParameter("@pid_clipro", obj.Id_clipro);
            db.AddParameter("@pid_producto", obj.Id_producto);
            db.AddParameter("@pid_color", obj.Id_color);
            db.AddParameter("@pnuItem", obj.NuItem);
            db.AddParameter("@pqt_rollo", obj.Qt_rollo);
            db.AddParameter("@pmt_preunit_real", obj.Mt_preunit_real);
            db.AddParameter("@pmt_preunit_actual", obj.Mt_preunit_actual);
            db.AddParameter("@pqt_peso", obj.Qt_peso);
            db.AddParameter("@pst_estado", obj.St_estado);
            db.AddParameter("@pid_Vendedor", obj.Id_vendedor);
            db.AddParameter("@pst_igv", obj.st_igv);

            db.AddParameter("@pid_ucreatrec", obj.Id_ucreatrec);



            db.ExecuteNonQuery("VE_OrdPedido_Detalle_mnt01");

        }

        public static DataSet VE_OrdPedido_Detalle_qry01(EParametros obj)
        {
            DBAccess db = new DBAccess();

            db.AddParameter("@psintypesel", obj.psintypesel);
            db.AddParameter("@pidreqsalida", obj.pidreqsalida);
            db.AddParameter("@pidEmpresa", obj.idEmpresa);
            db.AddParameter("@pidPeriodo", obj.idperiodo);
            db.AddParameter("@fechaIni", obj.fechaIni);
            db.AddParameter("@fechaFin", obj.fechaFin);
            db.AddParameter("@dsRazonSoc", obj.dsRazonSoc);
            db.AddParameter("@dsproducto", obj.dsproducto);
            db.AddParameter("@stAprobado", obj.st_autoriza);
            db.AddParameter("@stEstado", obj.estado);

            return db.ExecuteDataSet("VE_OrdPedido_Detalle_qry01");

        }


        private static EOrdPedido_Detalle mCargarDetOP(IDataReader rdr)
        {
            EOrdPedido_Detalle objID = new EOrdPedido_Detalle();

            objID.NuItem = rdr.IsDBNull(rdr.GetOrdinal("nuItem")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("nuItem"));
            objID.Id_clipro = rdr.IsDBNull(rdr.GetOrdinal("id_clipro")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_clipro"));
            objID.ds_clipro = rdr.IsDBNull(rdr.GetOrdinal("ds_cliente")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_cliente"));
            objID.Id_producto = rdr.IsDBNull(rdr.GetOrdinal("id_producto")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_producto"));
            objID.ds_producto = rdr.IsDBNull(rdr.GetOrdinal("ds_producto")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_producto"));
            objID.Id_color = rdr.IsDBNull(rdr.GetOrdinal("id_color")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_color"));
            objID.DsColor = rdr.IsDBNull(rdr.GetOrdinal("ds_color")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_color"));
            objID.Qt_rollo = rdr.IsDBNull(rdr.GetOrdinal("qt_rollo")) ? 0 : rdr.GetInt32(rdr.GetOrdinal("qt_rollo"));
            objID.Qt_rollo_pend = rdr.IsDBNull(rdr.GetOrdinal("qt_rollo_pend")) ? 0 : rdr.GetInt32(rdr.GetOrdinal("qt_rollo_pend"));
            objID.Qt_peso = rdr.IsDBNull(rdr.GetOrdinal("qt_peso")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("qt_peso"));
            objID.Id_vendedor = rdr.IsDBNull(rdr.GetOrdinal("id_Vendedor")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_Vendedor"));
            objID.Ds_vendedor = rdr.IsDBNull(rdr.GetOrdinal("ds_Vendedor")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_Vendedor"));
            objID.Mt_preunit_actual = rdr.IsDBNull(rdr.GetOrdinal("mt_preunit_actual")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("mt_preunit_actual"));

            bool st_igv = rdr.GetBoolean(rdr.GetOrdinal("st_igv"));

            objID._igvActivo = st_igv;
            objID.St_estado = rdr.IsDBNull(rdr.GetOrdinal("st_estado")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("st_estado")); 

            return objID;

        }

        public static List<EOrdPedido_Detalle> VE_OrdPedido_Detalle_qry02(EOrdPedido_Detalle obj)
        {
            DBAccess db = new DBAccess();

            db.AddParameter("@pidEmpresa", obj.IdEmpresa);
            db.AddParameter("@pidPeriodo", obj.IdPeriodo);
            db.AddParameter("@pidreqsalida", obj.Idreqsalida);


            List<EOrdPedido_Detalle> result = new List<EOrdPedido_Detalle>();
            using (IDataReader rd = db.ExecuteReader("VE_OrdPedido_Detalle_qry02"))
            {
                while (rd.Read())
                {
                    result.Add(mCargarDetOP(rd));
                }
            }

            return result;
        }

        public static void VE_OrdPedido_Detalle_mnt03(EOrdPedido_Detalle obj)
        {
            DBAccess db = new DBAccess();

            db.AddParameter("@pidEmpresa", obj.IdEmpresa);
            db.AddParameter("@pidPeriodo", obj.IdPeriodo);
            db.AddParameter("@pidreqsalida", obj.Idreqsalida);
            db.AddParameter("@pnuItem", obj.NuItem);
            db.AddParameter("@pid_uupdarec", obj.Id_uupdarec);
            db.ExecuteNonQuery("VE_OrdPedido_Detalle_mnt03");

        }


        public static void VE_OrdPedido_Detalle_mnt05(EOrdPedido_Detalle obj)
        {
            DBAccess db = new DBAccess();

            db.AddParameter("@pidEmpresa", obj.IdEmpresa);
            db.AddParameter("@pidPeriodo", obj.IdPeriodo);
            db.AddParameter("@pidreqsalida", obj.Idreqsalida);

            db.AddParameter("@pid_clipro", obj.Id_clipro);
            db.AddParameter("@pid_producto", obj.Id_producto);
            db.AddParameter("@pid_color", obj.Id_color);
     
            db.ExecuteNonQuery("VE_OrdPedido_Detalle_mnt05");

        }



    }
}
