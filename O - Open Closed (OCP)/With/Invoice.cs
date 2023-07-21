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
    public class Invoice
    {
        public virtual double GetInvoiceDiscount(double amount)
        {
            return amount - 10;
        }
    }

    public class FinalInvoice : Invoice
    {
        public override double GetInvoiceDiscount(double amount)
        {
            return base.GetInvoiceDiscount(amount) - 50;
        }
    }
    public class ProposedInvoice : Invoice
    {
        public override double GetInvoiceDiscount(double amount)
        {
            return base.GetInvoiceDiscount(amount) - 40;
        }
    }
    public class RecurringInvoice : Invoice
    {
        public override double GetInvoiceDiscount(double amount)
        {
            return base.GetInvoiceDiscount(amount) - 30;
        }
    }
}