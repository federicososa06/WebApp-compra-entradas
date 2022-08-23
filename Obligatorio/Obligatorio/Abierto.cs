using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio
{
   public class Abierto: Lugar
    {
        public static double PrecioPorButaca { get; set; }

        public Abierto(string nom, double dim, int p):base(nom, dim)
        {
            Nombre = nom;
            Dimension = dim;
            idAuto++;
            Id = idAuto;

            PrecioPorButaca = p;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre} || Dimension: {Dimension}m2 || Precio por butaca: {PrecioPorButaca}$";
        }


        public override double PrecioLugar(double precioBase)
        {
            double res = precioBase;
            if (Dimension > 1)
            {
                res += res * 0.1;
            }

            return res;
        }

    }
}
