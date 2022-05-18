# ICan.NET
.NET can do anything any other programming language can do.

# windows over array, List or IEnumerable

```csharp
int[] items = { 3,1,4,1,5,9};
foreach(var w in items.Window(2))
{
    WriteLine(w);
}
void WriteLine<T>(T[] items)
{
    foreach (var e in items)
    {
        Console.Write($"{e} ");
    }
    Console.WriteLine();
}
```

Output:

3 1
1 4
4 1
1 5
5 9


