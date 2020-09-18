using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NonoBlazor.Database.Contexts;
using NonoBlazor.Shared;

namespace NonoBlazor.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StandardNonogramController : ControllerBase
    {
        private readonly NonogramContext _db;

        public StandardNonogramController(NonogramContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<List<StandardNonogram>>> Get()
        {
            var nonograms = _db.StandardNonograms.ToList();

            return nonograms;
        }
    }
}
