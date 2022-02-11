using AutoMapper;
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
    public class AuthenticationController : Controller
    {
        private IAuthenticateRepository _authenticate;
        private IMapper _mapper;
        private ILogger _logger;

        public AuthenticationController(IAuthenticateRepository authenticate, IMapper mapper, ILogger<AuthenticationController> logger)
        {
            _authenticate = authenticate;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            _logger.LogInformation("Ingresa en método GetUser");
            if (id == 0)
            {
                _logger.LogWarning("Id suministrado como 0 en método GetUser de AuthenticationController");
                return BadRequest();
            }

            try
            {
                Users user = await _authenticate.GetUser(id);

                if (user != null)
                    return Ok(_mapper.Map<Users, UsersViewModel>(user));

                return NotFound();
            }
            catch(Exception ex)
            {
                _logger.LogError("No hay usuario en método GetUser en AuthenticationController - Mensaje: " + ex.Message);
                return NotFound();
            }
        }

        [HttpGet]
        [Route("{email}/{password}")]
        public async Task<IActionResult> SignInUser(string email, string password)
        {
            _logger.LogInformation("Ingresa en método SignInUser");

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                _logger.LogWarning("El email o contraseña son nulos");
                return BadRequest();
            }
            try
            {
                Users user = await _authenticate.SignIn(email, password);

                if (user.isLoggedIn == "true")
                {
                    UsersViewModel result = _mapper.Map<Users, UsersViewModel>(user);
                    return Ok(result);
                }
                    
                if (user.lockout == "true")
                {
                    _logger.LogWarning("El usuario se encuentra bloqueado");
                    return BadRequest("Usuario bloqueado");
                }

                return BadRequest();
            }
            catch(Exception ex)
            {
                _logger.LogError("Error en el método SignInUser - Mensaje: " + ex.Message);
                return BadRequest("Algo salió mal. Por favor intentalo más tarde");
            }           
        }

        [HttpGet]
        [Route("{signout}")]
        public async Task<IActionResult> SignOutUser(int id)
        {
            _logger.LogInformation("Ingresa a SignOutUser");

            if (id == 0)
            {
                _logger.LogWarning("El id es igual a 0 en SignOutUser");
                return BadRequest();
            }
            try
            {
                var result = await _authenticate.SignOut(id);

                if (result)
                    return Ok();

                return BadRequest();
            }
            catch(Exception ex)
            {
                _logger.LogError("Error en el método SignOutUser, no fue posible cerrar sesión - Mensaje: " + ex.Message);
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IActionResult> RegisterUser([FromBody] Users user)
        {
            _logger.LogInformation("Ingresa en método RegisterUser");

            if (user == null)
            {
                _logger.LogWarning("El usuario es nulo al ingresar a RegisterUser");
                return BadRequest();

            }

            if (!ModelState.IsValid)
            {
                _logger.LogWarning("El usuario ingresado no cumple con los requisitos");
                return BadRequest();
            }

            try
            {
                var result = await _authenticate.RegisterUser(user);

                if (result)
                    return Created("Usuario creado", result);

                return BadRequest();
            }
            catch (Exception ex)
            {
                _logger.LogError("Error al registrar usuario en RegisterUser - Mensaje: " + ex.Message);
                return BadRequest();
            }
        }
    }
}
