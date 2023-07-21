using DevelopmentChallenge.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;


namespace DevelopmentChallenge.Data.Classes.Lenguajes
{
    public abstract class Lenguaje 
    {

        public abstract LenguageEnum LenguageEnum { get; }

        public abstract string HeaderLabel { get; }
        public abstract string EmptyHaderLabel { get; }
        public abstract string TotalHeaderLabel { get; }
        public abstract string ShapeLabel { get; }
        public abstract string PerimeterLabel { get; }
        public abstract string AreaLabel { get; }

        public abstract List<ShapeNames> ShapeNames { get; } 
        public abstract string GetLine(GeometricDataResume geometricDataResume);

        public string GetShapeName(GeometricDataResume geometricDataResume)
        {
            try
            {
                return this.ShapeNames
                    .Where(x => x.ShapeEnum == geometricDataResume.shapeEnum)
                    .Select(x => geometricDataResume.Count == 1 ? x.SingleNameLabel : x.MultipleNameLabel)
                    .Single();
            }
            catch (ArgumentNullException e)
            {
                throw new Exception("Shape name not added on " + LenguageEnum.ToString() + " lenguage", e);
            }
        }


    }
}
