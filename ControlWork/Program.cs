int HowManyWordsInLine(string line)
{
    int result = 1;
    for(int i = 0; i < line.Length; i++)
    {
        if(line[i] == ' ')
        {
            result++;
        }
    }
    return result; 
}
Console.WriteLine("Hello, User! Enter words, press 'Enter'-button and you will see a magic!");
string UserLine = Console.ReadLine() ?? "0";
Console.WriteLine($"There are {HowManyWordsInLine(UserLine)} words");

