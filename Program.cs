//Задача 1. Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли второе число кратным первому. 
//Если второе число не кратно числу первому, то программа выводит остаток от деления.

//34, 5 -> не кратно, остаток 4
//16, 4  -> кратно

//Console.WriteLine("Введите число1");
//string text_a = Console.ReadLine();
//int a = Convert.ToInt32(text_a);

//Console.WriteLine("Введите число2");
//string text_b = Console.ReadLine();
//int b = Convert.ToInt32(text_b);

//int ostatok = a % b;
//if(ostatok == 0)
//{
//    Console.WriteLine("кратно");
//}

//else 
//{
//    Console.WriteLine(a % b);
//}


//Задача 2. Напишите программу, которая принимает на вход число и проверяет, 
//кратно ли оно одновременно 7 и 23.

//14  ->  нет
//46  ->  нет
//161 ->  да


Console.WriteLine("Введите число1");
string text_a = Console.ReadLine();
int a = Convert.ToInt32(text_a);

if (a % 7 == 0 && a % 23 ==0)
{
    Console.Write("число кратно 7 и 23");
}

else
{
    Console.Write("не кратно");
}