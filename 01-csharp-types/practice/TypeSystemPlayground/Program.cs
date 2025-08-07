ShowValueVsReferenceTypes();
ShowNullableTypes();
ShowTypeCasting();
ShowBoxingAndUnboxing();

Console.WriteLine("\n Demo complete.");
return;

void ShowValueVsReferenceTypes()
{
    Console.WriteLine(" Value Types:");
    int a = 5;
    int b = a;
    b = 10;
    Console.WriteLine($"a = {a}, b = {b}");

    Console.WriteLine("\n Reference Types:");
    int[] x = { 1, 2, 3 };
    int[] y = x;
    y[0] = 99;
    Console.WriteLine($"x[0] = {x[0]}, y[0] = {y[0]}");
}

void ShowNullableTypes()
{
    Console.WriteLine("\n Nullable Types:");
    int? score = null;

    if (score.HasValue)
        Console.WriteLine($"Score = {score.Value}");
    else
        Console.WriteLine("Score is null, using fallback value: 0");

    int finalScore = score ?? 0;
    Console.WriteLine($"Final Score = {finalScore}");
}

void ShowTypeCasting()
{
    Console.WriteLine("\n Type Casting:");

    int originalInt = 10;
    double castedDouble = originalInt; // Implicit
    Console.WriteLine($"Implicit cast int → double: {originalInt} → {castedDouble}");

    double originalDouble = 5.9;
    int castedInt = (int)originalDouble; // Explicit
    Console.WriteLine($"Explicit cast double → int: {originalDouble} → {castedInt}");
}

void ShowBoxingAndUnboxing()
{
    Console.WriteLine("\n Boxing and Unboxing:");

    int number = 42;
    object boxed = number; // Boxing
    Console.WriteLine($"Boxed value: {boxed}");

    try
    {
        int unboxed = (int)boxed; // Unboxing
        Console.WriteLine($"Unboxed value: {unboxed}");

        // Invalid unboxing
        string wrongCast = (string)boxed;
    }
    catch (InvalidCastException ex)
    {
        Console.WriteLine($" Unboxing error: {ex.Message}");
    }
}
