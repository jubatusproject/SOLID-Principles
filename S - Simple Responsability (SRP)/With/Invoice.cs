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
    public class Invoice
    {
        public long InvAmount { get; set; }
        public DateTime InvDate { get; set; }
        private ILogger fileLogger;
        private MailSender emailSender;
        
        public Invoice()
        {
            fileLogger = new Logger();
            emailSender = new MailSender();
        }
        
        public void AddInvoice()
        {
            try
            {
                fileLogger.Info("Add method Start");
                // Here we need to write the Code for adding invoice
                // Once the Invoice has been added, then send the  mail
                emailSender.EMailFrom = "emailfrom@xyz.com";
                emailSender.EMailTo = "emailto@xyz.com";
                emailSender.EMailSubject = "Single Responsibility Princile";
                emailSender.EMailBody = "A class should have only one reason to change";
                emailSender.SendEmail();
            }
            catch (Exception ex)
            {
                fileLogger.Error("Error Occurred while Generating Invoice", ex);
            }
        }
        
        public void DeleteInvoice()
        {
            try
            {
                //Here we need to write the Code for Deleting the already generated invoice
                fileLogger.Info("Delete Invoice Start at @" + DateTime.Now);
            }
            catch (Exception ex)
            {
                fileLogger.Error("Error Occurred while Deleting Invoice", ex);
            }
        }
    }
}