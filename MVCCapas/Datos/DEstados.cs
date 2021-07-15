using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.Entity;

namespace Datos
{
    public class DEstados
    {
        private PruebasTichEntities db = new PruebasTichEntities();
        public List<Estados> consultarEstado()
        {
            var estados = db.Estados;
            return estados.ToList();
        }
    }
}
