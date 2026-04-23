using System;
using System.Collections.Generic;
using System.Text;

namespace Municipality
{
    internal class ServiceRequest
    {
        public string requestType;
        public int priorityLevel;
        public int severityLevel;
        public int estResTime;
        public Residant Residant;

        public ServiceRequest(string rt, int pl, int sl, int ert, Residant res)
        {
            requestType = rt;
            priorityLevel = pl;
            severityLevel = sl;
            estResTime = ert;
            Residant = res;
        }


            

    }
}
