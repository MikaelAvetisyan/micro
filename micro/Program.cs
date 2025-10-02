using System;

bool start = true;
int money = 100;
int show_up = 0;

Console.WriteLine("Welcome to Burger (Yes, its the restaurant's name)");
Console.WriteLine();
Console.WriteLine("Would you like to look through our menu?");
Console.WriteLine("Yes or No?");
string opt1 = Console.ReadLine().Trim().ToUpper();

if (opt1 == "YES")
    Console.WriteLine("Here you go!");
else if (opt1 == "NO")
    Console.WriteLine("The cashier said: Well, we don't care, take the menu anyway.");

while (start)
{
    Console.WriteLine($"You have {money} SEK to spend");
    Console.WriteLine("Menu:");
    Console.WriteLine(@"1. Big Burger - 35 SEK
    A massive burger with extra patties and melted cheese. Fills you up but hits your wallet harder.");
    Console.WriteLine(@"2. Fish Burger - 50 SEK
    A patty made of fish, topped with sauces and sushi-inspired ingredients. Expensive but unique.");
    Console.WriteLine(@"3. Krabby Patty - 12 SEK
    A cheap but mysterious burger. No one knows the exact ingredients, but it tastes amazing.");

    show_up++;

    
    if (show_up == 1)
    {
        Console.WriteLine("So do you want the Big burger?");
        Console.WriteLine("Yes or No?");
        string okayyyy1 = Console.ReadLine().Trim().ToUpper();
        if (okayyyy1 == "YES")
        {
            Console.WriteLine("How many of them");

            opt1 = Console.ReadLine().Trim().ToUpper();
            bool Success = int.TryParse(opt1, out int opt1_1);

            if (Success)
            {
                int sum1 = opt1_1 * 35;

                if (sum1 > money)
                {
                    Console.WriteLine("nuh uh, no no money enough, you broke");
                }
                else
                {
                    money -= sum1;
                    Console.WriteLine($"Okayy so {opt1_1} big burgers, that will be {sum1} SEK");
                    Console.WriteLine($"You got {money} left");
                }
            }
            else
            {
                Console.WriteLine("hummm.... okay... seams like you like to waste my time ");
            }
        }
        else if (okayyyy1 == "NO")
        {
            Console.WriteLine("Okayyy... emmmm....");
        }
        else
        {
            Console.WriteLine("That is not an answer");
        }
    }


    else if (show_up == 2)
    {
        Console.WriteLine("Okayyy... emmmm....");
        Console.WriteLine("Do you want Fish burger?");
        Console.WriteLine("Yes or No?");
        string opt2 = Console.ReadLine().Trim().ToUpper();
        if (opt2 == "YES")
        {
            Console.WriteLine("Great, how many of them do you want");

            string op1 = Console.ReadLine().Trim().ToUpper();
            bool Success1 = int.TryParse(op1, out int op1_1);
            if (Success1)
            {
                int sum2 = op1_1 * 50;

                if (sum2 > money)
                {
                    Console.WriteLine("nuh uh, no no money enough, you broke");
                }
                else
                {
                    money -= sum2;
                    Console.WriteLine($"Okayy so {op1_1} fish burgers, that will be {sum2} SEK");
                    Console.WriteLine($"You got {money} left");
                }
            }
            else
            {
                Console.WriteLine("hummm.... okay... seams like you like to waste my time ");
            }
        }
        else if (opt2 == "NO")
        {
            Console.WriteLine("So you dont want fish burger then i guess..");
        }
        else
        {
            Console.WriteLine("Well seams like your trying to waste my time again");
        }
    }

    else if (show_up == 3)
    {
        Console.WriteLine("Okayyy... emmmm....");
        Console.WriteLine("Well i guess you want the krabby patty?");
        Console.WriteLine("Yes or No?");
        string opt3 = Console.ReadLine().Trim().ToUpper();
        if (opt3 == "YES")
        {
            Console.WriteLine("Great, how many of them do you want");

            string op3 = Console.ReadLine().Trim().ToUpper();
            bool Success4 = int.TryParse(op3, out int op3_3);
            if (Success4)
            {
                int sum21 = op3_3 * 12;

                if (sum21 > money)
                {
                    Console.WriteLine("nuh uh, no no money enough, you broke");
                }
                else
                {
                    money -= sum21;
                    Console.WriteLine($"Okayy so {op3_3} krabby patties, that will be {sum21} SEK");
                    Console.WriteLine($"You got {money} left");
                    break;
                }
            }
            else
            {
                Console.WriteLine("hummm.... okay... seams like you like to waste my time ");
            }
        }
        else if (opt3 == "NO")
        {
            Console.WriteLine("So you dont want anything is what your saying");
        }
        else
        {
            Console.WriteLine("Well seams like your trying to waste my time");
        }
    }

    else if (show_up == 4)
    {
        Console.WriteLine("Well so you came here to waste my time");
        Console.WriteLine("THE GET THE HELL OUT");
        break;
    }
    else
    {
        Console.WriteLine("That is not an answer");
    }
}
Console.ReadLine();
