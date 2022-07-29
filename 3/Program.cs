//Задача 1. Рассчитать значение y при заданном x по формуле
// при х > 0, y = sin ^ 2 (x)
// иначе, y = 1 - 2 * sin (x ^ 2)

void Zadacha_1()
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

//Zadacha_1();

//Задача 2. Дано трёхзначное число N. Определить кратна ли трём сумма всех его цифр.

void Zadacha_2()
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

//Zadacha_2();

//Задача 3. Дано трёхзначное число N. Определить, есть ли среди его цифр 4 или 7.

void Zadacha_3()
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

//Zadacha_3();

//Задача 4. Дан массив длиной 10 элементов. Заполнить его последовательно числами от 1 до 10.

void Zadacha_4()
{
    int[] massive = new int[10];
    for(int i = 0; i < 10; i++)
    {
        massive[i] = i + 1;
    }

    for(int i = 0; i < 10; i++)
    {
        Console.WriteLine(massive[i]);
    }
}

//Zadacha_4();

//Задачи повышенной сложности:
//Задача 1. На ввод подаётся номер четверти. Создаются 3 случайные точки в этой четверти. 
//Определите самый оптимальный маршрут для торгового менеджера, который выезжает из центра координат.

void Zadacha_11()
{
    int chetv = 1;
    int countPoint = 3;
    int[] radius = {0, 0};
    double[,] point = new double[countPoint, 2];
    Random rand = new Random();
    
    // Метод записывает значения в двумерный массив 
    double[,] CorPoint(double[,] mass, int count, int chet)
    {
        for(int i = 0; i < count; i++)
        {
            if(chet == 1)
            {
                mass[i, 0] = rand.Next(1, 10);
                mass[i, 1] = rand.Next(1, 10);
            }
            else if(chet == 2)
            {
                mass[i, 0] = rand.Next(1, 10) * -1;
                mass[i, 1] = rand.Next(1, 10);
            }
            else if(chet == 3)
            {
                mass[i, 0] = rand.Next(1, 10) * -1;
                mass[i, 1] = rand.Next(1, 10) * -1;
            }
            else if(chet == 4)
            {
                mass[i, 0] = rand.Next(1, 10);
                mass[i, 1] = rand.Next(1, 10) * -1;
            }
        }
        return mass;
    }

    point = CorPoint(point, countPoint, chetv); //Присвоение значений массиву

    Console.WriteLine(point[0,0] + " " + point[0,1] + " " + point[1,0] + " " + 
    point[1,1] + " " + point[2,0] + " " + point[2,1] + " " /*+ firstMass[0,0] + " " + firstMass[0,1] + 
    " " + firstMass[1,0] + " " +firstMass[1,1] + " " + firstInd + " " + secondInd*/);
    
    //Поиск расстояния по теореме Пифагора
    double radPoint(double[,] array,int pointInd)
    {
        return Math.Sqrt(array[pointInd, 0] * array[pointInd, 0] + array[pointInd, 1] * array[pointInd, 1]);
    }

    //Выводит индекс ближайшей точки
    double MinRad(double[,] array)
    {
        double min = radPoint(array, 0);
        int minInd = 0;
        for(int i = 0; i < array.Length / 2; i++)
        {
            if(radPoint(array, i) < min)
            {
                min = radPoint(array, i);
                minInd = i;
            }
        }
        return minInd;
    }
    




    /*
    //Отнимает от координат точек заданные значения (смещаю центр координат к предыдущей точке)
    double[,] MasPath(double[,] array, double xCorOfPoint, double yCorOfPoint)
    {
        array = new double[3,2];
        for(int i = 0; i < 3; i++)
        {
            array[i, 0] = array[i, 0] - xCorOfPoint;
            array[i, 1] = array[i, 1] - yCorOfPoint;
            
        }
        return array;
    }

    double firstInd = MinRad(point); 

    Console.WriteLine(firstInd);

    int n = 0;
    int b = 0;
    double[,] firstMass = new double[2, 2];

    //Записваю данные в новый массив firstMass
    while(n < 2)
    {
        for(int i = 0; i < 2; i++)
        {
            if(n != firstInd)
            {
                firstMass[n, i] = point[b, i];
                b++;
            }
        }
        n++;
        b = b/2;
        Console.WriteLine("Число" + " " + b);
    }

    Console.WriteLine("Мак " + firstMass[0,0] + " " + firstMass[0,1] + " " + firstMass[1,0] + " " + firstMass[1,1]);

    firstMass = MasPath(firstMass, point[Convert.ToInt32(firstInd), 0], point[Convert.ToInt32(firstInd), 1]);   
    
    double secondInd = MinRad(firstMass);

    //
    if(firstInd == 1 && secondInd == 1)
    {
        secondInd = secondInd + 1;
    }
    else if(firstInd == 0)
    {
        secondInd = secondInd + 1;
    }

    double endInd = 3 - secondInd - firstInd;

    Console.WriteLine(firstInd + " " + secondInd + " " + endInd);



    Console.WriteLine(point[0,0] + " " + point[0,1] + " " + point[1,0] + " " + 
    point[1,1] + " " + point[2,0] + " " + point[2,1] + " " + firstMass[0,0] + " " + firstMass[0,1] + 
    " " + firstMass[1,0] + " " +firstMass[1,1] + " " + firstInd + " " + secondInd);
    */
}

Zadacha_11();
