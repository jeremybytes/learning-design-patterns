# Design Patterns: Not Just for Architects  
Level: Introductory 

Design patterns are not just for architects. In fact, you already use Design Patterns but probably don't know it. Observer, Facade, Iterator, Proxy - these are all patterns that allow us to better communicate our ideas with other developers. And once we understand the patterns, we can use solutions that people way smarter than us have already implemented. In this session, we'll take a look at several Gang of Four patterns that we regularly use without realizing it. Don't know who the Gang of Four is? Join us to find out.  

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
