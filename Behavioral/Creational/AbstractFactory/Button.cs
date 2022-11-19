public interface IButton{
    void Click();
}

public class WindowsButton : IButton
{
    public void Click()
    {
        Console.WriteLine("Windows button has been clicked.");
    }
}

public class MacButton : IButton
{
    public void Click()
    {
        Console.WriteLine("Mac button has been clicked.");
    }
}