using DL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class UsuariosDL : InterfaceGenericDL<tbUsuarios>
    {
        public bool eliminar(tbUsuarios entity)
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

        public tbUsuarios guardar(tbUsuarios entity)
        {
            try
            {
                using (var context = new dbProyectoINAEntities())
                {
                    context.tbUsuarios.Add(entity);
                    context.SaveChanges();
                    return entity;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool modificar(tbUsuarios entity)
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

        public tbUsuarios obtenerPorID(tbUsuarios entity)
        {
            try
            {
                using (var context = new dbProyectoINAEntities())
                {
                    return context.tbUsuarios.Where(x => x.cedula == entity.cedula).SingleOrDefault();

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<tbUsuarios> obtenerTodos()
        {
            try
            {
                using (var context = new dbProyectoINAEntities())
                {

                    return context.tbUsuarios.Include("tbUsuarios").ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
