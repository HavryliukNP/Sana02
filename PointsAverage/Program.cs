Console.WriteLine("Введіть 5 оцінок за 100-бальною шкалою");

int sum = 0;

for (int i = 0; i < 5; i++)
{
    int a = int.Parse(Console.ReadLine());
    sum += a;
}
if((sum / 5)>=50)
    Console.WriteLine("Студент отримує допуск");
else Console.WriteLine("Студент не отримує допуск");

