﻿using RegistroInscripcion.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using RegistroInscripcion.Entidades;

namespace RegistroInscripcion.BLL.Tests
{
    [TestClass()]
    public class EstudiantesBLLTests
    {
        [TestMethod()]
        public void ActualizarBalanceTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Estudiantes estudiantes = new Estudiantes();

            estudiantes.EstudianteId = 0;
            estudiantes.Nombre = "Elizabeth Williams";
            estudiantes.Cedula = "888-888-888";
            estudiantes.Telefono = "888-888-888";
            estudiantes.Direccion = "Deep Park";
            estudiantes.FechaNacimiento = DateTime.Now;
            estudiantes.Balance = 0;
            paso = EstudiantesBLL.Guardar(estudiantes);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso;
            Estudiantes estudiantes = new Estudiantes();

            estudiantes.EstudianteId = 3;
            estudiantes.Nombre = "Andy";
            estudiantes.Cedula = "45659595";
            estudiantes.Telefono = "809-999-8787";
            estudiantes.Direccion = "Santiago";
            estudiantes.FechaNacimiento = DateTime.Now;
            estudiantes.Balance = 0;
            paso = EstudiantesBLL.Modificar(estudiantes);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            Estudiantes estudiantes = new Estudiantes();

            estudiantes.EstudianteId = 7;
            paso = EstudiantesBLL.Eliminar(estudiantes.EstudianteId);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }
    }
}