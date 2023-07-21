using DevelopmentChallenge.Data.Enums;

namespace DevelopmentChallenge.Data
{
    public abstract class GeometicShape
    {
        public abstract ShapeEnum Shape { get; }
        public abstract decimal getArea();
        public abstract decimal getPerimeter();
    }
}
