using HellowWebEmpty.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HellowWebEmpty.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public List<HelloMessage> Get()
        {
            List<HelloMessage> messages = new List<HelloMessage>();
            messages.Add(new HelloMessage() { Message = "Hello Wep Api1" });
            messages.Add(new HelloMessage() { Message = "Hello Wep Api2" });
            messages.Add(new HelloMessage() { Message = "Hello Wep Api3" });
            messages.Add(new HelloMessage() { Message = "Hello Wep Api4" });

            return messages;
        }
    }
}
