Console.WriteLine("Привет! Введи интервал чисел и количество попыток, я загадаю число из этого интервала, а тебе нужно будет его угадать");

Console.WriteLine("Введи начало интервала: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи конец интервала: ");
int max = Convert.ToInt32(Console.ReadLine());

double Chance()
{
    double distance = max - min;
    return Convert.ToInt32(Math.Log(distance, 2));
}
Console.WriteLine($"Количество твоих попыток: {Chance()}");

int SecretNumber = new Random().Next(min, max);

int AskNumber()
{
    Console.WriteLine("Bведи свое предположение: ");
    int PlayerNumber = Convert.ToInt32(Console.ReadLine());
    return PlayerNumber;
}

bool MakeMove()
{
    double count = Chance();
    bool res = false;
    while (res == false && count > 0)
    {
        int PlayerNumber = AskNumber();
        if (PlayerNumber > SecretNumber)
        {
            Console.WriteLine("Загаданное число меньше введенного");
            count--;
            Console.WriteLine($"Попытки: {count}");
        }
        else if (PlayerNumber < SecretNumber)
        {
            Console.WriteLine("Загаданное число больше введенного");
            count--;
            Console.WriteLine($"Попытки: {count}");
        }
        else
        {
            res = true;
        }
    }
    return res;
}

string GameOver()
{
    if (MakeMove() == true) return "Победа!";
    else return "К сожалению, ты проиграл";
}
Console.WriteLine(GameOver());


