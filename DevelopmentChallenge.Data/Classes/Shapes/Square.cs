using DevelopmentChallenge.Data.Enums;

namespace DevelopmentChallenge.Data.Classes.Shapes
{
    public class Square : GeometicShape
    {
        private readonly decimal _side;
        public Square(decimal side)
        {
            this._side = side;
        }

        public override ShapeEnum Shape => ShapeEnum.Square;
        public override decimal getArea() =>  this._side * this._side;
        public override decimal getPerimeter() => this._side * 4;
    }
}
