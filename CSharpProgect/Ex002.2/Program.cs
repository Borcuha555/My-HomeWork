//Задача 15: Напишите программу, которая принимает 
//на вход цифру, обозначающую день недели, и проверяет,
//является ли этот день выходным.


Console.Write("Введите цифру, обозначающую день недели: ");
string namber = Console.ReadLine();

if(namber.ToLower() == "6" || namber.ToLower() == "7")
{
    Console.WriteLine("да");
}
else
{
    Console.Write("нет");
    Console.WriteLine(namber);
}
