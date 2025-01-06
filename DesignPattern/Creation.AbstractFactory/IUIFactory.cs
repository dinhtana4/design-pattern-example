namespace Creation.AbstractFactory
{
    public interface IUIFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }
}
