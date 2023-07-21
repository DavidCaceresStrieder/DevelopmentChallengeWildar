using DevelopmentChallenge.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes.Lenguajes
{
    public class ShapeNames
    {
        public string SingleNameLabel { get; set; }
        public string MultipleNameLabel { get; set; }
        public ShapeEnum ShapeEnum { get; set; }

        public ShapeNames(string singleNameLabel, string multipleNameLabel,ShapeEnum shapeEnum) 
        {
            SingleNameLabel = singleNameLabel;
            MultipleNameLabel = multipleNameLabel;
            ShapeEnum = shapeEnum;
        }
    }
}
