using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Base_de_Dato;

namespace Datos.Core
{
    public class Repository<T> : Irepository<T> where T : class
    {
        public Exaconection dbcontext;

        public Repository()
        {
            this.dbcontext = new Exaconection();
        }
        public void Agregar(T entidad)
        {
            dbcontext.Set<T>().Add(entidad);
            //dbcontext.SaveChanges();
        }

        public void Agregar(IEnumerable<T> entidades)
        {
            throw new NotImplementedException();
        }

        public void Buscar(T entidad)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Consulta()
        {
            return dbcontext.Set<T>().AsQueryable();
        }

        public void Editar(T entidad)
        {
            dbcontext.Set<T>();
            //dbcontext.SaveChanges();
        }

        public void Eliminar(T entidad)
        {
            dbcontext.Set<T>().Remove(entidad);
            //dbcontext.SaveChanges();
        }
    }
}
