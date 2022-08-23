using Obligatorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ActividadController : Controller

    {
        Sistema sis = Sistema.GetInstancia();

        public IActionResult Index()
        {
            TodasLasListas modelo = new TodasLasListas();
            modelo.Actividades = sis.Actividades;

            return View(modelo);
        }

        // ----------- USUARIO CLIENTE -----------
        public IActionResult ComprarEntrada(int idActividadSeleccionada)
        {
            // limitar acceso por url
            string sesion = HttpContext.Session.GetString("username");
            if (sesion == null)
            {
                return RedirectToAction("Index", "Usuario");
            }
            else
            {
                int sesionTipo = (int)HttpContext.Session.GetInt32("tipoUser");
                if (sesionTipo == 2)
                {
                    return RedirectToAction("Index", "Usuario");
                }
            }


            Actividad actSeleccionada = sis.ObtenerActividad(idActividadSeleccionada);
            return View("CompraActividad", actSeleccionada);
        }


        [HttpPost]
        public IActionResult ComprarEntrada(int idActividad, int cantidadCampo)
        {
            Actividad actividadComprada = sis.ObtenerActividad(idActividad);
            double precioTotal = actividadComprada.PrecioFinal();
            DateTime fechaCompra = DateTime.Now;

            Usuario usuarioCompra = sis.ObtenerUsuario(HttpContext.Session.GetString("username"));

            Compra nuevaCompra = sis.CargarCompra(actividadComprada, cantidadCampo, usuarioCompra, fechaCompra, precioTotal);

            return View("CompraConfirmada", nuevaCompra);
        }


        public IActionResult DarMeGusta(int idActividadSeleccionada)
        {
            // limitar acceso por url
            string sesion = HttpContext.Session.GetString("username");
            if (sesion == null)
            {
                return RedirectToAction("Index", "Usuario");
            }
            else
            {
                int sesionTipo = (int)HttpContext.Session.GetInt32("tipoUser");
                if (sesionTipo == 2)
                {
                    return RedirectToAction("Index", "Usuario");
                }
            }

            TodasLasListas modelo = new TodasLasListas();
            modelo.Actividades = sis.Actividades;

            Actividad actSeleccionada = sis.ObtenerActividad(idActividadSeleccionada);
            actSeleccionada.MeGusta++;

            ViewBag.MeGustaMsg = "Like!";
            ViewBag.IdMeGusta = idActividadSeleccionada;

            return View("Index", modelo);
        }


        // mostrar las compras al usuario en sesion
        public IActionResult ComprasUsuario()
        {
            // limitar acceso por url
            string sesion = HttpContext.Session.GetString("username");
            if (sesion == null)
            {
                return RedirectToAction("Index", "Usuario");
            }
            else
            {
                int sesionTipo = (int)HttpContext.Session.GetInt32("tipoUser");
                if (sesionTipo == 2)
                {
                    return RedirectToAction("Index", "Usuario");
                }
            }

            Usuario user = sis.ObtenerUsuario(HttpContext.Session.GetString("username"));

            List<Compra> ComprasUsuario = sis.ComprasDelUsuario(user.Email);

            return View("Compras", ComprasUsuario);
        }



        // cancelar compras
        public IActionResult CancelarCompra(int idCompra)
        {

            // limitar acceso por url
            string sesion = HttpContext.Session.GetString("username");
            if (sesion == null)
            {
                return RedirectToAction("Index", "Usuario");
            }
            else
            {
                int sesionTipo = (int)HttpContext.Session.GetInt32("tipoUser");
                if (sesionTipo == 2)
                {
                    return RedirectToAction("Index", "Usuario");
                }
            }

            Usuario user = sis.ObtenerUsuario(HttpContext.Session.GetString("username"));
            List<Compra> listaComprasUsuario = sis.ComprasDelUsuario(user.Email);

            sis.DescactivarCompra(idCompra);

            return View("Compras", listaComprasUsuario);
        }



        // ----------- USUARIO OPERADOR -----------

        // mostrar todas las compras
        public IActionResult MostrarCompras()
        {
            // limitar acceso por url
            string sesion = HttpContext.Session.GetString("username");
            if (sesion == null)
            {
                return RedirectToAction("Index", "Usuario");
            }
            else
            {
                int sesionTipo = (int)HttpContext.Session.GetInt32("tipoUser");
                if (sesionTipo == 1)
                {
                    return RedirectToAction("Index", "Usuario");
                }
            }

            return View();
        }


        [HttpPost]
        public IActionResult MostrarCompras(DateTime fechaInicio, DateTime fechaFinal)
        {
            // limitar acceso por url
            string sesion = HttpContext.Session.GetString("username");
            if (sesion == null)
            {
                return RedirectToAction("Index", "Usuario");
            }
            else
            {
                int sesionTipo = (int)HttpContext.Session.GetInt32("tipoUser");
                if (sesionTipo == 1)
                {
                    return RedirectToAction("Index", "Usuario");
                }
            }

            List<Compra> comprasEnFecha = sis.ComprasEnFecha(fechaInicio, fechaFinal);
            if (comprasEnFecha.Count == 0)
            {
                ViewBag.CompraEncontrada = "No se encontraron compras para esas fechas";
            }

            return View(comprasEnFecha);

        }


        // mostrar todos los clientes registrados
        public IActionResult MostrarClientes()
        {
            TodasLasListas modelo = new TodasLasListas();
            modelo.Usuarios = sis.MostrarClientes();
            modelo.Usuarios.Sort();

            // limitar acceso por url
            string sesion = HttpContext.Session.GetString("username");
            if (sesion == null)
            {
                return RedirectToAction("Index", "Usuario");
            }
            else
            {
                int sesionTipo = (int)HttpContext.Session.GetInt32("tipoUser");
                if (sesionTipo == 1)
                {
                    return RedirectToAction("Index", "Usuario");
                }
            }

            return View(modelo);
        }



        // ESTADISTICAS
        // index
        public IActionResult MostrarEstadisticas()
        {
            // limitar acceso por url
            string sesion = HttpContext.Session.GetString("username");
            if (sesion == null)
            {
                return RedirectToAction("Index", "Usuario");
            }
            else
            {
                int sesionTipo = (int)HttpContext.Session.GetInt32("tipoUser");
                if (sesionTipo == 1)
                {
                    return RedirectToAction("Index", "Usuario");
                }
            }

            // llenar las listas del modelo que se envia a la vista
            TodasLasListas modelo = new TodasLasListas();
            modelo.Lugares = sis.Lugares;
            modelo.Categorias = sis.Categorias;

            // para mostrar las mayores compras
            modelo.MayoresCompras = sis.ComprasMayorValor();

            return View(modelo);
        }


        // Dado el nombre de Lugar, listar todas las actividades que allí se realizan.
        [HttpPost]
        public IActionResult ActividadesPorLugar(string slcLugar)
        {
            // llenar las listas del modelo que se envia a la vista
            TodasLasListas modelo = new TodasLasListas();
            modelo.Lugares = sis.Lugares;
            modelo.Categorias = sis.Categorias;

            // para mostrar las mayores compras
            modelo.MayoresCompras = sis.ComprasMayorValor();

            // busca actividades en el lugar seleccionado y si encuentra se lo pasa al modelo
            List<Actividad> actividadesEncontradas = sis.ActividadesEnLugar(slcLugar);
            modelo.ActividadesPorLugar = actividadesEncontradas;

            if (actividadesEncontradas.Count == 0)
            {
                ViewBag.ActividadNoEncontrada = "No se encontró ninguna activad para este lugar";
            }


            return View("MostrarEstadisticas", modelo);
        }



        // Dadas dos fechas y una categoría listar todas las actividades que cumplan con el filtro.
        [HttpPost]
        public IActionResult ActividadesPorCategoria(int slcCategoria, DateTime fechaInicio, DateTime fechaFinal)
        {
            // llenar las listas del modelo que se envia a la vista
            TodasLasListas modelo = new TodasLasListas();
            modelo.Categorias = sis.Categorias;
            modelo.Lugares = sis.Lugares;

            // para mostrar las mayores compras
            modelo.MayoresCompras = sis.ComprasMayorValor();

            // busca actividades para la categoria seleccionada y si encuentra se lo pasa al modelo
            List<Actividad> actividadEnFecha = sis.ActividadesEnFecha(fechaInicio, fechaFinal, slcCategoria);
            modelo.ActividadesPorFecha = actividadEnFecha;

            if (actividadEnFecha.Count == 0)
            {
                ViewBag.ActividadNoEncontrada = "No se encontraron actividades para esas fechas";
            }

            return View("MostrarEstadisticas", modelo);

        }

    }
}
