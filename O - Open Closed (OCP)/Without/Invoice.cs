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
namespace SolidPrinciples.Without.OCP
{
    public class Invoice
    {        
        public double GetInvoiceDiscount(double amount, InvoiceType invoiceType)
        {
            double finalAmount = 0;
            if (invoiceType == InvoiceType.FinalInvoice)
            {
                finalAmount = amount - 100;
            }
            else if (invoiceType == InvoiceType.ProposedInvoice)
            {
                finalAmount = amount - 50;
            }
            return finalAmount;
        }
    }
    public enum InvoiceType
    {
        FinalInvoice,
        ProposedInvoice
    };
}