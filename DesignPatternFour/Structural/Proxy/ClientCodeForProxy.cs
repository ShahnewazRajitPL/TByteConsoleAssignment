using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFour.Structural.Proxy
{
    public static class ClientCodeForProxy
    {
        public static void UseProxyPattern()
        {
            Employee emp1 = new Employee("Riyad", "CEO");
            SharedFolderProxy folderProxy1 = new SharedFolderProxy(emp1);

            folderProxy1.PerformRWOperation();

            Console.WriteLine();

            Employee emp2 = new Employee("Riyad", "Labeeb");
            SharedFolderProxy folderProxy2 = new SharedFolderProxy(emp2);

            folderProxy2.PerformRWOperation();
        }

    }
}
