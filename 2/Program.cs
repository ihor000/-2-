Console.WriteLine("Ввидите число:");
int number = Convert.ToInt32(Console.ReadLine());
int result = -1;

{
    
    if (number >= 100)
    {
        while (number > 999)
        {
            number = number / 10;
        }
        result = number % 10;
    Console.WriteLine(result);
    }
   else
   {
    Console.WriteLine("Введено не верное число");
   }
}









