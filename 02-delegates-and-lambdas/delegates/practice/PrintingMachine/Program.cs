void PrintLower(string text) => Console.WriteLine(text.ToLower());
void PrintUpper(string text) => Console.WriteLine(text.ToUpper());
void PrintReverse(string text)
{
    var chars = text.ToCharArray();
    Array.Reverse(chars);
    Console.WriteLine(new string(chars));
}

void PrintInAllStyles(string text)
{
    PrintDelegate printAllStyles = PrintLower;
    printAllStyles += PrintUpper;
    printAllStyles += PrintReverse;

    printAllStyles(text);
}

PrintInAllStyles("Print me in all styles");
public delegate void PrintDelegate(string text);