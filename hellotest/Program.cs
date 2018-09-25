using System;

namespace hellotest
{
    class Program
    {
        static void Main(string[] args)
        {
			bool playing = true;

			Random randomNumber = new Random();
			int compAnswer = randomNumber.Next(1, 21);
			int userNumber;

			Console.WriteLine("Pick a number between 1 and 20");

			while (playing)
			{
				string userAnswer = Console.ReadLine();
				bool isNumber = int.TryParse(userAnswer, out userNumber);
				checkResponse();
			}

			void checkResponse()
			{
				if (userNumber == compAnswer)
				{
					Console.WriteLine("Congratulations, you guessed right!");
					playing = false;
				}
				else if (userNumber > compAnswer && userNumber <= 20)
				{
					Console.WriteLine("Your guess was too high, try again!");
				}
				else if (userNumber < compAnswer && userNumber >= 1)
				{
					Console.WriteLine("your guess was too low, try again!");
				}
				else
				{
					Console.WriteLine("Invalid Number");
				}
			}
			
        }
    }
}
