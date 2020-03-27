using System;
using System.Collections.Generic;
using System.Text;

namespace PainelTO
{
    [Serializable]
    public class categoriaTO
    {
        #region .:Variables:.

        private int _id;
        private string _categoria;
        private string _valor_cgr;

        #endregion

        #region .:Property da classe:.
        public int id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public string categoria
        {
            get
            {
                return _categoria;
            }
            set
            {
                _categoria = value;
            }
        }
        public string valor_cgr
        {
            get
            {
                return _valor_cgr;
            }
            set
            {
                _valor_cgr = value;
            }
        }

        #endregion

    }
}