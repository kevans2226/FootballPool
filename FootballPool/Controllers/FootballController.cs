using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootballPool.Data;
using FootballPool.Data.View;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FootballPool.Controllers { 
    [ApiController]
    [Route("/api/[controller]")]
    public class FootballController : Controller { 
        private WebDbContext _webDbContext; 
        public FootballController(WebDbContext webDbContext) { 
            _webDbContext = webDbContext; 
        }

        [HttpGet("SimpleTeams")]
        public IActionResult GetSimpleTeams() { 
            var teams = _webDbContext.Teams.Select(t => new SimpleTeam() { 
                TeamId = t.TeamId, 
                Mascot = t.Mascot, 
                Location = t.Location
            }).OrderBy(t => t.Mascot).ToList();

            return Ok(teams);
        }
    }
}