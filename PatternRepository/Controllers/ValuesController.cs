using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using PatternRepository.Models;
using Microsoft.EntityFrameworkCore;

namespace PatternRepository.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        IRepository<Item> db;
        public ValuesController(DbContextOptions<ItemsContext> options)
        {
            db = new SQLItemsRepository(options);
        }

        // GET api/values
        [HttpGet]
        public ActionResult <IEnumerable<Item>> Get()
        {
           return db.GetItems().ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Item> Get(int id)
        {
            return db.GetItem(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Item value)
        {
            if (ModelState.IsValid)
            {
                db.Create(value);
                db.Save();
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Item value)
        {
            db.Update(value);
            db.Save();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.Delete(id);
            db.Save();
        }
    }
}
