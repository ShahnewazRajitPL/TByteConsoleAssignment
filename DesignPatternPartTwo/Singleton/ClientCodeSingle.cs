using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPartTwo.Singleton
{
    public static class ClientCodeSingle
    {
        public static void UseSingletonWithoutThreadSafeAndLazyLoading()
        {
            SingletonNoThreadSafe fromTeacher = SingletonNoThreadSafe.GetInstance();
            fromTeacher.ShowDetails("From Teacher");
            SingletonNoThreadSafe fromStudents = SingletonNoThreadSafe.GetInstance();
            fromTeacher.ShowDetails("From Students");

        }
        public static void UseMultiThreadProgram()
        {
            Parallel.Invoke(
                ()=>PrintTeacherDetails(),
                ()=> PrintStudentsDetails()
                ); 
        }

        private static void PrintTeacherDetails()
        {
            SingletonNoThreadSafe fromTeacher = SingletonNoThreadSafe.GetInstance();
            fromTeacher.ShowDetails("From Teacher");
        }

        private static void PrintStudentsDetails()
        {

        }
    }
}
