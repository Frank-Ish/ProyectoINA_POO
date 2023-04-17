using DL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class ClientesDL : InterfaceGenericDL<tbClientes>
    {
        public bool eliminar(tbClientes entity)
        {
            try
            {
                using (var context = new dbProyectoINAEntities())
                {
                    context.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public tbClientes guardar(tbClientes entity)
        {
            try
            {
                using (var context = new dbProyectoINAEntities())
                {
                    context.tbClientes.Add(entity);
                    context.SaveChanges();
                    return entity;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool modificar(tbClientes entity)
        {
            try
            {
                using (var context = new dbProyectoINAEntities())
                {
                    context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<tbClientes> obtenerDatos()
        {
            try
            {
                using (var context = new dbProyectoINAEntities())
                {
                    
                    return context .tbClientes.Include("tbPersona").ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public tbClientes obtenerPorID(tbClientes entity)
        {
            try
            {
                using (var context = new dbProyectoINAEntities())
                {
                    return context.tbClientes.Where(x => x.cedula == entity.cedula).SingleOrDefault();
                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
