using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Texfina.Core.Data;
using Texfina.Entity.TJ;

namespace Texfina.DOQry.TJ
{
    public class DTejeduriaDetMall
    {
        private static ETejeduria_DetMall mCargarTJD(IDataReader rdr)
        {
            ETejeduria_DetMall oTJ = new ETejeduria_DetMall();
            //oTJ.Id_producto = rdr.IsDBNull(rdr.GetOrdinal("id_producto")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_producto"));
            //oTJ.Nu_correficha = rdr.IsDBNull(rdr.GetOrdinal("nu_correficha")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("nu_correficha"));
            oTJ.Nu_secuen = rdr.IsDBNull(rdr.GetOrdinal("nu_secuen")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("nu_secuen"));
            oTJ.Nu_item = rdr.IsDBNull(rdr.GetOrdinal("nu_item")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("nu_item"));
            oTJ.Nu_longmalla = rdr.IsDBNull(rdr.GetOrdinal("nu_longmalla")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("nu_longmalla"));
            oTJ.St_anulado = rdr.IsDBNull(rdr.GetOrdinal("st_anulado")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("st_anulado"));

            return oTJ;
        }


        public static List<ETejeduria_DetMall> TJ_TejeduriaDetMall_qry07(ETejeduria_DetMall oTJ)
        {
            DBAccess db = new DBAccess();

            //db.AddParameter("@idPeriodo", oTJ.IdPeriodo);
            db.AddParameter("@idEmpresa", oTJ.IdEmpresa);
            db.AddParameter("@id_producto", oTJ.Id_producto);
            db.AddParameter("@nu_correficha", oTJ.Nu_correficha);
            //db.AddParameter("@nu_secuen", oTJ.Nu_secuen);

            List<ETejeduria_DetMall> result = new List<ETejeduria_DetMall>();
            using (IDataReader rd = db.ExecuteReader("TJ_TejeduriaDetMall_qry07"))
            {
                while (rd.Read())
                {
                    result.Add(mCargarTJD(rd));
                }
            }

            return result;
        }

        public static void TJ_Tejeduria_DetMall_mnt01(ETejeduria_DetMall TJDPM)
        {
            DBAccess db = new DBAccess();

            db.AddParameter("@pidEmpresa", TJDPM.IdEmpresa);
            db.AddParameter("@pidPeriodo", TJDPM.IdPeriodo);
            db.AddParameter("@pid_producto", TJDPM.Id_producto);
            db.AddParameter("@pnu_correficha", TJDPM.Nu_correficha);
            db.AddParameter("@pnu_secuen", TJDPM.Nu_secuen);
            db.AddParameter("@pnu_item", TJDPM.Nu_item);
            db.AddParameter("@pnu_longmalla", TJDPM.Nu_longmalla);
            db.AddParameter("@pid_ucrearec", TJDPM.Id_ucrearec);
            db.AddParameter("@pst_anulado", TJDPM.St_anulado);

            db.ExecuteNonQuery("TJ_Tejeduria_DetMall_mnt01");

        }



    }
}
