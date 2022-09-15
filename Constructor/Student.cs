using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
                //Create a class Student with rollno, name , 3 subjects marks . calculate total marks & percentage using method & display it
{
    internal class Student
    {
        int rollno, sub1, sub2, sub3, marks;
         string name;
         double percentage;
        public Student()
        {
            rollno=1;
            name="shraddha";
            sub1=88;
            sub2=78;
            sub3=99;
        }
        public Student(int rollno,string name,int sub1,int sub2,int sub3)
        {
            this.rollno=rollno;
            this.name=name;
            this.sub1=sub1;
            this.sub2=sub2;
            this.sub3=sub3;
        }
        
        public void Calculateper()
        {
            marks=(sub1+sub2+sub3);
            percentage=(marks/3);  
        }
        public string DisplayDetails()
        {
            return $" Student  : {rollno} \n {name} \n {sub1} \n {sub2} \n {sub3} \n {marks}  \n {percentage}";
        }
    }
}







