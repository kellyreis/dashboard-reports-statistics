using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using PainelBLL;
using PainelDAL;
using PainelTO;

namespace projeto.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            return View();
        }


        public ActionResult cadastro(string id)
        {
            StringBuilder conteudo = new StringBuilder();

            string total = "0";
            string valotTotalEcommerce = "0";
            List<informacoesTO> dados = informacoesBLL.GetinformacoesAllCategoria(Convert.ToInt32(id));

            //Criar uma lista de dados que mais tarde será transformada em JSON
            List<Dictionary<string, string>> resposta = new List<Dictionary<string, string>>();

            foreach (informacoesTO linha in dados)
            {
                if (linha.total != "S" | linha.total != "NA")
                    total = linha.total;
                if (linha.valor_ecommerce != "NA" | linha.valor_ecommerce != "NA")
                    valotTotalEcommerce = linha.valor_ecommerce;

                //Criar um dicionário de valores
                Dictionary<string, string> valores = new Dictionary<string, string>();

                //Adicionar todos esses valores ao dicionário
                valores.Add("text", categoriaBLL.GetcategoriaByID(linha.id_categoria).categoria);
                valores.Add("date", linha.ano);
                valores.Add("column-1", total.Replace(",", "."));
                valores.Add("column-2", valotTotalEcommerce.Replace(",", "."));
                valores.Add("column-3", categoriaBLL.GetcategoriaByID(linha.id_categoria).valor_cgr.Replace("%", "").Replace(",", "."));

                //Adicionar valores à lista
                resposta.Add(valores);
            }

            dynamic obj = new System.Dynamic.ExpandoObject();

            //Retornar lista e dicionário em formato JSON
            return Json(resposta, JsonRequestBehavior.AllowGet);



        }
    }
}