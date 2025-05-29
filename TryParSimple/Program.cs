using System.Text;

Console.OutputEncoding = Ecoding.UTF8;
int n = -1;
while(n<0)
{
    Console.WriteLine("nhap N >=0:");
    String s = Console.ReadLine();
    if(int.TryParse(s,out n)==false)
    {
        Console.WriteLine("ban phai nhap so");

    }
    else
    {
        if (n<0)
        {
            Console.WriteLine("ban phai nhap n>=0");
        }
    }
    int gt = 1;
    for (int i = 1; i <= n; i++)
        gt *= i;
    Console.WriteLine($"{n}!={gt}");

   