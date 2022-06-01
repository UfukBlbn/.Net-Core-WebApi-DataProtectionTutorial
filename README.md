# .Net-Core-WebApi-DataProtectionTutorial


Get started with data protection APIs in ASP.NET Core
 
Basically, protecting data consists of the following steps:

Create a data protector from a data protection provider.
ProtectCall the method with the data you want to protect.
UnprotectCall the method with the data you want to convert to plain text.
Many frameworks and application models, such as ASP.NET Core or SignalR, already configure the data protection system and attach it to a service container accessed via dependency injection . The following example shows:

Configure a service container to add dependency and save the data protection stack.
Obtained via data protection provider DI.
A guard is being created.
Reverting data protection.


![image](https://user-images.githubusercontent.com/71414017/171336463-7c4bf9d0-4d23-4251-ab58-b814b88cccdf.png)
