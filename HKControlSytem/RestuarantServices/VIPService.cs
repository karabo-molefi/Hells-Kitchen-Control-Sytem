using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HKControlSytem.RestuarantServices
{
    internal class VIPService: Service
    {
        // Constructor
        public VIPService(int serviceNumber, string serviceType, int timeLimit, bool currentStatus) : base (serviceNumber, serviceType, timeLimit, currentStatus) 
        {
        }
    }
}
