using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class PositionOfPlayer
    {
        String PositionID;
        String PlayerID;

        public void Set(String PositionID, String PlayerID)
        {
            this.PositionID = PositionID;
            this.PlayerID = PlayerID;
        }
    }
}
