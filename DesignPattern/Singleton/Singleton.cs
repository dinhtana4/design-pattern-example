namespace Creation.Singleton
{
    /// <summary>
    /// Singleton - Creation Pattern
    /// The Singleton design pattern ensures a class has only one instance and provide a global point of access to it.
    /// </summary>
    public sealed class Singleton
    {
        private static readonly object _lock = new object();
        private static Singleton _instance = null;
        public static Singleton Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                    return _instance;
                }
            }
        }
    }
}
