using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MLGS
{
    [Route("api/[controller]")]
    public class ParcelDataController : Controller
    {
        private readonly ParcelContext db;

        public ParcelDataController(ParcelContext context)
        {
            db = context;
        }

        // POST api/<controller>
        [HttpPost]
        public void Create([FromBody]ParcelData data)
        {
            db.ParcelsData.Add(data);
            db.SaveChanges();
        }
    }
}
