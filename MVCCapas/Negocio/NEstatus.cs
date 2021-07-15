using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class NEstatus
    {
        private DEstatus destatus = new DEstatus();

        public List<EstatusAlumnos> consultarEstatus() => destatus.consultarEstatus();

    }
}
