using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class GenericController : ControllerBase
    {

        [HttpPost]
        [Route("/api/Generic")]
        [Consumes("application/json")]
        public IActionResult ReceiveJson([FromBody]object data)
        {
            // Do something with a Json not Serialized

            return Ok(data);
        }

        [HttpPost]
        [Route("/api/Generic")]
        [Consumes("application/xml")]
        public IActionResult ReceiveXML([FromBody]string data)
        {
            // Do something with an XML not Serialized
            // Import - Uses CDATA to send XML like
            // <string><![CDATA[<contentToRead></contentToRead>]]></string>

            return Ok(data);
        }
    }
}