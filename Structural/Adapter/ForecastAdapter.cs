public class ForecastAdapter : IFahrenheitForecast{
    private ICelsiusForecast celsiusForecast;
    public ForecastAdapter(ICelsiusForecast celsiusForecast){
        this.celsiusForecast = celsiusForecast;
    }

    public int GetTemperature()
    {
        return this.celsiusForecast.GetTemperature()*9/5+32;
    }
}