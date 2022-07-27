void zadacha_1()
{
    Console.WriteLine("Число");
    int i = Convert.ToInt32(Console.ReadLine());

    for(int j = 0; j < i; j++)
    {
        Console.WriteLine(1);
    }
}

//zadacha_1();

void zadacha_2()
{
    int a = 2;
    int b = 3;
    Console.WriteLine(b / a);
}

//zadacha_2();

void zadacha_3()
{
    int one = 183;
    int two = 178;
    int three = 180;

    int[] masChisl = {one, two, three};
    for(int i = 0; i < masChisl.Length; i++)
    {
        for(int j = 0; j < i; j++)
        {
            if(masChisl[j] < masChisl[j+1])
            {
                int gr = masChisl[j];
                masChisl[j] = masChisl[j+1];
                masChisl[j+1] = gr;
            }
        }
    }

    for(int i = 0; i < masChisl.Length; i++)
    {
        Console.WriteLine(masChisl[i]);
    }
}

//zadacha_3();

void zadacha_4()
{
    int i = 72334;
    Console.WriteLine((i/3600) + ":" + ((i%3600)/60) + ":" + ((i%3600)%60));
}
//zadacha_4();