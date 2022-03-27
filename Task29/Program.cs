/*  Напишите программу, которая задаёт массив из N(-100 100) рандомных элементов 
и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

int[] GetRandomArray (int length)
{
    int [] randomArray = new int [length];
    for (int i = 0; i < length; i++)
    {
        randomArray[i] = new Random().Next(-100,100);    
    }
    return randomArray;
}

void printArray(int[] randomArray)
{
    Console.Write("[");
    for (int i = 0; i < randomArray.Length; i++)
    {
        Console.Write(randomArray[i]);
        if (i < randomArray.Length-1)
        {
            Console.Write(",");
        }
    }
    Console.Write("]");
}

Console.Write("Введите число элементов массива N: ");
int length = Convert.ToInt32(Console.ReadLine());
if (length > 0)
{
    int[] randomArray = GetRandomArray(length);
    printArray (randomArray);
}
else
{
    Console.WriteLine("ERROR");
}
