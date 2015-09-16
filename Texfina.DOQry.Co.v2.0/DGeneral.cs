using System;
using System.Collections.Generic;
using System.Data;

using System.Linq;
using System.Text;
using Texfina.Core.Data;
using Texfina.Entity.Co;

namespace Texfina.DOQry.Co
{
    public class DGeneral
    {
     
 

        public static List<Dato> ObtenerDato(string commandtext, string par1, string par2)
        {
            List<Dato> _lista = new List<Dato>();

            DBAccess db = new DBAccess();

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

        public static List<Dato> ObtenerDatoParameter(string commandtext, string par1, string par2, string par3)
        {
            List<Dato> _lista = new List<Dato>();

            DBAccess db = new DBAccess();

            db.AddParameter("@id_tabla", par3);

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


        public static List<Dato> ObtenerDatEmpresa(string commandtext, string par1, string par2, string par3)
        {
            List<Dato> _lista = new List<Dato>();

            DBAccess db = new DBAccess();

            db.AddParameter("@pidEmpresa", par3);

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


        public static List<Dato> ObtenerDatEmpresaPeriodo( Dato d)
        {
            List<Dato> _lista = new List<Dato>();

            DBAccess db = new DBAccess();

            db.AddParameter("@pidEmpresa", d.id);
            db.AddParameter("@pidPeriodo", "");
            IDataReader reader = db.ExecuteReader("SY_EmpPeriodo_qry04");

            while (reader.Read())
            {
                Dato _dato = new Dato();
                _dato.idperiodo = reader["idPeriodo"].ToString();
                _dato.periodo = reader["idPeriodo"].ToString();
                _lista.Add(_dato);
            }
            return _lista;
        }



        public static List<Dato> ObtenerDatoMenuPrincipal()
        {
            List<Dato> _lista = new List<Dato>();

            DBAccess db = new DBAccess();

            IDataReader reader = db.ExecuteReader("SY_UsuMenu_qry12");

            while (reader.Read())
            {
                Dato _dato = new Dato();
                _dato.idMenu = reader["idMenu"].ToString();
                _dato.dsMenu = reader["dsMenu"].ToString();
                _dato.dsWinForms = reader["dsWebPage"].ToString();
                _dato.idPadre = reader["idPadre"].ToString();
                _lista.Add(_dato);
            }
            return _lista;
        }


        public static List<Dato> ObtenerDatoMenu(Dato d)
        {
            List<Dato> _lista = new List<Dato>();

            DBAccess db = new DBAccess();

            db.AddParameter("@pidUser", d.idu);
          
            IDataReader reader = db.ExecuteReader("SY_UsuMenu_qry10");

            while (reader.Read())
            {
                Dato _dato = new Dato();
                _dato.idMenu = reader["idMenu"].ToString();
                _dato.dsMenu = reader["dsMenu"].ToString();
                _dato.dsWinForms = reader["dsWebPage"].ToString();
                _dato.idPadre = reader["idPadre"].ToString();
                _lista.Add(_dato);
            }
            return _lista;
        }



        public static List<Dato> ObtenerModulo(Dato d)
        {
            List<Dato> _lista = new List<Dato>();

            DBAccess db = new DBAccess();

            db.AddParameter("@pIdLogon", d.idLogon);

            IDataReader reader = db.ExecuteReader("SY_Modulo_qry01");

            while (reader.Read())
            {
                Dato _dato = new Dato();
                _dato.dsWebPage = reader["dsWebPage"].ToString();
                _dato.dsMenu = reader["dsMenu"].ToString();
                _lista.Add(_dato);
            }
            return _lista;
        }


    }
}
