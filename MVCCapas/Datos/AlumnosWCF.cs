using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.ReferenciaWCF;
using Entidades;

namespace Datos
{
    public class AlumnosWCF
    {
        WCFAlumnoClient wCFAlumnoClient = new WCFAlumnoClient(); //Sericio
        public Alumnos consultarUno(int id)
        {            
           // DCAlumno Obdcalumno = new DCAlumno(); //datos
            wCFAlumnoClient.Open();
            DCAlumno Obcalumno = wCFAlumnoClient.consultarUno(id);
            wCFAlumnoClient.Close();    
            return ConvertAlumno.convertAAlumnos(Obcalumno);
        }

        public void editar(Alumnos alumnos)
        {
            wCFAlumnoClient.Open();
            wCFAlumnoClient.editar(ConvertAlumno.convertDCAlumno(alumnos));
            wCFAlumnoClient.Close();          
        }


    }
}
