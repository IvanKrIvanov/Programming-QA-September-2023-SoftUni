using System.Threading.Channels;

string word = Console.ReadLine();

while (word != "end")
{
    string reverseWord = "";

	for (int i =  word.Length - 1; i >= 0; i -= 1 )
	{
		reverseWord += word[i];
	}

    Console.WriteLine($"{word} = {reverseWord}");

	word = Console.ReadLine();
}