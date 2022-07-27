//Задача 1. Написать программу, которая определяет, является ли треугольник со сторонами a, b, c равнобедренным.

void zadacha_01()
{
    //Координаты треугольника
    int A = 3;
    int B = 3;
    int C = 2;

    //Проверка сторон треугольника (если 2 стороны треугольника равны, то он равнобедренный)
    if(A == B)
    {
        Console.WriteLine("Гуд");
    }
    else if(B == C)
    {
        Console.WriteLine("Гуд");
    }
    else if(C == A)
    {
        Console.WriteLine("Гуд");
    }
    else
    {
        Console.WriteLine("Не Гуд");
    }
}

//zadacha_01();

void zadacha_2()
{
    Random random = new Random();
    int oneCount = random.Next(1, 11);
    int size = (int)Math.Pow(oneCount, 2);
    int[] array = new int[size];
    for (int i = 1; i <= oneCount; i++)
    {
        int pos = random.Next(0, size);
        if(array[pos] == 0)
        {
            array[pos] = 1;   
        }
        else
        {
            i--;
        }
    }   

    Console.WriteLine(oneCount);
    PrintArray(array);

    void PrintArray(int[] array0)
    {
        Console.Write("[");
        for (int i = 0; i < array0.Length; i++)
        {
            Console.Write(array0[i] + ", ");
        }
        Console.Write("\b\b]");
        Console.WriteLine();
    }
}

//zadacha_2();


//Задача 2. На вход подаются год, номер месяца и день рождения человека, 
//Определить возраст человека на момент 1 июля 2022 года.

void zadacha_02()
{
    int year = 2016;
    int month = 10;
    int day = 20;

    //Введение даты
    DateTime date = new DateTime (year, month, day);
    DateTime momentDate = new DateTime (2022, 7, 1);
    
    //Расчет даты
    int age = momentDate.Year - date.Year;
    if (date > momentDate.AddYears(-age)) age--;
    Console.WriteLine($"Возраст человека на 1 июля 2022 г.: {age}");
}

//zadacha_02();


//Задача 3. Иван в начале года открыл счет в банке, вложив 1000 руб. 
//Через каждый месяц размер вклада увеличивается на 1.5% от имеющейся суммы. 
//Определить размер депозита через n месяцев.

 void zadacha_03()
 {
    double vklad = 1000;
    int n = 2;
    //Цикл за каждый оборот увеличивает вклад на 1.5%
    for(int i = 0; i < n; i++)
    {
        vklad = vklad * 1.015;
    }
    Console.WriteLine(Math.Round(vklad, 2));
 }

 //zadacha_03();


//Задача 4. Дано натуральное число, в котором все цифры различны. 
//Определить, какая цифра расположена в нем левее: максимальная или минимальная.

void zadacha_04()
{
    int chislo = 23456;
    int perem = chislo / 10;
    int max = chislo % 10; //Присвоение последней цифры в переменную с максимальным числом 
    int min = chislo % 10; //Присвоение последней цифры в переменную с минимальным числом 
    int i = 1; //Индекс числа (Справа налево)
    int maxCor = 1; //Счетчик индекса максимального числа
    int minCor = 1; //Счетчик индекса минимального числа
    while(perem > 0)
    {
        i++;
        if(perem % 10 > max) //Условие проверяет последнее число с максимальным и записывает index
        {
            max = perem % 10;
            maxCor = i;
        }
        else if(perem % 10 < min) //Для определения индекса минимального числа
        {
            min = perem % 10;
            minCor = i;
        }
        perem = perem / 10;
    }

    if(maxCor > minCor) //Чем больше индекс, тем левее он находится
    {
        Console.WriteLine("Максимальное число левее"); 
    }
    else
    {
        Console.WriteLine("Минимальное число левee");
    }
}

//zadacha_04();