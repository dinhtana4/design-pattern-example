namespace Creation.AbstractFactory
{
    /// <summary>
    ///  provides an interface for creating families of related or dependent objects without specifying their concrete classes. 
    /// </summary>
    public class ABFactory
    {
        public static IUIFactory CreateUIFactory(string osType)
        {
            return osType.ToLower() switch
            {
                "windows" => new WindowsFactory(),
                "mac" => new MacFactory(),
                _ => throw new Exception("Invalid os type")
            };
        }
    }
}
