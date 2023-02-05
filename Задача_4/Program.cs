//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22



Console.WriteLine("Enter numberA: ");
String strNumberA=Console.ReadLine();
int numberA=Convert.ToInt32(strNumberA);

Console.WriteLine("Enter numberB: ");
String strNumberB=Console.ReadLine();
int numberB=Convert.ToInt32(strNumberB);

Console.WriteLine("Enter numberC: ");
String strNumberC=Console.ReadLine();
int numberC=Convert.ToInt32(strNumberC);


int Max;
{
    Max=numberA;
    if(numberB>Max) Max=numberB;
    if(numberC>Max) Max=numberC;
}
Console.WriteLine(Max);



