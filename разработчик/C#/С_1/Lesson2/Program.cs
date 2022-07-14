// напишите программу, которая выводит случайное число из отрезка [10, 99]
//и показывает наибольшу цифру числа

void Zadacha9()
{
    Random rand = new Random();
    int number = rand.Next();
    Console.WriteLine(number);
}

void Zadacha9_1()
{
    Random rand = new Random();
    for (int i = 0; i < 200; i++)
    {
    int number = rand.Next(10, 100);
    Console.WriteLine(number);
    }
}

void Zadacha9_2()
{
    Random rand = new Random();
    int number = rand.Next(10, 100);
    Console.WriteLine(number);
    
    int ones = number % 10; // 84 % 10 = 4
    int tens = number / 10; // 84 / 10 = 8
    //Console.WriteLine(ones);
    //Console.WriteLine(tens);

    if (ones > tens) Console.WriteLine(ones);
    else Console.WriteLine(tens);
}

//напишите программу, которая выводит случайное трехзначное число и удаляет
//второую цифру этого числа.

void Zadacha11_1()
{
    Random rand = new Random();
    int number = rand.Next(100, 1000);
    Console.WriteLine("number");
    int ones = number % 10;
    int tens = number / 10;
    int hundred = number / 100;
    Console.WriteLine("ones");
    Console.WriteLine("hundred");
}

void Zadacha11_2() //решение от студента
{
    Random rand = new Random();
    int number = rand.Next(100, 1000);
    Console.WriteLine("Случайное число");
    Console.WriteLine("number");
    int ones = number % 10;
    int tens = number / 10 % 10;
    int hundred = number / 100;

    int resultNumber = ones + hundred*10;
    Console.WriteLine("resultNumber");
}

//12. Напишите программу, которая будет принимать на вход два числа и
//выводить, является ли второе число кратным первому. Если число 2 не кратно
// числу 1, то программа выводит остаток от деления.



void Zadacha12_1()
{
    Console.WriteLine("Введите первое число");
    int a = Convert.ToInt32(Console.WriteLine());
    Console.WriteLine("Введите второе число");
    int b = Convert.ToInt32(Console.WriteLine());
    int div = b % a;

    if (div == 0) Console.WriteLine("Делится нацело");
    else
    {
        Console.WriteLine("остаток от деления: ");
        Console.WriteLine("div");
    }

}

//14.Напишите программу, которая принимает на вход число 
//и проверяет, кратно ли она одновременно 7 и 23.

void Zadacha14()
{
    /*
    int number = 5;
    //1 < number <10
    //number >1 и number <10 - это условия связанные через логические связки
    // "и" - обозначеется через and   или  && 
    if (number > 1 && number <10) 
    Console.WriteLine("число лежит в промежутке от 1 до 10");
    */
    Console.WriteLine("Введите число");
    int num = Convert.ToInt32(Console.ReadLine());
    if(num % 7 == 0)
    if(num % 23 ==0)
    Console.WriteLine("yes");
    else
    Console.WriteLine("no");
    else
    Console.WriteLine("no");
}

void Zadacha14_1()
{
    Console.WriteLine("Введите число");
    int a = Convert.ToInt32(Console.ReadLine());
    int div7 = a % 7;
    int div23 = a % 23;
    Console.WriteLine("div23");
    Console.WriteLine("div7");
    if (div23==0 && div7 == 0); 
    Console.WriteLine("Делится на 7 и 23");
    else 
    Console.WriteLine("Не делится на 7 и 23");

}

//Zadacha9();
//Zadacha9_1();
//Zadacha9_2();
//Zadacha11_1();
//Zadacha11_2();
//Zadacha12_1();
//Zadacha14();
Zadacha14_1();
