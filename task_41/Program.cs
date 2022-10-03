/*
    Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

    0, 7, 8, -2, -2 -> 2

    1, -7, 567, 89, 223-> 3
*/

string ReadData()
{
    Console.WriteLine("Введите числа через запятую: ");
    string numString = Console.ReadLine() ?? "";
    return numString;
}

int CalculateNumbers(string line)
{
    int count = 0;

    string[] words = line.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);

    for (int i = 0; i < words.Length; i++)
    {

        if (int.Parse(words[i]) > 0)
        {
            count++;
        }
    }

    return count;
}

string readData = ReadData();
int count = CalculateNumbers(readData);

if (count > 0)
    Console.WriteLine($"Среди введённых пользователем чисел {count} больше 0");
else
    Console.WriteLine($"Среди введённых пользователем нет чисел больше 0");