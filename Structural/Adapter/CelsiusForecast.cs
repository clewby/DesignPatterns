public interface ICelsiusForecast{
    int GetTemperature();
}

public class CelsiusForecast : ICelsiusForecast{
    public int GetTemperature(){
        return 10;
    }
}