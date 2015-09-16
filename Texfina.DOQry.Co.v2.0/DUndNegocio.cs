using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Texfina.Entity.Co;
using Texfina.Core.Data;

namespace Texfina.DOQry.Co
{
    public class DUndNegocio
    {
        public static IDataReader UndNegocio_qry01(EUnidadNegocio UndNg)
        {
            DBAccess db = new DBAccess();

            db.AddParameter("@pidEmpresa", UndNg.IdEmpresa);
            db.AddParameter("@pidUNegocio", UndNg.IdUNegocio);


            return db.ExecuteReader("MG_UNegocio_qry04");
        }

        public static IDataReader UndNegocio_qry02(EUnidadNegocio UndNg)
        {
            DBAccess db = new DBAccess();

            db.AddParameter("@pidEmpresa", UndNg.IdEmpresa);
            //db.AddParameter("@pidTipGasto", UndNg.IdtipGasto);
            return db.ExecuteReader("MG_UNegocio_qry05");
        }

        public static List<Dato> ObtenerDatoUN(string commandtext, string par1, string par2, EUnidadNegocio emp)
        {
            List<Dato> _lista = new List<Dato>();

            DBAccess db = new DBAccess();
            db.AddParameter("@pidEmpresa", emp.IdEmpresa);
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

        public static List<Dato> ObtenerDatoCC(string commandtext, string par1, string par2, EUnidadNegocio emp)
        {
            List<Dato> _lista = new List<Dato>();

            DBAccess db = new DBAccess();
            db.AddParameter("@pidEmpresa", emp.IdEmpresa);
            db.AddParameter("@pidUNegocio", emp.IdUNegocio);

            
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


        public static IDataReader MG_UNegocio_qry10(EUnidadNegocio undNeg)
        {
            DBAccess db = new DBAccess();
            db.AddParameter("@pidEmpresa", undNeg.IdEmpresa);
            db.AddParameter("@pidUNegocio", undNeg.IdUNegocio);
            return db.ExecuteReader("MG_UNegocio_qry12");
        }



        private static EUnidadNegocio mCargarExistenciaUnegocio(IDataReader rdr)
        {
            EUnidadNegocio eu = new EUnidadNegocio();
            eu.Existe = rdr.IsDBNull(rdr.GetOrdinal("existe")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("existe"));
            return eu;
        }	

        public static List<EUnidadNegocio> MG_Unegocio_qry06(EUnidadNegocio EU)
        {
            DBAccess db = new DBAccess();
            db.AddParameter("@pidEmpresa", EU.IdEmpresa);
            db.AddParameter("@pidUNegocio", EU.IdUNegocio);

            List<EUnidadNegocio> result = new List<EUnidadNegocio>();

            using (IDataReader rdr = db.ExecuteReader("MG_UNegocio_qry06"))
            {
                while (rdr.Read())
                {
                    result.Add(mCargarExistenciaUnegocio(rdr));
                }
            }
            return result;
        }

    }
}
