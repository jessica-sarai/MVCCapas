using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos.ReferenciaWCF;

namespace Datos
{
    class ConvertAlumno
    {
        public static Alumnos convertAAlumnos(DCAlumno alumosModelos)
        {
            Alumnos Oalumnos = new Alumnos()
            {
                id = alumosModelos.id,
                nombre = alumosModelos.nombre,
                primerApellido = alumosModelos.primerApellido,
                segundoApellido = alumosModelos.segundoApellido,
                correo = alumosModelos.correo,
                telefono = alumosModelos.telefono,
                fechaNacimiento = alumosModelos.fechaNacimiento,
                curp = alumosModelos.curp,
                idEstadoOrigen = alumosModelos.idEstadoOrigen,
                idEstatus = alumosModelos.idEstatus,
            };
            return Oalumnos;
        }

        public static DCAlumno convertDCAlumno(Alumnos alumnos)
        {
            DCAlumno dAlumnos = new DCAlumno()
            {
                id = alumnos.id,
                nombre = alumnos.nombre,
                primerApellido = alumnos.primerApellido,
                segundoApellido = alumnos.segundoApellido,
                correo = alumnos.correo,
                telefono = alumnos.telefono,
                fechaNacimiento = alumnos.fechaNacimiento,
                curp = alumnos.curp,
                idEstadoOrigen = alumnos.idEstadoOrigen,
                idEstatus = alumnos.idEstatus
            };
            return dAlumnos;
        }
    }
}
