//4.57. Плотников Кирилл Андреевич 22-ИСП-2/2
//Дано трехзначное число. Определить:а)входит ли в него цифра 6;б)входит ли в него цифра n.
try
{
    {
        Console.WriteLine("Введите числo");//a
        int num = Convert.ToInt32(Console.ReadLine());
    int n = 6;
    bool flag = false;
        while (num > 0)
        {
            int m = num % 10;
            if (m == n)
            {
                flag = true;
            }
            num = num / 10;
        }
        if (flag)
        {
            Console.WriteLine("есть");
        }
        else
        {
            Console.WriteLine("нет");
        }
    }
{
    Console.WriteLine("Введите числo");//b
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("n=");
    int n = Convert.ToInt32(Console.ReadLine());
    bool flag = false;
    while (num > 0)
    {
        int m = num % 10;
        if (m == n)
        {
            flag = true;
        }
        num = num / 10;
    }
    if (flag)
    {
        Console.WriteLine("есть");
    }
    else
    {
        Console.WriteLine("нет");
    }
}
}
catch (Exception ex)
{ Console.WriteLine(ex.ToString()); }