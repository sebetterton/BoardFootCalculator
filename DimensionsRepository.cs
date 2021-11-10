using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardFootCalculator
{
    class DimensionsRepository
    {
        public List<Dimensions> _dimensions;
        public DimensionsRepository()
        {
            _dimensions.Add(new Dimensions { Id = 0, width = 4, length = 12, thickness = 1, size = "small narrow shelf" });
            _dimensions.Add(new Dimensions {Id = 1, width = 6, length = 20, thickness = 1, size = "medium narrow shelf" });
            _dimensions.Add(new Dimensions {Id = 2, width = 6, length = 20, thickness = 1, size = "medium narrow shelf" });
            _dimensions.Add(new Dimensions { width = 6, length = 36, thickness = 1, size = "long narrow shelf" });
            _dimensions.Add(new Dimensions { width = 13, length = 36, thickness = 1, size = "single book shelf"  });
            _dimensions.Add(new Dimensions { width = 11, length = 36, thickness = 1, size = "stair tread" });
            _dimensions.Add(new Dimensions { width = 18 , length = 36, thickness = 1.5, size = "small coffee table" });
            _dimensions.Add(new Dimensions { width = 24, length = 48, thickness = 1.5, size = "large coffee table" });
            _dimensions.Add(new Dimensions { width = 23, length = 19.5, thickness = 1, size = "side table" });
            _dimensions.Add(new Dimensions { width = 25.5, length = 150, thickness = 1.5, size = "kitchen counter top" });
            _dimensions.Add(new Dimensions { width = 21, length = 48, thickness = 1.5, size = "bathroom counter top" });
            _dimensions.Add(new Dimensions { width = 20, length = 77.5, thickness = 1.5, size = "bar top" });
            _dimensions.Add(new Dimensions { width = 36, length = 36, thickness = 1, size = "kitchen table" });
            _dimensions.Add(new Dimensions { width = 44, length = 84, thickness = 1, size = "dining table" });
            _dimensions.Add(new Dimensions { width = 22, length = 36, thickness = 1, size = "small desk" });
            _dimensions.Add(new Dimensions { width = 24, length = 48, thickness = 1, size = "medium desk" });
            _dimensions.Add(new Dimensions { width = 36, length = 72, thickness = 1, size = "large desk" });
            _dimensions.Add(new Dimensions { width = 17, length = 80, thickness = 1, size = "bench" });
            _dimensions.Add(new Dimensions { width = 16, length = 48, thickness = 1.5, size = "console table" });

        }
    }
}
