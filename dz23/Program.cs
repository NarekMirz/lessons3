// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();
System.Console.WriteLine("Введите число ");
int limitCube = int.Parse(Console.ReadLine());

for(int i = 1; i < limitCube; i++)
{
    System.Console.Write(i*i*i);
}