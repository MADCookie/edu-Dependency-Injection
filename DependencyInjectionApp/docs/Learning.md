# .NET Core Dependency Injection In Depth

## Source Content

[.NET Core Dependency Injection In Depth](https://www.iamtimcorey.com/p/dotnet-core-dependency-injection-in-depth)

## Section 3 - Scope

* **Transient**. Return a new instance every time one is requested
* **Scoped**. In the middle: Singleton per use or request
* **Singleton**. Same instance for entire life of application 

## Section 4 - Using Interfaces

Why use interfaces in DI?

1. Easy swap out implementation
  * Example: UtcDemo are specific Demo. IDemo allows swapping out. DI can be used to switch from UTC to standard
1. Testing. 
  * Without an interface, the test project would require the implementation class `Demo` to let the client change the starting date value. Without that seam, the test project couldn't test the leap year function
  * Interface allows a class with different implementation to be used

What about multiple implementations for a single interface?

* Ask yourself if your code really meant to do that?
* Create multiple interfaces. Implementations can use comma seperated multiple interfaces
* Last one added to DI is the one used by the system
* You can inject an enumerable list of all the types and let the client class decide
* To know the different types, you can implement a specific interface on each to differentate them. Use `if (item is ILocalDemo)` or `if(item is IUtcDemo)`

## Section 5 - Advanced Topics

* Register group of classes
  * Like Microsoft does `services.AddRazorPages();`
  * Probably wouldn't be part of the solution, so done here for education. Probably in a class library project
  * Extension method to chain services.
  * Helpful to group together services.
* Idea for using group registration. See [Impact.md](Impact) for details
* Service Registration Methods
  * you can use a func routine
  * `services.AddTransient(i => new DemoWithData(5));`
* Add object checking if already added
  * `TryAdd`... methods allowing trying to add without stepping on existing obects.

## Section 6 - Best Practicies

* Transitent & Scoped will spin up the object and immediate dispose it.
* Interesting to implement IDisposable then watch the logs to see how DI uses them
* When using a singleton, DI will not work with disposal. keep in mind the singleton is supposed to the lifetime of your application.
* Anti-pattern: Using Servie Provider itself
  * harder to know what a class uses / depends on
  * harder to unit test because the class depends on the service provider itself
  * harder to know about breaking changes
* what about the "too many CTOR arguments?"
  * When they are in the CTOR, then DI makes it clear what you depend.
  * avoid using dependencies hidden through properties passed in and CTOR items
  * the Mediator pattern might be implemented to add some help for extremely complicated interdependencies. be careful of abusing
* default life time as "AddTransitent". Change to scoped or singleton when you have a reason.
  * runtime exception can throw when a signleton tries to use a scoped
  * this runtime exception is one reason why DI will run all your scoped and transitent items at start up (as mentioned above) so it lets you know of the issue
  * Singleton can't depend on a scoped class

## Section 7 - Frequently Asked Questions

* Can I Have Multiple Items with One Interface? 
  * discussed in the early topics with using interfaces
  * order is the biggest issue
  * using additional interface to label the specific kind
* Can I Have Other Constructor Parameters? 
* Can I Have Multiple Constructors? 
* Can I Pass In Values to My Constructors Besides Class Instances?
  * similar to like adding a factory to the DI instead of specific class
  * Use with caution
* Do I Put Every Class In My DI System?
  * No
  * Models don't need to be added to the DI
  * Technically, you depend on the model, but differently then the business logic class object. Models don't do anything

## Section 8 - Dependency Injection in Common Project Types

* Console project setup using `run` method approach and some interestin approaches. See [Impact.md](Impact) for details

## Course conclusions