using System;

namespace hostOpener
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter host:");
            string hosts = Console.ReadLine();
            if (accessHosts.modifyHosts(hosts))
            {
                Console.WriteLine("hosts file modified.");
                Console.ReadLine();
            }
        }
    }
}
