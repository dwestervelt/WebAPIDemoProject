using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIDemoProject.LiteDB;

namespace WebAPIDemoProject.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly ILogger<ContactsController> _logger;
        private readonly ILiteDbContactsService _contactsDbService;

        public ContactsController(ILogger<ContactsController> logger, ILiteDbContactsService contactsDbService)
        {
            _contactsDbService = contactsDbService;
            _logger = logger;
        }
        
        // GET api/contacts
        [HttpGet]
        public IEnumerable<Contacts> Get()
        {
            return _contactsDbService.FindAll();
        }

        // POST api/contacts
        [HttpPost]
        public ActionResult<Contacts> Insert(Contacts dto)
        {
            var id = _contactsDbService.Insert(dto);
            if (id != default)
                return CreatedAtRoute("FindOne", new { id = id }, dto);
            else
                return BadRequest();
        }

        // PUT api/contacts/5
        [HttpPut("{id}")]
        public ActionResult<Contacts> Update(Contacts dto)
        {
            var result = _contactsDbService.Update(dto);
            if (result)
                return Ok(result);
            else
                return NotFound();
        }

        // GET api/contacts/5
        [HttpGet("{id}", Name = "FindOne")]
        public ActionResult<Contacts> Get(int id)
        {          
                var result = _contactsDbService.FindOne(id);
                if (result != default)
                    return Ok(_contactsDbService.FindOne(id));
                else
                    return NotFound();                       
        }

        // DELETE api/contacts/5
        [HttpDelete("{id}")]
        public ActionResult<Contacts> Delete(int id)
        {
            var result = _contactsDbService.Delete(id);
            if (result > 0)
                return Ok();
            else
                return NotFound();
        }

        ////additional routing for get call-list
        [Route("/Contacts/call-list")]
        // GET api/contacts
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetCallList()          
        {
            //build out call list method
            return Ok();
            
        }

    }

}
