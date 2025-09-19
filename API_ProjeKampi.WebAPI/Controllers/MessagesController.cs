using API_ProjeKampi.WebAPI.Context;
using API_ProjeKampi.WebAPI.Dtos.MessageDtos;
using API_ProjeKampi.WebAPI.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_ProjeKampi.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly API_Context _context;

        public MessagesController(IMapper mapper, API_Context context)
        {
            _mapper = mapper;
            _context = context;
        }

        [HttpGet]
        public IActionResult GetMessages()
        {
            var values = _context.Messages;
            return Ok(_mapper.Map<List<ResultMessageDto>>(values));
        }

        [HttpPost]
        public IActionResult PostMessages(CreateMessageDto createMessageDto)
        {
            var value = _mapper.Map<Message>(createMessageDto);
            _context.Messages.Add(value);
            _context.SaveChanges();
            return Ok("Mesaj ekleme işlemi tamamlandı. ");
        }

        [HttpDelete]
        public IActionResult DeleteMessages(int Id)
        {
            var value = _context.Messages.Find(Id);
            _context.Messages.Remove(value);
            _context.SaveChanges();
            return Ok("Mesaj silme işlemi tamamlandı. ");
        }

        [HttpPut]
        public IActionResult PutMessage(UpdateMessageDto updateMessageDto)
        {
            var value = _mapper.Map<Message>(updateMessageDto);
            _context.Messages.Update(value);
            _context.SaveChanges();
            return Ok("Mesaj güncelleme işlemi tamamlandı. ");
        }

        [HttpGet("GetByIdMessage")]
        public IActionResult GetByIdMessage(int Id)
        {
            var value = _context.Messages.Find(Id);
            return Ok(_mapper.Map<GetByIdMessageDto>(value));
        }


    }
}
