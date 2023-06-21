Console.WriteLine("Hello, enter two number and an operator!");
Console.WriteLine("First:");
string str = Console.ReadLine();
int n = Int32.Parse(str);

Console.WriteLine("Select operator");
string oper = Console.ReadLine();
if (oper.Length != 1)
{
    Console.WriteLine("Error, try again");
    Environment.Exit(1);
    return;
}

Console.WriteLine("Second:");
string str1 = Console.ReadLine();
int n1 = Int32.Parse(str1);

int result = 0;
if (oper == "+")
{
    result = n + n1;
}
if (oper == "-")
{
    result = n - n1;
}
if (oper == "*")
{
    result = n * n1;
}
if (oper == "/")
{
    if (n1 == 0)
    {
        Console.WriteLine("Impossible to divide by 0");
        Environment.Exit(1);
        return;
    }
    else result = n / n1;

}
Console.WriteLine("RESULT : " + result);