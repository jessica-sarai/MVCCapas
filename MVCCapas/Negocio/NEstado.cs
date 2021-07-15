using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocio
{
    public class NEstado
    {
        private DEstados destado = new DEstados();
        public List<Estados> consultarEstado() => destado.consultarEstado();
    }
}
