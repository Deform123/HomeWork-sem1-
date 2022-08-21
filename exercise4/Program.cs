Console.Clear();
Console.Write("Введите число");
int number = Convert.ToInt32(Console.ReadLine());


for (int N = 2; N <= number; N++)

if (N % 2 == 0)
{
    Console.Write(N + ", ");
}