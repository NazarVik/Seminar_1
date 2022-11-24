Console.Clear();
int randomDigit = new Random().Next(10, 100);
Console.WriteLine("Случайное число: " + randomDigit);

int ostatok = randomDigit % 10;
Console.WriteLine("Последняя цифра: " + ostatok);

 int firstDigit = randomDigit / 10;
 Console.WriteLine("Первая цифра " + firstDigit);

 int max - firstDigit;

 if (ostatok > firstDigit)
    max = ostatok;
