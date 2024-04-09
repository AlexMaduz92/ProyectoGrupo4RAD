using Datos.Modelo;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    internal class Categoriad
    {
        Dcategorial dcategorial;
        public Categoriad()
        {
            dcategorial = new Dcategorial();

        }
        public int Guardar(Categoria categoria)
        {
            if (categoria.CategoriaId == 0)
            {
                return dcategorial.Agregar(categoria);
            }
            else
            {
                return dcategorial.Editar(categoria);
            }
        }

        public int eliminar(int categoria)
        {
            return dcategorial.Eliminar(categoria);
        }
    }
}
