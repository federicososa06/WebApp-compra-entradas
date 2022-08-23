using Obligatorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class TodasLasListas
    {
        public List<Actividad> Actividades { get; set; }

        public List<Usuario> Usuarios { get; set; }

        public List<Compra> Compras { get; set; }

        public List<Lugar> Lugares { get; set; }

        public List<Categoria> Categorias { get; set; }


        public List<Actividad> ActividadesPorLugar { get; set; }
        public List<Actividad> ActividadesPorFecha { get; set; }
        public List<Compra> MayoresCompras { get; set; }
    }
}
