using BL.Interface;
using DL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace BL
{
    public class UsuariosBL : IGenericBL<tbUsuarios>
    {
        UsuariosDL dlUsuariosInst = new UsuariosDL();
        public bool eliminar(tbUsuarios entity)
        {
            throw new NotImplementedException();
        }

        public tbUsuarios guardar(tbUsuarios entity)
        {
            //reglas de negocio
            //Validar si existe el cliente
            var usuario = obtenerPorID(entity);

            if (usuario != null)
            {
                //error
                throw new EntityExistDBException("Usuarios");

            }

            //guardar dl
            return dlUsuariosInst.guardar(entity);
        }

        public bool modificar(tbUsuarios entity)
        {
            throw new NotImplementedException();
        }

        public tbUsuarios obtenerPorID(tbUsuarios entity)
        {
            return dlUsuariosInst.obtenerPorID(entity);
        }

        public List<tbUsuarios> obtenerTodos()
        {
            return dlUsuariosInst.obtenerTodos();
        }
    }
}
