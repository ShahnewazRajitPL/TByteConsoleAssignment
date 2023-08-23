using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFour.Structural.Proxy
{
    public class SharedFolderProxy : ISharedFolder
    {
        private  SharedFolder _sharedFolder;
        private Employee _employee;

        public SharedFolderProxy(Employee employee)
        {
            _employee = employee;
        }

        public void PerformRWOperation()
        {
            if(_employee.Role.ToUpper()=="CEO"|| _employee.Role.ToUpper()=="MANAGER")
            {
                _sharedFolder = new SharedFolder();
                Console.WriteLine("It is calling sharedfolder to RW operation");

                _sharedFolder.PerformRWOperation();
            }
            else
            {
                Console.WriteLine("You dont have permission to access to shored folder");
            }
        }
    }
}
