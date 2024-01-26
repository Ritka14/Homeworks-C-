using System;
using System.Globalization;



namespace Hw1.Exercise3
{
    /// <summary>
    /// 'Rock-Paper-Scissors' game application core.
    /// </summary>
    public partial class GameApplication
    {
        /// <summary>
        /// Runs game application.
        /// Prints game results.
        /// </summary>
        /// <param name="args">
        /// Arguments - player's shape.
        /// args[0] - shape [Rock, Paper, Scissors].
        /// </param>
        /// <returns>Returns : 
        /// <c>0</c> in case of success; 
        /// <c>-1</c> in case of invalid <paramref name="args"/>.
        /// </returns>
        public enum Game
        {
            rock,
            scissors,
            paper,
        };

        public enum Outcome
        {
            win,
            lose,
            draw,
        };

        public enum User
        {
            Player,
            Computer,
        };

        public int Run(string[] args)
        {
            if (args == null || args.Length == 0 || args.Length > 1 || !Enum.TryParse(args[0].ToLowerInvariant(), out Game game))
            {
                return -1;
            }

            Random random = new Random();
            var randomIndex = random.Next(Enum.GetValues(typeof(Game)).Length);
            Game randomEnumValue = (Game)randomIndex;

            Outcome resultPlayer = Outcome.draw;
            Outcome resultComputer = Outcome.draw;
            
                switch (game)
                {
                    case Game.rock:
                    {
                        if (randomEnumValue == Game.scissors)
                            resultPlayer = Outcome.win;
                        else if (randomEnumValue == Game.paper)
                            resultPlayer = Outcome.lose;
                    }
                        break;
                    case Game.scissors:
                    {
                        if (randomEnumValue == Game.rock)
                            resultPlayer = Outcome.lose;
                        else if (randomEnumValue == Game.paper)
                            resultPlayer = Outcome.win;
                    }
                        break;
                    case Game.paper:
                    {
                        if (randomEnumValue == Game.rock)
                            resultPlayer = Outcome.win;
                        else if (randomEnumValue == Game.scissors)
                            resultPlayer = Outcome.lose;
                    }
                        break;
                }

                if (resultPlayer == Outcome.win)
                {
                    resultComputer = Outcome.lose;
                }
                else if (resultPlayer == Outcome.lose)
                {
                    resultComputer = Outcome.win;
                }
                
                string FirstCharToUpper(string input)
                {
                    if (string.IsNullOrEmpty(input))
                    {
                        return input;
                    }

                    return char.ToUpperInvariant(input[0]) + input.Substring(1).ToLowerInvariant();
                }
                
                Console.WriteLine($"{User.Player}={FirstCharToUpper(args[0])}:{FirstCharToUpper(resultPlayer.ToString())}");
                Console.WriteLine($"{User.Computer}={FirstCharToUpper(randomEnumValue.ToString())}:{FirstCharToUpper(resultComputer.ToString())}");
                

                return 0;
        }
    }

}









