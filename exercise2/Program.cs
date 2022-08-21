Console.Clear();
Console.Write("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число");
int number3 = Convert.ToInt32(Console.ReadLine());

int numberX = 0;

if (number1 > number2)
{
    numberX = number1;
}
else {
    numberX = number2;
}

if (number3 > numberX)
{
   Console.WriteLine($"Число {number3} большее из трех");
}
else {
    Console.WriteLine($"Число {numberX} большее из трех");
}