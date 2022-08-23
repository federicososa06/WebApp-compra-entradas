using System;
using System.Collections.Generic;

namespace Obligatorio
{
    public class Sistema
    {
        private int aforoMaximo = 60;
        private int precioButaca = 200;

        public List<Usuario> Usuarios = new List<Usuario>();

        public List<Compra> Compras = new List<Compra>();

        public List<Actividad> Actividades = new List<Actividad>();

        public List<Lugar> Lugares = new List<Lugar>();

        public List<Categoria> Categorias = new List<Categoria>();

        public static Sistema Instancia;


        /* --------------------- OBLIGATORIO 2 --------------------- */
        private Sistema()
        {
            precarga();
        }

        public static Sistema GetInstancia()
        {
            if (Instancia == null)
                Instancia = new Sistema();

            return Instancia;
        }


        public Actividad ObtenerActividad(int idAct)
        {
            Actividad ret = null;
            foreach (Actividad a in Actividades)
            {
                if (a.Id == idAct)
                    ret = a;
            }
            return ret;
        }


        public bool ExisteUsuario(string email, string contrasenia)
        {
            bool ret = false;
            foreach (Usuario u in Usuarios)
            {
                if (u.Email == email && u.Contrasenia == contrasenia)
                {
                    ret = true;
                    break;
                }
            }
            return ret;
        }

        public Usuario ObtenerUsuario(string emailUser)
        {
            Usuario ret = null;

            foreach (Usuario u in Usuarios)
            {
                if (u.Email == emailUser)
                {
                    ret = u;
                    break;
                }
            }

            return ret;
        }

        public bool ValidarUsuario(string email, string nombreUser)
        {
            bool ret = true;

            foreach (Usuario u in Usuarios)
            {
                if (u.Email == email || u.NombreUsuario == nombreUser)
                {
                    ret = false;
                }
            }

            return ret;
        }

        public void DescactivarCompra(int idCompra)
        {
            foreach (Compra c in Compras)
            {
                if (c.Id.Equals(idCompra))
                {
                    c.Activa = false;
                    break;
                }
            }

        }


        public List<Compra> ComprasDelUsuario(string emailUser)
        {
            List<Compra> ret = new List<Compra>();

            foreach (Compra c in Compras)
            {
                if (c.Usuario.Email == emailUser)
                    ret.Add(c);
            }

            return ret;
        }


        public List<Usuario> MostrarClientes()
        {
            List<Usuario> ret = new List<Usuario>();

            foreach (Usuario u in Usuarios)
            {
                if (u.TipoUsuario == TipoUsuario.cliente)
                    ret.Add(u);

            }
            return ret;
        }


        public List<Compra> ComprasEnFecha(DateTime fechaInicio, DateTime fechaFinal)
        {
            List<Compra> ret = new List<Compra>();

            foreach (Compra compra in Compras)
            {
                if (compra.FechaHora >= fechaInicio && compra.FechaHora <= fechaFinal)
                {
                    ret.Add(compra);
                }
            }

            return ret;

        }


        public List<Actividad> ActividadesEnLugar(string nombreLugar)
        {
            List<Actividad> ret = new List<Actividad>();

            foreach (Actividad a in Actividades)
            {
                if (a.Lugar.Nombre == nombreLugar)
                    ret.Add(a);
            }

            return ret;
        }



        public List<Actividad> ActividadesEnFecha(DateTime fechaInicio, DateTime fechaFinal, int idCategoria)
        {
            List<Actividad> ret = new List<Actividad>();

            foreach (Actividad actividad in Actividades)
            {
                if (actividad.Categoria.Id == idCategoria && actividad.FechaHora >= fechaInicio && actividad.FechaHora <= fechaFinal)
                    ret.Add(actividad);
            }

            return ret;
        }


        public List<Compra> ComprasMayorValor()
        {
            List<Compra> ret = new List<Compra>();

            double mayorValor = 0;

            foreach (Compra c in Compras)
            {
                if (c.CalcularPrecioFinal() > mayorValor)
                    mayorValor = c.CalcularPrecioFinal();
            }

            foreach (Compra c in Compras)
            {
                if (c.CalcularPrecioFinal() >= mayorValor)
                    ret.Add(c);
            }

            return ret;
        }


        /* --------------------- FIN OBLIGATORIO 2 --------------------- */



        /* Recibe el string "n" (nombre de la categoria) y el string "d" (descripcion de la categoria)
         Crea una nueva categoria con el nombre y la descripcion dados
        Devuelve la categoria creada*/
        public Categoria CargarCategoria(string n, string d)
        {
            Categoria c = null;
            if (n != "" && d != "")
            {
                c = new Categoria(n, d);

                Categorias.Add(c);
            }
            return c;
        }

        /* Recibe el string "n" (nombre), la categoria "c", la fecha "f", el lugar "l", la edad minima "e", el precio "p" y los me gusta "m".
         Crea una nueva actividad compuesta con los datos de arriba.
        Devuelve la actividad creada*/
        public Actividad CargarActividad(string n, Categoria c, DateTime f, Lugar l, EdadMinima e, double p, int m)
        {
            Actividad a = null;
            if (n != "" && m > 0)
            {
                a = new Actividad(n, c, f, l, e, p, m);
                Actividades.Add(a);
            }
            return a;
        }

        /* Recibe el string "n" (nombre), el string "a" (apellido), el string "e"(email) y la fecha "f".
        Crea un nuevo usuario compuesto con los datos de arriba.
        Devuelve el usuario creado*/
        public Usuario CargarUsuario(string n, string a, string e, string nomUs, string c, DateTime f, TipoUsuario user)
        {
            Usuario u = null;
            if (n != "" && n != "" && e != "" && c != null && f < DateTime.Now)
            {
                u = new Usuario(n, a, e, nomUs, c, f, user);
                Usuarios.Add(u);
            }
            return u;
        }

        /* Recibe el string "n" (nombre), el double "d" (dimension), el bool "a" (accesible) y el double "m" (mantenimiento).
        Crea un nuevo lugar cerrado compuesto con los datos de arriba.
        Devuelve el lugar creado*/
        public Cerrado CargarLugarCerrado(string n, double d, bool a, double m)
        {
            Cerrado c = null;
            if (n != "" && m > 0)
            {
                c = new Cerrado(n, d, a, m, aforoMaximo);
                Lugares.Add(c);
            }
            return c;
        }

        /* Recibe el string "n" (nombre), el double "d" (dimension).
        Crea un nuevo lugar abierto compuesto con los datos de arriba.
        Devuelve el lugar creado*/
        public Abierto CargarLugarAbierto(string n, double d)
        {
            Abierto a = null;
            if (n != "")
            {
                a = new Abierto(n, d, precioButaca);
                Lugares.Add(a);
            }
            return a;
        }

        /* Recibe la actividad "a", el int "ca" (cantidad de entradas), el usuario "u", la fecha "f", el double "p" (precio).
         Crea una nueva compra compuesta con los datos de arriba.
        Devuelve la compra creada*/
        public Compra CargarCompra(Actividad a, int ca, Usuario u, DateTime f, double p)
        {
            Compra co = null;
            if (ca > 0)
            {
                co = new Compra(a, ca, u, f, p);
                Compras.Add(co);
            }
            return co;
        }

        /* Recibe la compra a cancelar
        Le asigna a la compra el estado de cancelada
        No devuelve*/
        public void CancelarCompra(Compra compra)
        {
            compra.Activa = false;
        }

        /*No recibe
         Lista todas las actividades
        No devuelve*/
        public void ListarActividades()
        {
            foreach (Actividad actividad in Actividades)
            {
                Console.WriteLine(actividad.ToString());
            }
        }

        /* Recibe el int "valorNuevo" (nuevo aforo)
         si el valor es valido (> 0) lo asigna como nuevo aforo maximo
        Devuelve true si cambio de aforo, false en otro caso*/
        public bool CambiarAforo(int valorNuevo)
        {
            bool aforoCambiado = false;

            if (valorNuevo > 0)
            {
                Cerrado.Aforo = valorNuevo;
                aforoMaximo = valorNuevo;
                aforoCambiado = true;
            }

            return aforoCambiado;
        }

        /* Recibe el int "valorNuevo" (nuevo precio por butaca)
         si el valor es valido (> 0) lo asigna como nuevo precio
        Devuelve true si cambio de precio, false en otro caso*/
        public bool CambiarPrecioButaca(int valorNuevo)
        {
            bool cambiar = false;
            if (valorNuevo > 0)
            {
                Abierto.PrecioPorButaca = valorNuevo;
                precioButaca = valorNuevo;

                cambiar = true;
            }
            return cambiar;
        }

        /*No recibe
         Lista todas las actividades que sean aptas para todo publico
        No devuelve*/
        public void AptosParaTodos()
        {
            foreach (Actividad actividad in Actividades)
            {
                if (actividad.EdadMinima == EdadMinima.P)
                {
                    Console.WriteLine(actividad.ToString());
                }
            }
        }

        /*No recibe
         Lista todas las categorias
        No devuelve*/
        public void ListarCategorias()
        {
            foreach (Categoria cat in Categorias)
                Console.WriteLine(cat.Id + " - " + cat.Nombre);
        }

        /* Recibe el int "fechaInicio", el int "fechaFinal" (junto al anterior forman un periodo valido) y un int "idCategoria"
         Recorre todas las actividades, e imprime todas las que cumplan el periodo de tiempo y sean de la categoria
        No devuelve*/
        public void ActividadesEnFecha(int fechaInicio, int fechaFinal, int idCategoria)
        {
            bool encontro = false;

            foreach (Actividad actividad in Actividades)
            {
                if (actividad.Categoria.Id == idCategoria && actividad.FechaHora.Month >= fechaInicio && actividad.FechaHora.Month <= fechaFinal)
                {
                    Console.WriteLine(actividad.ToString());
                    encontro = true;
                }
            }

            if (!encontro)
                Console.WriteLine("No se encontraron actividades para esa categoria en esas fechas");

        }


        public void precarga()
        {
            Categoria c1 = CargarCategoria("Cine", "Peliculas");
            Categoria c2 = CargarCategoria("Teatro", "Obras, comedia");
            Categoria c3 = CargarCategoria("Concierto", "Musica");
            Categoria c4 = CargarCategoria("Feria gastronomica", "Comida");

            Abierto a1 = CargarLugarAbierto("Parque Rodo", 100);
            Abierto a2 = CargarLugarAbierto("Parque Rivera", 500);
            Abierto a3 = CargarLugarAbierto("Plaza Virgilio", 300);
            Cerrado ce1 = CargarLugarCerrado("Movie Portones", 20, true, 2000);
            Cerrado ce2 = CargarLugarCerrado("Sala Zitarrosa", 40, true, 3000);
            Cerrado ce3 = CargarLugarCerrado("Estadio Centenario", 400, true, 30000);

            Actividad ac1 = CargarActividad("Concierto Quinteto de Nos", c3, new DateTime(2021, 12, 25, 16, 0, 0), a3, EdadMinima.C13, 500, 10000);
            Actividad ac2 = CargarActividad("Feria de comidas Octubre 2021", c4, new DateTime(2021, 10, 10, 20, 30, 0), a2, EdadMinima.P, 200, 500);
            Actividad ac3 = CargarActividad("Concierto Te Va A Gustar", c3, new DateTime(2022, 4, 15, 12, 0, 0), a3, EdadMinima.P, 500, 10000);
            Actividad ac4 = CargarActividad("Concierto 1 Tiro", c3, new DateTime(2022, 6, 2, 19, 0, 0), a2, EdadMinima.C13, 500, 1000);
            Actividad ac5 = CargarActividad("Feria de comidas diciembre 2021", c4, new DateTime(2021, 12, 8, 12, 0, 0), a1, EdadMinima.P, 500, 1000);
            Actividad ac6 = CargarActividad("Facil de matar", c1, new DateTime(2022, 2, 18, 16, 0, 0), ce1, EdadMinima.C16, 200, 1500);
            Actividad ac7 = CargarActividad("Shrek 5", c1, new DateTime(2022, 2, 24, 16, 0, 0), ce1, EdadMinima.P, 200, 100000);
            Actividad ac8 = CargarActividad("Leandro Ureta: 70 kilos de Stand Up", c2, new DateTime(2022, 1, 16, 16, 0, 0), ce2, EdadMinima.C18, 250, 1000);
            Actividad ac9 = CargarActividad("Peor es trabajar", c2, new DateTime(2022, 3, 26, 16, 0, 0), ce2, EdadMinima.C13, 250, 1000);
            Actividad ac10 = CargarActividad("Rapidos y Furiosos 27: Familia", c1, new DateTime(2021, 11, 15, 16, 0, 0), ce1, EdadMinima.P, 200, 1000);


            Usuario u1 = CargarUsuario("Rafael", "Gonzalez", "rafa@gmail.com", "rafita", "1234Rafael", new DateTime(2000, 10, 12), TipoUsuario.operador);
            Usuario u2 = CargarUsuario("Alberto", "Ramirez", "alberto@gmail.com", "albert", "1234Alberto", new DateTime(1995, 06, 02), TipoUsuario.operador);
            Usuario u3 = CargarUsuario("Maria", "Perez", "maria@gmail.com", "maria", "1234Maria", new DateTime(1998, 07, 12), TipoUsuario.cliente);
            Usuario u4 = CargarUsuario("Roberto", "Rodriguez", "roberto@gmail.com", "roberto", "1234Roberto", new DateTime(1998, 07, 12), TipoUsuario.cliente);
            Usuario u5 = CargarUsuario("Marta", "Umpierrez", "marta@gmail.com", "marta", "1234Marta", new DateTime(1998, 07, 12), TipoUsuario.cliente);

            Compra compra1 = CargarCompra(ac7, 2, u3, new DateTime(2019, 03, 19, 10, 18, 0), ac7.PrecioFinal());
            Compra compra2 = CargarCompra(ac10, 21, u3, new DateTime(2021, 10, 12, 20, 30, 0), ac10.PrecioFinal());
            Compra compra3 = CargarCompra(ac1, 1, u3, new DateTime(2023, 05, 11, 18, 45, 0), ac1.PrecioFinal());
            Compra compra4 = CargarCompra(ac2, 4, u3, new DateTime(2021, 12, 24, 00, 00, 0), ac2.PrecioFinal());
        }


    }
}
