using BL.Interface;
using DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace BL
{
    public class ClientesBL : IGenericBL<tbClientes>
    {
        ClientesDL dlClientes = new ClientesDL();
        public bool eliminar(tbClientes entity)
        {
            throw new NotImplementedException();
        }

        public tbClientes guardar(tbClientes entity)
        {
            //reglas de negocio
            //Validar si existe el cliente
            var cliente = obtenerPorID(entity);

            if(cliente != null)
            {
                //error
                throw new EntityExistDBException("Clientes");

            } 

            //guardar dl
            return dlClientes.guardar(entity);
        }

        public bool modificar(tbClientes entity)
        {
            throw new NotImplementedException();
        }

        public tbClientes obtenerPorID(tbClientes entity)
        {
            return dlClientes.obtenerPorID(entity);
        }

        public List<tbClientes> obtenerTodos()
        {
            return dlClientes.obtenerTodos();
        }
    }
}
