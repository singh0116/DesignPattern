namespace CreationalPattern.Singleton
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The 'Singleton' class
    /// </summary>
    public sealed class LoadBalancer
    {
        // Static members are 'eagerly initialized', that is, 
        // immediately when class is loaded for the first time.
        // .NET guarantees thread safety for static initialization
        static readonly LoadBalancer _instance = new LoadBalancer();

        // Type-safe generic list of servers
        private IEnumerable<Server> _servers { get; set; }
        private Random _random = new Random();

        // Note: constructor is 'private'
        private LoadBalancer()
        {
            // Load list of available servers
            _servers = new List<Server>
            {
                new Server { IP = "192.168.0.1", Name = "Server I" },
                new Server { IP = "192.168.0.2", Name = "Server II" },
                new Server { IP = "192.168.0.3", Name = "Server III" },
                new Server { IP = "192.168.0.4", Name = "Server IV" },
                new Server { IP = "192.168.0.5", Name = "Server V" },
            };
        }

        /// <summary>
        /// Gets the load balancer.
        /// </summary>
        /// <returns>Singleton object of <seealso cref="LoadBalancer"/> class.</returns>
        public static LoadBalancer GetLoadBalancer()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the next server.
        /// </summary>
        /// <value>
        /// The next server.
        /// </value>
        public Server NextServer
        {
            get
            {
                int random = _random.Next(_servers.Count());
                return _servers.ElementAt(random);
            }
        }
    }

    /// <summary>
    /// Represents a server machine
    /// </summary>
    public class Server
    {
        /// <summary>
        /// Gets or sets the server name.
        /// </summary>
        /// <value>
        /// The server name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the ip address.
        /// </summary>
        /// <value>
        /// The ip address.
        /// </value>
        public string IP { get; set; }
    }
}
