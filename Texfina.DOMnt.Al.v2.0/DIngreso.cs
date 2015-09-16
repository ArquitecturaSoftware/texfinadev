using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Texfina.Core.Data;
using Texfina.Entity.Al;

namespace Texfina.DOMnt.Al
{
    public class DIngreso
    {
        public static List<Texfina.Entity.Co.Dato> IngresoGenCod_qry01_( string idPeriodo, string idEmpresa)
        {
            List<Texfina.Entity.Co.Dato> _lista = new List<Texfina.Entity.Co.Dato>();

            DBAccess db = new DBAccess();
            db.AddParameter("@idPeriodo", idPeriodo);
            db.AddParameter("@idEmpresa", idEmpresa);

            IDataReader reader = db.ExecuteReader("Al_Ingreso_GenCod");

            while (reader.Read())
            {
                Texfina.Entity.Co.Dato _dato = new Texfina.Entity.Co.Dato();

                _dato.id = reader["idIngreso"].ToString();

                _lista.Add(_dato);
            }
            return _lista;
        }


        public static void Ingreso_mnt01(EIngreso obj)
        {
            DBAccess db = new DBAccess();

            db.AddParameter("@pidIngreso", obj.IdIngreso);
            db.AddParameter("@pidEmpresa", obj.IdEmpresa);
            db.AddParameter("@pidPeriodo", obj.IdPeriodo);
            db.AddParameter("@pfeguia", obj.Feguia);
            db.AddParameter("@pid_local", obj.Id_local);
            db.AddParameter("@pid_Personal1", obj.Id_Personal1);      
            db.AddParameter("@pid_Personal2", obj.Id_Personal2);
            db.AddParameter("@pid_docucom", obj.Id_docucom);
            db.AddParameter("@pds_observ", obj.ds_observ);
            db.AddParameter("@pnu_doc", obj.Nu_doc);
            db.AddParameter("@pid_Almacen", obj.Id_Almacen);
            db.AddParameter("@pid_ucreatrec", obj.Id_ucreatrec);
            

            db.ExecuteNonQuery("AL_Ingreso_mnt01");

        }



        private static EIngreso mCargarIngreso(IDataReader rdr)
        {
            
            EIngreso obj = new EIngreso();
            obj.IdIngreso = rdr.IsDBNull(rdr.GetOrdinal("idIngreso")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("idIngreso"));
            obj.IdEmpresa = rdr.IsDBNull(rdr.GetOrdinal("idEmpresa")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("idEmpresa"));
            obj.IdPeriodo = rdr.IsDBNull(rdr.GetOrdinal("idPeriodo")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("idPeriodo"));
            obj.Feguia = rdr.IsDBNull(rdr.GetOrdinal("feguia")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("feguia"));
            obj.Id_local = rdr.IsDBNull(rdr.GetOrdinal("id_local")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_local"));
            obj.Id_Personal1 = rdr.IsDBNull(rdr.GetOrdinal("id_Personal1")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_Personal1"));
            obj.dsPesonal1 = rdr.IsDBNull(rdr.GetOrdinal("dsPersonal1")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("dsPersonal1"));
            
            obj.Id_Personal2 = rdr.IsDBNull(rdr.GetOrdinal("id_Personal2")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_Personal2"));
            obj.dsPesonal2 = rdr.IsDBNull(rdr.GetOrdinal("dsPersonal2")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("dsPersonal2"));
            obj.Id_docucom = rdr.IsDBNull(rdr.GetOrdinal("id_docucom")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_docucom"));
            obj.Nu_doc = rdr.IsDBNull(rdr.GetOrdinal("nu_doc")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("nu_doc"));
            obj.Id_Almacen = rdr.IsDBNull(rdr.GetOrdinal("id_Almacen")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("id_Almacen"));
            obj.ds_observ = rdr.IsDBNull(rdr.GetOrdinal("ds_observacion")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("ds_observacion"));
            
            return obj;
        }





        public static EIngreso AL_Ingreso_qry02(EIngreso obj)
        {
            DBAccess db = new DBAccess();

            db.AddParameter("@pidEmpresa", obj.IdEmpresa);
            db.AddParameter("@idPeriodo", obj.IdPeriodo);
            db.AddParameter("@idIngreso", obj.IdIngreso);

          
            using (IDataReader rd = db.ExecuteReader("AL_Ingreso_qry02"))
            {
                while (rd.Read())
                {
                    return mCargarIngreso(rd);
                }
            }

            return obj;
        }



        private static EIngreso mCargarIngExiste(IDataReader rdr)
        {
            EIngreso oTJ = new EIngreso();
            oTJ.existe = rdr.IsDBNull(rdr.GetOrdinal("existe")) ? String.Empty : rdr.GetString(rdr.GetOrdinal("existe"));
            return oTJ;
        }

        public static List<EIngreso> AL_Ingreso_qry05(EIngreso obj)
        {
            DBAccess db = new DBAccess();
            db.AddParameter("@pid_empresa", obj.IdEmpresa);
            db.AddParameter("@id_periodo", obj.IdPeriodo);
            db.AddParameter("@id_ingreso", obj.IdIngreso);
            db.AddParameter("@pexists", obj.existe);


            List<EIngreso> result = new List<EIngreso>();

            using (IDataReader rdr = db.ExecuteReader("AL_Ingreso_qry05"))
            {
                while (rdr.Read())
                {
                    result.Add(mCargarIngExiste(rdr));
                }
            }
            return result;
        }



        public DataTable AL_Ingreso_etiqueta_rpt(EIngreso obj)
        {
            DBAccess db = new DBAccess();
            ArrayList arrPrm = new ArrayList();

            //arrPrm.Add(DBAccess.CreateParameter("@psintypesel", SqlDbType.Int, tj.psintypesel));
            arrPrm.Add(DBAccess.CreateParameter("@pidEmpresa", SqlDbType.Char, 3, obj.IdEmpresa));
            arrPrm.Add(DBAccess.CreateParameter("@pidPeriodo", SqlDbType.Char, 4, obj.IdPeriodo));
            arrPrm.Add(DBAccess.CreateParameter("@pidIngreso", SqlDbType.Char, 7, obj.IdIngreso));

            DataTable dt = db.ExecuteDatatable("AL_Ingreso_etiqueta_rpt", arrPrm);
            return dt;
        }


    

      

    }
}
