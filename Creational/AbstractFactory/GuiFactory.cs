public interface IGuiFactiory{
    IButton CreateButton();
}

public class WindowsGuiFactory : IGuiFactiory
{
    public IButton CreateButton()
    {
        return new WindowsButton();
    }
}

public class MacGuiFactory : IGuiFactiory
{
    public IButton CreateButton()
    {
        return new MacButton();
    }
}