using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entidades;

namespace Datos
{
    public class DEstatus
    {
        private PruebasTichEntities db = new PruebasTichEntities();

        public List<EstatusAlumnos> consultarEstatus()
        {
            var estatus = db.EstatusAlumnos;
            return estatus.ToList();
        }

    }
}
