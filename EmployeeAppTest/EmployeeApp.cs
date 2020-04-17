using System;
namespace EmployeeAppTest
{
    public class EmployeeApp
    {
           private int EmpID;
            private string Name;
            private int Age;

         public void Employee(int i, string n, int age)
         {
            EmpID = i;
            Name = n;
            Age = age;
         }

          public void display()
         {
            Console.WriteLine(EmpID +""+Name+""+Age);
         }

}
}

