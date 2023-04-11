//Задача 1. Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли второе число кратным первому. 
//Если второе число не кратно числу первому, то программа выводит остаток от деления.

//34, 5 -> не кратно, остаток 4
//16, 4  -> кратно


Console.WriteLine("Введите первое число");
string a = Console.ReadLine();
int a = Convert.ToInt32(text_a);

Console.WriteLine("Введите второе число");
string b = Console.ReadLine();
int b = Convert.ToInt32(text_b);

if(a % b == 0)
{
    Console.WriteLine("кратно"); 
} 

else
{
    Console.WriteLine(a % b);
}

