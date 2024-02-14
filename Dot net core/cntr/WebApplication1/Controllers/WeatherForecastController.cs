using Microsoft.AspNetCore.Mvc;
using System.Collections.ObjectModel;
using WebApplication1.Design_Ptrn;
using WebApplication1.Filters;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    //[SampleActionFilter("","")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        //[HttpGet(Name = "GetStrtegy")] 
        //public IEnumerable<string> GetStrtegy()
        //{
        //    Child c = new Child(7000000);
        //    var rng = new List<string>();
        //    Animal sparky = new Dog();
        //    Animal Twty = new Duck();
        //    rng.Add("DOG : "  +  sparky.TryToFly());
        //    rng.Add("DUCK : " + Twty.TryToFly());
        //    sparky.setFlayingAbility(new CanFly());
        //    rng.Add("DOG : " + sparky.TryToFly());
        //    return rng;
        //}

        [HttpGet(Name = "GetWeatherForecast")]
        [ServiceFilter(typeof(SampleActionFilter))]
        [TypeFilter(typeof(SampleAuthActionFilter))]
        public IEnumerable<WeatherForecast> Get()
        {


            string S = "somedatainit";
            var Sk = S[0];
            
         

            var collection = new Collection<WeatherForecast>();
            var list = new List<WeatherForecast>();
            var k = list.Exists(x => x.Date != null);
            var c = list.Any();
            var kc = collection.Any();



            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }


    class Parent
    {
        public Parent(int i)
        {
            Console.WriteLine("Constructor of Parent class" + i);
        }
    }

    class Child : Parent
    {
        public Child(int i):base(i)  
        {
            Console.WriteLine("Constructor of Child class");
        }
    }

}
