using System;

/*
→ What is the Open-Closed Principle in C#? ←
Let us understand the above definition in simple words. Here we need to understand two things. 
The first thing is Open for Extension and the second thing is Closed for Modification. 
The Open for Extension means we need to design the software modules/classes/functions in such
a way that the new responsibilities or functionalities should be added easily when new 
requirements come. On the other hand, Closed for Modification means, we should not modify the 
class/module/function until we find some bugs.
*/

/* Reference Site:                                                                               */
/* https://dotnettutorials.net/lesson/open-closed-principle/                                     */
/*                                                                                               */
namespace SolidPrinciples.With.OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Invoice Amount: 10000");

            Invoice FInvoice = new FinalInvoice();
            double FInvoiceAmount = FInvoice.GetInvoiceDiscount(10000);
            Console.WriteLine($"Final Invoive : {FInvoiceAmount}");

            Invoice PInvoice = new ProposedInvoice();
            double PInvoiceAmount = PInvoice.GetInvoiceDiscount(10000);
            Console.WriteLine($"Proposed Invoive : {PInvoiceAmount}");

            Invoice RInvoice = new RecurringInvoice();
            double RInvoiceAmount = RInvoice.GetInvoiceDiscount(10000);
            Console.WriteLine($"Recurring Invoive : {RInvoiceAmount}");
            Console.Read();
        }
    }
}