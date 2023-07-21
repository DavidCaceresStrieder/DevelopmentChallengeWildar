using DevelopmentChallenge.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class GeometricDataResume
    {        
        public ShapeEnum shapeEnum { get; set; }
        public int Count { get; set; }
        public decimal TotalArea { get; set; }
        public decimal TotalPerimeter { get; set; }
    }
}
