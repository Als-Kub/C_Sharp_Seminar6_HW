// Задача 41: Пользователь вводит с клавиатуры число M, потом вводит M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3;

Console.Clear();
int[] array = CreateArray();
RecFillArray(array);
RecPositiveNumbers(array);

int[] CreateArray()
{
Console.WriteLine("Enter a quantity of numbers");
int arraySize = int.Parse(Console.ReadLine()!);    
int[] array = new int[arraySize];
return array;
}

void RecFillArray(int[] array, int index = 0)
{
    if (index < array.Length)
    {
Console.WriteLine($"Enter a number # {index + 1}");
array[index] = int.Parse(Console.ReadLine()!);
index++;
RecFillArray(array, index);
    }
}

void RecPositiveNumbers(int[] array, int index = 0, int quantityPosNum = 0)
{
if (index == array.Length)
Console.Write($"Quantity of positive numbers: {quantityPosNum}");
else
{
     if (array[index] > 0)
    {
quantityPosNum++;
    }
index++;
RecPositiveNumbers(array, index, quantityPosNum);
}
}
