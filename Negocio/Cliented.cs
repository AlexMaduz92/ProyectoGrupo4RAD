using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;
using Datos.Modelo;
using System.Data.Entity;
using Datos.Base_de_Dato;

namespace Negocio
{
    public class Cliented
    
    {
        public readonly Exaconection _dbContext;
        Dclientes dclientes;
        public Cliented()
        {
            dclientes= new Dclientes();

        }
        public int Guardar (Cliente cliente)
        {
            if (cliente.ClienteId == 0)
            {
                return dclientes.Agregar(cliente);
            }
            else
            {
                return dclientes.Editar(cliente);
            }
        }

        public int eliminar (int clienteid)
        {
            return dclientes.Eliminar(clienteid);
        }
        public List<int> ObtenerIdCondiconpago()
        {
            using (var dbContext = new Exaconection())
            {
                return dbContext.CondicionPagos.Select(c => c.CondicionPagoId).ToList();
            }
        }
        public List<int> ObtenerIdDescuento()
        {
            using (var dbContext = new Exaconection())
            {
                return dbContext.GrupoDescuentos.Select(c => c.GrupoDescuentoId).ToList();
            }
        }
        public string ObtenerCondicionPorId(int condid)
        {
            return _dbContext.CondicionPagos.FirstOrDefault(c => c.CondicionPagoId == condid)?.Descripcion;
        }
        public string ObtenerDescuentoPorId(int desc)
        {
            return _dbContext.GrupoDescuentos.FirstOrDefault(c => c.GrupoDescuentoId == desc)?.Descripcion;
        }





    }
}
