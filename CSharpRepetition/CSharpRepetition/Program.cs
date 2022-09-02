using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace CSharpRepetition
{
    class Program
    {
        public static void Main(string[] args)
        {
            Utmaning();
        }

        static void Utmaning()
        {
            List<int> numbers = new List<int>(); //lista med nummer
            Console.WriteLine("Skriv in nummer, skriv avrbyt när du är klar:");
            while (true) 
            {
                try{ //ifall man skriver annat än siffra avbryts loopen
                    int num = int.Parse(Console.ReadLine());
                    numbers.Add(num);
                }catch(Exception e)
                {
                    Console.WriteLine("Avbröts");
                    break;
                }
            }

            //temporär int där nummer sparas och byts ut
            int temp;

            //sortera
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                //jämför alla nummer
                for (int s = i + 1; s < numbers.Count; s++)
                {
                    //ifall det är större, byt plats 
                    if (numbers[i] > numbers[s])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[s];
                        numbers[s] = temp;
                    }
                }
            }

            Console.WriteLine("\nResultat:");
            for(int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine((i + 1) + ": " + numbers[i]);
            }

        }

        static void ex46()
        {
            int[] numbers = new int[5];
            for(int i = 0; i < 5; i++) {
                Console.WriteLine("Ange nummer " + (i+1) + ":");
                int num = int.Parse(Console.ReadLine());
                numbers[i] = num;
            }
            int max = numbers.Max();
            Console.WriteLine("Det största numret är: " + max);
        }

        static void ex45()
        {
            Console.WriteLine("Skriv något");
            string input = Console.ReadLine();
            char[] inputChars = input.ToCharArray();
            
            //texten innehåller minst 2 characters
            if(inputChars.Length >= 2)
            {
                //den innehåller if
               if(inputChars[0] != 'i' && inputChars[1] != 'f')
               {
                    input = "if " + input; 
               }
            }

            Console.WriteLine(input);
        }

        static void ex44()
        {
            while (true)
            {
                Console.WriteLine("Skriv ett tal");
                int num1 = int.Parse(Console.ReadLine());
                if (num1 % 10 == 0)
                {
                    Console.WriteLine("Result: " + true);
                } else
                {
                    Console.WriteLine("Result: " + false);
                }
                Thread.Sleep(200);
            }
        }

        static void ex43()
        {
            Console.WriteLine("Ange ett heltal");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ange ett heltal");
            int num2 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;
            if(num1 == 23 || num2 == 23 || sum == 23)
            {
                Console.WriteLine("Resultat: " + true);
            }


        }

        static void ex42()
        {
            Console.WriteLine("Ange n");
            int n = int.Parse(Console.ReadLine());
            int diff = Math.Abs(n - 63);

            if(n > 63)
            {
                diff = diff * 2;
            }
            Console.WriteLine(diff);
        }

        static void ex41()
        {
            while (true)
            {
                //ange tal
                try { //bryt om annat än siffra anges
                    Console.WriteLine("Skriv ett heltal:");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Skriv ett heltal:");
                    int num2 = int.Parse(Console.ReadLine());

                    int sum = num1 + num2;

                    //om de är lika
                    if (num1 == num2)
                    {
                        //returnera fyrdubbla summan
                        Console.WriteLine(sum * 4);
                    }
                    else
                    {
                        Console.WriteLine(sum);
                    }
                } catch( Exception e)
                {
                    Console.WriteLine("Avbröt");
                    break;
                }
            }
        }

        static void ex40()
        {
            int sum = 0;
            int count = 0;
            while (true)
            {
                Console.WriteLine("Skriv ett tal:");
                int guess = int.Parse(Console.ReadLine());
                if (guess == 0)
                {
                    break;
                }
                count++;
                sum += guess;
            }

            Console.WriteLine("Summa: " + sum + "\n" + "Antal: " + count);
        }

        static void ex36()
        {
            while (true)
            {
                Console.WriteLine("Gissa siffran:");
                int guess = int.Parse(Console.ReadLine());
                if (guess == 0)
                {
                    break;
                } else if(guess > 0)
                {
                    Console.WriteLine(Math.Pow(guess, 2));
                } else
                {
                    Console.WriteLine("Det är negativt!");
                }

            }
        }

        static void ex35()
        {
            while (true)
            {
                Console.WriteLine("Gissa siffran:");
                int guess = int.Parse(Console.ReadLine());
                if(guess == 42)
                {
                    Console.WriteLine("Rätt!");
                    break;
                }

            }
        }

        static void ex34()
        {
            while (true)
            {
                Console.WriteLine("Vill du fortsätta?");
                string input = Console.ReadLine();
                if(input == "nej")
                {
                    break;
                }
            }
        }

        static void ex31()
        {
            Console.WriteLine("Skriv ett tal:");
            int num = int.Parse(Console.ReadLine());
            if(num % 2 == 0)
            {
                Console.WriteLine($"{num} är jämnt");
            } else
            {
                Console.WriteLine($"{num} är udda");
            }
        }

        static void ex30()
        {
            Console.WriteLine("Hur mycket poäng fick du?");
            int score = int.Parse(Console.ReadLine());

            if(score < 0)
            {
                Console.WriteLine("Omöjligt");

            } else if(score <= 49)
            {
                Console.WriteLine("Fail");
            }
            else if (score <= 59)
            {
                Console.WriteLine("1");
            }
            else if (score <= 69)
            {
                Console.WriteLine("2");
            }
            else if (score <= 79)
            {
                Console.WriteLine("3");
            }
            else if (score <= 89)
            {
                Console.WriteLine("4");
            }
            else if (score <= 100)
            {
                Console.WriteLine("5");
            }
            else 
            {
                Console.WriteLine("Outstanding");
            }
        }

        static void ex29()
        {
            Console.WriteLine("Skriv ett tal");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv ett tal");
            int num2 = int.Parse(Console.ReadLine());

            if(num1 == num2)
            {
                Console.WriteLine("De är lika");
            } else if(num1 > num2)
            {
                Console.WriteLine($"{num1} är större än {num2}");
            } else
            {
                Console.WriteLine($"{num2} är större än {num1}");
            }
        }

        static void ex28()
        {
            Console.WriteLine("Hur gammal är du?");
            int age = int.Parse(Console.ReadLine());
            if(age >= 18)
            {
                Console.WriteLine("Du är myndig");
            } else
            {
                Console.WriteLine("Du är inte myndig");
            }
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
