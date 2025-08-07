# C# – Core Type System Concepts

This note summarizes foundational C# type system concepts — including how value vs reference types behave, how to handle nullability, and how to convert between types safely.

---

## Topics Covered

1. Value Types vs Reference Types  
2. Nullable Types  
3. Type Casting  
4. Boxing and Unboxing

---

## 1. Value Types vs Reference Types

- **Value types** hold data directly and are stored on the stack.
- **Reference types** hold references to data stored on the heap.

| Value Types                  | Reference Types            |
|-----------------------------|----------------------------|
| `int`, `double`, `bool`     | `string`, `class`, `array` |
| Copied by value             | Copied by reference        |

```csharp
int a = 5;
int b = a;
b = 10;
// a is still 5

int[] x = { 1, 2, 3 };
int[] y = x;
y[0] = 99;
// x[0] is now 99 because x and y refer to the same array
```

## 2. Nullable Types

Use `?` to allow null values in value types.

```csharp
int? score = null;

if (score.HasValue)
    Console.WriteLine(score.Value);
else
    Console.WriteLine("No score available.");
```

## 3. Type Casting

- **Implicit** Safe Conversions (e.g. int => Double)
- **Explicit** Manual Cast required (e.g. double => int)

```csharp
int a = 10;
double b = a; // implicit cast

double x = 5.9;
int y = (int)x; // explicit cast, y =5
```

## 4. Boxing and Unboxing

- **Boxing** Wraps a value type inside a reference type (object)
- **Unboxing** Extracts the value type back from an object

```csharp
int num = 123;
object obj = num; // boxing

int unboxed = (int)obj; // unboxing