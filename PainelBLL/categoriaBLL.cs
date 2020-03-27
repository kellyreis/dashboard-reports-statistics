using System;
using System.Collections.Generic;
using System.Text;
using PainelDAL;
using PainelTO;
namespace PainelBLL
{
    public class categoriaBLL
    {
        #region .: Search :.
        public static List<categoriaTO> GetcategoriaAll()
        {
            return categoriaDAL.GetcategoriaAll();
        }

        public static categoriaTO GetcategoriaByID(long id)
        {
            return categoriaDAL.GetcategoriaByID(id);
        }

        #endregion

        #region .: Search Custom :.

      
        
        #endregion

        
    }
}

