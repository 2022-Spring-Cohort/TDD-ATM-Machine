using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMMachine
{
    class Computer
    {
        List<Part> Parts { get; set; } = new List<Part>();
    }

    class Part
    {
        string Name { get; set; }
        double Cost { get; set; }
    }

    // Example Parts
    // new Part(){ Name = "Graphics Card", Cost = 500.0 };
}
