Console.WriteLine("Введите три числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
if (a>b)
    if (a>c)
        Console.WriteLine("{0} наибольшее ", a);
    else
        Console.WriteLine("{0} наибольшее ", c);
else 
    if (b>c)
        Console.WriteLine("{0} наибольшее ", b);
    else
        Console.WriteLine("{0} наибольшее ", c);
