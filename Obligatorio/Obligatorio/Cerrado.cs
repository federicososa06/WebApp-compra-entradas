using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio
{
    public class Cerrado: Lugar
    {
        public static int Aforo { get; set; }

        public bool Accesible { get; set; }

        public double Mantenimiento { get; set; }

        public Cerrado(string nombre, double dim, bool acces,  double mant, int a): base(nombre, dim)
        {
            Nombre = nombre;
            Dimension = dim;
            Accesible = acces;
            Mantenimiento = mant;

            Aforo = a;

            idAuto++;
            Id = idAuto;
        }

        public override string ToString()
        {
            string acces = "No Accesible";
            if (Accesible)
            {
                acces = "Accesible";
            }
            return $"Nombre: {Nombre} || Dimension: {Dimension}m2 || Accesibilidad: {acces} || Mantenimiento: {Mantenimiento}$";
        }


        public override double PrecioLugar(double precioBase)
        {
            double res = precioBase;

            if (Aforo < 50)
            {
                res += res * 0.3;
            }
            else if (Aforo < 70)
            {
                res += res * 0.15;
            }

            return res;
        }

    }
}
