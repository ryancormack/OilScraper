using System;
using OilScraper.Domain.Repository;
using OilScraper.Domain.Service;
using OilScraper.Helpers;

namespace OilScraper
{
    public class Program
    {
        
        

        static void Main(string[] args) {
            Console.WriteLine("Getting RigZone");
            RigZone.GetRigZoneRigs();
            Console.WriteLine("Inserting RigZone");

            


            Console.ReadLine();
        }
    }
}
