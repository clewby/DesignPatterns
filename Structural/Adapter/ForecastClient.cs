public class ForecastClient{
    public static void Run(){
        ICelsiusForecast celsiusForecast = new CelsiusForecast();
        Console.WriteLine("Celsius temperature: " + celsiusForecast.GetTemperature());
        IFahrenheitForecast forecastAdapter = new ForecastAdapter(celsiusForecast);
        Console.WriteLine("Adapted Farenheit temperature: " + forecastAdapter.GetTemperature());
    }
}