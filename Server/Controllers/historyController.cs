using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class historyController : ControllerBase
    {
        string file = @"D:\VZLOM\messenger\Server\history.txt";
        // GET api/<historyController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<string> Get(int id)
        {
            string json = "Not found";
            if (id == 0)
            {
                string history = "";
                using (StreamReader sr = new StreamReader(file))
                {
                    while (sr.Peek() >= 0)
                    {
                        history += sr.ReadLine();
                    }
                }
                json = JsonSerializer.Serialize(history);
                return json.ToString();
            }
            return NotFound();
        }
    }
}
