using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Treehouse.FitnessFrog.Shared.Data;
using Treehouse.FitnessFrog.Shared.Models;

namespace Treehouse.FitnessFrog.Spa.Controllers
{
    public class EntriesController : ApiController
    {
        private EntriesRepository _entriesRepository = null;

        public EntriesController(EntriesRepository entriesRepository) 
        {
            _entriesRepository = entriesRepository;
        }

        public IHttpActionResult Get() 
        {
            //var activityBiking = new Activity() { Name = "Biking" };
            //return new List<Entry>()
            //{
            //    new Entry(2017, 1, 2, activityBiking, 10.0m),
            //    new Entry(2017, 1, 3, activityBiking, 12.1m)
            //};

            return Ok(_entriesRepository.GetList());
            //return _entriesRepository.GetList();
        }

        public IHttpActionResult Get(int id)
        {
            var entry = _entriesRepository.Get(id);

            if (entry == null) 
            {
                return NotFound();
            }

            return Ok(entry);
        }

        public IHttpActionResult Post(Entry entry)
        {
            _entriesRepository.Add(entry);

            return Created(Url.Link("DefaultApi", new { Controller = "Entries", id = entry.Id }), entry);
        }
        public void Put(int id, Entry entry)
        {
            _entriesRepository.Update(entry);
        }
        public void Delete(int id)
        {
            _entriesRepository.Delete(id);
        }
    }
}