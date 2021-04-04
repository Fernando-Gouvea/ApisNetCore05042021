using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjApiRelatorio.Dto;
using ProjApiRelatorio.Services;

namespace ProjApiRelatorio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteReportController : ControllerBase
    {
       

        private RelatorioService _relatorioService;

        public ClienteReportController()
        {
            _relatorioService = new RelatorioService();
        }

        [HttpGet]
        public async Task<IEnumerable<ClienteDto>> GetClienteAsync()
        {
            return await _relatorioService.GetClienteAsync();
        }
    
        
    }
}