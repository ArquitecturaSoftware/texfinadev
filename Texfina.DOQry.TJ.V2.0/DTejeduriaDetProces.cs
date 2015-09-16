using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Texfina.Core.Data;
using Texfina.Entity.Co;
using Texfina.Entity.TJ;

namespace Texfina.DOQry.TJ
{
    public class DTejeduriaDetProces
    {
        private static ETejeduria_DetProces mCargarTJD(System.Data.IDataReader rdr)
        {
            ETejeduria_DetProces oTJ = new ETejeduria_DetProces();
            //oTJ.Id_producto = rdr.IsDBNull(rdr.GetOrdinal("id_producto")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_producto"));
            //oTJ.Nu_correficha = rdr.IsDBNull(rdr.GetOrdinal("nu_correficha")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("nu_correficha"));
            //oTJ.Nu_secuen = rdr.IsDBNull(rdr.GetOrdinal("nu_secuen")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("nu_secuen"));
            oTJ.IdItem = rdr.IsDBNull(rdr.GetOrdinal("idItem")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("idItem"));
            oTJ.IdRutaProces = rdr.IsDBNull(rdr.GetOrdinal("idRutaProces")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("idRutaProces"));

            return oTJ;
        }


        public static List<ETejeduria_DetProces> TJ_TejeduriaDetProces_qry07(ETejeduria_DetProces oTJ)
        {
            DBAccess db = new DBAccess();

            //db.AddParameter("@pidPeriodo", oTJ.IdPeriodo);
            db.AddParameter("@pidEmpresa", oTJ.IdEmpresa);
            db.AddParameter("@pid_producto", oTJ.Id_producto);
            db.AddParameter("@pnu_correficha", oTJ.Nu_correficha);
          

            List<ETejeduria_DetProces> result = new List<ETejeduria_DetProces>();
            using (IDataReader rd = db.ExecuteReader("TJ_TejeduriaRutaProces_qry02"))
            {
                while (rd.Read())
                {
                    result.Add(mCargarTJD(rd));
                }
            }

            return result;
        }


        public static List<Dato> ObtenerDato()
        {
            List<Dato> _lista = new List<Dato>();

            DBAccess db = new DBAccess();

            IDataReader reader = db.ExecuteReader("MG_RutaProceso_qry02");

            while (reader.Read())
            {
                Dato _dato = new Dato();

                _dato.id = reader["idRutaProces"].ToString();
                _dato.desc = reader["dsRutaProces"].ToString();
                _lista.Add(_dato);
            }
            return _lista;
        }


        public static List<Dato> MG_RutaProceso_qry03()
        {
            List<Dato> _lista = new List<Dato>();

            DBAccess db = new DBAccess();

            IDataReader reader = db.ExecuteReader("MG_RutaProceso_qry03");

            while (reader.Read())
            {
                Dato _dato = new Dato();

                _dato.id = reader["idRutaProces"].ToString();
                _dato.desc = reader["dsRutaProces_usa"].ToString();
                _lista.Add(_dato);
            }
            return _lista;
        }



        public static void TJ_TejeduriaRutaProces_mnt01(ETejeduria_DetProces TJDP)
        {
            DBAccess db = new DBAccess();

            db.AddParameter("@pidPeriodo", TJDP.IdPeriodo);
            db.AddParameter("@pid_producto", TJDP.Id_producto);
            db.AddParameter("@pidEmpresa", TJDP.IdEmpresa);
            db.AddParameter("@pnu_correficha", TJDP.Nu_correficha);
            db.AddParameter("@pidItem", TJDP.IdItem);
            db.AddParameter("@pidRutaProces", TJDP.IdRutaProces);

            db.AddParameter("@pid_ucrearec", TJDP.Id_ucrearec);

            db.ExecuteNonQuery("TJ_TejeduriaRutaProces_mnt01");

        }



        public static void TJ_TejeduriaRutaProces_mnt03(ETejeduria_DetProces TJDP)
        {
            DBAccess db = new DBAccess();

            db.AddParameter("@pidPeriodo", TJDP.IdPeriodo);
            db.AddParameter("@pid_producto", TJDP.Id_producto);
            db.AddParameter("@pidEmpresa", TJDP.IdEmpresa);
            db.AddParameter("@pnu_correficha", TJDP.Nu_correficha);
            db.AddParameter("@pidItem", TJDP.IdItem);
            db.AddParameter("@pid_ucrearec", TJDP.Id_ucrearec);

            db.ExecuteNonQuery("TJ_TejeduriaRutaProces_mnt03");

        }

    }
}
