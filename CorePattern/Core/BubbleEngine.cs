[assembly: System.Resources.NeutralResourcesLanguage("en")]
namespace CorePattern.Core
{
    using CorePattern.Properties;
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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Exception is generic, and suppose to catch all kind of errors.")]
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
                    BubbleDisplay.Error(Resources.OBJECT_NOT_INITIALIZED);
                }
            }
            catch (Exception ex)
            {
                BubbleDisplay.Error(ex.ToString());
            }
        }
    }
}
