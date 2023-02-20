using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Indicates the placement number, i.e 1st, 2nd, 3rd
        /// </summary>
        public int PlaceNumber { get; set; }
      /// <summary>
      /// Indicates name of placement number, i.e 1st place = champion
      /// </summary>
        public string PlaceName { get; set; }    
      /// <summary>
      /// Indicates the prize amount in decimal format
      /// </summary>
        public decimal PrizeAmount { get; set; }   
       /// <summary>
       /// Indicates the prize money percentage for division amongst winners, i.e 1st place = 50% of winnings
       /// </summary>
        public double PrizePercentage { get; set; }
    }
}
