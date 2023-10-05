int num = int.Parse(Console.ReadLine());
int startNumber = num;
bool isSpecial = true;

while (num > 0)
{
    int lastDigit = num % 10;

	if (startNumber % lastDigit != 0)
	{
		isSpecial = false;
		break;
	}
	num = num / 10;
}
if (isSpecial == true)
{
    Console.WriteLine($"{startNumber} is special");
}
else
{
    Console.WriteLine($"{startNumber} is not special");
}