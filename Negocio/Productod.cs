using Datos.Base_de_Dato;
using Datos.Modelo;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Productod
    {
        public readonly Exaconection _dbContext;

  
        public Productod()
        {
            _dbContext = new Exaconection();
        }

        public void GuardarProducto(Producto produc)
        {
            _dbContext.Productos.Add(produc);
            _dbContext.SaveChanges();
        }

        public void ModificarProducto(Producto produc)
        {
            var pedidoExistente = _dbContext.Productos.Find(produc.ProductoId);
            if (pedidoExistente != null)
            {
                pedidoExistente.ProductoId = produc.ProductoId;
                pedidoExistente.FechaCreacion = produc.FechaCreacion;
                pedidoExistente.UnidadMedidaId= produc.UnidadMedidaId;
                pedidoExistente.CategoriaId= produc.CategoriaId;
                pedidoExistente.PrecioCompra= produc.PrecioCompra;
                pedidoExistente.Estado = produc.Estado;
           
                _dbContext.SaveChanges();
            }
        }


        public void EliminarProducto(int pedidoId)
        {
            var prodc = _dbContext.Productos.Find(pedidoId);
            if (prodc != null)
            {
                _dbContext.Productos.Remove(prodc);
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
        public List<int> ObtenerIdcategoria()
        {
            using (var dbContext = new Exaconection())
            {
                return dbContext.Categorias.Select(c => c.CategoriaId).ToList();
            }
        }
        public List<int> ObtenerIdUnidadMeida()
        {
            using (var dbContext = new Exaconection())
            {
                return dbContext.UnidadMedidas.Select(c => c.UnidadMedidaId).ToList();
            }
        }


        public Producto ObtenerProductoPorId(int producid)
        {
            using (var context = new Exaconection())
            {
                return context.Productos.FirstOrDefault(p => p.ProductoId ==producid );
            }
        }
        public string ObtenerCategoriaClientePorId(int condid)
        {
            return _dbContext.Categorias.FirstOrDefault(c => c.CategoriaId == condid)?.Codigo;
        }
        public string ObtenerUnidadMedidaPorId(int desc)
        {
            return _dbContext.UnidadMedidas.FirstOrDefault(c => c.UnidadMedidaId == desc)?.Codigo;
        }
    }
}
