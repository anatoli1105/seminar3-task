double Promt(string messege)
{
    Console.Write(messege);
    string strN = Console.ReadLine();
    double N =double.Parse(strN);
    return N;
}
double x1 = Promt("x1->");double x2 = Promt("x2->");
double y1 = Promt("y1->");double y2 = Promt("y2->");
double z1 = Promt("z2->");double z2 = Promt("z2->");
double result = Math.Sqrt(Math.Pow((x1-x2),2) + Math.Pow((y1 - y2),2) + Math.Pow((z1 - z2),2));
Console.WriteLine( result);
    
// Задача 2: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
