using DevelopmentChallenge.Data.Enums;

namespace DevelopmentChallenge.Data.Classes.Shapes
{
    public class Trapeze : GeometicShape
    {
        private readonly decimal _top;
        private readonly decimal _base;
        private readonly decimal _height;
        private readonly decimal _side1;
        private readonly decimal _side2;
        public Trapeze(decimal top, decimal @base, decimal height,decimal side1, decimal side2)
        {
            _top = top;
            _base = @base;
            _height = height;
            _side1 = side1;
            _side2 = side2;
        }

        public override ShapeEnum Shape => ShapeEnum.Trapeze;
        public override decimal getArea() => ((_base + _top) * _height) / 2;
        public override decimal getPerimeter() => _base + _top + _side1 + _side2;
    }
}
