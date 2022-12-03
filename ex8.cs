Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
//int i = 1;
for (int i = 1; i < num+1; i++)
{
    int sum = i % 2;
    if (sum == 0)
        Console.Write($"{i} ");
}
//while (i<num+1)
//{
//    int sum = i % 2;
//    if (sum == 0)
//        Console.Write($"{i} ");
//        i++;
//}
Console.WriteLine();
