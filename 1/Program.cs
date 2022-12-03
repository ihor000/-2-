Console.WriteLine("Введите трех значное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int secondNumber = (number /10) % 10; 

Console.WriteLine(secondNumber);