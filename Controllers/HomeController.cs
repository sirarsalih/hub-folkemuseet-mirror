using System;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace NorskFolkemuseum.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public bool UpdateJSON(string lat, string lng)
        {
            var locationHasSound = false;
            const string pathToJSON = "wwwroot/data/locations.json";
            var jsonStr = System.IO.File.ReadAllText(pathToJSON);
            dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonStr);
            jsonObj["lat"] = lat;
            jsonObj["lng"] = lng;
            foreach (var sound in jsonObj.sounds) {
                if(sound.lat.Value.Equals(lat) && sound.lng.Value.Equals(lng)) {
                    locationHasSound = true;
                    break;
                }
            }
            var output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText(pathToJSON, output);
            return locationHasSound;
        }
    }
}
