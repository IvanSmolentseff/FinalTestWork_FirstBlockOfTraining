/* Задача: Смотри readme файл */

using static System.Console;

Clear();

Write("Введите массив строк через пробел: ");
string[] stringArray = ReadLine().Split(' ');

string[] resultStringArray = GetResultStringArray(stringArray);
PrintArray(resultStringArray);


string[] GetResultStringArray(string[] array)
{
    int maxWordLength = 3;
    int count = 0;
    string[] result = new string[array.Length];
    foreach (var item in array)
        if (item.Length <= maxWordLength )
            { 
            result[count] = item;
            count++;
            }
    Array.Resize(ref result, count); // *Пояснение к строке кода - смотри readme файл
    return result;
}


void PrintArray(string[] array)
{
    if (array.Length == 0)
        WriteLine("Результирующий массив не содержит требуемых строк");
    else
        Write("Результирующий массив содержит следующие строки: ");
        foreach (var item in array)
            Write($"{item} ");
}
