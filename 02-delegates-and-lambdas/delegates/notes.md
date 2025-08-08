# C# – Delegates

This note summarizes foundational C# delegate concepts — including what is a delegate, why to use them and multicast delegate.

---

## Topics Covered

1. What is a Delegate?  
2. Why use Delegates  
3. Multicast Delegates

---

## 1. What is a Delegate?

A Delegate is a reference type that points to methods with specific parameters and return type.

- It stores a reference to a method(s)
- Can be called just like other methods
- Enforces type safety

```csharp
public delegate void PrintDelegate(string message); // declaring a delegate
void PrintConsole(string message) => Console.WriteLine(message); // declaring a method

PrintDelegate printDelegate = PrintConsole; // assigning method to delegate
printDelegate("I am from delegate"); // calling delegate
```

## 2. Why Use Delegates?

 - **Loose Coupling**: The caller does not need to know which method will run.
 - **Runtime method selection**: It can be decided at run-time which method to call.
 - **Callbacks**: A method call be passed to other methods to be executed later.

 ## 3. Multicast Delegates

 - When a delegate refers to multiple methods
 - Delegates are by default multicast

```csharp
void PrintUpperCase(string message) => Console.WriteLine(message.ToUpper()); // declaring 2nd method

PrintDelegate printMultiple = PrintConsole; // assigning 1st method
printMultiple+= PrintUpperCase; // assigning 2nd method
printMultiple("I am from multicast delegate");

 ```