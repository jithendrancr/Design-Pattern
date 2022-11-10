using ObserverPattern;

class Program
    { 
        static void Main(string[] args)
        {
        WeatherUpdates weatherUpdate = new WeatherUpdates(20.5f,72f);; 
        Customer accuWeather = new Customer("AccuWeather");
        Customer bbcWeather = new Customer("bbcWeather");
        Customer skymet = new Customer("skymet");

        weatherUpdate.AddCustomer(accuWeather);
        weatherUpdate.AddCustomer(bbcWeather);
        weatherUpdate.AddCustomer(skymet);

        weatherUpdate.Temparature = 26.4f;
        Console.WriteLine("---------------------------------------------------------------------");
        weatherUpdate.WindSpeed = 81.5f;
        Console.WriteLine("---------------------------------------------------------------------");

        weatherUpdate.Temparature = 46.5f;
        Console.WriteLine("---------------------------------------------------------------------");

        weatherUpdate.WindSpeed = 80.8f;
    }
    }
