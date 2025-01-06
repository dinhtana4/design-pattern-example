namespace Creation.AbstractFactory
{
    public class MacFactory : IUIFactory
    {
        public IButton CreateButton() => new MacButton();
        
        public ICheckbox CreateCheckbox() => new MacCheckbox();
    }
}
