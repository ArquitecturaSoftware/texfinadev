using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Texfina.Core.Data;
using Texfina.Entity.Co;

namespace Texfina.DOQry.Co
{
    public class DTablaGeneral
    {
        //web
        public static IDataReader TablaGeneralFill(String Codigo)
        {
            DBAccess db = new DBAccess();
            db.AddParameter("@id_tabla", Codigo);
            return db.ExecuteReader("MG_TablaGeneral_qry01");

        }
        //desktop
        public static List<Dato> tablaGeneral(String Codigo)
        {
            List<Dato> _lista = new List<Dato>();

            DBAccess db = new DBAccess();
            db.AddParameter("@id_tabla", Codigo);


            IDataReader reader = db.ExecuteReader("MG_TablaGeneral_qry01");

            while (reader.Read())
            {
                Dato _dato = new Dato();

                _dato.id = reader["id_item"].ToString();
                _dato.desc = reader["ds_item"].ToString();
                _lista.Add(_dato);
            }
            return _lista;
        }


        public static List<Dato> tablaGeneral_2(String Codigo)
        {
            List<Dato> _lista = new List<Dato>();

            DBAccess db = new DBAccess();
            db.AddParameter("@pidTabla", Codigo);
            db.AddParameter("@pidCodigo", "");

            IDataReader reader = db.ExecuteReader("MG_TablaGenDet_qry04");

            while (reader.Read())
            {
                Dato _dato = new Dato();

                _dato.id = reader["idCodigo"].ToString();
                _dato.desc = reader["dsDescrip"].ToString();
                _lista.Add(_dato);
            }
            return _lista;
        }

        public static IDataReader TablaGeneral_qry02(String codigo)
        {
            DBAccess db = new DBAccess();
            db.AddParameter("@pchr_idtabla", codigo);
            return db.ExecuteReader("MG_TablaGeneral_qry02");
        }


        public static IDataReader MG_TablaGenDet_qry04(String idtabla, String codigo)
        {
            DBAccess db = new DBAccess();
            db.AddParameter("@pidTabla", idtabla);
            db.AddParameter("@pidCodigo", codigo);
            return db.ExecuteReader("MG_TablaGenDet_qry04");
        }
    }
}
