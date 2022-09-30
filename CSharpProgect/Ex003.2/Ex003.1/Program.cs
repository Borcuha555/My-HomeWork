Console.WriteLine("Ведите число и я возведу его в квадрат");
int number = Convert.ToInt32(Console.ReadLine());
int cube = number + 1;
int index = 1;
while(index < cube)
{
    int rezalt = index * index * index;
    Console.WriteLine(rezalt);
    index++;
}
