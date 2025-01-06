namespace Creation.AbstractFactory
{
    public class WindowsCheckbox : ICheckbox
    {
        public void Render() => Console.WriteLine("Rendering a window checkbox");
    }
}
