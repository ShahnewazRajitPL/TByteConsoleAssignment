using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFive.DepencyInjection
{
    public class EmployeeDAL : IEmployeeDAL
    {
        public List<Employee> SelectAllEmployess()
        {
            List<Employee> listEmployee = new List<Employee>
            {
                new Employee() {ID=1, Name="Riyad", Department="Project Manager"},
                new Employee(){ID=2, Name ="Poly", Department="Operation"},
                new Employee(){ID=3, Name="Adil", Department="Sofrware"}
            };
            return listEmployee;
        }
    }
}
