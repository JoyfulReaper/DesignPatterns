// Example based on https://www.youtube.com/watch?v=F1YQ7YRjttI

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
Abstraction (View): Defines Abstraction's interface, maintains reference to object of type Implementor
RefinedAbstraction (LongFormView):  Extends the interface defined by Abstraction
Implementor (Resource): Defines the interface for implementation classes. this interface doesn't have to correspond
exactly to the Abstractions interface, Typically the Implementor interface provides only primitive operations
and Abstraction defines higher-level operations based on these primitives.

ConcreteImplementor (Artist): Implements the Implementor interface and defines its concrete implementation.

See Also:
*/

using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor org = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Design Pattern Demos: Updated Gang of Four Examples: Structural Design Patterns: Bridge");
            Console.WriteLine("https://github.com/JoyfulReaper\n");
            Console.ForegroundColor = org;
            Console.WriteLine("Example based on https://www.youtube.com/watch?v=F1YQ7YRjttI\n");

            Book book = new Book()
            {
                Author = "Sam Smith",
                Title = "How to be Awesome",
                Excerpt = "In this chapter you will learn how to be awesome.\nStep one be awesome\nStep two don't not be awesome.",
                Image = "https://example.com/images/howtobeawesome.png",
                Url = "https://example.com/books/howtobeawesome"
            };

            Artist artist = new Artist()
            {
                Name = "Awesome Band",
                Bio = "Awesome Band was founder in 1645.\nThey have been making music for over 5000 years\nYou should listen to them!",
                Image = "https://example.com/images/AwesomeBand.jpg",
                Url = "https://example.com/bands/AwesomeBand"
            };

            BookResource bookResource = new BookResource(book);
            ArtistResource artistResource = new ArtistResource(artist);

            LongFormView longFormView = new LongFormView(bookResource);
            ShortFormView shortFormView = new ShortFormView(bookResource);

            Console.WriteLine("LongFormView: ");
            Console.WriteLine(longFormView.Show());
            Console.WriteLine("ShortFormView: ");
            Console.WriteLine(shortFormView.Show());

            longFormView = new LongFormView(artistResource);
            shortFormView = new ShortFormView(artistResource);

            Console.WriteLine("LongFormView: ");
            Console.WriteLine(longFormView.Show());
            Console.WriteLine("ShortFormView: ");
            Console.WriteLine(shortFormView.Show());
        }
    }
}
