Console.WriteLine("введите числа");
string strN = Console.ReadLine();
int N =int.Parse(strN);
//int [] arrey = new int [5];
int A = N/10000;
int b = N/1000%10;
int c = N/100%10;
int e = N/10%10;
int f = N%10;
int [] array = { A, b, c, e, f};
if(array[0] == array[4] || array[1] == array[3])
Console.WriteLine("палиндром");
else Console.WriteLine("не палиндром");
