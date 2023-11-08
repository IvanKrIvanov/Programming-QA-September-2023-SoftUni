string[] words = Console.ReadLine().Split();

string output = "";

for (int i = 0; i < words.Length; i++)
{
    string currentword = words[i];

	for (int j = 0; j < currentword.Length; j += 1)
	{
		output += currentword;
	}
}
Console.WriteLine(output);