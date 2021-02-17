using Microsoft.EntityFrameworkCore;
using RegistroPrestamosDetalle.DAL;
using RegistroPrestamosDetalle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroPrestamosDetalle.BLL
{
    public class PersonasBLL
    {
        public static bool Guardar(Personas personas)
        {
            if (!Existe(personas.PersonaId))
                return Insertar(personas);
            else
                return Modificar(personas);
        }

        private static bool Insertar(Personas personas)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.personas.Add(personas);
                paso = db.SaveChanges() > 0;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;

        }


        public static bool Modificar(Personas personas)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Entry(personas).State = EntityState.Modified;
                paso = db.SaveChanges() > 0;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();

            }

            return paso;

        }


        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();


            try
            {
                var eliminar = db.personas.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }


        public static Personas Buscar(int id)
        {

            Contexto db = new Contexto();
            Personas personas = new Personas();

            try
            {

                personas = db.personas.Find(id);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return personas;


        }


        public static bool Existe(int id)
        {
            bool encontrado = false;
            Contexto db = new Contexto();

            try
            {
                encontrado = db.personas.Any(p => p.PersonaId == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return encontrado;

        }

    }
}
