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
    public class Pedidos
    {
        public readonly Exaconection _dbContext;
        public Pedidos()
        {
            _dbContext = new Exaconection(); 
        }

        public void GuardarPedido(Pedido pedido)
        {
            _dbContext.Pedidos.Add(pedido);
            _dbContext.SaveChanges();
        }

        public void ModificarPedido(Pedido pedido)
        {
            var pedidoExistente = _dbContext.Pedidos.Find(pedido.PedidoId);
            if (pedidoExistente != null)
            {
                pedidoExistente.ClienteId = pedido.ClienteId;
                pedidoExistente.FechaCreacion = pedido.FechaCreacion;
                pedidoExistente.FechaPedido = pedido.FechaPedido;
                pedidoExistente.Estado = pedido.Estado;
                pedidoExistente.Total = pedido.Total;
                pedidoExistente.Subtotal = pedido.Subtotal;
                pedidoExistente.Descuento = pedido.Descuento;
                _dbContext.SaveChanges();
            }
        }


        public void EliminarPedido(int pedidoId)
        {
            var pedido = _dbContext.Pedidos.Find(pedidoId);
            if (pedido != null)
            {
                _dbContext.Pedidos.Remove(pedido);
                _dbContext.SaveChanges();
            }
        }

        public List<int> ObtenerIdsClientes()
        {
            using (var dbContext = new Exaconection())
            {
                return dbContext.Clientes.Select(c => c.ClienteId).ToList();
            }
        }

        public List<int> ObtenerIdsProductos()
        {
            using (var dbContext = new Exaconection())
            {
                return dbContext.Productos.Select(c => c.ProductoId).ToList();
            }
        }

        public string ObtenerNombreClientePorId(int clienteId)
        {
            return _dbContext.Clientes.FirstOrDefault(c => c.ClienteId == clienteId)?.Nombres;
        }

        public Pedido ObtenerPedidoPorId(int pedidoId)
        {
            using (var context = new Exaconection())
            {
                return context.Pedidos.FirstOrDefault(p => p.PedidoId == pedidoId);
            }
        }


    }
}
