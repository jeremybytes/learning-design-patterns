# Design Patterns: Not Just for Architects  
Level: Introductory 

Design patterns are not just for architects. In fact, you already use design patterns without even knowing it. Observer, Facade, Iterator, Proxy -- these are just a few of the patterns that you have probably used. But it is really hard to use a tool effectively when you don't even know you are using it. So let's fix that.  

In this session, you will learn what design patterns are (and what they are not). You will see both the benefits and consequences of patterns. And you will see several of the Gang of Four patterns that you already use (they may even be built into your programming language). Don't know who the Gang of Four is? You'll learn that, too. Once we understand design patterns, we can find solutions that people way smarter than us have already implemented. This gives us another set of tools that we can use to build great software.  

You will learn:

* What design patterns are  
* How you are already using design patterns (even if you don't realize it)  
* How intentional use of patterns can lead to better software  

## Project Layout  

Each pattern has its own folder/project of the same name.  

* Observer/Observer.csproj  
* Iterator/Iterator.csproj  
* Facade/Facade.csproj  
* ChainOfResponsibility/ChainOfResponsibility.csproj  
* Proxy/Proxy.csproj  

In addition, there are 2 supporting projects:  

* People.Service/People.Service.csproj  
The service used by the "Proxy" sample.  
* Shared/Shared.csproj  
Shared elements like the "Person" object and sample data.  

## Running the Projects  
Each project can be started by setting the startup project from Visual Studio 2022 or by using "dotnet run" on the command line for the project.  

In order for the "Proxy" sample to work, the "People.Service" service must be started. To start the service, navigate to the "Person.Service" folder from the command line and type "dotnet run".

Ex:
```
C:\learning-design-patterns\People.Service> dotnet run
```  

The service endpoint can be found at [http://localhost:9874/people](http://localhost:9874/people)

## Additional Resources  

* Blog Article: [The Use and Misuse of Design Patterns](http://jeremybytes.blogspot.com/2010/07/use-and-misuse-of-design-patterns.html)  
* Blog Article: [Design Patterns: Understand Your Tools](http://jeremybytes.blogspot.com/2012/05/design-patterns-understand-your-tools.html)  
* Demo (Factory Method Pattern & Inversion of Control Pattern): [IEnumerable, ISaveable, IDontGetIt: Interfaces in .NET](http://www.jeremybytes.com/Demos.aspx#INT)  
* Blog Article (MVVM Pattern): [Overview of the MVVM Design Pattern](http://www.jeremybytes.com/Demos.aspx#INT)  
* Blog Article (Iterator Pattern): [Next, Please! - A Closer Look at IEnumerable (Part 1)](http://jeremybytes.blogspot.com/2012/05/next-please-closer-look-at-ienumerable.html)  
* Blog Article (Strategy Pattern): [Next, Please! - A Closer Look at IEnumerable (Part 4)](http://jeremybytes.blogspot.com/2012/05/next-please-closer-look-at-ienumerable_24.html)  
* Recorded Presentation: [Learn the Lingo: Design Patterns](https://youtu.be/QmSf2FtPvKA) recorded live at Silicon Valley Code Camp (Oct 2015)  
* Pluralsight Course (authored by me): [Design Patterns On-Ramp](http://www.pluralsight.com/training/Courses/TableOfContents/design-patterns-on-ramp)  
*Note: This one is a bit old (the sample code uses .NET Framework), but the information is still relevant -- that's one of the fun things about design patterns!).*

---
