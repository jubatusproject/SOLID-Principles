/*
→ What is the Dependency Inversion Principle in C#? ←
The Dependency Inversion Principle (DIP) states that High-Level Modules/Classes should not depend 
on Low-Level Modules/Classes. Both should depend upon Abstractions. Secondly, Abstractions should 
not depend upon Details. Details should depend upon Abstractions.

The most important point that you need to remember while developing real-time applications is 
always to try to keep the High-level module and Low-level module as loosely coupled as possible.

When a class knows about the design and implementation of another class, it raises the risk that 
if we do any changes to one class will break the other class. So we must keep these high-level 
and low-level modules/classes loosely coupled as much as possible. To do that, we need to make 
both of them dependent on abstractions instead of knowing each other. If this is not clear at the 
moment, then don’t worry, at the end of this article, you will understand this concept very well 
with examples.
*/

/* Reference Site:                                                                               */
/* https://dotnettutorials.net/lesson/dependency-inversion-principle/                            */
/*                                                                                               */

namespace SolidPrinciples.Without.DIP
{
    public class EmployeeDataAccessLogic
    {
        public Employee GetEmployeeDetails(int id)
        {
            //In real time get the employee details from database
            //but here we have hard coded the employee details
            Employee emp = new Employee()
            {
                ID = id,
                Name = "Pranaya",
                Department = "IT",
                Salary = 10000
            };
            return emp;
        }
    }
}