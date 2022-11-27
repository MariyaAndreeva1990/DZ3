/*Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53*/
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Ax = ReadInt("Введите координату x точки A: ");
int Ay = ReadInt("Введите координату y точки A: ");
int Az = ReadInt("Введите координату z точки A: ");

int Bx = ReadInt("Введите координату x точки B: ");
int By = ReadInt("Введите координату y точки B: ");
int Bz = ReadInt("Введите координату z точки B: ");

int sqrSideX = (Ax - Bx) * (Ax - Bx);
int sqrSideY = (Ay - By) * (Ay - By);
int sqrSideZ = (Az - Bz) * (Az - Bz);

double distance = Math.Sqrt(sqrSideX + sqrSideY + sqrSideZ);
Console.WriteLine($"Расстояние между двумя точками = {distance}");
