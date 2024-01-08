using System;
using System.Globalization;

namespace Hw1.Exercise2
{
    /// <summary>
    /// Area calc application core.
    /// </summary>
    public class AreaCalcApplication
    {
        private enum Figure
        {
            circle,
            square,
            rect,
            triangle
        };
        /// <summary>
        /// Runs area calc application.
        /// Prints area of selected shape (from <paramref name="args"/>) to the output.
        /// </summary>
        /// <param name="args">
        /// Arguments - shape with dimensions.
        /// args[0] - shape [Circle, Square, Rect, Triangle].
        /// args[0..2] - shape dimensions.
        /// </param>
        /// <returns>Returns : 
        /// <c>0</c> in case of success; 
        /// <c>-1</c> in case of invalid <paramref name="args"/>;
        /// <c>-2</c> in case of invalid dimensions.
        /// </returns>
        public int RunPain(string[] args)

        {
            double num2, result;

            if (args == null || args.Length < 2 || args.Length > 4 ||
                !Enum.TryParse<Figure>(args[0].ToLowerInvariant(), out var figure) ||
                !double.TryParse(args[1].Replace(",", "."), CultureInfo.InvariantCulture, out var num1))
            {
                return -1;
            }

            if (num1 <= 0)
            {
                return -2;
            }

            switch (figure)

            {
                case Figure.circle: 
                    result = Math.PI * num1 * num1;
                    Console.WriteLine(result);
                    break;

                case Figure.square:
                    result = num1 * num1;
                    Console.WriteLine(result);
                    break;

                case Figure.rect:

                    if (args.Length != 3)
                    {
                        return -1;
                    }
                    if (!double.TryParse(args[2], out num2))
                    {
                        return -1;
                    }

                    if (num2 <= 0)
                    {
                        return -2;
                    }

                    result = num1 * num2;
                    Console.WriteLine(result);
                    break;
                case Figure.triangle:
                    if (args.Length == 3)
                    {
                        if (!double.TryParse(args[2], out num2))
                        {
                            return -1;
                        }

                        if (num2 <= 0) 
                        {
                            return -2;
                        }

                        result = 0.5 * num1 * num2;
                        Console.WriteLine(result);
                    }
                    else if (args.Length == 4)
                    {
                        if (!double.TryParse(args[2].Replace(",", "."), CultureInfo.InvariantCulture,  out num2) || !double.TryParse(args[3].Replace(",", "."), CultureInfo.InvariantCulture,  out var num3))
                        {
                            return -1;
                        }

                        if (num2 <= 0 || num3 <= 0 || num1 <=0 || num2 + num1 < num3 || num2+num3 < num1 || num1+num3 <num2)
                        {
                            return -2;
                        }

                        var p = (num1 + num2 + num3) / 2;
                        result = Math.Sqrt(p * (p - num1) * (p - num2) * (p - num3));
                        Console.WriteLine(result);
                    }
                    break;
                default:
                    return -1;
            }
            return 0;
        }
    }
}
