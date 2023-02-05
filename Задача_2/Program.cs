//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3


 int Max;
 
Console.WriteLine("Enter numberA: ");

String strNumberA=Console.ReadLine();

int numberA=Convert.ToInt32(strNumberA);


Console.WriteLine("Enter numberB: ");

String strNumberB=Console.ReadLine();

int numberB=Convert.ToInt32(strNumberB);

if(numberA > numberB)
{
    Console.WriteLine(Max=numberA);

}

else 
Console.WriteLine( Max= numberB);
