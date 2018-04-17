using Microsoft.AspNetCore.Mvc;

namespace NorskFolkemuseum.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public void UpdateJSON(string lat, string lng)
        {
            const string pathToJSON = "wwwroot/data/locations.json";
            var jsonStr = System.IO.File.ReadAllText(pathToJSON);
            dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonStr);
            jsonObj["lat"] = lat;
            jsonObj["lng"] = lng;
            var output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText(pathToJSON, output);
        }
    }
}
