using System;

namespace Obligatorio
{
   public class Program
    {
        static void Main(string[] args)
        {
            Sistema sis = Sistema.GetInstancia();


            Console.WriteLine("Bienvenido al sistema, digite la opción deseada");
            int opcion = 1;


            while (opcion != 0)
            {
                Console.WriteLine("Seleccionar una opción");

                opcion = ValidarOpcionInical();
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("1 - Listar actividades");
                        sis.ListarActividades();
                        break;

                    case 2:
                        Console.WriteLine("2 - Cambiar valor del aforo máximo");
                        Console.WriteLine("Ingresar el nuevo aforo permitido");

                        int nuevoAforo = ValidarNumeroIngresado();
                        bool aforoNuevo = sis.CambiarPrecioButaca(nuevoAforo);

                        if (aforoNuevo)
                            Console.WriteLine("Se cambió el aforo correctamente");
                        else
                            Console.WriteLine("Debe ingresar un número mayor a 0, intente nuevamente");


                        break;

                    case 3:
                        Console.WriteLine("3 - Listar actividades por fecha");

                        //validar categoria ingresada:
                        bool convertir = false;
                        bool opcionDisponible = false;
                        int catSeleccionada = 0;

                        while (!convertir || !opcionDisponible)
                        {
                            Console.WriteLine("Elegir una categoría");
                            sis.ListarCategorias();
                            string catCampo = Console.ReadLine();
                            convertir = int.TryParse(catCampo, out catSeleccionada);

                            if (catSeleccionada > sis.Categorias.Count || catSeleccionada < 1)
                            {
                                Console.Clear();
                                Console.WriteLine("Ingresar una categoria válida, intente nuevamente");
                            }
                            else
                                opcionDisponible = true;


                            if (!convertir)
                            {
                                Console.Clear();
                                Console.WriteLine("Ingresar un número válido, intente nuevamente");
                            }

                        }

                        //validar fechas ingresadas
                        Console.Clear();
                        string catNombre = sis.Categorias.Find(x => x.Id == catSeleccionada).Nombre;
                        Console.WriteLine($"Buscar actividades para {catNombre}"); //mostrar en consola la categoria elegida

                        bool fechasCorrectas = false;
                        while (!fechasCorrectas)
                        {
                            int fechaInicio = FechaInicio();
                            int fechaFinal = FechaFinal();

                            if (fechaInicio <= fechaFinal)
                            {
                                sis.ActividadesEnFecha(fechaInicio, fechaInicio, catSeleccionada);
                                fechasCorrectas = true;
                            }
                            else
                                Console.WriteLine("El mes de inicio no puede ser mayor al mes final");
                        }

                        break;

                    case 4:
                        Console.WriteLine("4 - Listar espectáculos aptos para todo público");
                        sis.AptosParaTodos();
                        break;

                    case 5:
                        Console.WriteLine("5 - Cambiar precio de las butacas en lugares abiertos");
                        Console.WriteLine("Ingresar el precio por butaca");

                        int nuevoPrecio = ValidarNumeroIngresado();
                        bool precioNuevo = sis.CambiarAforo(nuevoPrecio);

                        if (precioNuevo)
                            Console.WriteLine("Se cambió el precio correctamente");
                        else
                            Console.WriteLine("Debe ingresar un número mayor a 0, intente nuevamente");


                        break;

                    case 0:
                        Console.WriteLine("Saliendo");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("El número no es correcto, intente nuevamente");
                        break;


                }

            }

        }



        // pedir que ingrese las fechas para mostrar las actividades
        public static int FechaInicio()
        {
            int fechaInicio = 0;

            Console.WriteLine("Ingresar mes de inicio (por defecto: mes 1)");
            string fechaInicioCampo = Console.ReadLine();
            bool fechaInicioCorrecta = int.TryParse(fechaInicioCampo, out fechaInicio);

            if (fechaInicioCorrecta && fechaInicio <= 12 && fechaInicio >= 1)
                return fechaInicio;

            return 1; // si no ingresa un dato correcto se devuelve el mes 1

        }

        public static int FechaFinal()
        {
            int fechaFinal = 0;

            Console.WriteLine("Ingresar mes final (por defecto: mes 12)");
            string fechaFinalCampo = Console.ReadLine();
            bool fechaFinalCorrecta = int.TryParse(fechaFinalCampo, out fechaFinal);

            if (fechaFinalCorrecta && fechaFinal <= 12 && fechaFinal >= 1)
                return fechaFinal;

            return 12; //si no ingresa un dato correcto se devuelve el mes 12
        }


        //validar que el valor ingresado sea un numero
        public static int ValidarNumeroIngresado()
        {
            bool esNumero = false;
            int numero = 1;

            while (!esNumero)
            {
                string campo = Console.ReadLine();
                esNumero = int.TryParse(campo, out numero);

                if (!esNumero)
                {
                    Console.Clear();
                    Console.WriteLine("Debe ingresar un número correcto, intente nuevamente");
                }

            }

            return numero;
        }



        // mostrar opciones
        public static void MostrarMenu()
        {
            Console.WriteLine("1 - Listar actividades");
            Console.WriteLine("2 - Cambiar valor del aforo máximo");
            Console.WriteLine("3 - Listar actividades por fecha");
            Console.WriteLine("4 - Listar espectáculos aptos para todo público");
            Console.WriteLine("5 - Cambiar precio de las butacas en lugares abiertos");
            Console.WriteLine("0 - Salir");
        }


        // pedir un valor y validar que sea correcto
        public static int ValidarOpcionInical()
        {
            int valor = 0;
            bool convertir = false;

            while (!convertir)
            {
                MostrarMenu();
                string numero = Console.ReadLine();
                convertir = int.TryParse(numero, out valor);

                if (!convertir)
                {
                    Console.Clear();
                    Console.WriteLine("Error al seleccionar una opcion, intente de nuevo");
                }

            }

            return valor;
        }
    }
}
