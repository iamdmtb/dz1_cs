Console.WriteLine("Введите два числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (b==a)
  Console.WriteLine("числа равны");
else if(b > a)
  Console.WriteLine("{0} наибольшее ", b);
else
  Console.WriteLine("{0} наибольшее ", a);
