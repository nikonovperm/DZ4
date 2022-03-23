/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

void SumDigitOfNumber(int number)
{
    int result = 0;
    int digit =0;
    while (number > 0)
    {
        digit = number%10;
        result+= digit;
        number/=10;
    }
    Console.WriteLine("Сумма цифр числа: " + result);
}

Console.WriteLine("Введите число");
int InputNumber = Convert.ToInt32(Console.ReadLine());
SumDigitOfNumber(InputNumber);