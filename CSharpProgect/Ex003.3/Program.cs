//Задача 19
//Напишите метод, который принимает на вход пятизначное число и проверяет,
//является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Ведите пятизначное число");
int N = Convert.ToInt32(Console.ReadLine());
int n1 = N / 10000;
int polyndrom = N-n1*10000;
int n2 = (polyndrom) / 10000;
int n4 = ((polyndrom)/10)%10;
int n5 = N%10;
if(N < 10000 | N > 99999) Console.Write(" Введено не верное число");
else if(n1 == n5 || n2 == n4) Console.Write("Веденное число является полиндромом ");
else Console.Write("Данное число не является палиндромом");
   
