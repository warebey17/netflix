using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Show(inherits from Title)
//-    Contains a list of Episodes
//-    Overrides parent’s Rating to return an aggregated rating of Episode ratings
//-    Overrides ToString() method to return a string of the name of the show and number of episodes
//Episode
//-    Rating field



namespace netflix
{
    class show : title
    {
        public show()
        {

        }
    }
}
