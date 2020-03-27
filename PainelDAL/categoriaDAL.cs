using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using MySql.Data.MySqlClient;
using PainelTO;

namespace PainelDAL
{
    public class categoriaDAL
    {
        public categoriaDAL(MySqlDataReader dr)
        {
            Load(dr);
        }

        #region .: Load :.

        public static categoriaTO Load(MySqlDataReader dr)
        {

            categoriaTO objeto = new categoriaTO();


            if (!dr.IsDBNull(dr.GetOrdinal("id"))) objeto.id = dr.GetInt32(dr.GetOrdinal("id")); else objeto.id = 0;
            if (!dr.IsDBNull(dr.GetOrdinal("categoria"))) objeto.categoria = dr.GetString(dr.GetOrdinal("categoria")); else objeto.categoria = "";
            if (!dr.IsDBNull(dr.GetOrdinal("valor_cgr"))) objeto.valor_cgr = dr.GetString(dr.GetOrdinal("valor_cgr")); else objeto.valor_cgr = "";
          
            return objeto;
        }

        #endregion

        #region .: Search :.

        public static List<categoriaTO> GetcategoriaAll()
        {
            string conexao = Convert.ToString(ConfigurationSettings.AppSettings["STRING_CONNECTION"]);
            MySqlConnection db = new MySqlConnection(conexao);
            List<categoriaTO> objeto = new List<categoriaTO>();
            try
            {
                string sql = "SELECT * FROM categoria ORDER BY id";
                MySqlCommand comand = new MySqlCommand(sql, db);
                db.Open();
                using (MySqlDataReader dr = comand.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        objeto.Add(Load(dr));
                    }
                }
            }
            finally
            {
                db.Close();
            }
            return objeto;
        }

        public static categoriaTO GetcategoriaByID(long id)
        {
            string conexao = Convert.ToString(ConfigurationSettings.AppSettings["STRING_CONNECTION"]);
            MySqlConnection db = new MySqlConnection(conexao);
            categoriaTO objeto = new categoriaTO();
            try
            {
                string sql = "SELECT * FROM categoria WHERE id=@id;";
                MySqlCommand comand = new MySqlCommand(sql);
                comand.Parameters.AddWithValue("@id", id);
                db.Open();
                comand.Connection = db;
                comand.ExecuteNonQuery();
                using (MySqlDataReader dr = comand.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        objeto = Load(dr);
                    }
                }
            }
            finally
            {
                db.Close();
            }
            return objeto;
        }

        #endregion

        

        

    }
}
