Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());


if (number > 100 && number < 999)

{
    number = (number / 10) % 10;
    Console.Write("Вторая цифра трехзначного числа: ");
    Console.WriteLine(number); 
}

else

{
    Console.WriteLine("Число не является трехзначным");
}
  


