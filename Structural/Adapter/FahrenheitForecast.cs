public interface IFahrenheitForecast{
    int GetTemperature();
}

public class FahrenheitForecast : IFahrenheitForecast {
    public int GetTemperature(){
        return 10;
    }
}