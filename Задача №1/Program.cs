// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Write("Введите количество чисел ");
int num = Convert.ToInt32(Console.ReadLine());

int[] mas = new int[num];

void InputNum(int n)
{
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Введите число {i + 1}: ");
        mas[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int SearchNum(int[] mas)
{
    int count = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] > 0)
        {
            count++;
        }
    }
    return count;
}

InputNum(num);

Console.WriteLine($"В массиве {SearchNum(mas)} чисел больше нуля");

