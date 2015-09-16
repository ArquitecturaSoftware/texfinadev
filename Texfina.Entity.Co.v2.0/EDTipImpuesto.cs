using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Texfina.Entity.Co
{
    public class EDTipImpuesto
    {
        #region Campos

       
        private int _intIdDet = 0;
        private Nullable<int> _intIdImp = null;
        private string _strIdPeriodo = null;
        private Nullable<decimal> _decMtIgv = null;
        private string _strStAnulado = "";
    
        #endregion

        #region Atributos


        
        public int IdDet
        {
            get { return _intIdDet; }
            set { _intIdDet = value; }
        }

        
        public Nullable<int> IdImp
        {
            get { return _intIdImp; }
            set { _intIdImp = value; }
        }

        
        public string IdPeriodo
        {
            get { return _strIdPeriodo; }
            set { _strIdPeriodo = value; }
        }

        
        public Nullable<decimal> MtIgv
        {
            get { return _decMtIgv; }
            set { _decMtIgv = value; }
        }

        /// <summary>
        /// Estado Anulado
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        
        public string StAnulado
        {
            get { return _strStAnulado; }
            set { _strStAnulado = value; }
        }

        #endregion

    }
}
