namespace CurrencyConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
                string firstCurrency = Console.ReadLine();

                bool isCorrectMenu = firstCurrency == MenuDolar ||
                                     firstCurrency == MenuEuro ||
                                     firstCurrency == MenuRuble;

                if (isCorrectMenu)
                {
                    Console.Clear();

                    Console.Write("Ведите число: ");
                    string numberFromUser = Console.ReadLine();

                    if (int.TryParse(numberFromUser, out numberForConvert))
                    {
                        float firstCurrencyCount = 0;

                        switch (firstCurrency)
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
                            switch (firstCurrency)
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

                            switch (firstCurrency)
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
                    Console.WriteLine($"Комманды \"{firstCurrency}\" не существует");
                    Console.ReadKey();
                    continue;
                }

                Console.WriteLine($"{CommandToDolar}) В доллары");
                Console.WriteLine($"{CommandToEuro}) В евро");
                Console.WriteLine($"{CommandToRuble}) В рубли");
                string secondCurrency = Console.ReadLine();

                isCorrectMenu = secondCurrency == CommandToDolar ||
                                secondCurrency == CommandToEuro ||
                                secondCurrency == CommandToRuble;

                if (isCorrectMenu)
                {
                    switch (secondCurrency)
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
                    Console.WriteLine($"Комманды \"{secondCurrency}\" не существует");
                    Console.ReadKey();
                    continue;
                }
            }
        }
    }
}
