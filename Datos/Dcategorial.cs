using Datos.Core;
using Datos.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Dcategorial
    {
        Repository<Categoria> repository;
        public int CategoriaId { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public Dcategorial()
        {
            repository = new Repository<Categoria>();
        }
        public int Agregar(Categoria cate)
        {
            cate.FechaCreacion = DateTime.Now;
            repository.Agregar(cate);
            return 1;
        }

        public int Editar(Categoria cate)
        {
            var categ = repository.Consulta().FirstOrDefault(c => c.CategoriaId == cate.CategoriaId);
            if (categ != null)
            {
                categ.FechaCreacion = DateTime.Now;
                categ.Codigo = cate.Codigo;
                categ.Descripcion = cate.Descripcion;   
                categ.Estado = cate.Estado;
                repository.Editar(categ);
                return 1;

            }
            return 0;
        }
        public int Eliminar(int cate)
        {
            var categ = repository.Consulta().FirstOrDefault(c => c.CategoriaId == cate);
            if (categ != null)
            {
                repository.Eliminar(categ);
                return 1;
            }
            return 0;
        }

        public List<Categoria> TodasLascategorias()
        {
            return repository.Consulta().Include(c => c.CategoriaId).ToList();
        }
    }
}
