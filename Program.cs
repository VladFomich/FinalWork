Console.WriteLine("Введите массив строк через запятую");
string[] wordsMatrix;
string words = Console.ReadLine();
words = words.Replace(" ", "");
wordsMatrix = words.Split(',');
var result = new string[wordsMatrix.Length];
var size = 0;
foreach (var value in wordsMatrix )
{
    if (value.Length <= 3)
    {
        result[size] = value;
        size++;
    }
}
Console.WriteLine("Новый массив строк со значениями не более трёх символов:");
Console.WriteLine(string.Join(", ", result, 0,  size));