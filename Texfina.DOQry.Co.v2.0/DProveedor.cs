using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Texfina.Core.Data;
using Texfina.Entity.Co;
namespace Texfina.DOQry.Co
{
    public class DProveedor
    {
        public static DataSet ProveedorFill(EProveedor prov)
        {
            DBAccess db = new DBAccess();

            db.AddParameter("@psintypesel", prov.psintypesel);
            db.AddParameter("@raszoc", prov.Ds_raznombre);
            db.AddParameter("@id_clipro", prov.Id_clipro);
            db.AddParameter("@nu_ruc", prov.Nu_ruc);
            db.AddParameter("@id_empresa", prov.Id_empresa);

            return db.ExecuteDataSet("MG_Tercero_qry01");

        }


        public static List<Dato> ObtenerDatoProveedor(string commandtext, string par1, string par2, EProveedor prov)
        {
            List<Dato> _lista = new List<Dato>();

            DBAccess db = new DBAccess();
            db.AddParameter("@psintypesel", prov.psintypesel);
            db.AddParameter("@raszoc", prov.Ds_raznombre);
            db.AddParameter("@id_clipro", prov.Id_clipro);
            db.AddParameter("@nu_ruc", prov.Nu_ruc);
            db.AddParameter("@id_empresa", prov.Id_empresa);

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

        public static IDataReader Proveedor_qry02( EProveedor prov)
        {
            DBAccess db = new DBAccess();

            db.AddParameter("@id_empresa", prov.Id_empresa);

            return db.ExecuteReader("MG_Tercero_qry02");
        }


        public static DataSet Proveedor_qry03(ETerceros prov)
        {
            DBAccess db = new DBAccess();

            db.AddParameter("@pvchcriterio", prov.Ds_raznombre);

            db.AddParameter("@id_clipro", prov.Id_clipro);

            db.AddParameter("@nu_dociden", prov.Nu_dociden);

            db.AddParameter("@st_vtippro", prov.St_vtipcli);

            db.AddParameter("@st_vtipcli", prov.St_vtippro);

            db.AddParameter("@nu_ruc", prov.Nu_ruc);

            db.AddParameter("@id_empresa", prov.Id_empresa);

            return db.ExecuteDataSet("MG_Tercero_qry03");
        }


        private static ETerceros mCargarCliProv(IDataReader rdr)
        {
            ETerceros oCliProv = new ETerceros();
            oCliProv.Id_clipro = rdr.IsDBNull(rdr.GetOrdinal("id_clipro")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_clipro"));
            //oCliProv.Id_empresa = rdr.IsDBNull(rdr.GetOrdinal("idEmpresa")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("idEmpresa"));
            oCliProv.Id_vpersjuri = rdr.IsDBNull(rdr.GetOrdinal("id_vpersjuri")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_vpersjuri"));
            oCliProv.Id_vtipsocie = rdr.IsDBNull(rdr.GetOrdinal("id_vtipsocie")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_vtipsocie"));
            oCliProv.Id_vtipclasi = rdr.IsDBNull(rdr.GetOrdinal("id_vtipclasi")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_vtipclasi"));
            oCliProv.Ds_raznombre = rdr.IsDBNull(rdr.GetOrdinal("ds_raznombre")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_raznombre"));
            oCliProv.Ds_apellido = rdr.IsDBNull(rdr.GetOrdinal("ds_apellido")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_apellido"));
            oCliProv.Ds_nomcomer = rdr.IsDBNull(rdr.GetOrdinal("ds_nomcomer")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_nomcomer"));
            oCliProv.Nu_ruc = rdr.IsDBNull(rdr.GetOrdinal("nu_ruc")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("nu_ruc"));
            oCliProv.Id_vtipdoc = rdr.IsDBNull(rdr.GetOrdinal("id_vtipdoc")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_vtipdoc"));
            oCliProv.Nu_dociden = rdr.IsDBNull(rdr.GetOrdinal("nu_dociden")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("nu_dociden"));
            oCliProv.Id_grupo = rdr.IsDBNull(rdr.GetOrdinal("id_grupo")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_grupo"));
            oCliProv.Ds_direccion = rdr.IsDBNull(rdr.GetOrdinal("ds_direccion")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_direccion"));
            oCliProv.Ds_urbaniza = rdr.IsDBNull(rdr.GetOrdinal("ds_urbaniza")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_urbaniza"));
            oCliProv.Id_pais = rdr.IsDBNull(rdr.GetOrdinal("id_pais")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_pais"));
            oCliProv.Id_depto = rdr.IsDBNull(rdr.GetOrdinal("id_depto")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_depto"));
            oCliProv.Id_prov = rdr.IsDBNull(rdr.GetOrdinal("id_prov")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_prov"));
            oCliProv.Id_dist = rdr.IsDBNull(rdr.GetOrdinal("id_dist")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_dist"));
            oCliProv.Nu_telf1 = rdr.IsDBNull(rdr.GetOrdinal("nu_telf1")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("nu_telf1"));
            oCliProv.Nu_telf2 = rdr.IsDBNull(rdr.GetOrdinal("nu_telf2")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("nu_telf2"));
            oCliProv.Nu_fax1 = rdr.IsDBNull(rdr.GetOrdinal("nu_fax1")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("Nu_fax1"));
            oCliProv.Ds_emailco = rdr.IsDBNull(rdr.GetOrdinal("ds_emailco")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_emailco"));
            oCliProv.Ds_url = rdr.IsDBNull(rdr.GetOrdinal("ds_url")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_url"));
            oCliProv.Ds_appreleg = rdr.IsDBNull(rdr.GetOrdinal("ds_appreleg")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_appreleg"));
            oCliProv.Ds_apmreleg = rdr.IsDBNull(rdr.GetOrdinal("ds_apmreleg")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_apmreleg"));
            oCliProv.Ds_nomreleg = rdr.IsDBNull(rdr.GetOrdinal("ds_nomreleg")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_nomreleg"));
            oCliProv.Nu_tlfreleg = rdr.IsDBNull(rdr.GetOrdinal("nu_tlfreleg")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("nu_tlfreleg"));
            oCliProv.Nu_anxreleg = rdr.IsDBNull(rdr.GetOrdinal("nu_anxreleg")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("nu_anxreleg"));
            oCliProv.Ds_emareleg = rdr.IsDBNull(rdr.GetOrdinal("ds_emareleg")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_emareleg"));
            oCliProv.Id_vtipcalle = rdr.IsDBNull(rdr.GetOrdinal("id_vtipcalle")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_vtipcalle"));
            oCliProv.St_vtipcli = rdr.IsDBNull(rdr.GetOrdinal("st_vtipcli")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("st_vtipcli"));
            oCliProv.St_vtippro = rdr.IsDBNull(rdr.GetOrdinal("st_vtippro")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("st_vtippro"));
            return oCliProv;
        }

        public static ETerceros mObtenerProveedor(ETerceros provCli)
        {
            DBAccess db = new DBAccess();

            db.AddParameter("@pchr_idclipro", provCli.Id_clipro);
            db.AddParameter("@pchr_idEmpresa", provCli.Id_empresa);

            List<ETerceros> result = new List<ETerceros>();

            using (IDataReader rd = db.ExecuteReader("MG_Tercero_qry04"))
            {

                while (rd.Read())
                {
                    return mCargarCliProv(rd);
                }

            }

            return provCli;
        }

        //eliminar proveedor
        public static DataSet Proveedor_mnt02(ETerceros prov)
        {
            DBAccess db = new DBAccess();

            db.AddParameter("@id_clipro", prov.Id_clipro);

            db.AddParameter("@id_empresa", prov.Id_empresa);

            return db.ExecuteDataSet("MG_Tercero_mnt02");
        }

        public static List<ETerceros> MG_Tercero_qry05(ETerceros prov)
        {
            DBAccess db = new DBAccess();
            db.AddParameter("@pid_clipro", prov.Id_clipro);
            db.AddParameter("@pidEmpresa", prov.Id_empresa);

            List<ETerceros> result = new List<ETerceros>();

            using (IDataReader rdr = db.ExecuteReader("MG_Tercero_qry05"))
            {
                while (rdr.Read())
                {
                    result.Add(mCargarExistenciaTercero(rdr));
                }
            }
            return result;
        }


        private static ETerceros mCargarExistenciaTercero(IDataReader rdr)
        {
            ETerceros oCliProv = new ETerceros();
            oCliProv.existe = rdr.IsDBNull(rdr.GetOrdinal("existe")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("existe"));
            return oCliProv;
        }
        
    }
}
