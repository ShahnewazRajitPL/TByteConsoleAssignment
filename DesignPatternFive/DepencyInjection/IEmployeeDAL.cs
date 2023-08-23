using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternFive.DepencyInjection
{
    public interface IEmployeeDAL
    {
        List<Employee> SelectAllEmployess();
    }
}
