using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowroom_V._2
{
    interface ICar
    {
        int ID
        {
            get;
            set;
        }
        int MaxDistance();
        int CarAge();
    }
}
