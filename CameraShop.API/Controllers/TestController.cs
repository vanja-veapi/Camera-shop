using CameraShop.Domain;
using CameraShop.EfDataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CameraShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromServices] CameraShopDbContext context)
        {

            if (context.Users.Any())
            {
                return Conflict();
            }

            var roles = new List<Role>
            {
                new Role {Name = "User"},
                new Role {Name = "Admin"},
            };

            var users = new List<User>
            {
                new User {FirstName ="Pera", LastName ="Peric", UserName = "pera01", Email = "korisnikPera@gmail.com", Password = BCrypt.Net.BCrypt.HashPassword("pera1234"), Role = roles.First(), IsAdmin = false},
                new User {FirstName ="Pera", LastName ="Peric", UserName = "pera02", Email = "adminPera@gmail.com", Password = BCrypt.Net.BCrypt.HashPassword("pera1234"), Role = roles.Last(), IsAdmin = true},
            };

            var sensorTypes = new List<SensorType>
            {
                new SensorType {Type = "CMOS"},
                new SensorType {Type = "CCD"},
                new SensorType {Type = "MOS"},
                new SensorType {Type = "Foveon X3"},
                new SensorType {Type = "FF"},
            };

            var brands = new List<Brand>
            {
                new Brand {BrandName = "Canon"},
                new Brand {BrandName = "Nikon"},
                new Brand {BrandName = "Sony"},
                new Brand {BrandName = "Fujifilm"},
                new Brand {BrandName = "Pentax"},
            };

            var cameras = new List<Camera>
            {
                new Camera
                {
                    ProductName = "Camera 1",
                    ProductDescription = "A high-performance camera with a CMOS sensor",
                    Brand = brands.First(),
                    SensorType = sensorTypes.First(),
                    Megapixels = 24.2,
                    ISO = "100-12800",
                    VideoResolution = "1920x1080",
                    WifiSupport = true,
                    BluetoothSupport = true,
                    LensMount = "EF",
                    QuantityInStock = 10,
                    Price = 1200
                },
                new Camera
                {
                    ProductName = "Camera 2",
                    ProductDescription = "An entry-level camera with a CCD sensor",
                    Brand = brands.Last(),
                    SensorType = sensorTypes.Last(),
                    Megapixels = 16.1,
                    ISO = "100-6400",
                    VideoResolution = "1280x720",
                    WifiSupport = false,
                    BluetoothSupport = false,
                    LensMount = "F",
                    QuantityInStock = 15,
                    Price = 800
                }
            };
            context.AddRange(roles);
            context.AddRange(brands);
            context.AddRange(cameras);
            context.AddRange(users);

            context.SaveChanges();

            return StatusCode(201);
        }
    }
}
