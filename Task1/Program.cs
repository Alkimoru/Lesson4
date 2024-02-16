using System.ComponentModel;

while (true)
{
    Console.Write("Введите число или 'q' для выхода: ");
    string input = Console.ReadLine();
    if (input == "q")
        {
        break;
        }
    int number;
    if(int.TryParse(input, out number))
    {
        int sum = 0;
        while(number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        if (sum % 2 == 0)
        {
            Console.Write("[STOP]");
            break;
        }
    }
    else
    {
        Console.WriteLine("Некорректный ввод");
    }
}