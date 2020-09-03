[assembly: System.Resources.NeutralResourcesLanguage("en")]
namespace CreationalPattern.Singleton
{
    using CorePattern.Core;
    using CreationalPattern.Properties;

    /// <summary>
    /// Singleton Design Pattern
    /// </summary>
    /// <seealso cref="CorePattern.Core.IBubbleApp" />
    public class SingletonApp : IBubbleApp
    {
        /// <summary>
        /// Executes this pattern instance
        /// </summary>
        public void Execute()
        {
            var b1 = LoadBalancer.GetLoadBalancer();
            var b2 = LoadBalancer.GetLoadBalancer();
            var b3 = LoadBalancer.GetLoadBalancer();
            var b4 = LoadBalancer.GetLoadBalancer();

            // Confirm these are the same instance
            if (b1 == b2 && b2 == b3 && b3 == b4)
            {
                BubbleDisplay.Info(Resources.IDENTICAL_OBJECT);
            }

            // Next, load balance 15 requests for a server
            var balancer = LoadBalancer.GetLoadBalancer();
            for (int i = 0; i < 15; i++)
            {
                string serverName = balancer.NextServer.Name;
                BubbleDisplay.Info("Dispatch request to: " + serverName);
            }
        }
    }
}
