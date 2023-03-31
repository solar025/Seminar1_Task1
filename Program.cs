//Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Укажите число ");
string value;
value = Console.ReadLine();
int numberA = Convert.ToInt32(value);

Console.Write("Укажите число ");
string value2;
value2 = Console.ReadLine();
int numberB = Convert.ToInt32(value2);
if (numberA < numberB)
{
    System.Console.WriteLine(numberB);
}
else
{
    System.Console.WriteLine(numberA);
}
if (numberA == numberB)
{
    System.Console.WriteLine("Числа равны");
}