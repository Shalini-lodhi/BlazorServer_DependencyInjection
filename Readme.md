# Dependency Injection (Blazor Server)

By Default it is in **ASP.NET**

- allows to develop loosely-coupled code that is easy to maintain
- redue dependencies among classes by injecting those dependencies at *run-time* instead of design time technically.

- dependency injection is a way to create your dependencies outside of the class that uses it. 
- we inject them from the outside, and take control about their creation away from the inside of your class.

# Drawbacks
- We have to hard code everytime whenever we want to use any class/interface.

# Type 

1. **Transient** 
- objects are always different; a new instance is provided to every controller and every service. 
- single instance for the lifetime of the application domain.
2. **Scoped** 
- objects are the same within a request, but different across different requests.
- single instance for the duration of the scoped request, which means per HTTP request in ASP.NET
3. **Singleton** 
- objects are the same for every object and every request. 
-  single instance for the lifetime of the application domain.
