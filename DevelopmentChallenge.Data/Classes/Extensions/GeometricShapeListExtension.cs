using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes.Extensions
{
    public static class GeometricShapeListExtension
    {
        public static List<GeometricDataResume> getAllData(this List<GeometicShape> data) 
        {
            return data
                .GroupBy(x => x.Shape)
                .Select(x => new GeometricDataResume
                {
                    shapeEnum = x.Key,
                    Count = x.Count(),
                    TotalArea = x.Sum(y => y.getArea()),
                    TotalPerimeter = x.Sum(y => y.getPerimeter()),
                }).ToList();
        }
    }
}
