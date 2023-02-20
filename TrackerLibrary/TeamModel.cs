using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TeamModel
    {
        /// <summary>
        /// Indicates List of members in team / single players
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
       /// <summary>
       /// Indicates name of team
       /// </summary>
        public string TeamName { get; set; }
    }
}
