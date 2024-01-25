using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

static void sum1 (double n)
{
    double a = 0;
    for (int i = 1; i <= n; i++)
        a += Math.Pow(-1, i) / (2 * i + 1);
    Console.WriteLine($"a = {a}");
}

static void sum2(double n)
{
    double b = 0;
    for (int i = 1; i <= n; i++)
        b += 1 + 1.0 / (i * i);
    Console.WriteLine($"b = {b}");
}

static void sum3(double n)
{
    int sum = 0;
    int dob = 1;
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