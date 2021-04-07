// Example from https://www.youtube.com/watch?v=AvszFRYvvt0

/**
Bridge Demo from the GOF Design Patter Book (151)

Intent: 
Decouple an abstraction from its implementation so that the two can vary independently

Also known as: Handle/Body

Applicability: 
Avoid permanent binding between an abstraction and its implementation. For example when the
implementation must be switched at runtime.

Both the abstractions and their implementation should be extensible by subclassing. Bridge
pattern lets you combine different abstractions and implementations and extend them independently.

Changes in the implementation of an abstraction should have no impact on clients

You want to hide the implementation of an abstraction completely from clients.

You have a proliferation of classes.

You want to share an implementation among multiple objects and this face should be 
hidden from the clients.

Collaborations:
Abstraction forwards client requests to its Implementor object.

Participants:
Abstraction (Payment): Defines Abstraction's interface, maintains reference to object of type Implementor
RefinedAbstraction (CardPayment/NetBankingPayment):  Extends the interface defined by Abstraction
Implementor (IPaymentSystem): Defines the interface for implementation classes. this interface doesn't have to correspond
exactly to the Abstractions interface, Typically the Implementor interface provides only primitive operations
and Abstraction defines higher-level operations based on these primitives.

ConcreteImplementor (CitiPaymentSystem/IDBIPaymentSystem): Implements the Implementor interface and defines its concrete implementation.

See Also:
*/

using System;

namespace BridgeGOF
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor org = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Design Pattern Demos: Traditional Gang of Four Examples: Structural Design Patterns: Adapter");
            Console.WriteLine("https://github.com/JoyfulReaper\n");
            Console.ForegroundColor = org;

            Console.WriteLine();
            Console.WriteLine("Example from: https://www.youtube.com/watch?v=AvszFRYvvt0");

            Payment order = new CardPayment();
            order._IPaymentSystem = new CitiPaymentSystem();
            order.MakePayment();

            order._IPaymentSystem = new IDBIPaymentSystem();
            order.MakePayment();

            order = new NetBankingPayment();
            order._IPaymentSystem = new CitiPaymentSystem();
            order.MakePayment();

        }
    }
}
