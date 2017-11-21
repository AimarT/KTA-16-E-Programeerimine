namespace BlackJack.Client.Console
{
    using System;
    using Blackjack.Core;
    class Program
    {
        static void Main(string[] args)
        {
            //all aces are 11 points. In real life, one can choose weather it is 1 or 11.
            //when user draws a card, house always draws one aswell.

            Console.WriteLine("Welcome to the game of Blackjack!");
            Console.WriteLine();

            var c4 = new Card("4", 'C', 4);
            var h6 = new Card("6", 'H', 6);
            var s8 = new Card("8", 'S', 8);
            var d2 = new Card("2", 'D', 10);

            //4C =card.Description


            Console.WriteLine($"You have been dealt:{c4.Description}, {h6.Description}  ");
            Console.WriteLine($"House have been dealt: {s8.Description}, {(d2.Hidden ? "?" : d2.Description)} ");
            Console.WriteLine();

            Console.WriteLine("What do you want to do ?");
            Console.WriteLine("Choose: 1 - To take another card");
            Console.WriteLine("Choose: 2 - To finish");
            Console.WriteLine();
            Console.WriteLine("I choose: 1");
            Console.WriteLine();

            var s4 = new Card("4", 'S', 4);
            s4.Hidden = false;

            var h1 = new Card("1", 'H', 10);

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
