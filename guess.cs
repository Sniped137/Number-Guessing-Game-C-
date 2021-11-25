using System;

class GuessNumberGame
{
    static private int RandomNumber()
    {
        int correct;
        Random rand = new Random();
        correct = rand.Next(1,100); 
        return correct;
    }

    static private void Main(string[] args)
    {
        bool win = false;
        int correct = RandomNumber();

        Console.WriteLine("Welcome to the Number Guessing Game");
        Console.WriteLine("Please Guess A Number!");

        while (!win)
        {
            int guess = Convert.ToInt32(Console.ReadLine());
            if (correct == guess)
            {
                Console.WriteLine("You Win, Congrats!");
                win = true;
            }    

            else if (correct < guess)
            {   
                Console.WriteLine("Guess is too High, Guess Lower!");
            }

            else
            {
                Console.WriteLine("Guess is too Low, Guess Higher!");
            }

        }

    }

}
