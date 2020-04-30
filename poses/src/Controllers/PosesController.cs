using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using src.Models;

namespace poses.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PosesController : ControllerBase
    {
        private static readonly List<Pose> Poses = new List<Pose>
        {
            new Pose 
            {
                Name = "Warrior 1",
                Sanskrit = "Virabhadrasana I",
                Level = "Beginner",
                Tags = new List<string>{ "standing" }
            },
            new Pose 
            {
                Name = "Warrior 2",
                Sanskrit = "Virabhadrasana II",
                Level = "Beginner",
                Tags = new List<string>{ "standing" }
            },
            new Pose 
            {
                Name = "Warrior 3",
                Sanskrit = "Virabhadrasana III",
                Level = "Beginner",
                Tags = new List<string>{ "standing", "one-legged" }
            },
        };

        private readonly ILogger<PosesController> _logger;

        public PosesController(ILogger<PosesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Poses);
        }
    }
}
