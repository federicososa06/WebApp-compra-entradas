using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio
{
	public enum EdadMinima
    {
		P,
		C13,
		C16,
		C18
    }

   public class Actividad
    {
		public int Id { get; set; }

		public string Nombre { get; set; }

		public Categoria Categoria { get; set; }

		public DateTime FechaHora { get; set; }

		public Lugar Lugar { get; set; }

		public EdadMinima EdadMinima { get; set; }

		public double PrecioBase { get; set; }

		public int MeGusta { get; set; }

		public static int idAuto = 1;

		public Actividad(string nom, Categoria cat, DateTime fec, Lugar lug, EdadMinima edad, double pre, int meg)
        {
			Nombre = nom;
			Categoria = cat;
			FechaHora = fec;
			Lugar = lug;
			EdadMinima = edad;
			PrecioBase = pre;
			MeGusta = meg;

			Id = idAuto;
			idAuto++;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre} || {Categoria.ToString()} || Fecha y hora: {FechaHora} || Lugar: {Lugar.ToString()} || Edad minima: {EdadMinima} || Precio base: {PrecioBase} || Me gusta: {MeGusta}";
        }

		public double PrecioFinal()
		{
			return Lugar.PrecioLugar(PrecioBase);
		}

	}
}
