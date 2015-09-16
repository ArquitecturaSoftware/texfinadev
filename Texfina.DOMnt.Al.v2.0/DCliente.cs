using System;
using System.Collections;
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
    public class DCliente
    {
        public static DataSet ClienteFill(ECliente prov)
        {
            DBAccess db = new DBAccess();

            db.AddParameter("@psintypesel", prov.psintypesel);
            db.AddParameter("@raszoc", prov.Ds_raznombre);
            db.AddParameter("@id_clipro", prov.Id_clipro);
            db.AddParameter("@nu_ruc", prov.Nu_ruc);
            db.AddParameter("@id_empresa", prov.IdEmpresa);

            return db.ExecuteDataSet("MG_Cliente_qry01");

        }

        public static List<Dato> Cliente_qry06(String Codigo)
        {
            List<Dato> _lista = new List<Dato>();

            DBAccess db = new DBAccess();
            db.AddParameter("@idEmpresa", Codigo);

            IDataReader reader = db.ExecuteReader("MG_GencodigoCliente");

            while (reader.Read())
            {
                Dato _dato = new Dato();

                _dato.id = reader["id_clipro"].ToString();
                _dato.desc = reader["id_clipro"].ToString();
                _lista.Add(_dato);
            }
            return _lista;
        }

        public static void Cliente_mnt01(ECliente c)
        {
            DBAccess db = new DBAccess();

            db.AddParameter("@pidEmpresa", c.IdEmpresa);
            db.AddParameter("@pid_clipro", c.Id_clipro);
            db.AddParameter("@pid_vptipsocie", c.Id_vptipsocie);
            db.AddParameter("@pid_vpersjuri", c.Id_vpersjuri);
            db.AddParameter("@pds_raznombre", c.Ds_raznombre);
            db.AddParameter("@pds_apellido", c.Ds_apellido);
            db.AddParameter("@pnu_ruc", c.Nu_ruc);
            db.AddParameter("@pid_vtipdoc", c.Id_vtipdoc);
            db.AddParameter("@pnu_dociden", c.Nu_dociden);
            db.AddParameter("@pds_nomcomer", c.Ds_nomcomer);
            db.AddParameter("@pid_grupo", c.Id_grupo);
            db.AddParameter("@pid_vtipclasi", c.Id_vtipclasi);
            db.AddParameter("@pst_activo", c.St_activo);
            db.AddParameter("@pid_vtipcalle", c.Id_vtipcalle);
            db.AddParameter("@pds_direccion", c.Ds_direccion);
            db.AddParameter("@pds_urbaniza", c.Ds_urbaniza);
            db.AddParameter("@pid_pais", c.Id_pais);
            db.AddParameter("@pid_depto", c.Id_depto);
            db.AddParameter("@pid_prov", c.Id_prov);
            db.AddParameter("@pid_dist", c.Id_dist);
            db.AddParameter("@pnu_telf1", c.Nu_telf1);
            db.AddParameter("@pnu_telf2", c.Nu_telf2);
            db.AddParameter("@pds_emailco", c.Ds_emailco);
            db.AddParameter("@pds_url", c.Ds_url);
            db.AddParameter("@pds_monreleg", c.Ds_monreleg);
            db.AddParameter("@pds_appreleg", c.Ds_appreleg);
            db.AddParameter("@pds_apmreleg", c.Ds_apmreleg);
            db.AddParameter("@pnu_anxreleg", c.Nu_anxreleg);
            db.AddParameter("@pnu_telfeg", c.Nu_telfeg);
            db.AddParameter("@pds_emareleg", c.Ds_emareleg);
            db.AddParameter("@pid_ucrearec", c.Id_ucrearec);

            db.AddParameter("@idCliFox", c.Id_cliFox);
            db.AddParameter("@idVendFox", c.id_Vendedor);

            db.ExecuteNonQuery("MG_Cliente_mnt01");

        }



        public static List<ECliente> MG_Cliente_qry05(ECliente c)
        {
            DBAccess db = new DBAccess();
            db.AddParameter("@pid_clipro", c.Id_clipro);
            db.AddParameter("@pidEmpresa", c.IdEmpresa);

            List<ECliente> result = new List<ECliente>();

            using (IDataReader rdr = db.ExecuteReader("MG_Cliente_qry05"))
            {
                while (rdr.Read())
                {
                    result.Add(mCargarExistenciaCliente(rdr));
                }
            }
            return result;
        }


        private static ECliente mCargarExistenciaCliente(IDataReader rdr)
        {
            ECliente oCliProv = new ECliente();
            oCliProv.existe = rdr.IsDBNull(rdr.GetOrdinal("existe")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("existe"));
            return oCliProv;
        }




        public static ECliente MG_Cliente_qry02(ECliente provCli)
        {
            DBAccess db = new DBAccess();

            db.AddParameter("@pchr_idclipro", provCli.Id_clipro);
            db.AddParameter("@pchr_idEmpresa", provCli.IdEmpresa);

            List<ETerceros> result = new List<ETerceros>();

            using (IDataReader rd = db.ExecuteReader("MG_Cliente_qry02"))
            {

                while (rd.Read())
                {
                    return mCargarCliente(rd);
                }

            }

            return provCli;
        }




        private static ECliente mCargarCliente(IDataReader rdr)
        {
            ECliente oCliProv = new ECliente();
            oCliProv.Id_clipro = rdr.IsDBNull(rdr.GetOrdinal("id_clipro")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_clipro"));
            oCliProv.Id_vptipsocie = rdr.IsDBNull(rdr.GetOrdinal("id_vptipsocie")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_vptipsocie"));
            oCliProv.Id_vpersjuri = rdr.IsDBNull(rdr.GetOrdinal("id_vpersjuri")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_vpersjuri"));
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
            oCliProv.Nu_telfeg = rdr.IsDBNull(rdr.GetOrdinal("nu_telfeg")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("nu_telfeg"));
            oCliProv.Ds_emailco = rdr.IsDBNull(rdr.GetOrdinal("ds_emailco")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_emailco"));
            oCliProv.Ds_url = rdr.IsDBNull(rdr.GetOrdinal("ds_url")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_url"));
            oCliProv.Ds_appreleg = rdr.IsDBNull(rdr.GetOrdinal("ds_appreleg")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_appreleg"));
            oCliProv.Ds_apmreleg = rdr.IsDBNull(rdr.GetOrdinal("ds_apmreleg")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_apmreleg"));
            oCliProv.Ds_monreleg = rdr.IsDBNull(rdr.GetOrdinal("ds_monreleg")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_monreleg"));
            oCliProv.Nu_anxreleg = rdr.IsDBNull(rdr.GetOrdinal("nu_anxreleg")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("nu_anxreleg"));
            oCliProv.Ds_emareleg = rdr.IsDBNull(rdr.GetOrdinal("ds_emareleg")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_emareleg"));
            oCliProv.Id_vtipcalle = rdr.IsDBNull(rdr.GetOrdinal("id_vtipcalle")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_vtipcalle"));

            oCliProv.Id_cliFox = rdr.IsDBNull(rdr.GetOrdinal("idCliFox")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("idCliFox"));
            oCliProv.id_Vendedor = rdr.IsDBNull(rdr.GetOrdinal("id_Vendedor")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_Vendedor"));
            oCliProv.ds_Vendedor = rdr.IsDBNull(rdr.GetOrdinal("dsVendedor")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("dsVendedor"));

   
            return oCliProv;
        }


        public static DataSet Cliente_mnt02(ECliente prov)
        {
            DBAccess db = new DBAccess();

            db.AddParameter("@id_clipro", prov.Id_clipro);

            db.AddParameter("@id_empresa", prov.IdEmpresa);

            return db.ExecuteDataSet("MG_Cliente_mnt02");
        }

        public static List<Dato> ObtenerDatoCliente(ECliente c)
        {
            List<Dato> _lista = new List<Dato>();

            DBAccess db = new DBAccess();
            db.AddParameter("@psintypesel", c.psintypesel);
            db.AddParameter("@raszoc", c.Ds_raznombre);
            db.AddParameter("@id_clipro", c.Id_clipro);
            db.AddParameter("@nu_ruc", c.Nu_ruc);
            db.AddParameter("@id_empresa", c.IdEmpresa);

            IDataReader reader = db.ExecuteReader("MG_Cliente_qry01");

            while (reader.Read())
            {
                Dato _dato = new Dato();

                _dato.id = reader["Codigo"].ToString();
                _dato.desc = reader["Razon Social"].ToString();
                _lista.Add(_dato);
            }
            return _lista;
        }



        public DataTable MG_Cliente_rpt01(ECliente c)
        {
            DBAccess db = new DBAccess();
            ArrayList arrPrm = new ArrayList();

            arrPrm.Add(DBAccess.CreateParameter("@idEmpresa", SqlDbType.Char, 3, c.IdEmpresa));
            arrPrm.Add(DBAccess.CreateParameter("@nu_ruc", SqlDbType.Char, 11, c.Nu_ruc.Trim()));
            arrPrm.Add(DBAccess.CreateParameter("@ds_raznombre", SqlDbType.Char, 100, c.Ds_raznombre.Trim()));

            DataTable dt = db.ExecuteDatatable("MG_Cliente_rpt01", arrPrm);
            return dt;
        }

       
    }
}
