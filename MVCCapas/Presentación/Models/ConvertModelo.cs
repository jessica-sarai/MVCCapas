using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entidades;

namespace Presentación.Models
{
    public class ConvertModelo
    {
        /// <summary>
        /// Método estatico que recibe un Alumno y lo convierte en un objeto AlumnosModelo
        /// </summary>
        /// <param name="alumnos"></param>
        /// <returns></returns>
        public static AlumosModelos convertAAlumnoModelo(Alumnos alumnos)
        {
            AlumosModelos OalumnoModelo = new AlumosModelos()
            {
                id = alumnos.id,
                nombre = alumnos.nombre,
                primerApellido = alumnos.primerApellido,
                segundoApellido = alumnos.segundoApellido,
                correo = alumnos.correo,
                telefono = alumnos.telefono,
                fechaNacimiento = alumnos.fechaNacimiento,
                curp = alumnos.curp
            };
            return OalumnoModelo;
        }

        /// <summary>
        /// Método estatico que recibe un AlumnosModelo y lo convierte en un objeto Alumnos
        /// </summary>
        /// <param name="alumosModelos"></param>
        /// <returns></returns>
        public static Alumnos convertAAlumnos(AlumosModelos alumosModelos)
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
        
    }
}