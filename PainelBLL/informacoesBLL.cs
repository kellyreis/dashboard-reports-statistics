using System;
using System.Collections.Generic;
using System.Text;
using PainelDAL;
using PainelTO;
namespace PainelBLL
{
    public class informacoesBLL
    {
        #region .: Search :.
        public static List<informacoesTO> GetinformacoesAll()
        {
            return informacoesDAL.GetinformacoesAll();
        }

        public static informacoesTO GetinformacoesByID(long id)
        {
            return informacoesDAL.GetinformacoesByID(id);
        }

        public static List<informacoesTO> GetinformacoesAllCategoria(int ano)
        {
            return informacoesDAL.GetinformacoesAllCategoria(ano);
        }

        public static List<informacoesTO> GetinformacoesAllByYear(int ano)
        {
            return informacoesDAL.GetinformacoesAllByYear(ano);
        }

        


        #endregion

        #region .: Search Custom :.





        #endregion


    }
}

