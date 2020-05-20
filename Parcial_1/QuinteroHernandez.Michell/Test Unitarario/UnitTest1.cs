using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using QuinteroHernandez;
using QuinteroHernandez.Michell;

namespace Test_Unitarario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(PersonaSinDni))]
        public void PersonaSinDni()
        {
            Alumno a1 = new Alumno("Ricardo", "Herran", 20000000, false, 2500);
            a1.Dni = 0;
            ///Assert.IsNotNull(a1);//Si se crea el alumno, entonces el test es postivo

        }
        [TestMethod]
        public void PersonaDniValido()
        {
            Alumno a1 = new Alumno("Ricardo", "Herran", 2000000, false, 2500);

            Assert.IsNotNull(a1);//Si se crea el alumno, entonces el test es postivo

        }
        [TestMethod]
        public void Crear50Profesores()
        {
            QuinteroHernandez.Michell.frmMenuPrincipal f1 = new QuinteroHernandez.Michell.frmMenuPrincipal();
            f1.CargarDocentesBoton();
            f1.CargarAlumnosBoton();
            Assert.IsTrue(Listas.listaDocentes.Count == 6 && Listas.listaAlumnos.Count == 50);
            

        }
    }
}
