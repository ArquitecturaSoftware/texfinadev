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
    public class DColor
    {
        public static DataSet ColorFill(EColor col)
        {
            DBAccess db = new DBAccess();

            db.AddParameter("@psintypesel", col.psintypesel);
            db.AddParameter("@pidEmpresa", col.IdEmpresa);
            db.AddParameter("@pid_color", col.Id_color);
            db.AddParameter("@pds_color", col.Ds_color);
            return db.ExecuteDataSet("MG_Color_qry01");
        }

        public static void Color_mnt(EColor CL)
        {
            DBAccess db = new DBAccess();

            db.AddParameter("@pid_color", CL.Id_color);
            db.AddParameter("@pidEmpresa", CL.IdEmpresa);
            db.AddParameter("@pds_color", CL.Ds_color);
            db.AddParameter("@pid_vtipcolor", CL.Id_vtipcolor);
            db.AddParameter("@pfe_creacion", CL.Fe_creacion);
            db.AddParameter("@pid_cartacol", CL.Id_cartacol);
            db.AddParameter("@pnu_opcion", CL.Nu_opcion);
            db.AddParameter("@pid_ucrearec", CL.Id_ucrearec);
            db.ExecuteNonQuery("MG_Color_mnt01");

        }

        public static List<Dato> Color_qry06(String Codigo)
        {
            List<Dato> _lista = new List<Dato>();

            DBAccess db = new DBAccess();
            db.AddParameter("@idEmpresa", Codigo);

            IDataReader reader = db.ExecuteReader("TJ_Color_GenCod");

            while (reader.Read())
            {
                Dato _dato = new Dato();

                _dato.id = reader["id_color"].ToString();
                _dato.desc = reader["id_color"].ToString();
                _lista.Add(_dato);
            }
            return _lista;
        }


        public static List<Dato> ObtenerDatoColor(EColor c)
        {
            List<Dato> _lista = new List<Dato>();

            DBAccess db = new DBAccess();

            db.AddParameter("@psintypesel", c.psintypesel);
            db.AddParameter("@pidEmpresa", c.IdEmpresa);
            db.AddParameter("@pid_color", c.Id_color);
            db.AddParameter("@pds_color", c.Ds_color);

            IDataReader reader = db.ExecuteReader("MG_Color_qry01");

            while (reader.Read())
            {
                Dato _dato = new Dato();

                _dato.id = reader["id_color"].ToString();
                _dato.desc = reader["ds_color"].ToString();
                _lista.Add(_dato);
            }
            return _lista;
        }



    }
}
