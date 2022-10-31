
int day=new Random().Next(1,8);

if (day > 0 && day <= 5) 
{
    Console.WriteLine("Будний день "+ day);
}
if (day == 6 || day == 7) 
{
    Console.WriteLine("Выходной день "+ day);
}

