using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Texfina.Entity.Co;
using Texfina.DOQry.Co;
namespace Texfina.BOQry.Co
{
    public class BPersonalBandeja
    {
        public static DataSet GetListFill(EPersonalBandeja PerBand)
        {
            return DPersonalBandeja.GetList(PerBand);
        }

        public static List<Dato> ObtenerDatoPersonal(EPersonalBandeja PerBand)
        {
            return DPersonalBandeja.ObtenerDatoPersonal("RH_Personal_qry04", "idPersonal", "dsRazSocial", PerBand);
        }

    }
}
