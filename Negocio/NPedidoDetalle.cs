using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Datos.Base_de_Dato;
using Datos.Modelo;

namespace Negocio
{
    public class NPedidoDetalle
    {
        private readonly Exaconection _dbContext;

        public NPedidoDetalle()
        {
            _dbContext = new Exaconection();
        }

        public void GuardarPedidoDetalle(PedidoDetalle pedidoDetalle)
        {
            _dbContext.PedidoDetalles.Add(pedidoDetalle);
            _dbContext.SaveChanges();
        }

        public void ModificarPedidoDetalle(PedidoDetalle pedidoDetalle)
        {
            var pedidoDetalleExistente = _dbContext.PedidoDetalles.Find(pedidoDetalle.PedidoDetalleId);
            if (pedidoDetalleExistente != null)
            {
                pedidoDetalleExistente.PedidoId = pedidoDetalle.PedidoId;
                pedidoDetalleExistente.ProductoId = pedidoDetalle.ProductoId;
                pedidoDetalleExistente.Precio = pedidoDetalle.Precio;
                pedidoDetalleExistente.Total = pedidoDetalle.Total;
                pedidoDetalleExistente.Descuento = pedidoDetalle.Descuento;
                pedidoDetalleExistente.FechaCreacion = pedidoDetalle.FechaCreacion;
                _dbContext.SaveChanges();
            }
        }

        public void EliminarPedidoDetalle(int pedidoDetalleId)
        {
            var pedidoDetalle = _dbContext.PedidoDetalles.Find(pedidoDetalleId);
            if (pedidoDetalle != null)
            {
                _dbContext.PedidoDetalles.Remove(pedidoDetalle);
                _dbContext.SaveChanges();
            }
        }

        public List<int> ObtenerIdsPedidos()
        {
            using (var dbContext = new Exaconection())
            {
                return dbContext.Pedidos.Select(p => p.PedidoId).ToList();
            }
        }

        public List<int> ObtenerIdsProductos()
        {
            using (var dbContext = new Exaconection())
            {
                return dbContext.Productos.Select(p => p.ProductoId).ToList();
            }
        }
        public string ObtenerPedidoPorId(int clienteId)
        {
            var pedido = _dbContext.Pedidos.FirstOrDefault(c => c.PedidoId == clienteId);
            if (pedido != null)
            {
                return $"{pedido.ClienteId}";
            }
            return string.Empty;
        }
        public string ObtenerPedidoDescuentoPorId(int clienteId)
        {
            var pedido = _dbContext.Pedidos.FirstOrDefault(c => c.PedidoId == clienteId);
            if (pedido != null)
            {
                return $"{pedido.Descuento}";
            }
            return string.Empty;
        }
        public string ObtenerTotalPorId(int clienteId)
        {
            var pedido = _dbContext.Pedidos.FirstOrDefault(c => c.PedidoId == clienteId);
            if (pedido != null)
            {
                return $"{pedido.Total}";
            }
            return string.Empty;
        }

        public string ObtenerCodigoProductoPorId(int clienteId)
        {
            var producto = _dbContext.Productos.FirstOrDefault(c => c.ProductoId == clienteId);
            if (producto != null)
            {
                return $"{producto.CategoriaId}";
            }
            return string.Empty;
        }
        public string ObtenerCodigoProductoPrecioPorId(int clienteId)
        {
            var producto = _dbContext.Productos.FirstOrDefault(c => c.ProductoId == clienteId);
            if (producto != null)
            {
                return $"{producto.PrecioCompra}";
            }
            return string.Empty;
        }


        public PedidoDetalle ObtenerPedidoDetallePorId(int pedidoDetalleId)
        {
            using (var context = new Exaconection())
            {
                return context.PedidoDetalles.FirstOrDefault(pd => pd.PedidoDetalleId == pedidoDetalleId);
            }
        }
    }
}
