// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int InputInt(string massage)
{
    System.Console.WriteLine($"{massage} > ");
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}
int num = InputInt("Введите число");
int i = 1;
while (i <= num)
{
    System.Console.Write($" {i * i * i}");
    i++;
}

