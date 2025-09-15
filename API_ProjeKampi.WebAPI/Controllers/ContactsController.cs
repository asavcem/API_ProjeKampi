using API_ProjeKampi.WebAPI.Context;
using API_ProjeKampi.WebAPI.Dtos.ContactDtos;
using API_ProjeKampi.WebAPI.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_ProjeKampi.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly API_Context _context;

        public ContactsController(API_Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetContacts()
        {
            var values = _context.Contacts;
            return Ok(values);
        }

        [HttpPost]
        public IActionResult PostContacts(CreateContactDto contactDto)
        {
            Contact contact = new Contact();
            contact.Phone = contactDto.Phone;
            contact.Email = contactDto.Email;
            contact.Address = contactDto.Address;
            contact.MapLocation = contactDto.MapLocation;
            contact.OpenHours = contactDto.OpenHours;

            _context.Contacts.Add(contact);
            _context.SaveChanges();

            return Ok("İletişim bilgileri eklendi. ");
        }

        [HttpDelete]
        public IActionResult DeleteContacts(int Id)
        {
            var value = _context.Contacts.Find();
            _context.Contacts.Remove(value);
            _context.SaveChanges();
            return Ok("İlteişim bilgileri silindi. ");
        }

        [HttpGet("GetContact")]
        public IActionResult GetContact(int Id)
        {
            var value = _context.Contacts.Find(Id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult PutContact(UpdateContactDto updateContactDto)
        {
            Contact contact = new Contact();
            contact.Phone = updateContactDto.Phone;
            contact.Email = updateContactDto.Email;
            contact.Address = updateContactDto.Address;
            contact.MapLocation = updateContactDto.MapLocation;
            contact.OpenHours = updateContactDto.OpenHours;
            contact.ContactId = updateContactDto.ContactId;
            _context.Contacts.Update(contact);
            _context.SaveChanges();
            return Ok("İletişim bilgileri güncellendi. ");
        }
    }
}
