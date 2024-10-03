namespace CurrencyConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandExit = "7";

            const string CommandDolarToEuro = "1";
            const string CommandDolarToRubles = "2";
            const string CommandEuroToDolar = "3";
            const string CommandEuroToRubles = "4";
            const string CommandRublesToDolar = "5";
            const string CommandRublesToEuro = "6";


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

                Console.WriteLine("Конвертировать:");
                Console.WriteLine($"{CommandDolarToEuro}) Доллары в евро");
                Console.WriteLine($"{CommandDolarToRubles}) Долары в рубли");
                Console.WriteLine($"{CommandEuroToDolar}) Евро в доллары");
                Console.WriteLine($"{CommandEuroToRubles}) Евро в рубли");
                Console.WriteLine($"{CommandRublesToDolar}) Рубли в долары");
                Console.WriteLine($"{CommandRublesToEuro}) Рубли в евро");
                Console.WriteLine($"{CommandExit}) Закрыть программу");
                string firstInput = Console.ReadLine();
                string numberFromUser = string.Empty;

                switch (firstInput)
                {
                    default:
                        Console.WriteLine($"Комманды \"{firstInput}\" не существует");
                        Console.ReadKey();
                        break;

                    case CommandDolarToEuro:
                        Console.Write("Ведите число: ");
                        numberFromUser = Console.ReadLine();

                        if (int.TryParse(numberFromUser, out numberForConvert))
                        {
                            if (numberForConvert <= userDolars)
                            {
                                userDolars -= numberForConvert;
                                convertBuffer = numberForConvert;
                                convertBuffer /= dolarExchangeRate;
                                convertBuffer *= euroExchangeRate;
                                userEuros += convertBuffer;
                            }
                        }
                        else
                        {
                            Console.WriteLine($"\"{numberFromUser}\" не является числом");
                            Console.ReadKey();
                        }
                        break;

                    case CommandDolarToRubles:
                        Console.Write("Ведите число: ");
                        numberFromUser = Console.ReadLine();

                        if (int.TryParse(numberFromUser, out numberForConvert))
                        {
                            if (numberForConvert <= userDolars)
                            {
                                userDolars -= numberForConvert;
                                convertBuffer = numberForConvert;
                                convertBuffer /= dolarExchangeRate;
                                convertBuffer *= rubleExchangeRate;
                                userRubles += convertBuffer;
                            }
                        }
                        else
                        {
                            Console.WriteLine($"\"{numberFromUser}\" не является числом");
                            Console.ReadKey();
                        }
                        break;

                    case CommandEuroToDolar:
                        Console.Write("Ведите число: ");
                        numberFromUser = Console.ReadLine();

                        if (int.TryParse(numberFromUser, out numberForConvert))
                        {
                            if (numberForConvert <= userDolars)
                            {
                                userEuros -= numberForConvert;
                                convertBuffer = numberForConvert;
                                convertBuffer /= euroExchangeRate;
                                convertBuffer *= dolarExchangeRate;
                                userDolars += convertBuffer;
                            }
                        }
                        else
                        {
                            Console.WriteLine($"\"{numberFromUser}\" не является числом");
                            Console.ReadKey();
                        }
                        break;

                    case CommandEuroToRubles:
                        Console.Write("Ведите число: ");
                        numberFromUser = Console.ReadLine();

                        if (int.TryParse(numberFromUser, out numberForConvert))
                        {
                            if (numberForConvert <= userDolars)
                            {
                                userEuros -= numberForConvert;
                                convertBuffer = numberForConvert;
                                convertBuffer /= euroExchangeRate;
                                convertBuffer *= rubleExchangeRate;
                                userRubles += convertBuffer;
                            }
                        }
                        else
                        {
                            Console.WriteLine($"\"{numberFromUser}\" не является числом");
                            Console.ReadKey();
                        }
                        break;

                    case CommandRublesToDolar:
                        Console.Write("Ведите число: ");
                        numberFromUser = Console.ReadLine();

                        if (int.TryParse(numberFromUser, out numberForConvert))
                        {
                            if (numberForConvert <= userDolars)
                            {
                                userRubles -= numberForConvert;
                                convertBuffer = numberForConvert;
                                convertBuffer /= rubleExchangeRate;
                                convertBuffer *= dolarExchangeRate;
                                userDolars += convertBuffer;
                            }
                        }
                        else
                        {
                            Console.WriteLine($"\"{numberFromUser}\" не является числом");
                            Console.ReadKey();
                        }
                        break;

                    case CommandRublesToEuro:
                        Console.Write("Ведите число: ");
                        numberFromUser = Console.ReadLine();

                        if (int.TryParse(numberFromUser, out numberForConvert))
                        {
                            if (numberForConvert <= userDolars)
                            {
                                userRubles -= numberForConvert;
                                convertBuffer = numberForConvert;
                                convertBuffer /= rubleExchangeRate;
                                convertBuffer *= euroExchangeRate;
                                userEuros += convertBuffer;
                            }
                        }
                        else
                        {
                            Console.WriteLine($"\"{numberFromUser}\" не является числом");
                            Console.ReadKey();
                        }
                        break;
                }
            }
        }
    }
}
