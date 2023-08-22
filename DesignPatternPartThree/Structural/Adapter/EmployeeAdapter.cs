using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPartThree.Structural.Adapter
{
    public class EmployeeAdapter : IAdapter
    {
        ThirdPartyBilingSystem thirdPartyBillingSystem = new ThirdPartyBilingSystem();

        public void AdaptMatixData(string[,] employeesArray)
        {
            string Name = null;
            string Salary = null;

            List<Employee> listEmployees = new List<Employee>();

            for(int i=0;i<employeesArray.GetLength(0);i++)
            {
                for(int j=0;j<employeesArray.GetLength(1);j++)
                {
                    if(j==0)
                    {
                        Name = employeesArray[i, j];

                    }
                    else
                    {
                        Salary = employeesArray[i, j];
                    }
                }
                listEmployees.Add(new Employee(Name!, Salary!));
            }
            Console.WriteLine("Delegate to the thirdPartyBillingSystem for processing the salary\n");

            ThirdPartyBilingSystem.ProcessSalary(listEmployees);

            
        }
    }
}
