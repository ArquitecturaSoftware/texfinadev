using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Texfina.Core.Data;
using Texfina.Entity.Co;

namespace Texfina.DOQry.Co
{
    public  class DTipGasto
    {
        public static DataSet TipoGasto_Qry1(ETipGasto etg)
        {
            DBAccess db = new DBAccess();
            db.AddParameter("@codigo", etg.Id_tipogsto);
            db.AddParameter("@Descrip", etg.Ds_tipogsto);
            return db.ExecuteDataSet("MG_TipoGasto_Qry01");
        }

        ///// <summary>
        ///// codigo para desktop
        ///// </summary>
        ///// <returns></returns>

        //public static List<ETipGasto> TipoGasto_Qry1_(ETipGasto etg)
        //{
        //    List<ETipGasto> _lista = new List<ETipGasto>();

        //    DBAccess db = new DBAccess();
        //    db.AddParameter("@codigo", etg.Id_tipogsto);
        //    db.AddParameter("@Descrip", etg.Ds_tipogsto);

        //    IDataReader reader = db.ExecuteReader("MG_TipoGasto_Qry01");

        //    while (reader.Read())
        //    {
        //        ETipGasto _tg = new ETipGasto();

        //        _tg.Id_tipogsto = reader["Codigo"].ToString();
        //        _tg.Ds_tipogsto = reader["Descripcion"].ToString();
        //        _tg.Ds_abrev = reader["Abreviatura"].ToString();

        //        _lista.Add(_tg);
        //    }
        //    return _lista;
        //}

        public static IDataReader MG_Clase_qry01(String idEmpresa, String idUnegocio,String idCCostos )
        {
            DBAccess db = new DBAccess();
            db.AddParameter("@idEmpresa", idEmpresa);
            db.AddParameter("@idunegocio", idUnegocio);
            db.AddParameter("@idCCosto", idCCostos);
            return db.ExecuteReader("MG_CLASE_Qry01_prueba");
        }



        public static List<Dato> ObtenerDatoTg(string commandtext, string par1, string par2, ETipGasto tg)
        {
            List<Dato> _lista = new List<Dato>();

            DBAccess db = new DBAccess();
            db.AddParameter("@idEmpresa", tg.Id_empresa);
            db.AddParameter("@idunegocio", tg.Id_unegocio);
            db.AddParameter("@idCCosto", tg.Id_ccosto);

            IDataReader reader = db.ExecuteReader(commandtext);

            while (reader.Read())
            {
                Dato _dato = new Dato();

                _dato.id = reader[par1].ToString();
                _dato.desc = reader[par2].ToString();
                _lista.Add(_dato);
            }
            return _lista;
        }


        private static ETipGasto mCargarTipoGasto(IDataReader rdr)
        {
            ETipGasto etg = new ETipGasto();


            etg.Id_tipogsto = rdr.IsDBNull(rdr.GetOrdinal("Codigo")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("Codigo"));
            etg.Ds_tipogsto = rdr.IsDBNull(rdr.GetOrdinal("Descripcion")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("Descripcion"));


            return etg;
        }


        public static ETipGasto mListarTipoGasto(ETipGasto etg)
        {
            DBAccess db = new DBAccess();

            db.AddParameter("@codigo", etg.Id_tipogsto);
            db.AddParameter("@Descrip", etg.Ds_tipogsto);

            List<ETerceros> result = new List<ETerceros>();

            using (IDataReader rd = db.ExecuteReader("MG_TipoGasto_Qry01"))
            {

                while (rd.Read())
                {


                    return mCargarTipoGasto(rd);
                }

            }

            return etg;
        }




     
    }
}
