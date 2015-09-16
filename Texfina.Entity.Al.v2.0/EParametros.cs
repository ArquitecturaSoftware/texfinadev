using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texfina.Entity.Al
{
   public class EParametros
    {
        public int psintypesel { get; set; }
        public string pidreqsalida { get; set; } 
        public string idEmpresa { get; set; }        
        public string idperiodo { get; set; }
        public string codbarra { get; set; }
        public string idIngreso { get; set; }
        
        public string fechaIni { get; set; }
        public string fechaFin { get; set; }
        public string dsRazonSoc { get; set; }
        public string dsproducto { get; set; }
        public string Existe { get; set; }
        public string Idreqsalida { get; set; }
        public string estado { get; set; }

        public string nu_Item { get; set; }
        public string feguia { get; set; }
        public string id_docucom { get; set; }
        public string nu_op { get; set; }
        public string nu_doc { get; set; }
        public string id_Almacen { get; set; }
        public string id_Tipo { get; set; }
        public string id_TipIngreso { get; set; }
        public string id_mercado { get; set; }
        public string id_tiptela { get; set; }
        public string id_producto { get; set; }
        public string ds_producto { get; set; }
        public string ds_raznombre { get; set; }

        public string st_autoriza { get; set; }
        public string id_autoriza { get; set; }
       
        public string id_color { get; set; }
        public string ds_color { get; set; }
        public string nu_tf { get; set; }
        public int qt_rollo { get; set; }
        public string id_clipro { get; set; }
        public string id_vendedor { get; set; }
        public string dsVendedor { get; set; }
        public decimal qt_ancho { get; set; }
        public decimal qt_densidad { get; set; }
        public decimal qt_peso_desp { get; set; }
        public decimal qt_peso_real { get; set; }
        public decimal qt_peso_actual { get; set; }

        //public DateTime feordenpeini { get;set;}
        //public DateTime feordenpefin { get; set; }
    }
}
