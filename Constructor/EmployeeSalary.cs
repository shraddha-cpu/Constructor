using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class EmployeeSalary
    {
        int empid;
        double basic_salary, hra, da, pf, pt, total, netpaid;
        string empname;
     
        public EmployeeSalary( double slary, string empname, double pt)
        {
            this.pt=pt;
            this.basic_salary=basic_salary;
            this.empname=empname;
        }
        public void CalculateSalary()
        {
            hra = 0.40 * basic_salary;
            da = 0.20 * basic_salary;
            pf = 0.12 * basic_salary;
            total=basic_salary+hra+da;
            netpaid=total - (pf + pt);
        }
        public string DisplayDetails()
        {
            return $" EmployeeSalary : \n empname is {empname} \n  total is {total} \n net paid is {netpaid}";
        }

    }
}


