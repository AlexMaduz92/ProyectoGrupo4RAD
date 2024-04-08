using Datos.Base_de_Dato;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Core
{
   public  class UnitOfWork: IunitOfWork
    {
        private readonly Exaconection dbcontext;
        private DbContextTransaction _transaccion;
        public UnitOfWork()
        {
            dbcontext = new Exaconection();
        }

     

        public void ComenzandoTransaccion()
        {
            _transaccion = dbcontext.Database.BeginTransaction();
        }

        public void ConfirmarTransaccion()
        {
            _transaccion.Commit();
            _transaccion.Dispose();
            _transaccion = null;
        }

        public int Guardar()
        {
            int guardar = 0;
            if (_transaccion == null)
            {
                try
                {
                    ComenzandoTransaccion();
                    guardar = dbcontext.SaveChanges();
                    ConfirmarTransaccion();
                    return guardar;
                }
                catch (Exception ex)
                {
                    ReversarTransaccion();
                    throw ex;
                }
            }
            return dbcontext.SaveChanges();
        }

        public Irepository<T> Repository<T>() where T : class
        {
            var repository = new Repository<T>();
            repository.dbcontext = dbcontext;
            return repository;
        }

        public void ReversarTransaccion()
        {
            _transaccion.Rollback();
            _transaccion.Dispose();
            _transaccion = null;
        }

    }
}
