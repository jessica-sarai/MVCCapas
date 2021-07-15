using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entidades;
using Negocio;
using Presentación.Models;

namespace Presentación.Controllers

{
    public class AlumnoController : Controller
    {
        NAlumno Obalumno = new NAlumno();
        NEstado Obestado = new NEstado();
        NEstatus Obestatus = new NEstatus();
        // GET: Alumno
        public ActionResult Index()
        {
            List<Alumnos> lstAlumno = Obalumno.consultaL();
            
            return View(lstAlumno);
        }

        public ActionResult Details(int id)
        {
            Alumnos alumnos = Obalumno.consultarUnAlumno(id);
            return View(alumnos);
        }

        public ActionResult Create()
        {
            ViewBag.idEstadoOrigen = new SelectList(Obestado.consultarEstado(), "id", "nombre");
            ViewBag.idEstatus = new SelectList(Obestatus.consultarEstatus(), "id", "clave");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AlumosModelos alumnosModelo)
        {
            var alumnos1 = ConvertModelo.convertAAlumnos(alumnosModelo);
            

            if (ModelState.IsValid)
            {
                NAlumno Obalumno = new NAlumno();
                Obalumno.crear(alumnos1);
                return RedirectToAction("Index");

             }

            ViewBag.idEstadoOrigen = new SelectList(Obestado.consultarEstado(), "id", "nombre");
            ViewBag.idEstatus = new SelectList(Obestatus.consultarEstatus(), "id", "clave");
            return View(alumnosModelo);
        }

        public ActionResult Edit(int id)
        {
            Alumnos alumnos = Obalumno.consultarUnAlumno(id);
           
            if (alumnos==null)
            {
                return HttpNotFound();
            }
            ViewBag.idEstadoOrigen = new SelectList(Obestado.consultarEstado(), "id", "nombre",alumnos.idEstadoOrigen);
            ViewBag.idEstatus = new SelectList(Obestatus.consultarEstatus(), "id", "clave",alumnos.idEstatus);
            return View(ConvertModelo.convertAAlumnoModelo(alumnos));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AlumosModelos alumnosModelo)
        {
            var alumno = ConvertModelo.convertAAlumnos(alumnosModelo);
            if (ModelState.IsValid)
            {
                Obalumno.editar1(alumno);
                return RedirectToAction("Index");
            }
            ViewBag.idEstadoOrigen = new SelectList(Obestado.consultarEstado(), "id", "nombre", alumno.idEstadoOrigen);
            ViewBag.idEstatus = new SelectList(Obestatus.consultarEstatus(), "id", "clave", alumno.idEstatus);
            return View(alumnosModelo);
        }

        public ActionResult Delete(int id)
        {
            Alumnos alumnos = Obalumno.consultarUnAlumno(id);

            if (alumnos==null)
            {
                return HttpNotFound();
            }

            return View(alumnos);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteCorfimed(int id)
        {
            Obalumno.eliminar(id);
            return RedirectToAction("Index");
        }

        public ActionResult DetalleParcial(int id)
        {
            Alumnos alumnos = Obalumno.consultarUnAlumno1(id);
            return PartialView(alumnos);
        }
    }
}