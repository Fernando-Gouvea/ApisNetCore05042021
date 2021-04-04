using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ProjApiProduto.Models;
using ProjApiProduto.Services;

namespace ProjApiProduto.Controllers
{
   [Route("api/[controller]")]
    [ApiController]
    public class FornecedorController : ControllerBase
    {
          private readonly FornecedorService _fornecedorService;

        public FornecedorController(FornecedorService fornecedorService)
        {
            _fornecedorService = fornecedorService;
        }

       [HttpGet]
       public ActionResult<List<Fornecedor>> Get() =>
       _fornecedorService.Get();

        [HttpGet("{id:length(24)}", Name = "GetFornecedor")]
        public ActionResult<Fornecedor> Get(string id)
        {
            var fornecedor = _fornecedorService.Get(id);
       
        if (fornecedor == null)
            {
                return NotFound();
            }

            return fornecedor;
        }

        [HttpPost]
        public ActionResult<Fornecedor> Create(Fornecedor fornecedor)
        {
            _fornecedorService.Create(fornecedor);

            return CreatedAtRoute("GetFornecedor", new { id = fornecedor.Id.ToString() }, fornecedor);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Fornecedor fornecedorIn)
        {
            var fornecedor = _fornecedorService.Get(id);

            if (fornecedor == null)
            {
                return NotFound();
            }

            _fornecedorService.Update(id, fornecedorIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var fornecedor = _fornecedorService.Get(id);

            if (fornecedor == null)
            {
                return NotFound();
            }

            _fornecedorService.Remove(fornecedor.Id);

            return NoContent();
        }
        
    }
}