using System;
using System.Collections.Generic;
using System.Text;

namespace Municipality
{
    internal class UtilitiesManager
    {
        
        public int CalcUrgency(ServiceRequest sr)
        {
            int us;
            int pl = sr.priorityLevel;
            int sl = sr.severityLevel;
            

            return us = pl * sl * 2 ;
        }

        public int Impact(ServiceRequest sr, Residant res)
        {
            int mU = res.monthlyUsage;
            int sl = sr.severityLevel;

            return (mU * sl)/10;

        }

        public int Resolution(ServiceRequest sr)
        {
            return sr.estResTime + (sr.severityLevel / 2);
        }

        public void GenerateReport(ServiceRequest sr, Residant res)
        {
            int us = CalcUrgency(sr);
            int ar = Resolution(sr);
            int iS = Impact(sr, res);

            Console.WriteLine("=== Service Report ===");
            Console.WriteLine($"Resident: {res.Name}");
            Console.WriteLine($"Service Type: {sr.requestType}");
            Console.WriteLine($"Urgency Score: {us}");
            Console.WriteLine($"Adjusted Resolution: {ar}");
            Console.WriteLine($"Household Impact Score: {iS}");

        }

        public void FinalReport(List<ServiceRequest> srList, List<Residant> resList)
        {
            Console.WriteLine("=== Final Municipal Summary ===");

            if (srList.Count == 0 || resList.Count == 0)
            {
                Console.WriteLine("No data available.");
                return;
            }

            Console.WriteLine("Highest Priority issue:");

            int highestIndex = 0;
            int highestPriority = srList[0].priorityLevel;

            for (int i = 1; i < srList.Count; i++)
            {
                if (srList[i].priorityLevel > highestPriority)
                {
                    highestPriority = srList[i].priorityLevel;
                    highestIndex = i;
                }
            }

            ServiceRequest topRequest = srList[highestIndex];
            Residant topResident = resList[0]; // assumes matching indexes

            Console.WriteLine($"Resident: {topResident.Name}");
            Console.WriteLine($"Service Type: {topRequest.requestType}");
            Console.WriteLine($"Urgency Score: {CalcUrgency(topRequest)}");
            Console.WriteLine($"Adjusted Resolution: {Resolution(topRequest)}");
            Console.WriteLine($"Household Impact Score: {Impact(topRequest, topResident)}");
        }



    }
}
