using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegistroInscripcion.BLL;
using System;
using System.Collections.Generic;
using System.Text;
using RegistroInscripcion.Entidades;

namespace RegistroInscripcion.BLL.Tests
{
    [TestClass()]
    public class InscripcionesBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Estudiantes estudiantes = new Estudiantes();
            Inscripciones inscripciones = new Inscripciones();
            bool paso;

            inscripciones.InscripcionId = 0;
            inscripciones.Fecha = DateTime.Now;
            inscripciones.EstudianteID = 10;
            inscripciones.Comentario = "Primera inscripcion";
            inscripciones.Monto = 5000;
            inscripciones.Balance = 5000;
            paso = InscripcionesBLL.Guardar(inscripciones);
            estudiantes = EstudiantesBLL.Buscar(inscripciones.EstudianteID);

            decimal balanceEstudiante = estudiantes.Balance;
            decimal nuevoBalance = (balanceEstudiante + inscripciones.Balance);
            EstudiantesBLL.ActualizarBalance(inscripciones.EstudianteID, nuevoBalance);

            if (estudiantes.Balance == balanceEstudiante)
            {
                Assert.AreEqual(paso, true);
            }
            else
            {
                paso = false;
            }
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Estudiantes estudiantes = new Estudiantes();
            Inscripciones inscripciones = new Inscripciones();
            bool paso;

            inscripciones.InscripcionId = 31;
            inscripciones.Fecha = DateTime.Now;
            inscripciones.EstudianteID = 10;
            inscripciones.Comentario = "Modificando la inscripcion";
            inscripciones.Monto = 15000;
            inscripciones.Balance = 15000;
            

            if(InscripcionesBLL.Modificar(inscripciones))
            {
                paso = EstudiantesBLL.ActualizarBalance(inscripciones.EstudianteID, inscripciones.Balance);
                Assert.AreEqual(paso, true);

            }
            else
            {
                paso = false;
            }
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            decimal balanceInscripcion;
            decimal balanceEstudiante;

            Inscripciones inscripcion = new Inscripciones();
            Estudiantes estudiantes = new Estudiantes();

            inscripcion.InscripcionId = 32;
            inscripcion.EstudianteID = 10;

            inscripcion = InscripcionesBLL.Buscar(inscripcion.InscripcionId);
            estudiantes = EstudiantesBLL.Buscar(inscripcion.EstudianteID);
            balanceEstudiante = estudiantes.Balance;
            balanceInscripcion = inscripcion.Balance;
            EstudiantesBLL.ActualizarBalance(inscripcion.EstudianteID, (balanceEstudiante - balanceInscripcion));

            if (InscripcionesBLL.Eliminar(inscripcion.InscripcionId))
            {
                paso = true;
                Assert.AreEqual(paso, true);
            }
           else
            {
                paso = false;
            }   
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }
    }
}