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
    public class Dclientes
    {
        Repository<Cliente> repository;
        public Dclientes()
        {
            repository = new Repository<Cliente>();
        }
        public int ClienteId { get; set; }
        public string Codigo { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaCreacion { get; set; }

        public GrupoDescuento GrupoDescuento { get; set; }
        public CondiccionPago CondicionPago { get; set; }
  

        public int Agregar(Cliente cliente)
        {
            cliente.FechaCreacion=DateTime.Now; 
            repository.Agregar(cliente);
            return 1;
        }

        public int Editar(Cliente cliente)
        {
            var cliented=repository.Consulta().FirstOrDefault(c=> c.ClienteId==cliente.ClienteId);
            if(cliented != null)
            {
                cliented.FechaCreacion = DateTime.Now;
                cliented.Codigo=cliente.Codigo;
                cliented.Nombres=cliente.Nombres;
                cliented.Apellidos=cliente.Apellidos;
                cliented.Estado=cliente.Estado;
                cliented.GrupoDescuento = cliente.GrupoDescuento;
                cliented.CondicionPago = cliente.CondicionPago;
                repository.Editar(cliented);
                return 1;

            }
            return 0;
        }
        public int Eliminar (int clienteid)
        { 
            var cliented=repository.Consulta().FirstOrDefault(c=>c.ClienteId==clienteid);
            if (cliented != null)
            {
                repository.Eliminar(cliented);
                return 1;
            }
            return 0; 
        }

        public List<Cliente> Todaslascondicionespago()
        {
            return repository.Consulta().Include(c => c.CondicionPagoId).ToList();
        }
    }
}

