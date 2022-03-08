Console.WriteLine("введите числа");
string N = Console.ReadLine();
int array = N.Length;
int count = 0;
if(N[count] == N[count + 4] || N[count + 1] == N[count + 3])
Console.WriteLine("палиндром");
else Console.WriteLine("не палиндром");