Console.WriteLine("Welcome To Calculator");
Console.WriteLine("Enter First Number");
int first = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Second Number");
int second = int.Parse(Console.ReadLine());
Console.WriteLine("Sonuç");
Console.WriteLine(first + "+" + second + " = " + (first + second));
Console.WriteLine(first + "-" + second + " = " + (first - second));
Console.WriteLine(first + "/" + second + " = " + (first / second));
Console.WriteLine(first + "X" + second + " = " + (first * second));

Console.WriteLine("Welcome To Calculator");
Console.WriteLine("Enter First Number");
int first = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Second Number");
int second = int.Parse(Console.ReadLine());
Console.WriteLine("Choose Process (+ - / *)");
string third = Console.ReadLine();

if (third == "+")
{
    Console.WriteLine(first + second);
}
if (third == "-") 
{
    Console.WriteLine(first - second);
}
if (third == "/")
{
    Console.WriteLine(first / second);
}
if (third == "*")
{
    Console.WriteLine(first * second);
}