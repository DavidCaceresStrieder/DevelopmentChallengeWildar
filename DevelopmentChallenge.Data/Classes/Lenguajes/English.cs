using DevelopmentChallenge.Data.Enums;
using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Classes.Lenguajes
{
    public class English : Lenguaje
    {
        public override LenguageEnum LenguageEnum => LenguageEnum.Ingles;
        public override string HeaderLabel => "<h1>Shapes report</h1>";
        public override string EmptyHaderLabel => "<h1>Empty list of shapes!</h1>";
        public override string TotalHeaderLabel => "TOTAL:<br/>";
        public override string ShapeLabel => "shapes";
        public override string PerimeterLabel => "Perimeter ";
        public override string AreaLabel => "Area ";

        public override List<ShapeNames> ShapeNames => new List<ShapeNames>()
        {
            new ShapeNames("Square","Squares",ShapeEnum.Square),
            new ShapeNames("Triangle","Triangles",ShapeEnum.EquilateralTriangle),
            new ShapeNames("Circle","Circles",ShapeEnum.Circle),
            new ShapeNames("Trapeze","Trapezoids",ShapeEnum.Trapeze),
        };

        public override string GetLine(GeometricDataResume geometricDataResume)
        {
            if (geometricDataResume == null) return string.Empty;
            return $"{geometricDataResume.Count} {GetShapeName(geometricDataResume)} | Area {geometricDataResume.TotalArea:#.##} | Perimeter {geometricDataResume.TotalPerimeter:#.##} <br/>";
        }
    }
}
