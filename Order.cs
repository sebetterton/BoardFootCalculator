using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardFootCalculator
{
    public class Order
    {
        private readonly int inchPerFoot = 12;

        public Order( Wood woodType, Dimensions dimensionsType )
        {
          WoodType = woodType;
          DimensionsType = dimensionsType;
        }

        public Wood WoodType { get; set; }
    
        public Dimensions DimensionsType { get; set; }



        public double Price => WoodType.cost * (DimensionsType.width / inchPerFoot) * (DimensionsType.length / inchPerFoot) * (DimensionsType.thickness / inchPerFoot);
    }
}
