//Задача 1. Рассчитать значение y при заданном x по формуле
// при х > 0, y = sin ^ 2 (x)
// иначе, y = 1 - 2 * sin (x ^ 2)

void zadacha_1()
{
    Double x = 5;
    if(x>0)
    {
        x = (1 - Math.Cos(2 * x)) / 2; //sin ^ 2 (x) разложена по формуле
    }
    else
    {
        x = 1 - 2 * Math.Sin(x * x); 
    }
    Console.WriteLine(Math.Round(x, 2));
}

//zadacha_1();

//Задача 2. Дано трёхзначное число N. Определить кратна ли трём сумма всех его цифр.

void zadacha_2()
{
    int n = 254;
    int i = 0;
    int sum = 0;
    while(n>0)
    {
        sum = sum + n % 10;
        n = n / 10;
    }
    
    if(sum % 3 == 0)
    {
        Console.WriteLine("Сумма цифр кратна 3");
    }
    else
    {
        Console.WriteLine("Сумма цифр не кратна 3");
    }
}

//zadacha_2();

//Задача 3. Дано трёхзначное число N. Определить, есть ли среди его цифр 4 или 7.

void zadacha_3()
{
    int n = 423;
    int g = 0;
    while(n > 0)
    {
        if(n % 10 == 4)
        {
            g = 1;
        }
        else if(n % 10 == 7)
        {
            g = 1;
        }
        n = n / 10;
    }

    if(g == 1)
    {
        Console.WriteLine("В числе есть 4 или 7");
    }
    else
    {
        Console.WriteLine("В числе нет 4 или 7");
    }
}

zadacha_3();