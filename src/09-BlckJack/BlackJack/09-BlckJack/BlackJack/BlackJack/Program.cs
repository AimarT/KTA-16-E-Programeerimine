namespace BlackJack.Client.Console
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            //all aces are 11 points. In real life, one can choose weather it is 1 or 11
            //when user draws a card, house always draws one aswell

            Console.WriteLine("Welcome to the game of Blackjack!");
            Console.WriteLine();

            Console.WriteLine("You have been dealt: 4C, 6H ");
            Console.WriteLine("House have been dealt: 8S, [?] ");
            Console.WriteLine();

            Console.WriteLine("What do you want to do ?");
            Console.WriteLine("Choose: 1 - To take another card");
            Console.WriteLine("Choose: 2 - To finish");
            Console.WriteLine();
            Console.WriteLine("I choose: 1");
            Console.WriteLine();

            Console.WriteLine("You have been dealt: 4S");
            Console.WriteLine("House have been dealt:[?] ");
            Console.WriteLine();

            Console.WriteLine("What do you want to do ?");
            Console.WriteLine("Choose: 1 - To take another card");
            Console.WriteLine("Choose: 2 - To finish");
            Console.WriteLine();
            Console.WriteLine("I choose: 2");
            Console.WriteLine();

            Console.WriteLine("You have 14 points vs. house 17 points");

            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}
