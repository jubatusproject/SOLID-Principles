using System.Net.Mail;
using System;

/*
→ What is the Single Responsibility Principle in C#? ←
The Single Responsibility Principle in C# states that “Each software module or class should have 
only one reason to change“. In other words, we can say that each module or class should have only 
one responsibility to do. 
So we need to design the software in such a way that everything in a class or module should be 
related to a single responsibility. That does not mean your class should contain only one method 
or property, you can have multiple members (methods or properties) as long as they are related to 
a single responsibility or functionality. So, with the help of SRP in C#, the classes become 
smaller and cleaner and thus easier to maintain. Before Proceeding further and understanding the 
Single Responsibility Principle, first we need to understand What is Responsibility.
*/

/* Reference Site:                                                                               */
/* https://dotnettutorials.net/lesson/single-responsibility-principle/                           */
/*                                                                                               */
namespace SolidPrinciples.With.SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice();
            invoice.AddInvoice();
            Console.WriteLine("The email has been sent");
            invoice.DeleteInvoice();
            Console.WriteLine("The invoice has been deleted");
            Console.Read();
        }
    }
}