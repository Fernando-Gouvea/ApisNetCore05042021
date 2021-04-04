using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjApiRelatorio.Dto;
using ProjApiRelatorio.Services;

namespace ProjApiRelatorio.Controllers
{
      [Route("api/[controller]")]
    [ApiController]

    public class ProdutoReportController
    {
          

        private RelatorioService _relatorioService;

        public ProdutoReportController()
        {
            _relatorioService = new RelatorioService();
        }

        [HttpGet]
        public async Task<IEnumerable<ProdutoDto>> GetProdutoAsync()
        {
            return await _relatorioService.GetProdutoAsync();
        }
    
   
    }
}