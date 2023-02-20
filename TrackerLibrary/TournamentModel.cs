using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TournamentModel
    {
        /// <summary>
        /// Indicates name chosen for particular tournament, i.e women's ping pong
        /// </summary>
        public string TournamentName { get; set; }
       /// <summary>
       /// Indicates the entry fee in decimal form
       /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// Indicates a list of teams / players entered into tournament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
       /// <summary>
       /// Indicates a list of prizes or the prizepool for particular tournament
       /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
       /// <summary>
       /// Indicates number of rounds within the tournament
       /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
