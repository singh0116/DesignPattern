namespace App
{
    using CorePattern.Core;
    using CreationalPattern.Prototype;
    using CreationalPattern.Singleton;

    /// <summary>
    /// Main Program
    /// </summary>
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            // Prototype Design Pattern
            BubbleEngine.Run(new PrototypeApp());

            // Singleton Design Pattern
            BubbleEngine.Run(new SingletonApp());
        }
    }
}
