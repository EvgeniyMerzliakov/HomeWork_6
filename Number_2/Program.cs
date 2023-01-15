// задача 40 - HARD необязательная. На вход программы подаются три целых положительных числа. Определить , является ли это сторонами треугольника. 
// Если да, то вывести всю информацию по нему - площадь, периметр, значения углов треугольника в градусах, является ли он прямоугольным, равнобедренным, равносторонним.


void FillArray(int[] col)
{
    Console.WriteLine("Введите 3 целых положительных числа");
    for (int i = 0; i < col.Length; i++)
        col[i] = Convert.ToInt32(Console.ReadLine());
}


void Searching_P_S_Angle(int[] col)
{
    double a = col[0];
    double b = col[1];
    double c = col[2];

    double P = a + b + c;
    double p = P / 2;
    double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

    double ang1 = (a*a + c*c - b*b) / (2 *a*c);
    double angle1 = Math.Acos(ang1) * (180.0 / Math.PI);

    double ang2 = (a*a + b*b - c*c) / (2 *a*b);
    double angle2 = Math.Acos(ang2) * (180.0 / Math.PI);

    double ang3 = (b*b + c*c - a*a) / (2 *b*c);
    double angle3 = Math.Acos(ang3) * (180.0 / Math.PI);
    Console.WriteLine($"Площадь = {Math.Round(S, 2)}, периметр = {P}, первый угол = {Math.Round(angle1, 2)}, второй угол = {Math.Round(angle2, 2)}, третий угол = {Math.Round(angle3, 2)}");

    if (angle1 == 90 || angle2 == 90 || angle3 == 90)
        Console.WriteLine("Треугольник является прямоугольным");

    if (a == b && b == c)
        Console.WriteLine("Треугольник является равносторонним");
    else if (a == b || a == c || b == c)
        Console.WriteLine("Треугольник является равнобедренным");

}




int[] array = new int[3];

FillArray(array);
if (array[0] + array[1] > array[2] && array[0] + array[2] > array[1] && array[1] + array[2] > array[0])
    {
        Searching_P_S_Angle(array);
    }
else Console.WriteLine("С такими сторонами треугольника не существует");