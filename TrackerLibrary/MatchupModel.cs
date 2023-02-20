using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// This is a list of Matchup Entries of the teams in the tournament
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// This should be to determine/define the winner of the tournament
        /// </summary>
        public TeamModel Winner { get; set; }
       /// <summary>
       /// This is to indicate the rounds of the matchups in the tournament.
       /// </summary>
        public int MatchupRound { get; set; }
    }
}
