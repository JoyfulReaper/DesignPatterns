/**
Adapter Demo from the GOF Design Patter Book (139)

Intent: 
Convert the interface of a class into another interface clients expect.
Adapter lets classes word together that couldn't otherwise because of incompatible interfaces.

Also known as: Wrapper

Applicability: 
You want to use an existing class, and its interface does not match the one you need.
You want to create a reusable class that cooperates with unrelated or unforeseen classes,
that is, classes that don't necessarily have compatible interfaces.
(object Adapter): You need to use several existing subclasses, but its impractical to
adapt their interface by subclassing everyone. An object updater can adapt the interface of its parent class.

Collaborations:
Clients call operations on an Adapter instance. In turn, the adapter calls 
Adaptee operations that carry out the request.

Participants:
Target (): defines the domain-specific interface that Client uses
Client ():  Collaborates with objects conforming to the Target interface
Adaptee (): defines an existing interface that needs adapting
Adapter (): Adapts the interface of Adaptee to the target interface

See Also:
*/

using System;

namespace Adaptor
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor org = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Design Pattern Demos: Updated Gang of Four Examples: Structural Design Patterns: Adapter");
            Console.WriteLine("https://github.com/JoyfulReaper\n");
            Console.ForegroundColor = org;
            Console.WriteLine("Example based on https://www.youtube.com/watch?v=2PKQtcJjYvc\n");

            ITarget target = new Adapter(new Adaptee());
            target.Request();
        }
    }
}
