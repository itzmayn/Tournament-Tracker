using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PersonModel
    {
        /// <summary>
        /// Indicates the first name of a team member/player
        /// </summary>
        public string FirstName { get; set; }
       /// <summary>
       /// Indicates the last name of a team member/player
       /// </summary>
        public string LastName { get; set; }
       /// <summary>
       /// Indicates the email adress of a team member/player
       /// </summary>
        public string EmailAdress { get; set; }
       /// <summary>
       /// Indicates the cellphone number of a team/member/player
       /// </summary>
        public string CellphoneNumber { get; set; }
    }
}
