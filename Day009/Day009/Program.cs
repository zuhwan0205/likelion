string[] names = { "Charlie", "Alice", "Bob" };
var sortedNames = names.OrderBy(n => n);

foreach(var name in sortedNames)
{
    Console.WriteLine(name);
}

var firstName = names.First(n => n.StartsWith("A"));

Console.WriteLine($"First name starting with A: {firstName}");