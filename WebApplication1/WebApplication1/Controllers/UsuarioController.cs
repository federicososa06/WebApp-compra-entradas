using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Obligatorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UsuarioController : Controller
    {

        Sistema sis = Sistema.GetInstancia();

        public IActionResult Index()
        {
            return View("LogIn");
        }

        [HttpPost]
        public IActionResult Index(string emailCampo, string contraseniaCampo)
        {
            bool usuarioCorrecto = sis.ExisteUsuario(emailCampo, contraseniaCampo);
            Usuario usuarioEnSesion = sis.ObtenerUsuario(emailCampo);

            if (usuarioCorrecto)
            {
                HttpContext.Session.SetInt32("tipoUser", ((int)usuarioEnSesion.TipoUsuario));

                HttpContext.Session.SetString("username", emailCampo);

                return RedirectToAction("Index", "Actividad");

            }

            ViewBag.Msg = "Verifique usuario y contraseña";
            return View("LogIn");
        }



        public IActionResult Registrarse()
        {
            return View("Registro");
        }

        [HttpPost]
        public IActionResult Registrarse(string nombreRegistro, string apellidoRegistro, DateTime fechaRegistro, string emailRegistro, string usuarioRegistro, string contraseniaRegistro)
        {
            bool usuarioValido = sis.ValidarUsuario(emailRegistro, usuarioRegistro);


            if (usuarioValido)
            {
                Usuario nuevoUsuario = sis.CargarUsuario(nombreRegistro, apellidoRegistro, emailRegistro, usuarioRegistro, contraseniaRegistro, fechaRegistro, TipoUsuario.cliente);

                return View("RegistroConfirmado", nuevoUsuario);
            }

            ViewBag.ExisteUsuario = "Ya existe el nombre de usuario o email";

            return View("Registro");

        }

        public IActionResult CerrarSesion()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

    }
}
