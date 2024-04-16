using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_part1
{
    // Class representing a step in the recipe
    public class Step
    {
        public string Description { get; set; }

        // Constructor
        public Step(string description)
        {
            Description = description;
        }
    }
}
