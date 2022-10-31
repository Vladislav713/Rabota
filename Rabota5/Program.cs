//Console.WriteLine("Hello, World!");
Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
num /= 10;
num %= 10;
Console.WriteLine(num);


