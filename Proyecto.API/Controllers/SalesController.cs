using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proyecto.Models;
using Proyecto.Repositories.Repositories.authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : Controller
    {
        private ISalesRepository _salesRepository;
        private ILogger _logger;

        public SalesController(ISalesRepository salesRepository, ILogger<SalesController> logger)
        {
            _salesRepository = salesRepository;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<Sales>> GetSales()
        {
            _logger.LogInformation("Ingresa en método GetSales");

            try
            {
                return await _salesRepository.GetSales();
            }
            catch(Exception ex)
            {
                _logger.LogError("Error en GetSales - Mensaje: " + ex.Message);
            }

            return null;
        }

        [HttpPost]
        public async Task<IActionResult> InsertSale(List<Sales> sales)
        {
            _logger.LogInformation("Ingresa en método InsertSale");
            try
            {
                foreach (var item in sales)
                {
                    await _salesRepository.AddSale(item);
                }
            }
            catch(Exception ex)
            {
                _logger.LogError("Error en InsertSale - Mensaje: " + ex.Message);
                return BadRequest();
            }

            return Ok();
        }
    }
}
