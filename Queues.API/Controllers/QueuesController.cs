using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Queues.API.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Queues.API.Controllers
{
    [Route("[controller]")]
    public class QueuesController : Controller
    {
        // GET: api/queues
        /// <summary>
        /// Lists all available queues
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult ListAllQueues()
        {
            return Ok(new string[] { "queue1", "queue2" });
        }

        // GET api/queues/{queueName}
        [HttpGet("{queueName}")]
        public string DequeMessage(string queueName)
        {
            return $"{queueName}-value";
        }

        // POST api/queues
        /// <summary>
        /// Creates a new queue.
        /// </summary>
        /// <param name="value"></param>
        [HttpPost]
        public void CreateQueue([FromBody]string value)
        {
            System.Diagnostics.Debug.WriteLine(value);
        }

        // PUT api/<controller>/5
        [HttpPost("{id}")]
        public void QueueMessage(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
