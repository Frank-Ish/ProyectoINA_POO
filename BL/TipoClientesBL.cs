using BL.Interface;
using DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class TipoClientesBL : IGenericBL<tbTipoClientes>
    {

        TipoClientesDL tipoCliIns = new TipoClientesDL();

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

        public tbTipoClientes obtenerPorID(tbTipoClientes entity)
        {
            throw new NotImplementedException();
        }

        public List<tbTipoClientes> obtenerTodos()
        {
            //No hay reglas de negocio
            //Retorna la lista que devuelve la capa de datos DL
            return tipoCliIns.obtenerTodos();
        }
    }
}
