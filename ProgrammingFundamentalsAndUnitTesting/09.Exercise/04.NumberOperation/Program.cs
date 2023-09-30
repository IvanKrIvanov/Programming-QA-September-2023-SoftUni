//Write a program to evaluate operations, which:
//•	Reads 2 real numbers and math operator (string) from the console
//•	Possible given values for the math operator are: "+", "-", "*", "/"
//•	Apply the operator with given numbers
//•	Print output in the following format, where result is formatted to the second digit:
//"{N1} {operator} {N2} = {result}"

double num1 = double.Parse(Console.ReadLine());
double num2 = double.Parse(Console.ReadLine());

string op = Console.ReadLine();
double result = 0;
if (op == "+")
{
    result = num1 + num2;
}
else if (op == "-")
{
    result = num1 - num2;
}
else if (op == "*")
{
    result = num1 * num2;
}
else if (op == "/")
{
    result = num1 / num2;
}
Console.WriteLine($"{num1} {op} {num2} = {result:F2}");