Console.WriteLine("Введите трех значное число: ");
int number = Convert.ToInt32(Console.ReadLine());


if (number >= 100)

{
    number = (number / 10) % 10;

    Console.Write("Вторая цифра трех значного числа: ");
    Console.WriteLine(number); 
}

else

{
    Console.WriteLine("Число не является трех значным");
}
  


