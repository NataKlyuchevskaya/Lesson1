// Задача 2: напишите программу, которая на вход принимает два числа 
//и выдает какое число большее, а какое меньшее 

void Zadacha2()
{
    int numberFirst = 3;
    int numberSecond = 9;

    if (numberFirst > numberSecond)
    {
    Console.WriteLine(numberFirst + "  больше чем  " +  numberSecond);
    }
    else if(numberFirst < numberSecond)
    {
    Console.WriteLine(numberSecond + " больше чем " + numberFirst);
    }
    else
    {
        Console.WriteLine("Числа равны");
    }
}


//Задача 4: Напишите программу, которая принимает на вход 
//три числа и выдаёт максимальное из этих чисел.
void Zadacha4()
{
    int numberFirst = 2;
    int numberSecond = 3;
    int numberThird = 7;
    int max = numberFirst;
    if (max < numberSecond)
    {
        max = numberSecond;
    }
    if (max < numberThird)
    {
        max = numberThird;
    }
    Console.WriteLine(max);
}


//Задача 6: Напишите программу, которая на вход принимает число и 
//выдаёт, является ли число чётным (делится ли оно на два без остатка).
void Zadacha6()
{
    int number = 11;
    if (number % 2 == 0) Console.WriteLine("число чётное");
    else Console.WriteLine("число нечётное");
}


//Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
void Zadacha8()
{
    int number = 8;
    int count = 1;
    while (count <= number)
    {
    if (count % 2 == 0) Console.WriteLine(count);
    count++;
    }

}

void Zadacha8_1()
{
    int number = 8;
    int count = 2;
    while (count <= number)
    {
    Console.WriteLine(count);
    count+= 2;
    }

}

void Zadacha8_2()
{
    int number = 8;
    for (int i = 1; i <=number; i++)
    {
     if (i % 2 == 0) Console.WriteLine(i);
   
    }

}


//Zadacha2();
//Zadacha4();
//Zadacha6();
//Zadacha8();
//Zadacha8_1();
Zadacha8_2();