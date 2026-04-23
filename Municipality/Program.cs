using Municipality;
using System;
using System.Xml.Linq;

    class Program
{
    List<Residant> Residants = new List<Residant>();
    List<ServiceRequest> services = new List<ServiceRequest>();
    public void residant(int numberOfResidants)
    {
        string name;
        string add;
        int accnum;
        int montUs;
        for (int i = 1; i <= numberOfResidants; i++)
        {
            Console.WriteLine($"--- Residant {i} ---");
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Address: ");
            add = Console.ReadLine();
            Console.Write("Account Number: ");
            accnum = int.Parse(Console.ReadLine());
            Console.Write("Monthly Utility Usage (kWh or Litres): ");
            montUs = int.Parse(Console.ReadLine());
            Residant res = new Residant(name, add, accnum, montUs);

            Residants.Add(res);
        }

    }

    public void ServiceRequest(int numberOfRequests, int numberOfResidants)
    {
        string rt;
        int pl;
        int sl;
        int ert;
        int whichResident;
        for (int i = 1; i <= numberOfRequests; i++)
        {
            Console.WriteLine($"--- Service Request {i} ---");
            Console.Write($"Select resident by nummber 1 of {numberOfResidants}: ");
            whichResident = int.Parse(Console.ReadLine());
            Console.Write("Request Type (e.g. Water Outage, Burt Pipe): ");
            rt = Console.ReadLine();
            Console.Write("Priority Level (1-5): ");
            pl = int.Parse(Console.ReadLine());
            Console.Write("Severity Level (1-10): ");
            sl = int.Parse(Console.ReadLine());
            Console.Write("Estimated Rsolution Time: ");
            ert = int.Parse(Console.ReadLine());
            ServiceRequest s = new ServiceRequest(rt, pl, sl, ert, Residants[whichResident - 1]);

            services.Add(s);
        }
    }

    static void Main()
    {
        UtilitiesManager util = new UtilitiesManager();

        Console.Write("=== Welcome to Enfuleni Municipality service desk ===" +
            "\nHow many residents do you want to register?: ");
        int numberOfResidants = int.Parse(Console.ReadLine());

        Program n = new Program();
        n.residant(numberOfResidants);

        Console.WriteLine("How many requests do you want to log?");
        int numberOfrequest;
        numberOfrequest = int.Parse(Console.ReadLine());
        n.ServiceRequest(numberOfrequest, numberOfResidants);

        Console.WriteLine();

        for (int i = 0 ; i < n.Residants.Count; i++)
        {
            for (int y = 0; y < n.services.Count; y++)
            util.GenerateReport(n.services[y], n.Residants[i]);
            Console.WriteLine();
        }

        util.FinalReport(n.services, n.Residants);
        Console.WriteLine();
        Console.WriteLine("Thank You for using the Emfuleni Municipality Service Desk");







    }
}