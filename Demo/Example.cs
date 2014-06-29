namespace Demo
{
    using log4net;
    using log4net.Config;

    /// <summary>
    /// Demo class just for the homework purposes.
    /// </summary>
    public class Example
    {
        /// <summary>
        /// This field holds the instance of the logger.
        /// </summary>
        private static readonly ILog Log = LogManager.GetLogger(typeof(Example));
        
        /// <summary>
        /// Demonstrates logging using log4net.
        /// </summary>
        public static void Main()
        {
            BasicConfigurator.Configure();
            Log.Debug("Debug msg");
            Log.Error("Error msg");
        }
    }
}