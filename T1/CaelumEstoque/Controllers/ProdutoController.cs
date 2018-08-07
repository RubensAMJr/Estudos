using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CaelumEstoque.DAO;
using CaelumEstoque.Filtro;
using CaelumEstoque.Models;

namespace CaelumEstoque.Controllers
{
    [AutorizacaoFilter]
    public class ProdutoController : Controller {
        [Route("produtos", Name = "ListaDeProdutos")]

        public ActionResult Index() {
            ProdutosDAO dao = new ProdutosDAO();
            IList<Produto> produtos = dao.Lista();

            return View(produtos);

        }
        [ValidateAntiForgeryToken]
        public ActionResult Form() {
            CategoriasDAO dao = new CategoriasDAO();
            IList<CategoriaDoProduto> categorias = dao.Lista();
            ViewBag.Categorias = categorias;
            ViewBag.Produto = new Produto();
            return View();
        }

        [HttpPost]
        public ActionResult Adiciona(Produto produto) {

            int idInformatica = 1;
            if(produto.CategoriaId.Equals(idInformatica) && produto.Preco < 100) {
                ModelState.AddModelError("produto.Invalido","Informatica com preço abaixo de 100 reais");
            }

            if (ModelState.IsValid) {
                ProdutosDAO dao = new ProdutosDAO();
                dao.Adiciona(produto);
                return RedirectToAction("Index", "Produto");
            }
            else {
                ViewBag.Produto = produto;
                CategoriasDAO dao = new CategoriasDAO();
                IList<CategoriaDoProduto> categorias = dao.Lista();
                ViewBag.Categorias = categorias;
                return View("Form");
            }
        }

        [Route("produtos/{id}",Name ="VisualizaProduto")]
        public ActionResult Visualiza(int id) {
            ProdutosDAO dao = new ProdutosDAO();
            Produto produto = dao.BuscaPorId(id);
            ViewBag.Produto = produto;
            return View();
        }

        public ActionResult DecrementaQtd(int id) {
            ProdutosDAO dao = new ProdutosDAO();
            Produto produto = dao.BuscaPorId(id);
            produto.Quantidade--;
            
            dao.Atualiza(produto);
            return Json(produto);
        }
    }
}