using DevelopmentChallenge.Data.Enums;
using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Classes.Lenguajes
{
    public class Italiano : Lenguaje
    {
        public override LenguageEnum LenguageEnum => LenguageEnum.Italiano;

        public override string HeaderLabel => "<h1>Rapporto sui moduli</h1>";
        public override string EmptyHaderLabel => "<h1>Elenco vuoto di forme!</h1>";
        public override string TotalHeaderLabel => "TOTALE:<br/>";
        public override string PerimeterLabel => "Perimetro ";
        public override string AreaLabel => "La zona ";
        public override string ShapeLabel => "forme";
        public override List<ShapeNames> ShapeNames => new List<ShapeNames>()
        {
            new ShapeNames("Piazza","Piazze",ShapeEnum.Square),
            new ShapeNames("Triangolo","Triangoli",ShapeEnum.EquilateralTriangle),
            new ShapeNames("Cerchio","Cerchi",ShapeEnum.Circle),
            new ShapeNames("Trapezio","Trapezi",ShapeEnum.Trapeze),
        };

        public override string GetLine(GeometricDataResume geometricDataResume)
        {
            if (geometricDataResume == null) return string.Empty;
            return $"{geometricDataResume.Count} {GetShapeName(geometricDataResume)} | La zona  {geometricDataResume.TotalArea:#.##} | Perimetro {geometricDataResume.TotalPerimeter:#.##} <br/>";
        }
    }
}
