using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Texfina.Entity.Co;
using Texfina.DOQry.Co;
namespace Texfina.BOQry.Co
{
    public class BCondicionPago
    {
        public static DataSet CondiPagoFill(ECondicionPago CondPago)
        {
            return DCondicionPago.GetList(CondPago);
        }
        

        public static List<Dato> ObtenerDatoFormaPago(ECondicionPago CondPago)
        {
            return DCondicionPago.ObtenerDatoFPago("MG_CondicionPago_qry01", "id_condpago", "ds_condpago", CondPago);
        }

    }
}
