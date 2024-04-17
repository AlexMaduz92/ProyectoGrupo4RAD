using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class DetallePedido
    {
        public readonly Exaconection _dbContext;
        public DetallePedido()
        {
            _dbContext = new Exaconection();
        }

        public void GuardarPedido(DetallePedido DetallePedido)
        {
            _dbContext.Pedidos.Add(DetallePedido);
            _dbContext.SaveChanges();
        }

        public void ModificarPedido(DetallePedido DetallePedido)
        {
            var detallePedidoExistente = _dbContext.DetallePedido.Find(PedidoDetalleId);
            if (detallePedidoExistente != null)
            {
                detallePedidoExistente.PedidoId = DetallePedido.PedidoId;
                detallePedidoExistente.ProductoID = DetallePedido.ProductoId;
                detallePedidoExistente.Precio = DetallePedido.Precio;
                detallePedidoExistente.Total = DetallePedido.Total;
                detallePedidoExistente.Descuento = DetallePedido.Descuento;
                detallePedidoExistente.FechaCreacion = DetallePedido.FechaCreacion;
                _dbContext.SaveChanges();
            }
        }

        public void EliminarDetallePedido(int PedidoDetalleId)
        {
            var detallepedido = _dbContext.DetallePedido.Find(PedidoDetalleId);
            if (detallepedido != null)
            {
                _dbContext.Pedidos.Remove(DetallePedido);
                _dbContext.SaveChanges();
            }
        }

        public List<int> ObtenerIdsProductos()
        {
            using (var dbContext = new Exaconection())
            {
                return dbContext.Productos.Select(c => c.ProductoId).ToList();
            }
        }

        public DetallePedido ObtenerDetallePedidoPorId(int PedidoDetalleId)
        {
            using (var context = new Exaconection())
            {
                return context.DetallePedido.FirstOrDefault(p => p.PedidoDetalleId == PedidoDetalleId);
            }
        }
    }




        public void EliminarDetallePedido(int PedidoDetalleId)
        {
            var detallepedido = _dbContext.DetallePedido.Find(PedidoDetalleId);
            if (detallepedido != null)
            {
                _dbContext.Pedidos.Remove(DetallePedido);
                _dbContext.SaveChanges();
            }
        }

        public List<int> ObtenerIdsProductos()
        {
            using (var dbContext = new Exaconection())
            {
                return dbContext.Productos.Select(c => c.ProductoId).ToList();
            }
        }

        public DetallePedido ObtenerDetallePedidoPorId(int PedidoDetalleId)
        {
            using (var context = new Exaconection())
            {
                return context.DetallePedido.FirstOrDefault(p => p.PedidoDetalleId == PedidoDetalleId);
            }
        }
}

