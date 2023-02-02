using Microsoft.AspNetCore.Mvc;
//using API_WIth_EF_CoreMigration.Data;
//using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using API_WIth_EF_CoreMigration;

namespace Co2_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VehicleController : Controller
    {
        [HttpGet] // how to basic
        [ProducesResponseType(StatusCodes.Status200OK)]
        public float Get(int id, float distance) 
        {         
            float result = 0;
            switch (id)
            {
                case 0:
                    result = distance / 15 * 0.2f; // Car
                    break;
                case 1:
                    result = distance / 20 * 2.545f; // Boat
                    break;
                case 2:
                    result = distance * 0.020625f; // Bicycle
                    break;
                case 3:
                    result = distance * 3.10f * 12; // Airplane
                    break;
                case 4:
                    result = distance / 100 * 1.536f; // Scooter
                    break;
                case 5:
                    result = distance * 0.00032f; // Train
                    break;
                case 6:
                    result = distance * 0.0947f; // Bus
                    break;
            }
            return result;
        }
    }
}