using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

static void sum1 (double n)
{
    double a = 0;
    for (int i = 0; i < n; i++)
        a += Math.Pow(-1, n) / (2 * n + 1);
    Console.WriteLine($"a = {a}");
}

static void sum2(double n)
{
    double b = 0;
    for (int i = 0; i < n; i++)
        b += 1 + (1 / Math.Pow(n, 2));
    Console.WriteLine($"b = {b}");
}

static void sum3(double n)
{
    double sum = 0;
    double dob = 1;
    for(int j = 1; j <= n; j++) { 
        dob *= j;
        sum += dob;
    }
    Console.WriteLine($"c = {sum}");
}

Console.WriteLine("Введіть n: ");
int n = int.Parse(Console.ReadLine());
sum1(n);
sum2(n);
sum3(n);