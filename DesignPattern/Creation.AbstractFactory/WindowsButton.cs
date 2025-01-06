namespace Creation.AbstractFactory
{
    public class WindowsButton : IButton
    {
        public void Render() => Console.WriteLine("Rendering a window button");
    }
}
