using CorePattern.Core;
using CreationalPattern.Singleton;
using System;

namespace App
{
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
            // Singleton Design Pattern
            BubbleEngine.Run(new SingletonApp());
        }
    }
}
