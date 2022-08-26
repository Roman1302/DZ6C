/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

Console.WriteLine("Программа подсчета чисел больше ноля веденых пользователем");

int FillArray(int[] array, string[] sign)
{
    int length = array.Length;
    int index = 0;
    int j = 0;
    while (index < length)
    {
        array[index] = Convert.ToInt32(sign[index]);
        if (array[index] > 0)
        {
            j++;
        }
        index++;
    }
    return j;
}

Console.Clear();

Console.WriteLine();
Console.WriteLine("Введите положительные и отрицательные числа через пробел: ");
string[] arrayCoord = Console.ReadLine()!.Split();
int[] signCoord = new int[arrayCoord.Length];

Console.WriteLine(FillArray(signCoord, arrayCoord));


