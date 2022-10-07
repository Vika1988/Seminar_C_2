/*Напишите программу, которая на вход принимает 2 числа и проверяет является ли одно число квадратом другого*/
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
if(a / b == b || b / a == a){
    Console.WriteLine("Одно число является квадратом другого");
}
else{
    Console.WriteLine("Ни одно из чисел не является квадратом другого");
}
