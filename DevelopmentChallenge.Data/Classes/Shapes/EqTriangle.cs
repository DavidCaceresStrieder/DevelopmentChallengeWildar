using DevelopmentChallenge.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes.Shapes
{
    public class EqTriangle : GeometicShape
    {
        private readonly decimal _side;
        public EqTriangle(decimal side)
        {
            _side = side;
        }

        public override ShapeEnum Shape => ShapeEnum.EquilateralTriangle;
        public override decimal getArea() => ((decimal)Math.Sqrt(3) / 4) * _side * _side;
        public override decimal getPerimeter() => _side * 3;
    }
}
