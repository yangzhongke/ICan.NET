/*
int[] items = { 3,1,4,1,5,9};
foreach(var w in items.Window(2))
{
    WriteLine(w);
}
Console.WriteLine("**********");
foreach (var w in items.Window(5))
{
    WriteLine(w);
}
Console.WriteLine("**********");
foreach (var w in items.Window(6))
{
    WriteLine(w);
}
Console.WriteLine("**********");

List<int> items2 = new List<int> { 3, 1, 4, 1, 5, 9 };
foreach (var w in items2.Window(2))
{
    WriteLine(w);
}
Console.WriteLine("**********");
foreach (var w in items2.Window(5))
{
    WriteLine(w);
}
Console.WriteLine("**********");
foreach (var w in items2.Window(6))
{
    WriteLine(w);
}

Console.WriteLine("**********");

IEnumerable<int> items3 = new List<int> { 3, 1, 4, 1, 5, 9 };
foreach (var w in items3.Window(2))
{
    WriteLine(w);
}
Console.WriteLine("**********");
foreach (var w in items3.Window(5))
{
    WriteLine(w);
}
Console.WriteLine("**********");
foreach (var w in items3.Window(6))
{
    WriteLine(w);
}

void WriteLine<T>(T[] items)
{
    Console.WriteLine(String.Join(",",items));
}*/
using ICan.AutoGUI;

dynamic window = new DynamicWindow(new Vanara.PInvoke.HWND(new IntPtr(0x00120290)));
//window.File.Save();
//window.File.SaveAs();
window.File.Launch.SearchInFiles();