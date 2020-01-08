using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShowroom_V._2
{
    interface IClient
    {
        int ClientID
        {
            get;
            set;
        }
        int Discount
        {
            get;
            set;
        }
    }
}
