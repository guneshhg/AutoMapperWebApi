using AutoMapper;
using AutoMapperWebApi.DTOs;
using AutoMapperWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeveloperController : ControllerBase
    {
        private readonly IMapper _mapper;
        public DeveloperController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult>Post(Developer developer)
        {
            var developerDtoMapped = _mapper.Map<DeveloperDTO>(developer);
            return Ok(developerDtoMapped);
        }

    }
}
