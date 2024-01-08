namespace Hw1.Exercise2
{
    /// <summary>
    /// Area calculator application.
    /// </summary>
    internal sealed class Program
    {
        /// <summary>
        /// Application entry point.
        /// </summary>
        public static int Main(string[] args)
        {
            var app = new AreaCalcApplication();
            return app.RunPain(args);
        }
    }
}
