//Задача 3: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 4, 9. 
//5 -> 1, 8, 27, 64, 125
Console.WriteLine("введите числo");
string strN = Console.ReadLine();
int N =int.Parse(strN);
int i = 1;
while (i<=N)
{
    int A = i * i * i;
    Console.Write(A + "  ");
    i++;
}
Console.WriteLine("  <- через while ,таблица кубов чисел от 1 до N. ");

for (int d = 1;d <= N;d++)
Console.Write( (d*d*d) + "  "); 
Console.WriteLine("  <- через for   ,таблица кубов чисел от 1 до N. ");