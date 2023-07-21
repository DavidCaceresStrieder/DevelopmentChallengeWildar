using System.Collections.Generic;
using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Classes.Shapes;
using DevelopmentChallenge.Data.Enums;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual(
                "<h1>Lista vacía de formas!</h1>", 
                FormaGeometrica.Imprimir(new List<GeometicShape>(), 1)
            );
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual(
                "<h1>Empty list of shapes!</h1>",
                FormaGeometrica.Imprimir(new List<GeometicShape>(), 2)
           );
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<GeometicShape>() {
                new Square((decimal)5)
            };

            var resumen = FormaGeometrica.Imprimir(cuadrados, (int)LenguageEnum.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<GeometicShape>()
            {
                new Square((decimal)5),
                new Square((decimal)1),
                new Square((decimal)3)
            };

            var resumen = FormaGeometrica.Imprimir(cuadrados, (int)LenguageEnum.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<GeometicShape>()
            {
                new Square((decimal)5),
                new Circle(3),
                new EqTriangle(4),
                new Square((decimal)2),
                new EqTriangle(9),
                new Circle(2.75m),
                new EqTriangle(4.2m)
            };

            var resumen = FormaGeometrica.Imprimir(formas, (int)LenguageEnum.Ingles);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<GeometicShape>()
            {
                new Square((decimal)5),
                new Circle(3),
                new EqTriangle(4),
                new Square((decimal)2),
                new EqTriangle(9),
                new Circle(2.75m),
                new EqTriangle(4.2m)
            };

            var resumen = FormaGeometrica.Imprimir(formas, (int)LenguageEnum.Castellano);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
                resumen);
        }


        [TestCase]
        public void TestResumenListaConMasTrapesoidesEnCastellano()
        {
            var formas = new List<GeometicShape>()
            {
                new Square((decimal)5),
                new Circle(3),
                new EqTriangle(4),
                new Square((decimal)2),
                new EqTriangle(9),
                new Circle(2.75m),
                new EqTriangle(4.2m),
                new Trapeze(2,3,4,6,6),
                new Trapeze(2,4,4,6,6),
                new Trapeze(2,5,4,8,8),
                new Trapeze(4,3,4,9,9),
                new Trapeze(6,4,4,9,9),
                new Trapeze(6,2,4,4,4),               
                
            };

            var resumen = FormaGeometrica.Imprimir(formas, (int)LenguageEnum.Castellano);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>6 Trapecios | Area 86 | Perimetro 127 <br/>TOTAL:<br/>13 formas Perimetro 224,66 Area 177,65",
                resumen);
        }


        [TestCase]
        public void TestResumenListaConMasTrapesoidesEnIngles()
        {
            var formas = new List<GeometicShape>()
            {
                new Square((decimal)5),
                new Circle(3),
                new EqTriangle(4),
                new Square((decimal)2),
                new EqTriangle(9),
                new Circle(2.75m),
                new EqTriangle(4.2m),
                new Trapeze(2,3,4,6,6),
                new Trapeze(2,4,4,6,6),
                new Trapeze(2,5,4,8,8),
                new Trapeze(4,3,4,9,9),
                new Trapeze(6,4,4,9,9),
                new Trapeze(6,2,4,4,4),

            };

            var resumen = FormaGeometrica.Imprimir(formas, (int)LenguageEnum.Ingles);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>6 Trapezoids | Area 86 | Perimeter 127 <br/>TOTAL:<br/>13 shapes Perimeter 224,66 Area 177,65",
                resumen);
        }
    }
}
