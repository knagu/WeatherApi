using System;

namespace weatherapi
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }

        public string User { get; set;}

        public string Topic { get; set;}

        public string Password { get; set;}
        public string DB_Url { get; set;}
        
    }
}
