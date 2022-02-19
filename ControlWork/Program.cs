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
string[] CreateNewArray(string line, int numberofwords)
{
    string[] array = new string[numberofwords];
    int k = 0;
    for(int i = 0; i < line.Length; i++)
    {
        if(line[i]!=' ')
        {
            array[k] = array[k]+line[i];
        }
        else 
        {
            k++;
        }
    }
    return array;
}
void ShowImportant(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length<=3)
        {
            Console.Write($"{array[i]} ");
        }
    }
}
Console.WriteLine("Hello, User! Enter words, press 'Enter'-button and you will see a magic!");
string line = Console.ReadLine() ?? "0";
Console.WriteLine($"There are {HowManyWordsInLine(line)} words in total here");
string[] newArray = CreateNewArray(line, HowManyWordsInLine(line));
ShowImportant(newArray);
Console.WriteLine();
Console.WriteLine("There is words which consist from 3 or less characters");

