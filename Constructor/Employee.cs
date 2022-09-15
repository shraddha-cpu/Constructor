using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
                    //Create a class Employee with empid, empname, basic salary & allowances, initialize value using non parametric & parametric constructor
//Create a method CalculateSalary method & calculate total salary & net paid salary
//Display employee details with net paid salary in Print method


{
    internal class Employee
    {
        int empId,basic_salary,allowance,total_salary;
            string empname;
        int pf = 1300;
        public Employee()
        {
            empId = 1;
            empname="shree";
            basic_salary=95000;
            allowance=20000;
        }
        public Employee(int empId, int basic_salary, int allowance,  string empname)
        {
            this.empId=empId;
            this.basic_salary=basic_salary;
            this.allowance=allowance;
            this.empname=empname;
            
        }
        public void CalculateSalary()
        {
            total_salary=((basic_salary + allowance) - pf);
        }
        public string DisplayDetails()
        {
            return $"Employee id={empId} \n name {empname} \n basic_salary {basic_salary} \n allowance {allowance} \n total_salary {total_salary} \n pf {pf}";
        }
    }
}
