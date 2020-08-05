using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConPartial
{

    partial class Employee
    {
        public void Show()
        {
            Console.WriteLine("EmpId: "+eid);
        }
        partial void Display();
    }
}
