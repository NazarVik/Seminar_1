// Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8

Console.Clear();
Console.Write("введите число ");
int count =0;
int number =  int.Parse(Console.ReadLine());
if (number < 0) number = number * (-1);

while (number >= count)
{
    Console.WriteLine(count - number);
    count++;
}
count = number-1;
while (count >= 0)
{
    Console.WriteLine(number - count);
    count--;
}

