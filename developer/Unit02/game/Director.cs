using System;
using System.Collections.Generic;


namespace cse210.Game
{
    // The responsibility of a Director will be control the sequence of play.

    public class Director
    {
        Card card = new Card();
        bool playing = true;
        int totalScore = 300;


        // Constructs a new instance of Director.
        public Director()
        {
        }

        //Starts the game by running the main game loop.

        public void StartGame()
        {
            while (playing && totalScore > 0)
            {
                GetInputs();
                DrawCards();
                Outputs();
            }

            // Game over message.
            if (!playing)
            {
                Console.WriteLine($"You have ended the game with {totalScore} points. ");
                Console.WriteLine("Thanks for playing!");
            }
            else if (totalScore <= 0){
                Console.WriteLine("You have run out of points! \n YOU LOSE!");
            }
        }

        // Asks the user if they want to draw a card.

        public void GetInputs()
        {
            Console.Write("Draw a card? [y/n] ");
            string drawCard = Console.ReadLine();
            playing = (drawCard == "y");
        }

        // Updates the two cards drawn.

        public void DrawCards()
        {
            if (!playing)
            {
                return;
            }

            card.GetCard1();
            card.GetCard2();
        }

        // Displays the cards, tracks the user's guess, and updates score.
        public void Outputs()
        {
            if (!playing)
            {
                return;
            }

            card.DisplayCard1();
            Console.Write("Higher or lower? (h/l) ");
            string playerGuess = Console.ReadLine();
            card.DisplayCard2();

            bool guessLower = (playerGuess == "h");

            if (guessLower == card.higher())
            {
                totalScore += 100;
            }
            else
            {
                totalScore -= 75;
            }

            Console.WriteLine($"Your score is: {totalScore}\n");
        }
    }
}