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
    public class FlightBookingsController : ControllerBase
    {
        // GET: api/FlightBookings
        [HttpGet]
        public async Task<IEnumerable<string>> Get()
        {
            Console.Write("FlightBookingsController.Get() called. Waiting for 2 secs: ");
            await System.Threading.Tasks.Task.Delay(2000);
            Console.WriteLine("Done.");
            return new string[] { "value1", "value2" };
        }

    }
}
