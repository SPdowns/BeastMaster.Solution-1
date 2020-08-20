using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BeastMaster.Models;
using Microsoft.EntityFrameworkCore;

namespace BeastMaster.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreaturesController : ControllerBase
    {
        private BeastMasterContext _db;

        public CreaturesController(BeastMasterContext db)
        {
            _db = db;
        }

        // GET api/creatures
        // [HttpGet]
        // public ActionResult<IEnumerable<string>> Get()
        // {
        //     return new string[] { "value1", "value2" };
        // }

    
        // [HttpGet]                                          // This one is working
        // public ActionResult<IEnumerable<Creature>> Get()
        //     {
        //     return _db.Creatures.ToList();
        //     }
        
    
   // GET api/creatures
    [HttpGet]
    public ActionResult<IEnumerable<Creature>> Get(string creatureName, string creatureOriginDate, string creatureTaxonomy, string creatureType, string creatureAbility, string creatureHabitat, string creatureMorality, string creatureDescription, string creatureLifespan, string creatureRelatedCreature, string creatureNemesis, string creatureWeakness, string creatureOriginCulture, string creatureImage)
    {
        var query = _db.Creatures.AsQueryable(); //standard

        if (creatureTaxonomy != null)
        {
            query = query.Where(entry => entry.CreatureTaxonomy == creatureTaxonomy);
        }

        if (creatureName != null)
        {
            query = query.Where(entry => entry.CreatureName == creatureName);
        }

        if (creatureOriginCulture != null)
        {
            query = query.Where(entry => entry.CreatureOriginCulture == creatureOriginCulture);
        }
        
        if (creatureOriginDate != null)
        {
            query = query.Where(entry => entry.CreatureOriginDate == creatureOriginDate);
        }
        
        if (creatureType != null)
        {
            query = query.Where(entry => entry.CreatureType == creatureType);
        }

        if (creatureAbility != null)
        {
            query = query.Where(entry => entry.CreatureAbility == creatureAbility);
        }

        if (creatureHabitat != null)
        {
            query = query.Where(entry => entry.CreatureHabitat == creatureHabitat);
        }
        
        if (creatureMorality != null)
        {
            query = query.Where(entry => entry.CreatureMorality == creatureMorality);
        }
        
        if (creatureDescription != null)
        {
            query = query.Where(entry => entry.CreatureDescription == creatureDescription);
        }
    
        if (creatureImage != null)
        {
            query = query.Where(entry => entry.CreatureImage == creatureImage);
        }
    
        if (creatureLifespan != null)
        {
            query = query.Where(entry => entry.CreatureLifespan == creatureLifespan);
        }

        if (creatureRelatedCreature != null)
        {
            query = query.Where(entry => entry.CreatureRelatedCreature == creatureRelatedCreature);
        }

        if (creatureNemesis != null)
        {
            query = query.Where(entry => entry.CreatureNemesis == creatureNemesis);
        }

        if (creatureWeakness != null)
        {
            query = query.Where(entry => entry.CreatureWeakness == creatureWeakness);
        }

        return query.ToList();
    }

/*         [HttpGet("{id}")]
        public ActionResult<IEnumerable<Creature>> Get(int id)
        {
            
            var query = _db.Creatures.AsQueryable();
            
            query = query.Where(entry => entry.CreatureTaxonomy == creatureTaxonomy);
        }
 */
    
        // [HttpGet("{id}")]
        // public ActionResult<IEnumerable<Creature>> Get(string creatureTaxonomy, int id)
        // {
        // var query = _db.Creatures.AsQueryable();

        // if (creatureTaxonomy != null)
        // {
        //     query = query.Where(entry => entry.CreatureTaxonomy == creatureTaxonomy);
        // }

        //     return query.ToList();
        // }

        [HttpPost]
        public void Post([FromBody] Creature creature)
        {
            _db.Creatures.Add(creature);
            _db.SaveChanges();
        }

        [HttpGet ("{id}")]
        public ActionResult<Creature> Get(int id)
        {
        return _db.Creatures.FirstOrDefault(entry => entry.CreatureId == id);
        }
        
        //Pagination
        [HttpGet("page")]
        public ActionResult GetPage([FromQuery] UrlQuery urlQuery)
        {
            var validUrlQuery = new UrlQuery(urlQuery.PageNumber, urlQuery.PageSize);
            var pagedData = _db.Creatures
                .OrderBy(creature => creature.CreatureId)
                .Skip((validUrlQuery.PageNumber - 1) * validUrlQuery.PageSize)
                .Take(validUrlQuery.PageSize);
            return Ok(pagedData);
        }

        // PUT api/creatures/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Creature creature)
        {
            creature.CreatureId = id;
            _db.Entry(creature).State = EntityState.Modified;
            _db.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var creatureToDelete = _db.Creatures.FirstOrDefault(entry => entry.CreatureId == id);
            _db.Creatures.Remove(creatureToDelete);
            _db.SaveChanges();
        }
    }
}
