
/*
Задача 6
Console.WriteLine("Введите число : ");
int a = Convert.ToInt32(Console.Read());
    if (a % 2 == 0) Console.WriteLine("Четное");
    else Console.WriteLine("Нечетное");
    Console.ReadKey();
*/

/*
Задача 2
var n1 = Convert.ToInt32(Console.ReadLine());
    var n2 = Convert.ToInt32(Console.ReadLine());
    if (n1 > n2)
        Console.WriteLine(n1);
    else 
        Console.WriteLine(n2);
*/


/*
Задача 8
Console.Write("Введите число 1: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int m = int.Parse(Console.ReadLine());
for (int i = 1; i <= m; i++)
{
    if (i % 2 == 0) 
    {
        Console.Write(i + " ");
    }
}

*/

/*
Задача 4
Console.Write("Введите первое число: ");
string inputA = Console.ReadLine();
Console.Write("Введите второе число: ");
string inputB = Console.ReadLine();
Console.Write("Введите третье число: ");
string inputC = Console.ReadLine();
int a = Convert.ToInt32(inputA);
int b = Convert.ToInt32(inputB);
int c = Convert.ToInt32(inputC);
int max = a;
if (max < b)
{
    max = b;
}
if (max < c)
{
    max = c;
}
Console.WriteLine("Максимальное число: " + max);
