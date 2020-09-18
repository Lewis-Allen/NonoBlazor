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

        [HttpGet("")]
        public async Task<ActionResult<List<StandardNonogram>>> Get()
        {
            var nonograms = (from sn in _db.StandardNonograms
                             select new StandardNonogram
                             {
                                 PublicID = sn.PublicID,
                                 Width = sn.Width,
                                 Height = sn.Height,
                                 RowValues = sn.RowValues,
                                 ColumnValues = sn.ColumnValues
                             }).ToList();

            return nonograms;
        }

        [HttpGet("{publicId}")]
        public async Task<ActionResult<StandardNonogram>> Get(Guid publicId)
        {
            var nonogram = (from sn in _db.StandardNonograms
                            where sn.PublicID == publicId
                            select new StandardNonogram
                            {
                                PublicID = sn.PublicID,
                                Width = sn.Width,
                                Height = sn.Height,
                                RowValues = sn.RowValues,
                                ColumnValues = sn.ColumnValues
                            }).FirstOrDefault();
                           
            return nonogram;
        }
    }
}
