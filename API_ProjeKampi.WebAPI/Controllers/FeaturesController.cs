using API_ProjeKampi.WebAPI.Context;
using API_ProjeKampi.WebAPI.Dtos.FeatureDtos;
using API_ProjeKampi.WebAPI.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_ProjeKampi.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeaturesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly API_Context _context;
        
        public FeaturesController(IMapper mapper, API_Context context)
        {
            _mapper = mapper;
            _context = context;
        }

        [HttpGet]
        public IActionResult GetFeature()
        {
            var values = _context.Features;
            return Ok(_mapper.Map<List<ResultFeatureDto>>(values));
        }

        [HttpPost]
        public IActionResult PostFeature(CreateFeatureDto createFeatureDto)
        {
            var value = _mapper.Map<Feature>(createFeatureDto);
            _context.Features.Add(value);
            _context.SaveChanges();
            return Ok("Özellik eklendi.");
        }

        [HttpDelete]
        public IActionResult DeleteFeature(int Id)
        {
            var value = _context.Features.Find(Id);
            _context.Features.Remove(value);
            _context.SaveChanges();
            return Ok("Özellik silindi.");
        }

        [HttpGet("GetFeatureById")]
        public IActionResult GetFeatureById(int Id)
        {
            var value = _context.Features.Find(Id);
            return Ok(_mapper.Map<GetByIdFeatureDto>(value));
        }

        [HttpPut]
        public IActionResult PutFeature(UpdateFeatureDto updateFeatureDto)
        {
            var value = _mapper.Map<Feature>(updateFeatureDto);
            _context.Features.Update(value);
            _context.SaveChanges();
            return Ok("Özellik güncellendi.");
        }

    }
}
