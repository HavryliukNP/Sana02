using System.Text;
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

Console.WriteLine("Розв’язання квадратного рівняння (ax^2 + bx + c = 0)");

Console.WriteLine("Введіть a:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введіть b:");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введіть c:");
int c = int.Parse(Console.ReadLine());

double D, x1, x2;

D = Math.Pow(b, 2) - 4 * a * c;
Console.WriteLine($"D = {D}");

if (D == 0) 
{ 
    x1 = -b / (2 * a);
    Console.WriteLine($"x = {x1}");
}
else if (D > 0)
{
    x1 = (-b + Math.Sqrt(D))/ (2 * a);
    Console.WriteLine($"x1 = {x1}");
    x2 = (-b - Math.Sqrt(D)) / (2 * a);
    Console.WriteLine($"x2 = {x2}");
}else Console.WriteLine("Розв’язків немає");
