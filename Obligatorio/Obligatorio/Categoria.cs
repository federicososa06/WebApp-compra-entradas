using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorio
{
   public class Categoria
    {

        protected static int autoIncremental = 1;
        public int Id { get; set; }
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public Categoria(string nom, string des)
        {
            Nombre = nom;
            Descripcion = des;
            Id = autoIncremental;
            autoIncremental++;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre} || Descripcion: {Descripcion}";
        }

    }
}
