using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFive.DepencyInjection
{
    public static class ClientCodeInjector
    {
        public static void UseInjectors()
        {
            EmployeeBL employeeBL = new EmployeeBL(new EmployeeDAL());
            List<Employee> listOfEmployee = employeeBL.GetEmployee();

            foreach(Employee employee in listOfEmployee)
            {
                Console.WriteLine($"ID={employee.ID}, Name ={employee.Name},Department={employee.Department}");
            }

        }
    }
}
