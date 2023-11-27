// See https://aka.ms/new-console-template for more information
Console.WriteLine($"{CalcAge("nairan", new DateTime(1990, 5, 24))}");


(string, int) CalcAge(string name, DateTime BirthDate)
{
  var Age = DateTime.Today.Year - BirthDate.Year;
  if (BirthDate.Date.DayOfYear >= DateTime.Now.DayOfYear) Age--;
  return (name, Age);
}



#region
System.Diagnostics.Debugger.Break();
Action<string> greet = name =>
{
  string greeting = $"Hello {name}!";
  Console.WriteLine(greeting);
};
string person = Console.ReadLine() ?? "";
greet(person);
// Hello `person or Someone`
// ?? and ??= are null-coalescing operators, 
//    which return the left-hand operand if the operand is not null; 
//    otherwise, they return the right operand.

Func<string, int, string> isBiggerThan = (string s, int x) => s.Length > x ? "Yes" : "No";
var size = 5;
Console.WriteLine($"The text {person} has more than {size} chars? {isBiggerThan(person, size)}");

string[] people = { "Mario", "Ruan", "João e,Jhony" };
char letter = 'R';
Console.WriteLine($"People with name started with '{letter}': {string.Join(", ", people.Where(x => x.StartsWith(letter)))}");

#endregion

#region 
List<int> list = new() { 1, 2, 3, 4, 5 };
var squaredList = list.Select(x => x * x);
Console.WriteLine($"Original List: {string.Join(", ", list)}");
Console.WriteLine($"Squared  List: {string.Join(", ", squaredList)}");
// Original List: 1, 2, 3, 4, 5
// Squared  List: 1, 4, 9, 16, 25
var summedList = list.Select((x, index) => x + squaredList.ElementAt(index));
Console.WriteLine($"Summed   List: {string.Join(", ", summedList)}");
// Summed   List: 2, 6, 12, 20, 30

var listMultipleOfThree = list.Where(x => x % 3 == 0).ToList();
listMultipleOfThree.AddRange(squaredList.Where(x => x % 3 == 0).ToList());
listMultipleOfThree.AddRange(summedList.Where(x => x % 3 == 0).ToList());
Console.WriteLine($"List Multiple of Three: {string.Join(", ", listMultipleOfThree)}");
// List Multiple of Three: 3, 9, 6, 12, 30
Console.WriteLine($"List Multiple of Three: {string.Join(", ", listMultipleOfThree.Order())}");


#endregion