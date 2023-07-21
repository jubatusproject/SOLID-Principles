using System;
using System.Net.Mail;

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
namespace SolidPrinciples.Without.SRP
{
    public class Invoice
    {
        public long InvoiceAmount { get; set; }
        public DateTime InvoiceDate { get; set; }

        public void AddInvoice()
        {
            try
            {
                // Here we need to write the Code for adding invoice
                // Once the Invoice has been added, then send the  mail
                MailMessage mailMessage = new MailMessage("EMailFrom", "EMailTo", "EMailSubject", "EMailBody");
                this.SendInvoiceEmail(mailMessage);
            }
            catch (Exception ex)
            {
                //Error Logging
                System.IO.File.WriteAllText(@"c:\ErrorLog.txt", ex.ToString());
            }
        }

        public void DeleteInvoice()
        {
            try
            {
                //Here we need to write the Code for Deleting the already generated invoice
            }
            catch (Exception ex)
            {
                //Error Logging
                System.IO.File.WriteAllText(@"c:\ErrorLog.txt", ex.ToString());
            }
        }

        public void SendInvoiceEmail(MailMessage mailMessage)
        {
            try
            {
                // Here we need to write the Code for Email setting and sending the invoice mail
            }
            catch (Exception ex)
            {
                //Error Logging
                System.IO.File.WriteAllText(@"c:\ErrorLog.txt", ex.ToString());
            }
        }
    }
}