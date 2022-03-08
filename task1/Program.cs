Console.WriteLine("введите числа");
string strN = Console.ReadLine();
int N =int.Parse(strN);
if(N%100%10*10+N%100/10 == N/1000)Console.WriteLine("палиндром");
else Console.WriteLine( "не палиндром");