using DevelopmentChallenge.Data.Enums;
using System;

namespace DevelopmentChallenge.Data.Classes.Shapes
{
    public class Circle : GeometicShape
    {
        private readonly decimal _radius;
        public Circle(decimal radius)
        {
            _radius = radius;
        }

        public override ShapeEnum Shape => ShapeEnum.Circle;
        public override decimal getArea() => (decimal)Math.PI * ((_radius / 2) * (_radius / 2));
        public override decimal getPerimeter() => (decimal)Math.PI * _radius;
    }
}
