using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio
{
    public abstract class Lugar
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public double Dimension { get; set; }

        public static int idAuto = 0;
        public Lugar(string nom, double dim)
        {
            Nombre = nom;
            Dimension = dim;
        }

        public abstract double PrecioLugar(double precioBase);
    }
}
