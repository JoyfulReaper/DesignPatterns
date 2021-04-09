// Example from: GOF Book

/**
Composite Demo from the GOF Design Patter Book (163)

Intent: 
Compose objects into tree structures to represent part-whole hierarchies. Composite
let's clients treat individual objects and compositions of objects uniformly.

Also known as:

Applicability: 
Use when you want to represent part-whole hierarchies of objects/
When you want clients to be able to ignore the difference between compositions of objects and
individual objects. Clients will treat all objects in the composite structure uniformly.

Collaborations:
Clients use the Component class interface to interact with objects in the composite structure. If the recipient is a Composite, then it usually forwards requests to its child components, possible performing additional operations before or after forwarding.

Participants:
Component (): Declares the interface for objects in the composition. Implements default behavior for
the interface common to all classes, as appropriate.
Declares an interface for accessing and managing its child components.
Optionally defines an interface for accessing a components parent in the recursive structure and
implements it if appropriate.

Leaf ():  Represents leaf objects in the composition. A leaf has no children.
Defines behavior for primitive objects in the composition.

Composite ():
Defines behavior for components having children. Stores child components.
Implements child related operations in the component interface.

Client ():
Manipulates objects in the composition through the Component interface.

See Also:
*/

using System;

namespace CompositeGOF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
