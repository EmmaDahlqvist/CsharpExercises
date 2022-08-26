using System;

namespace CSharpRepetition
{
    class Program
    {
        public static void Main(string[] args)
        {

            ex27();
        }

        static void ex()
        {

        }

        static void ex27()
        {
            Console.WriteLine("Skriv ett nummer");
            int num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("Positivt!");
            } else if(num < 0)
            {
                Console.WriteLine("Negativt");
            } else
            {
                Console.WriteLine("noll");
            }
        }

        static void ex26()
        {
            Console.WriteLine("Skriv ett årtal");
            int num = int.Parse(Console.ReadLine());

            if (num < 1900)
            {
                Console.WriteLine("You're old!");
            } else
            {
                Console.WriteLine("You're young ;)");
            }
        }

        static void ex25()
        {
            Console.WriteLine("Skriv ett nummer");
            int num = int.Parse(Console.ReadLine());

            if (num == 1984)
            {
                Console.WriteLine("Orwell!");
            }
        }

        static void ex24()
        {
            Console.WriteLine("Skriv ett nummer");
            int num = int.Parse(Console.ReadLine());

            if(num > 120)
            {
                Console.WriteLine("Speeding!");
            }
        }

        static void ex23()
        {
            Console.WriteLine("Skriv ett nummer");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Skriv ett till nummer");
            double num2 = double.Parse(Console.ReadLine());

            double sum = (num1 + num2);
            double diff = num1 - num2;
            double quota = num1 / num2;
            double product = num1 * num2;

            Console.WriteLine($"{num1} + {num2} = {sum}");
            Console.WriteLine($"{num1} - {num2} = {diff}");
            Console.WriteLine($"{num1} / {num2} = {quota}");
            Console.WriteLine($"{num1} * {num2} = {product}");
        }

        static void ex22()
        {
            Console.WriteLine("Skriv ett nummer");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Skriv ett till nummer");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Skriv ett till nummer");
            double num3 = double.Parse(Console.ReadLine());

            double avarage = (num1 + num2 + num3) / 2;

            Console.WriteLine($"Medelvärdet av {num1}, {num2} och {num3} är {avarage}");
        }

        static void ex21()
        {
            Console.WriteLine("Skriv ett nummer");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Skriv ett till nummer");
            double num2 = double.Parse(Console.ReadLine());

            double avarage = (num1 + num2)/2;

            Console.WriteLine($"Medelvärdet av {num1} och {num2} är {avarage}");
        }

        static void ex20()
        {
            Console.WriteLine("Skriv ett nummer");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Skriv ett till nummer");
            int num2 = int.Parse(Console.ReadLine());

            int sum = num1 * num2;

            Console.WriteLine($"{num1} * {num2} = {sum}");
        }

        static void ex19()
        {
            Console.WriteLine("Skriv ett nummer");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Skriv ett till nummer");
            int num2 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;

            Console.WriteLine($"{num1} + {num2} = {sum}");
        }

        static void ex18()
        {
            Console.WriteLine("Skriv ett nummer");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Skriv ett till nummer");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Skriv ett till nummer");
            int num3 = int.Parse(Console.ReadLine());

            int sum = num1 + num2 + num3;

            Console.WriteLine("Summan blir: " + sum);
        }

        static void ex17()
        {
            Console.WriteLine("Skriv ett nummer");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Skriv ett till nummer");
            int num2 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;

            Console.WriteLine("Summan blir: " + sum);
        }

        static void ex16()
        {
            Console.WriteLine("Skriv in ett antal dagar");
            int days = int.Parse(Console.ReadLine());

            int seconds = days * 24 * 60 * 60;
            Console.WriteLine($"{days}d är {seconds}s");
        }

        static void ex15()
        {
            Console.WriteLine("Skriv ett heltal");
            int getInt = int.Parse(Console.ReadLine());

            Console.WriteLine("Skriv en bool");
            bool getBool = bool.Parse(Console.ReadLine());

            Console.WriteLine("Skriv ett decimaltal");
            double getDouble = double.Parse(Console.ReadLine());
            
            Console.WriteLine($"Du skrev nummer {getInt}" +
                $"\nDu skrev bool {getBool}" +
                $"\nDu skrev decimaltalet {getDouble}");
        }

        static void ex14()
        {
            try{
                Console.WriteLine("Skriv en boolean");
                bool input = bool.Parse(Console.ReadLine());
                Console.WriteLine(input);
            } catch(Exception e)
            {
                Console.WriteLine("något gick fel");
            };
        }

        static void ex13()
        {
            Console.WriteLine("Skriv ett nummer");
            double number = double.Parse(Console.ReadLine());
            Console.WriteLine("Du skrev nummer " + number);
        }

        static void ex12()
        {
            Console.WriteLine("Skriv ett nummer");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Du skrev nummer " + number);
        }

        static void ex11()
        {
            int days = 200;
            double hours = 3.5;
            string coding = "It sure is!";
            Console.WriteLine("Days to summer:");
            Console.WriteLine(days);
            Console.WriteLine("Hours to lunch:");
            Console.WriteLine(hours);
            Console.WriteLine("Coding is fun:");
            Console.WriteLine(coding);
        }

        static void ex10()
        {
            string animal;
            string age;
            string food;
            
            Console.WriteLine("Nämn ett djur");
            animal = Console.ReadLine();

            Console.WriteLine("Skriv en ålder");
            age = Console.ReadLine();

            Console.WriteLine("Nämn en maträtt");
            food = Console.ReadLine();

            Console.WriteLine($"Det var en gång en {animal} som var {age} år gammal. {animal}ens favoritmat var {food}");
        }

        static void ex9()
        {
            Console.WriteLine("I restaurangen...");
            Console.WriteLine("Hej vad får det lov att vara?");
            string order = Console.ReadLine();
            Console.WriteLine("Okej en " + order + ". Något annat?");
            string order2 = Console.ReadLine();
            Console.WriteLine("Okej 15 minuter!");
        }

        static void ex8()
        {
            Console.WriteLine("HEj vad heter du?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hej {name}!");
        }

        static void ex7()
        {
            Console.WriteLine("Skriv in ett ord");
            string word = Console.ReadLine();
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(word);
            }
        }

        static void ex6()
        {
            Console.WriteLine("Skriv in ditt namn");
            string name = Console.ReadLine();
            Console.WriteLine("Hej " + name);
        }

        static void ex5()
        {
            string name = "Ada Lovelace";
            Console.WriteLine("Hej " + name);
        }

        static void ex4()
        {
            string text = "Trip and food!";
            text = "live and sleep!";
            Console.WriteLine(text);
        }

    }
}
