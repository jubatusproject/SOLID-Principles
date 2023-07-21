using System;

/*
→ What is the Liskov Substitution Principle in C#? ←
The Liskov Substitution Principle is a Substitutability principle in object-oriented programming 
Language. This principle states that, if S is a subtype of T, then objects of type T should be 
replaced with objects of type S.
So, the Liskov Substitution Principle says that the object of a derived class should be able to 
replace an object of the base class without bringing any errors in the system or modifying the 
behavior of the base class. That means child class objects should be able to replace parent class 
objects without compromising application integrity.
*/

/* Reference Site:                                                                               */
/* https://dotnettutorials.net/lesson/liskov-substitution-principle/                             */
/*                                                                                               */

namespace SolidPrinciples.With.LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            SolidPrinciples.Without.LSP.Apple apple = new SolidPrinciples.Without.LSP.Orange();
            Console.WriteLine(apple.GetColor());

            IFruit fruit = new Orange();
            Console.WriteLine($"Color of Orange: {fruit.GetColor()}");
            fruit = new Apple();
            Console.WriteLine($"Color of Apple: {fruit.GetColor()}");
            Console.Read();
        }
    }
}