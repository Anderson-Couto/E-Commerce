using System;
using System.Threading.Tasks;
using ecommerce.Data;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly ProdutoRepository _repository;

        public ProdutoController(ProdutoRepository repository)
        {
            this._repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

    [HttpGet]    
    public async Task<ActionResult> PaginaInicial()
    {
        try
        {
            var candidatoList = await _repository.GetAllProdutos();
            return View(candidatoList);
        }
        catch (Exception e)
        {
            
            return StatusCode(500, e);
        }
    }

    }
}