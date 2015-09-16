using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Texfina.Entity.Co;
using Texfina.Core.Data;
using System.Data;

namespace Texfina.DOQry.Co
{
   public  class DDetFactura
    {
       public static void DetFact_mnt01(EDetFactura fac)
       {
           DBAccess db = new DBAccess();

           db.AddParameter("@pid_periodo", fac.Id_periodo);
           db.AddParameter("@pid_serie", fac.Id_serie);
           db.AddParameter("@pid_factura", fac.Id_factura);
           db.AddParameter("@pnu_correla", fac.Nu_correla);
           db.AddParameter("@pid_producto", fac.Id_producto);
           db.AddParameter("@pid_prodprese", fac.Id_prodprese);
           db.AddParameter("@pqt_producto", fac.Qt_producto);

           db.AddParameter("@pid_vmoneda", fac.Id_vmoneda);
           db.AddParameter("@pqt_pesobruto", fac.Qt_pesobruto);
           db.AddParameter("@pqt_pesoneto", fac.Qt_pesoneto);
           db.AddParameter("@pmt_precuni", fac.Mt_precuni);
           db.AddParameter("@pmt_igv", fac.Mt_igv);
           db.AddParameter("@pmt_subtotal", fac.Mt_subtotal);
  
           db.AddParameter("@pmt_dscto", fac.Mt_dscto);
           db.AddParameter("@pid_ucrearec", fac.Id_ucrearec);
           db.AddParameter("@pid_uupdarec", fac.Id_uupdarec);
           db.AddParameter("@pst_anulado", fac.St_anulado);
           db.AddParameter("@pid_empresa", fac.Id_empresa);
           db.AddParameter("@detalle", fac.detalle);


           db.ExecuteNonQuery("CO_DetFactura_mnt01");

       }



       private static EDetProducto mCargarDetFactura(IDataReader rdr)
       {
           EDetProducto oCompra = new EDetProducto();
           oCompra._Nu_Correla = rdr.IsDBNull(rdr.GetOrdinal("nu_correla")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("nu_correla"));
           oCompra._Codigo = rdr.IsDBNull(rdr.GetOrdinal("id_producto")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_producto"));
           oCompra._Pres = rdr.IsDBNull(rdr.GetOrdinal("id_prodprese")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_prodprese"));
           oCompra._Producto = rdr.IsDBNull(rdr.GetOrdinal("ds_producto")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_producto"));
           oCompra._Presenta = rdr.IsDBNull(rdr.GetOrdinal("ds_prodprese")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_prodprese"));
           oCompra.Id_vunicons = rdr.IsDBNull(rdr.GetOrdinal("id_vunicons")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_vunicons"));
           oCompra._Peso_Bruto = rdr.IsDBNull(rdr.GetOrdinal("qt_pesobruto")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("qt_pesobruto"));

           
           oCompra._Cant = rdr.IsDBNull(rdr.GetOrdinal("qt_producto")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("qt_producto"));
           oCompra._cantReciv = rdr.IsDBNull(rdr.GetOrdinal("qt_difcierre")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("qt_difcierre"));
           oCompra._cantReg = rdr.IsDBNull(rdr.GetOrdinal("cantReg")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("cantReg"));

           oCompra._PreNeto = rdr.IsDBNull(rdr.GetOrdinal("qt_pesoneto")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("qt_pesoneto"));
           oCompra._PreUnit = rdr.IsDBNull(rdr.GetOrdinal("mt_precuni")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("mt_precuni"));
           oCompra._nu_pordscto = rdr.IsDBNull(rdr.GetOrdinal("pordsc")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("pordsc"));

           oCompra._Igv = rdr.IsDBNull(rdr.GetOrdinal("mt_igv")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("mt_igv"));
           oCompra._Dscto = rdr.IsDBNull(rdr.GetOrdinal("mt_dscto")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("mt_dscto"));
           oCompra._subTotal = rdr.IsDBNull(rdr.GetOrdinal("mt_subtotal")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("mt_subtotal"));

           return oCompra;
       }


       public static List<EDetProducto> mListarDetFac(EFactura fac)
       {
           DBAccess db = new DBAccess();
           db.AddParameter("@pchr_idperiodo", fac.Id_periodo);
           db.AddParameter("@pchr_idFactura", fac.Id_factura);
           db.AddParameter("@idEmpresa", fac.Id_empresa);

           List<EDetProducto> result = new List<EDetProducto>();

           using (IDataReader rdr = db.ExecuteReader("CO_Factdet_qry02"))
           {
               while (rdr.Read())
               {
                   result.Add(mCargarDetFactura(rdr));
               }
          }
           return result;
       }


    }
}
