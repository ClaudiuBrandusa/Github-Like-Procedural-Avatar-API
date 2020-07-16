using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using static Github_Like_Procedural_Avatar.Generator;

namespace Github_Like_Procedural_Avatar_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AvatarController : ControllerBase
    {
        [HttpGet("get")]
        public IActionResult Get(string hexadecimalColor, int width = 100, int height = 100)
        {
            Startup.Generator.SetDimensions(width, height); // set the resolution needed

            Startup.Generator.Generate(); // generate

            Startup.Generator.SetColor(hexadecimalColor); // setting the hexadecimal color

            Stream stream = new MemoryStream(); // here we are storing the stream where we will save the bitmap

            Startup.Generator.Export(stream); // setting the image to the stream

            stream.Seek(0, SeekOrigin.Begin); // setting the cursor at the beginning of the stream

            return File(stream, "image/png"); // converting the stream to a png image
        }
    }
}