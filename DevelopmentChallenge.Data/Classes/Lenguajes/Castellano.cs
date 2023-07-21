using DevelopmentChallenge.Data.Enums;
using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Classes.Lenguajes
{

    public class Castellano : Lenguaje
    {
        public override LenguageEnum LenguageEnum => LenguageEnum.Castellano;       
        
        public override string HeaderLabel => "<h1>Reporte de Formas</h1>";
        public override string EmptyHaderLabel => "<h1>Lista vacía de formas!</h1>";
        public override string TotalHeaderLabel => "TOTAL:<br/>";
        public override string PerimeterLabel => "Perimetro ";
        public override string AreaLabel => "Area ";
        public override string ShapeLabel => "formas";
        public override List<ShapeNames> ShapeNames => new List<ShapeNames>()
        {
            new ShapeNames("Cuadrado","Cuadrados",ShapeEnum.Square),
            new ShapeNames("Triángulo","Triángulos",ShapeEnum.EquilateralTriangle),
            new ShapeNames("Circulo","Círculos",ShapeEnum.Circle),
            new ShapeNames("Trapecio","Trapecios",ShapeEnum.Trapeze),
        };

        public override string GetLine(GeometricDataResume geometricDataResume)
        {
            if (geometricDataResume == null) return string.Empty;
            return $"{geometricDataResume.Count} {GetShapeName(geometricDataResume)} | Area {geometricDataResume.TotalArea:#.##} | Perimetro {geometricDataResume.TotalPerimeter:#.##} <br/>";
        }


    }
}
