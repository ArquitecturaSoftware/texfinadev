using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Texfina.Core.Data;
using Texfina.Entity.Al;
using Texfina.Entity.Co;

namespace Texfina.DOMnt.Al
{
    public class DVendedor
    {
        public static DataSet MG_Vendedor_qry01(EVendedor v)
        {

            DBAccess db = new DBAccess();
            db.AddParameter("@psintypesel", v.psintypesel);
            db.AddParameter("@pidVendedor", v.Id_Vendedor);
            db.AddParameter("@pnuDocIden", v.Nu_dni);
            db.AddParameter("@pdsApellNom", v.Ds_razsoc);

            return db.ExecuteDataSet("MG_Vendedor_qry01");
        }


        public static List<Dato> ObtenerDatoVendedor(EVendedor prov)
        {
            List<Dato> _lista = new List<Dato>();

            DBAccess db = new DBAccess();
            db.AddParameter("@psintypesel", prov.psintypesel);
            db.AddParameter("@pidVendedor", prov.Id_Vendedor);
            db.AddParameter("@pnuDocIden", prov.Nu_dni);
            db.AddParameter("@pdsApellNom", prov.Ds_razsoc);
            

            IDataReader reader = db.ExecuteReader("MG_Vendedor_qry01");

            while (reader.Read())
            {
                Dato _dato = new Dato();

                _dato.id = reader["id_Vendedor"].ToString();
                _dato.desc = reader["dsRazsocial"].ToString();
                _lista.Add(_dato);
            }
            return _lista;
        }

        public static List<Dato> MG_Vendedor_qry02(String obj)
        {
            List<Dato> _lista = new List<Dato>();

            DBAccess db = new DBAccess();
            db.AddParameter("@dsRazonSocial", obj);


            IDataReader reader = db.ExecuteReader("MG_Vendedor_qry02");

            while (reader.Read())
            {
                Dato _dato = new Dato();

                _dato.id = reader["id_Vendedor"].ToString();
                _dato.desc = reader["dsRazsocial"].ToString();
                _lista.Add(_dato);
            }
            return _lista;
        }

    }
}
