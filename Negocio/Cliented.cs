using Datos;
using Datos.Base_de_Dato;
using Datos.Core;
using Datos.Modelo;
using System.Collections.Generic;
using System.Linq;

namespace Negocio
{
    public class Cliented
    {
        private readonly Exaconection _dbContext;
        private readonly Dclientes _dclientes;

        public Cliented()
        {
            _dbContext = new Exaconection();
            _dclientes = new Dclientes();
        }
        public List<CondiccionPago> ObtenerCondiccionesPago()
        {
            using (var unitOfWork = new UnitOfWork())
            {
                return unitOfWork.Repository<CondiccionPago>().ObtenerTodos().ToList();
            }
        }
        public int Guardar(Cliente cliente)
        {
            if (cliente.ClienteId == 0)
            {
                return _dclientes.Agregar(cliente);
            }
            else
            {
                Modificar(cliente);
                return cliente.ClienteId;
            }
        }

        public int Eliminar(int clienteId)
        {
            return _dclientes.Eliminar(clienteId);
        }

        public void Modificar(Cliente cliente)
        {
            var clienteExistente = _dbContext.Clientes.Find(cliente.ClienteId);
            if (clienteExistente != null)
            {
                clienteExistente.Codigo = cliente.Codigo;
                clienteExistente.Nombres = cliente.Nombres;
                clienteExistente.Apellidos = cliente.Apellidos;
                clienteExistente.Estado = cliente.Estado;
                clienteExistente.FechaCreacion = cliente.FechaCreacion;
                clienteExistente.GrupoDescuentoId = cliente.GrupoDescuentoId;
                clienteExistente.CondicionPagoId = cliente.CondicionPagoId;
                _dbContext.SaveChanges();
            }
        }

        public IEnumerable<CondiccionPago> ObtenerIdCondiconpago()
        {
            using (var dbContext = new Exaconection())
            {
                return dbContext.CondicionPagos.ToList();
            }
        }

        public IEnumerable<GrupoDescuento> ObtenerIdDescuento()
        {
            using (var dbContext = new Exaconection())
            {
                return dbContext.GrupoDescuentos.ToList();
            }
        }


    }
}
