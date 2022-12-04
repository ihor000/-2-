Console.WriteLine("Ввидите число:");
int number = Convert.ToInt32(Console.ReadLine());
int number1;
int number2;


if (number > 100) 
{
    number1 = number;
            number = number % 10;
    Console.WriteLine(number);    
}


else
{
   Console.WriteLine("Введено не верное число");
}


