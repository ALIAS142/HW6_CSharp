// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// 1. Метод вывода массива рандомного.

int [] GetArray (int size, int minValue, int maxValue)
{
    int [] res = new int [size];
    for(int i = 0; i < size; i++)
    {
        res [i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int [] Array = GetArray(5, -10, 10);
System.Console.WriteLine(String.Join(" ", Array));

// 2. Метод вычисления элементов больше 0.

int PositiveNumber (int[] Array)
{
    int positiveNum = 0;
for(int i = 0; i < Array.Length; i++)
{
   
if(Array[i] > 0)
{
   
   positiveNum++;
}
}
return positiveNum;
}

System.Console.WriteLine($"{PositiveNumber(Array)}");
// System.Console.WriteLine($"{positiveNum}");
