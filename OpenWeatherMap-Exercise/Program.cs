using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace OpenWeatherMap_Exercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // TODO: Create an instance of the HttpClient Class called client
            var client = new HttpClient();
            // TODO: Ask for the users API Key and store that in a variable called "api_Key"
            Console.WriteLine("Please enter you API key:");
            var api_Key = Console.ReadLine();
            // TODO: Ask the user for their city name and store that in a variable called "city_name"
            Console.WriteLine("Please enter you city's name:");
            var city_Name = Console.ReadLine();
            
            // TODO: Create a variable to store the URL (use String Interpolation for the {city_name} and {api_Key}  HINT: Make sure to use the "imperial" measurement endpoint
            var tempUrl = $"https://api.openweathermap.org/data/2.5/weather?q={city_Name}&units=imperial&appid={api_Key}";
            // TODO: Create a variable to store the response from your GET request to that URL from above  HINT: Don't forget to call .Result 
            var response = client.GetStringAsync(tempUrl).Result;
            // TODO: Create a variable to store the formattedResponse after you JObject.Parse() the response from above
            var formatResponse = JObject.Parse(response).GetValue("main").ToString();
            // TODO: Write out the current temperature in degrees Fahrenheit
            Console.WriteLine(formatResponse);
        }
    }
}
