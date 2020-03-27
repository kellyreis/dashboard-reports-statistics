using System;
using System.Collections.Generic;
using System.Text;

namespace PainelTO
{
    [Serializable]
    public class informacoesTO
    {
        #region .:Variables:.

        private int _id;
        private int _id_categoria;
        private string _ano;
        private string _total;
        private string _valor_ecommerce;
        private string _total_valor_ecommerce;
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
        public int id_categoria
        {
            get
            {
                return _id_categoria;
            }
            set
            {
                _id_categoria = value;
            }
        }
        public string ano
        {
            get
            {
                return _ano;
            }
            set
            {
                _ano = value;
            }
        }
        public string total
        {
            get
            {
                return _total;
            }
            set
            {
                _total = value;
            }
        }
        public string valor_ecommerce
        {
            get
            {
                return _valor_ecommerce;
            }
            set
            {
                _valor_ecommerce = value;
            }
        }

        public string total_valor_ecommerce
        {
            get
            {
                return _total_valor_ecommerce;
            }
            set
            {
                _total_valor_ecommerce = value;
            }
        }

        #endregion

    }
}
