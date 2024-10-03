namespace CurrencyConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandExit = "4";

            const string MenuDolar = "1";
            const string MenuEuro = "2";
            const string MenuRuble = "3";

            const string CommandToDolar = "1";
            const string CommandToEuro = "2";
            const string CommandToRuble = "3";

            bool isRunning = true;

            float dolarExchangeRate = 0.00680782f;
            float euroExchangeRate = 0.00616584f;
            float rubleExchangeRate = 0.656835f;

            float convertBuffer = 0;
            int numberForConvert = 0;

            float userDolars = 100;
            float userEuros = 100;
            float userRubles = 100;

            while (isRunning)
            {
                Console.Clear();

                Console.WriteLine("Состояние валют\n");
                Console.WriteLine($"Доллар: {userDolars}");
                Console.WriteLine($"Евро: {userEuros}");
                Console.WriteLine($"Рубль: {userRubles}");
                Console.WriteLine();

                Console.WriteLine($"{MenuDolar}) Конвертировать доллары");
                Console.WriteLine($"{MenuEuro}) Конвертировать евро");
                Console.WriteLine($"{MenuRuble}) Конвертировать рубли");
                Console.WriteLine($"{CommandExit}) Закрыть программу");
                string firstInput = Console.ReadLine();

                if (firstInput == CommandExit)
                {
                    isRunning = false;
                    continue;
                }

                bool isCorrectMenu = firstInput == MenuDolar ||
                                     firstInput == MenuEuro ||
                                     firstInput == MenuRuble;

                if (isCorrectMenu)
                {
                    Console.Clear();

                    Console.Write("Ведите число: ");
                    string numberFromUser = Console.ReadLine();

                    if (int.TryParse(numberFromUser, out numberForConvert))
                    {
                        float firstCurrencyCount = 0;

                        switch (firstInput)
                        {
                            case MenuDolar:
                                firstCurrencyCount = userDolars;
                                break;

                            case MenuEuro:
                                firstCurrencyCount = userEuros;
                                break;

                            case MenuRuble:
                                firstCurrencyCount = userRubles;
                                break;
                        }

                        if (numberForConvert <= firstCurrencyCount)
                        {
                            switch (firstInput)
                            {
                                case MenuDolar:
                                    userDolars -= numberForConvert;
                                    break;

                                case MenuEuro:
                                    userEuros -= numberForConvert;
                                    break;

                                case MenuRuble:
                                    userRubles -= numberForConvert;
                                    break;
                            }

                            convertBuffer = numberForConvert;

                            switch (firstInput)
                            {
                                case MenuDolar:
                                    convertBuffer /= dolarExchangeRate;
                                    break;

                                case MenuEuro:
                                    convertBuffer /= euroExchangeRate;
                                    break;

                                case MenuRuble:
                                    convertBuffer /= rubleExchangeRate;
                                    break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"\"{numberFromUser}\" не является числом");
                        Console.ReadKey();
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine($"Комманды \"{firstInput}\" не существует");
                    Console.ReadKey();
                    continue;
                }

                Console.WriteLine($"{CommandToDolar}) В доллары");
                Console.WriteLine($"{CommandToEuro}) В евро");
                Console.WriteLine($"{CommandToRuble}) В рубли");
                string secondInput = Console.ReadLine();

                isCorrectMenu = secondInput == CommandToDolar ||
                                secondInput == CommandToEuro ||
                                secondInput == CommandToRuble;

                if (isCorrectMenu)
                {
                    switch (secondInput)
                    {
                        case CommandToDolar:
                            convertBuffer *= dolarExchangeRate;
                            userDolars += convertBuffer;
                            break;

                        case CommandToEuro:
                            convertBuffer *= euroExchangeRate;
                            userEuros += convertBuffer;
                            break;

                        case CommandToRuble:
                            convertBuffer *= rubleExchangeRate;
                            userRubles += convertBuffer;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine($"Комманды \"{secondInput}\" не существует");
                    Console.ReadKey();
                    continue;
                }
            }
        }
    }
}
