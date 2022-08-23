using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio
{
   public class Compra
    {
		public int Id { get; set; }

		public Actividad Actividad { get; set; }

		public int CantidadEntradas { get; set; }

		public Usuario Usuario { get; set; }

		public DateTime FechaHora { get; set; }

		public bool Activa { get; set; }

		public double PrecioFinal { get; set; }

		public static int idAuto = 0;

		public Compra(Actividad act, int cant, Usuario usu, DateTime fec, double prec)
        {
			Actividad = act;
			CantidadEntradas = cant;
			Usuario = usu;
			FechaHora = fec;
			PrecioFinal = prec;
			Activa = true;

			idAuto++;
			Id = idAuto;
        }

		public double CalcularPrecioFinal ()
        {
			double ret = this.CantidadEntradas * PrecioFinal;
			return ret;
        }



        public override string ToString()
        {
			string act = "Si";
			if (!Activa)
            {
				act = "No";
            }
            return $"Actividad: {Actividad.ToString()} || Cantidad de entradas: {CantidadEntradas} || Usuario: {Usuario.ToString()} || Fecha: {FechaHora} || Precio final: {PrecioFinal} || Activa: {act}";
        }
    }
}
