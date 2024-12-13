using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        private int idArticulo;
        private string nombreArticulo;
        private string descripcion;
        private Marca marca;
        private Categoria categoria;
        private float precio;

        public int MyProperty { get; set; }
    }
}
