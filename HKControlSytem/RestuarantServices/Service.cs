using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HKControlSytem.RestuarantServices
{
    internal class Service
    {
        protected int ServiceNumber;

        public int NumberofGuests;

        public string ServiceType;

        public int TimeLimit;

        public bool CurrentStatus;

        // Constructor
        public Service (int serviceNumber, string serviceType, int timeLimit, bool currentStatus)
        {
            this.ServiceNumber = serviceNumber;
            this.ServiceType = serviceType;
            this.TimeLimit = timeLimit;
            this.CurrentStatus = currentStatus;
        }


    }
}
