Console.WriteLine("Введите число");
double num = Convert.ToInt32(Console.ReadLine());
double sum = num % 2;
if (sum == 0)
    Console.WriteLine($"число {num} четное");
else 
    Console.WriteLine($"число {num} нечетное");
