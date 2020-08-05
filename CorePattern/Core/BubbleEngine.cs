namespace CorePattern.Core
{
    using System;

    /// <summary>
    /// App Engine for execution of patterns
    /// </summary>
    /// <seealso cref="CorePattern.Core.IBubbleApp" />
    public static class BubbleEngine
    {
        /// <summary>
        /// Runs the specified application.
        /// </summary>
        /// <param name="app">The application.</param>
        public static void Run(IBubbleApp app)
        {
            try
            {
                if (app != null)
                {
                    app.Execute();
                }
                else
                {
                    BubbleDisplay.Error("Object is not initialized properly");
                }
            }
            catch (Exception ex)
            {
                BubbleDisplay.Error(ex.ToString());
            }
        }
    }
}
