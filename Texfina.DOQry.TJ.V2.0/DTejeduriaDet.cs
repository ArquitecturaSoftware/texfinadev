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
    public class DTejeduriaDet
    {

        private static ETejeduriaDet mCargarTJD(IDataReader rdr)
        {
            ETejeduriaDet oTJ = new ETejeduriaDet();
            oTJ.Id_producto = rdr.IsDBNull(rdr.GetOrdinal("id_producto")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_producto"));
            oTJ.Nu_correficha = rdr.IsDBNull(rdr.GetOrdinal("nu_correficha")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("nu_correficha"));
            oTJ.Nu_secuen = rdr.IsDBNull(rdr.GetOrdinal("nu_secuen")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("nu_secuen"));
            oTJ.Id_numalim = rdr.IsDBNull(rdr.GetOrdinal("id_numalim")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_numalim"));
            oTJ.Ds_distrib = rdr.IsDBNull(rdr.GetOrdinal("ds_distrib")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_distrib"));
            oTJ.Ds_estruct = rdr.IsDBNull(rdr.GetOrdinal("ds_estruct")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_estruct"));
            oTJ.Id_prodhilo = rdr.IsDBNull(rdr.GetOrdinal("id_prodhilo")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_prodhilo"));
            oTJ.ds_prodhilo = rdr.IsDBNull(rdr.GetOrdinal("ds_prodhilo")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_prodhilo"));
            oTJ.Ds_tipfibra = rdr.IsDBNull(rdr.GetOrdinal("ds_tipfibra")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_tipfibra"));
            oTJ.Ds_carachilo = rdr.IsDBNull(rdr.GetOrdinal("ds_carachilo")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_carachilo"));
            oTJ.Ds_titulo = rdr.IsDBNull(rdr.GetOrdinal("ds_titulo")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_titulo"));
            oTJ.Id_vlustre = rdr.IsDBNull(rdr.GetOrdinal("id_vlustre")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_vlustre"));
            oTJ.ds_lustre = rdr.IsDBNull(rdr.GetOrdinal("ds_lustre")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_lustre"));
            oTJ.Nu_torsion = rdr.IsDBNull(rdr.GetOrdinal("nu_torsion")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("nu_torsion"));
            oTJ.Id_clipro = rdr.IsDBNull(rdr.GetOrdinal("id_clipro")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_clipro"));
            oTJ.ds_razsoc = rdr.IsDBNull(rdr.GetOrdinal("ds_raznombre")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_raznombre"));
            oTJ.Nu_lote = rdr.IsDBNull(rdr.GetOrdinal("nu_lote")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("nu_lote"));
            oTJ.Ds_etiqueta = rdr.IsDBNull(rdr.GetOrdinal("ds_etiqueta")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_etiqueta"));
            oTJ.Nu_porhilo = rdr.IsDBNull(rdr.GetOrdinal("nu_porhilo")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("nu_porhilo"));
            oTJ.Nu_porhiloaca = rdr.IsDBNull(rdr.GetOrdinal("nu_porhiloaca")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("nu_porhiloaca"));
            oTJ.Nu_tension = rdr.IsDBNull(rdr.GetOrdinal("nu_tension")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("nu_tension"));
            oTJ.Nu_bobinas = rdr.IsDBNull(rdr.GetOrdinal("nu_bobinas")) ? 0 : rdr.GetInt16(rdr.GetOrdinal("nu_bobinas"));
            oTJ.Nu_alimenta = rdr.IsDBNull(rdr.GetOrdinal("nu_alimenta")) ? 0 : rdr.GetInt16(rdr.GetOrdinal("nu_alimenta"));
            oTJ.Mt_preuni = rdr.IsDBNull(rdr.GetOrdinal("mt_preuni")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("mt_preuni"));
            oTJ.Mt_subtotcon = rdr.IsDBNull(rdr.GetOrdinal("mt_subtotcon")) ? 0 : rdr.GetDecimal(rdr.GetOrdinal("mt_subtotcon"));

            
            return oTJ;
        }

         
        public static List<ETejeduriaDet> TJ_Tejeduria_qry07(ETejeduriaDet oTJ)
        {
            DBAccess db = new DBAccess();

            //db.AddParameter("@idPeriodo", oTJ.IdPeriodo);
            db.AddParameter("@idEmpresa", oTJ.IdEmpresa);
            db.AddParameter("@id_producto", oTJ.Id_producto);
            db.AddParameter("@nu_correficha", oTJ.Nu_correficha);


            List<ETejeduriaDet> result = new List<ETejeduriaDet>();
            using (IDataReader rd = db.ExecuteReader("TJ_TejeduriaDet_qry07"))
            {
                while (rd.Read())
                {
                    result.Add(mCargarTJD(rd));
                }
            }

            return result;
        }




        public static void TJ_TejeduriaDet_mnt01(ETejeduriaDet TJD)
        {
            DBAccess db = new DBAccess();

            db.AddParameter("@pidPeriodo", TJD.IdPeriodo);
            db.AddParameter("@pidEmpresa", TJD.IdEmpresa);
            db.AddParameter("@pid_producto", TJD.Id_producto);
            db.AddParameter("@pnu_correficha", TJD.Nu_correficha);
            db.AddParameter("@pnu_secuen", TJD.Nu_secuen);
            db.AddParameter("@pid_numalim", TJD.Id_numalim);
            db.AddParameter("@pds_distrib", TJD.Ds_distrib);
            db.AddParameter("@pds_estruct", TJD.Ds_estruct);
            db.AddParameter("@pid_prodhilo", TJD.Id_prodhilo);
            db.AddParameter("@pds_tipfibra", TJD.Ds_tipfibra);
            db.AddParameter("@pds_carachilo", TJD.Ds_carachilo);
            db.AddParameter("@pds_titulo", TJD.Ds_titulo);
            db.AddParameter("@pid_vlustre", TJD.Id_vlustre);
            db.AddParameter("@pnu_torsion", TJD.Nu_torsion);
            db.AddParameter("@pid_clipro", TJD.Id_clipro);
            db.AddParameter("@pnu_lote", TJD.Nu_lote);
            db.AddParameter("@pds_etiqueta", TJD.Ds_etiqueta);
            db.AddParameter("@pnu_porhilo", TJD.Nu_porhilo);
            db.AddParameter("@pnu_porhiloaca", TJD.Nu_porhiloaca);
            db.AddParameter("@pnu_longmalla", TJD.Nu_longmalla);
            db.AddParameter("@pnu_tension", TJD.Nu_tension);
            db.AddParameter("@pnu_bobinas", TJD.Nu_bobinas);
            db.AddParameter("@pnu_alimenta", TJD.Nu_alimenta);
            db.AddParameter("@pmt_preuni", TJD.Mt_preuni);
            db.AddParameter("@pmt_subtotcon", TJD.Mt_subtotcon);
            db.AddParameter("@pid_ucrearec", TJD.Id_ucrearec);
           


            db.ExecuteNonQuery("TJ_TejeduriaDet_mnt01");

        }


        public static void TJ_TejeduriaDet_mnt03(ETejeduriaDet TJD)
        {
            DBAccess db = new DBAccess();

            db.AddParameter("@pidPeriodo", TJD.IdPeriodo);
            db.AddParameter("@pidEmpresa", TJD.IdEmpresa);
            db.AddParameter("@pid_producto", TJD.Id_producto);
            db.AddParameter("@pnu_correficha", TJD.Nu_correficha);
            db.AddParameter("@pnu_secuen", TJD.Nu_secuen);
            db.AddParameter("@pid_ucrearec", TJD.Id_ucrearec);

            

            db.ExecuteNonQuery("TJ_TejeduriaDet_mnt03");

        }



    }
}
