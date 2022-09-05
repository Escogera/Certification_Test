// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либоо задать на старте выполнения алгоритма.
// ["hello", "2", "world", ":-)"]->["2", ":-)"]
// ["1234", "1567"< "-2", "computer science"]->["-2"]
// ["Russia", "Denmark", "Kazan"]->[]

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
string[] firstArray = new string[] { "hello", "2", "world", ":-)" };
string[] secondArray = new string[firstArray.Length];
int count = 0;
for (int i = 0; i < firstArray.Length; i++)
{
    if (firstArray[i].Length <= 3)
    {
        secondArray[count] = firstArray[i];
        count++;
    }
}
PrintArray(firstArray);
PrintArray(secondArray);