using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api
{
    public class Chuck
    {
        //public string chuck_id;
        public int chuckID { get; set; } // musi być chyba int żeby bd działał
        public string value;

        /*
        public Chuck (string id = "", string j = "")
        {
            chuck_id = id;
            value = j;
        }
        */

        public override string ToString()
        {
            return "Chuck's joke: " + value;
        }
    }
}
