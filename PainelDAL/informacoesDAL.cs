using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using MySql.Data.MySqlClient;
using PainelTO;

namespace PainelDAL
{
    public class informacoesDAL
    {
        public informacoesDAL(MySqlDataReader dr)
        {
            Load(dr);
        }

        #region .: Load :.

        public static informacoesTO Load(MySqlDataReader dr)
        {

            informacoesTO objeto = new informacoesTO();


            if (!dr.IsDBNull(dr.GetOrdinal("id"))) objeto.id = dr.GetInt32(dr.GetOrdinal("id")); else objeto.id = 0;

            if (!dr.IsDBNull(dr.GetOrdinal("id_categoria"))) objeto.id_categoria = dr.GetInt32(dr.GetOrdinal("id_categoria")); else objeto.id_categoria = 0;

  
            if (!dr.IsDBNull(dr.GetOrdinal("ano"))) objeto.ano = dr.GetString(dr.GetOrdinal("ano")); else objeto.ano = "";
            if (!dr.IsDBNull(dr.GetOrdinal("total"))) objeto.total = dr.GetString(dr.GetOrdinal("total")); else objeto.total = "";

            if (!dr.IsDBNull(dr.GetOrdinal("valor_ecommerce"))) objeto.valor_ecommerce = dr.GetString(dr.GetOrdinal("valor_ecommerce")); else objeto.valor_ecommerce = "";


            if (!dr.IsDBNull(dr.GetOrdinal("total_valor_ecommerce"))) objeto.total_valor_ecommerce = dr.GetString(dr.GetOrdinal("total_valor_ecommerce")); else objeto.total_valor_ecommerce = "";
            return objeto;
        }

        #endregion

        #region .: Search :.

        public static List<informacoesTO> GetinformacoesAll()
        {
            string conexao = Convert.ToString(ConfigurationSettings.AppSettings["STRING_CONNECTION"]);
            MySqlConnection db = new MySqlConnection(conexao);
            List<informacoesTO> objeto = new List<informacoesTO>();
            try
            {
                string sql = "SELECT * FROM informacoes ORDER BY id";
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

        public static informacoesTO GetinformacoesByID(long id)
        {
            string conexao = Convert.ToString(ConfigurationSettings.AppSettings["STRING_CONNECTION"]);
            MySqlConnection db = new MySqlConnection(conexao);
            informacoesTO objeto = new informacoesTO();
            try
            {
                string sql = "SELECT * FROM informacoes WHERE id=@id;";
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


        public static List<informacoesTO> GetinformacoesAllCategoria(int categoria)
        {
            string conexao = Convert.ToString(ConfigurationSettings.AppSettings["STRING_CONNECTION"]);
            MySqlConnection db = new MySqlConnection(conexao);
            List<informacoesTO> objeto = new List<informacoesTO>();
            try
            {
                string sql = "SELECT *FROM informacoes WHERE id_categoria = @categoria ORDER BY ano ASC";
                MySqlCommand comand = new MySqlCommand(sql, db);
                comand.Parameters.AddWithValue("@categoria", categoria);
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

        public static List<informacoesTO> GetinformacoesAllByYear(int ano)
        {
            string conexao = Convert.ToString(ConfigurationSettings.AppSettings["STRING_CONNECTION"]);
            MySqlConnection db = new MySqlConnection(conexao);
            List<informacoesTO> objeto = new List<informacoesTO>();
            try
            {
                string sql = "SELECT *FROM informacoes WHERE ano = @ano ORDER BY total_valor_ecommerce DESC";
                MySqlCommand comand = new MySqlCommand(sql, db);
                comand.Parameters.AddWithValue("@ano", ano);
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


        



        #endregion





    }
}
