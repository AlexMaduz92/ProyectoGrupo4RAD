using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Datos.Core
{
    public interface Irepository<T> where T : class
    {
        void Agregar(T entidad);
        void Agregar(IEnumerable<T> entidades);
        void Editar (T entitad);
        void Eliminar (T entitad);
        IQueryable<T> Consulta ();
        void Buscar (T entitad);
    }
}
