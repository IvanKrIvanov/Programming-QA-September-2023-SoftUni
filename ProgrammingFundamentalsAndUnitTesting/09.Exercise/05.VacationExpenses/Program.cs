string season = Console.ReadLine();
string accType = Console.ReadLine();
int days = int.Parse(Console.ReadLine());

double finalPrice = 0;

if (season == "Spring")
{
	if (accType == "Hotel")
	{
		finalPrice = days * 30;
	}
	else if (accType == "Camping")
	{
		finalPrice = days * 10;
    }
    finalPrice *= 0.80;
}
else if (season == "Summer")
{
    if (accType == "Hotel")
    {
        finalPrice = days * 50;
    }
    else if (accType == "Camping")
    {
        finalPrice = days * 30;
    }
}
else if (season == "Autumn")
{
    if (accType == "Hotel")
    {
        finalPrice = days * 20;
    }
    else if (accType == "Camping")
    {
        finalPrice = days * 15;
    }
    finalPrice *= 0.70;
}
else if (season == "Winter")
{
    if (accType == "Hotel")
    {
        finalPrice = days * 40;
    }
    else if (accType == "Camping")
    {
        finalPrice = days * 10;
    }
    finalPrice *= 0.90;
}
Console.WriteLine($"{finalPrice:F2}");