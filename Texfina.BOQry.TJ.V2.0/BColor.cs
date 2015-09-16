using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Texfina.DOQry.TJ;
using Texfina.Entity.Co;
using Texfina.Entity.TJ;

namespace Texfina.BOQry.TJ
{
    public class BColor
    {
        public static DataSet GetListFill(EColor col)
        {
            return DColor.ColorFill(col);
        }

        public static void TJ_Color_mnt04(EColor CL)
        {
            DColor.Color_mnt(CL);
            
        }

        public static List<Dato> Color_qry06(String codigo)
        {
            return DColor.Color_qry06(codigo);
        }

        public static List<Dato> ObtenerDatoColor(EColor c)
        {
            return DColor.ObtenerDatoColor(c);
        }

    }
}
