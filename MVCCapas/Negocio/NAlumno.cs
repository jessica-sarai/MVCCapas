using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    
    public class NAlumno
    {
        private DAlumnos dalumno = new DAlumnos();
        private DEstados destado = new DEstados();
        private DEstatus destatus = new DEstatus();
        private AlumnosWCF alumnosWCF = new AlumnosWCF();
        public void consultar(Alumnos alumnos) => dalumno.consultar();

        public List<Alumnos> consultaL() => dalumno.consultar();

        public Alumnos consultarUnAlumno1(int id) => alumnosWCF.consultarUno(id);

        public Alumnos consultarUnAlumno(int id) => dalumno.consultarUno(id);
        public void crear(Alumnos alumnos) => dalumno.crear(alumnos);

        public void editar1(Alumnos alumnos) => dalumno.editar(alumnos);
        //public void editar(Alumnos alumnos) => dalumno.editar(alumnos);
        public void eliminar(int id) => dalumno.eliminar(id);
    }
}
