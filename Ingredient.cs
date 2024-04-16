using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_part1
{
    /// <summary>
    /// Class representing an ingredient in the recipe
    /// </summary>
    ///------------------------------------------------------------------------------------------------------------///
    public class Ingredient
    {
        //getters and setters for ingredients( name, quantity and unit of measurement)
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }
        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="quantity"></param>
        /// <param name="unit"></param>
        ///------------------------------------------------------------------------------------------------------///
        public Ingredient(string name, double quantity, string unit)
        {
            Name = name;
            Quantity = quantity;
            Unit = unit;
        }
    }
}
//---------------------------------------------------------End of Class-------------------------------------------------------//
