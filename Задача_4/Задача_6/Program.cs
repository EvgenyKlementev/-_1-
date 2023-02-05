//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет


int Size;
Console.WriteLine("Enter number: ");
String strNumber=Console.ReadLine();
int number=Convert.ToInt32(strNumber);
Size=number;

if(Size %2==0)
{
    Console.WriteLine("является четным");
}
else
{
    Console.WriteLine("не является четным");
}
