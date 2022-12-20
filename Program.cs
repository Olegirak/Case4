// Напишите программу, которая принимает на вход три числа и 
// выдает максимальное из них
int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
int number3 = int.Parse(Console.ReadLine());

int maximum = 0;
if (number1>number2)
    {
         maximum = number1;
    }
else
    {
         maximum = number2;
    }
if (number3>maximum)
    {
         maximum = number3;
    }
Console.WriteLine(maximum);