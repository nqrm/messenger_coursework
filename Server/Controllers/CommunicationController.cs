using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommunicationController : ControllerBase
    {
        string file = @"D:\VZLOM\messenger\Server\history.txt";
        // GET api/<CommunicationController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<string> Get(int id)
        {
            string json = "Not Found";
            if ((id < Program.ms.GetCountMessages()) && (id >= 0))
            {
                json = JsonSerializer.Serialize(Program.ms.Get(id));
                return json.ToString();
            }
            return NotFound();
        }

        // POST api/<CommunicationController>
        [HttpPost]
        public void Post([FromBody] message msg)
        {
            Program.ms.Add(msg);
            Console.WriteLine($"{msg.username}:  {msg.text} ({Program.ms.messages.Count})");
            using (StreamWriter sw = new StreamWriter(file, true))
            {
                string info = $"[{msg.username}]: {msg.text};";
                sw.WriteLine(info);
                sw.Close();
            }
        }
    }
}
