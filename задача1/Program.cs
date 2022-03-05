Console.WriteLine("введите первое число ");
string strA = Console.ReadLine();
int A = int.Parse(strA);

Console.WriteLine("введите второе число ");
string strB = Console.ReadLine();
int B = int.Parse(strB);

if(A > B) Console.WriteLine("максимальное число " + A);else Console.WriteLine("максимальное число " + B);
if(A < B) Console.WriteLine("минимальное число " + A);else Console.WriteLine("минимальное число " + B);
