using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Texfina.Entity.Co;
using Texfina.Core.Data;
using System.Data;

namespace Texfina.DOQry.Co
{
    public class DProdXUnd
    {
        public static void ProdXUnd_mnt01(EProdXUnd prod)
        {
            DBAccess db = new DBAccess();

            db.AddParameter("@pid_producto", prod.Id_producto);
            db.AddParameter("@pid_prodprese", prod.Id_prodprese);
            db.AddParameter("@pds_prodprese", prod.Ds_prodprese);
            db.AddParameter("@pnu_uniprese", prod.Nu_uniprese);
            db.AddParameter("@pnu_umprese", prod.Nu_umprese);
            db.AddParameter("@pqt_pesoneto", prod.Qt_pesoneto);
            db.AddParameter("@pqt_pesobruto", prod.Qt_pesobruto);
            db.AddParameter("@pmt_precio", prod.Mt_precio);
            db.AddParameter("@pid_ucrearec", prod.Id_ucrearec);
            db.AddParameter("@pid_uupdarec", prod.Id_ucrearec);
            db.AddParameter("@pid_empresa", prod.Id_Empresa);
            db.ExecuteNonQuery("MG_ProdXUnd_mnt01");

        }


        public static void ProdXUnd_mnt03(EProdXUnd prod)
        {
            DBAccess db = new DBAccess();

            db.AddParameter("@pid_empresa", prod.Id_Empresa);
            db.AddParameter("@pid_producto", prod.Id_producto);
            db.AddParameter("@pid_prodprese", prod.Id_prodprese);

            db.ExecuteNonQuery("MG_ProdXUnd_mnt03");

        }

        private static EProdXUnd mCargarProd(IDataReader rdr)
        {
            EProdXUnd oProd = new EProdXUnd();
            //oProd.Id_producto = rdr.IsDBNull(rdr.GetOrdinal("id_producto")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_producto"));
            oProd.Id_prodprese = rdr.IsDBNull(rdr.GetOrdinal("id_prodprese")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_prodprese"));
            oProd.Ds_prodprese = rdr.IsDBNull(rdr.GetOrdinal("ds_prodprese")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_prodprese"));
            oProd.Nu_uniprese = rdr.IsDBNull(rdr.GetOrdinal("nu_uniprese")) ? 0 : rdr.GetInt16(rdr.GetOrdinal("nu_uniprese"));
            oProd.Nu_umprese = rdr.IsDBNull(rdr.GetOrdinal("nu_umprese")) ? 0 : rdr.GetInt16(rdr.GetOrdinal("nu_umprese"));
            oProd.Qt_pesoneto = rdr.IsDBNull(rdr.GetOrdinal("qt_pesoneto")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("qt_pesoneto"));
            oProd.Qt_pesobruto = rdr.IsDBNull(rdr.GetOrdinal("qt_pesobruto")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("qt_pesobruto"));
            oProd.Mt_precio = rdr.IsDBNull(rdr.GetOrdinal("mt_precio")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("mt_precio"));
            //oProd.St_anulado = rdr.IsDBNull(rdr.GetOrdinal("st_anulado")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("st_anulado"));
                        
            return oProd;
        }

        public static List<EProdXUnd> GetListProducto_sql01(EProdXUnd prod)
        {
            DBAccess db = new DBAccess();
            db.AddParameter("@pchr_idproducto", prod.Id_producto);
            db.AddParameter("@pchr_idEmpresa", prod.Id_Empresa);

            List<EProdXUnd> result = new List<EProdXUnd>();

            using (IDataReader rdr = db.ExecuteReader("MG_Producto_qry04"))
            {
                while (rdr.Read())
                {
                    result.Add(mCargarProd(rdr));
                }
            }
            return result;
        }


    }
}
