using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proyecto.Models;
using Proyecto.Repositories.Repositories;
using System;
using System.Threading.Tasks;

namespace Proyecto.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ILogger _logger;

        public ProductController(IProductRepository productRespository, ILogger<ProductController> logger)
        {
            _productRepository = productRespository;
            _logger = logger;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            _logger.LogInformation("Ingresa en GetAllProducts");

            try
            {
                return Ok(await _productRepository.GetAllProducts());
            }
            catch(Exception ex)
            {
                _logger.LogError("Error en GetAllProducts - Mensaje: " + ex.Message);
                return BadRequest();
            }
            
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            _logger.LogInformation("Ingresa en GetProduct");

            if (id == 0)
            {
                _logger.LogWarning("El id de GetProduct es 0");
                return BadRequest();
            }

            try
            {
                var result = await _productRepository.GetProduct(id);

                if (result == null)
                {
                    _logger.LogWarning("El producto obtenido está vacio");
                }

                return Ok(result);
            }
            catch
            {
                _logger.LogError("Error en GetProduct");

                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody] Products product)
        {
            _logger.LogInformation("Ingresa en método CreateProduct");

            if (product == null)
            {
                _logger.LogWarning("El objeto de producto que ingreso a CreateProduct es nulo");
                return BadRequest();
            }
                

            if (product.name == string.Empty)
            {
                _logger.LogWarning("El objeto de producto que ingreso a CreateProduct no tiene nombre");
                ModelState.AddModelError("nombre", "El nombre no puede estar vacio");
            }
                

            if (!ModelState.IsValid)
            {
                _logger.LogWarning("El objeto de producto que ingreso a CreateProduct no pasó todas las validaciones");
                return BadRequest(ModelState);
            }
            try
            {
                var created = await _productRepository.InsertProduct(product);

                return Created("Creado", created);
            }
            catch(Exception ex)
            {
                _logger.LogError("Error en CreateProduct - Mensaje: " + ex.Message);
                return BadRequest();
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct([FromBody] Products product)
        {
            _logger.LogInformation("Ingresa en método UpdateProduct");

            if (product == null)
            {
                _logger.LogWarning("El objeto enviado a UpdateProduct es nulo");
                return BadRequest();
            }
                

            if (product.name.Trim() == string.Empty)
            {
                _logger.LogWarning("El nombre del producto está vacio");
                ModelState.AddModelError("nombre", "El nombre no puede estar vacio");
            }
                

            if (!ModelState.IsValid)
            {
                _logger.LogWarning("El producto no es valido");
                return BadRequest(ModelState);
            }
            try
            {
                await _productRepository.UpdateProduct(product);
                return Ok();
            }
            catch(Exception ex)
            {
                _logger.LogError("Error en UpdateProduct - Mensaje: " + ex.Message);
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            _logger.LogInformation("Ingresa en método DeleteProduct");

            if (id == 0)
            {
                _logger.LogWarning("El id suministrado a DeleteProduct es 0");
                return BadRequest();
            }
            try
            {
                await _productRepository.DeleteProduct(id);

                return Ok();
            }
            catch(Exception ex)
            {
                _logger.LogError("Error en DeleteProduct - Mensaje: " + ex.Message);
                return BadRequest();
            }
        }
    }
}
