int MathPower(int baseNum, int powerNum)
{
    int output = baseNum;
    for (int i = 0; i < powerNum - 1; i++)
    {
        output *= baseNum;
    }
    return output;
}

int baseNum = int.Parse(Console.ReadLine());
int powerNum = int.Parse(Console.ReadLine());

int result = MathPower(baseNum, powerNum);


Console.WriteLine(result);