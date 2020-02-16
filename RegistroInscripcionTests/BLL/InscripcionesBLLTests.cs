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
            Inscripciones inscripciones = new Inscripciones();
            bool paso;
            inscripciones.InscripcionId = 0;
            inscripciones.Fecha = DateTime.Now;
            inscripciones.Comentario = "KLK";
            inscripciones.EstudianteID = 1;
            inscripciones.Monto = 10000;
            inscripciones.Balance = 5000;

            paso = InscripcionesBLL.Guardar(inscripciones);
            EstudiantesBLL.ActualizarBalance(inscripciones.EstudianteID, inscripciones.Balance);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Inscripciones inscripciones = new Inscripciones();
            bool paso;
            inscripciones.InscripcionId = 18;
            inscripciones.Fecha = DateTime.Now;
            inscripciones.EstudianteID = 1;
            inscripciones.Comentario = "KLK";
            inscripciones.Monto = 10000;
            inscripciones.Balance = 6000;

            paso = InscripcionesBLL.Modificar(inscripciones);
            EstudiantesBLL.ActualizarBalance(inscripciones.EstudianteID, inscripciones.Balance);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Inscripciones inscripciones = new Inscripciones();

            inscripciones.InscripcionId = 15;
            inscripciones = InscripcionesBLL.Buscar(inscripciones.InscripcionId);
            Assert.IsNotNull(inscripciones);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            Inscripciones inscripcion = new Inscripciones();
            inscripcion.InscripcionId = 18;
            inscripcion.EstudianteID = 1;
            inscripcion.Fecha = DateTime.Now;
            inscripcion.Monto = 100000;
            inscripcion.Balance = 6000;
            EstudiantesBLL.ActualizarBalance(inscripcion.EstudianteID,(0*inscripcion.Balance));
            paso = InscripcionesBLL.Eliminar(inscripcion.InscripcionId);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }
    }
}