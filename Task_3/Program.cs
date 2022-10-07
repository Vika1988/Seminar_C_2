/* Написать программу, которая будет принимать на вход два числа и выявлять является ли второе число кратным первому.
Если чило не является кратным, то программа выводит остаток от деления*/
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
int res = (a % b);
if(res == 0){
    Console.WriteLine($"Число {b} кратно числу {a} ");
}
else
{
    Console.WriteLine($"Второе Число не кратно первому, остаток {res}");
}