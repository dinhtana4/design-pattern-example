namespace Creation.AbstractFactory
{
    public class WindowsFactory : IUIFactory
    {
        public IButton CreateButton() => new WindowsButton();

        public ICheckbox CreateCheckbox() => new WindowsCheckbox();
    }
}
