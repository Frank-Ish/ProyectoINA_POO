﻿using DL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class TipoClientesDL : InterfaceGenericDL<tbTipoClientes>
    {

        
        public bool eliminar(tbTipoClientes entity)
        {
            throw new NotImplementedException();
        }

        public tbTipoClientes guardar(tbTipoClientes entity)
        {
            throw new NotImplementedException();
        }

        public bool modificar(tbTipoClientes entity)
        {
            throw new NotImplementedException();
        }

        public List<tbTipoClientes> obtenerTodos()
        {
            try
            {
                using (var context = new dbProyectoINAEntities())
                {
                    return context.tbTipoClientes.Where(x => x.estado == true).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public tbTipoClientes obtenerPorID(tbTipoClientes entity)
        {
            throw new NotImplementedException();
        }
    }
}
