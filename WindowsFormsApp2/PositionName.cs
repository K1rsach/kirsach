using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class PositionName
    {
        String PositionID;
        String Name;

        public void Set(String PositionID, String Name)
        {
            this.PositionID = PositionID;
            this.Name = Name;
        }
    }
}

