Console.Clear();
Console.Write("Введите первое число: ");
int number1=int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2=int.Parse(Console.ReadLine());
            if (number1 > number2)
            {
                Console.WriteLine("Первое число " + number1 + " больше чем второе " + number2);
            }
            else
            {
                Console.WriteLine("Второе число " + number2 + " больше чем первое " + number1);
            };