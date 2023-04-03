# Dependency Injection (Blazor Server)

By Default it is in **ASP.NET**

- allows to develop loosely-coupled code that is easy to maintain
- redue dependencies among classes by injecting those dependencies at *run-time* instead of design time technically.

- dependency injection is a way to create your dependencies outside of the class that uses it. 
- we inject them from the outside, and take control about their creation away from the inside of your class.

[Why does one use dependency injection?](https://stackoverflow.com/questions/14301389/why-does-one-use-dependency-injection)

# Drawbacks
- We have to hard code everytime whenever we want to use any class/interface.

# [Type](https://stackoverflow.com/questions/38138100/addtransient-addscoped-and-addsingleton-services-differences#:~:text=Singleton%20is%20a%20single%20instance,single%20instance%20per%20code%20request.) 

1. **Transient** 
- objects are always different; a new instance is provided to every controller and every service. 
- single instance for the lifetime of the application domain.
2. **Scoped** 
- objects are the same within a request, but different across different requests.
- single instance for the duration of the scoped request, which means per HTTP request in ASP.NET
3. **Singleton** 
- objects are the same for every object and every request. 
-  single instance for the lifetime of the application domain.
![image](https://user-images.githubusercontent.com/55933789/229435171-06ef7c5a-6da9-4e67-a68a-37bcf426c880.png)
