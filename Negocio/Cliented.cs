using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;
using Datos.Modelo;

namespace Negocio
{
    public class Cliented
    {
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






    }
}
