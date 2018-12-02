using System;

namespace HostOpener
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter host:");
            string hosts = Console.ReadLine();
            if (AccessHosts.ModifyHosts(hosts))
            {
                Console.WriteLine("Hosts file modified.");
                Console.ReadLine();
            }
        }
    }
}
