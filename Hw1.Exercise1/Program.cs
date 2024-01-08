namespace Hw1.Exercise1
{
    /// <summary>
    /// Prime numbers application.
    /// </summary>
    internal sealed class Program
    {
        /// <summary>
        /// Application entry point.
        /// </summary>
        public static int Main(string[] args)
        {
            var app = new PrimeNumbersApplication();
            return app.Run(args);
        }
    }
}
