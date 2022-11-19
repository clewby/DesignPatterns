public class FactoryClient{
    private IGuiFactiory factiory;
    public FactoryClient(IGuiFactiory factiory){
        this.factiory = factiory;
    }
    public IButton CreateButton(){
        return this.factiory.CreateButton();
    }
}