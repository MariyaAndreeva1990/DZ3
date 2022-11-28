/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да*/
while (true)
{
int Read(string message)
{
Console.WriteLine(message);
return Convert.ToInt32(Console.ReadLine());
}

int number = Read ("Введите пятизначное число: ");
int number1 = number/10000;
int number2 = (number/1000) % 10;
int number3 = (number/10) % 10;
int number4 = number % 10;
int count = 0; 
while (number > 0)
{
    number /= 10;
    count++;
}

if (count != 5)
{
    Console.WriteLine("Введено не пятизначное число!");
    continue;
}
if (number1 == number4 && number2 == number3)
{
     Console.Write("Число является палиндромом");
}
else
{
    Console.Write("Число не является палиндромом");
}
break;
}