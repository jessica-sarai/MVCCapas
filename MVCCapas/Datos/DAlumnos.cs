using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entidades;

namespace Datos
{
    public class DAlumnos
    {
        private PruebasTichEntities db = new PruebasTichEntities();
        public List<Alumnos> consultar()
        {
            var alumnos = db.Alumnos.Include(a =>a.Estados ).Include(a => a.EstatusAlumnos);
            return alumnos.ToList();
        }

        public Alumnos consultarUno(int id)
        {
           Alumnos alumnos = db.Alumnos.Find(id);
            return alumnos;
        }

        public void crear(Alumnos alumnos)
        {
                db.Alumnos.Add(alumnos);
                db.SaveChanges();
        }

        public void editar(Alumnos alumnos)
        {
            db.Entry(alumnos).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void eliminar(int id)
        {
            Alumnos alumnos = db.Alumnos.Find(id);
            db.Alumnos.Remove(alumnos);
            db.SaveChanges();
        }

       

    }
}
