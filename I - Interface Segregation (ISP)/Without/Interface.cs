/*
→ What is the Interface Segregation Principle in C#? ←
The Interface Segregation Principle states that “Clients should not be forced to implement any 
methods they don’t use. Rather than one fat interface, numerous little interfaces are preferred 
based on groups of methods with each interface serving one submodule“.

Let us break down the above definition into two parts.

1) First, no class should be forced to implement any method(s) of an interface they don’t use.
2) Secondly, instead of creating large or you can say fat interfaces, create multiple smaller 
interfaces with the aim that the clients should only think about the methods that are of interest 
to them.

As per the Single Responsibility Principle of SOLID, like classes, interfaces also should have a 
single responsibility. That means we shouldn’t force any class to implement any method(s) that 
they don’t require.
*/

/* Reference Site:                                                                               */
/* https://dotnettutorials.net/lesson/interface-segregation-principle/                           */
/*                                                                                               */

namespace SolidPrinciples.Without.ISP
{
    public interface IPrinterTasks
    {
        void Print(string PrintContent);
        void Scan(string ScanContent);
        void Fax(string FaxContent);
        void PrintDuplex(string PrintDuplexContent);
    }
}