using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Test_AsyncServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelBookingsController : ControllerBase
    {
        // GET: api/HotelBookings
        [HttpGet]
        public async Task<IEnumerable<string>> Get()
        {
            Console.Write("HotelBookingsController.Get() called. Waiting for 1 sec: ");
            await System.Threading.Tasks.Task.Delay(1000);
            Console.WriteLine("Done.");
            return new string[] { "value1", "value2" };
        }
    }
}
