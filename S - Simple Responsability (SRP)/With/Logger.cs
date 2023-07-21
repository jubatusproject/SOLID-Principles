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
    public interface ILogger
    {
        void Info(string info);
        void Debug(string info);
        void Error(string message, Exception ex);
    }

    public class Logger : ILogger
    {
        public Logger()
        {
            // here we need to write the Code for initialization 
            // that is Creating the Log file with necesssary details
        }
        public void Info(string info)
        {
            // here we need to write the Code for info information into the ErrorLog text file
        }
        public void Debug(string info)
        {
            // here we need to write the Code for Debug information into the ErrorLog text file
        }
        public void Error(string message, Exception ex)
        {
            // here we need to write the Code for Error information into the ErrorLog text file
        }
    }
}