using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NslAPI.Services.DTOs;
using NslAPI.Services.IRepository;

namespace NslAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public FeesController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetFees()
        {
            var fees = await _unitOfWork.Fees.GetAll(null, null, new List<string> { "Member" });
            var result = _mapper.Map<List<FeesDTO>>(fees);
            return Ok(result);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetMember(int id)
        {
            var fees = await _unitOfWork.Fees.Get(m => m.Id == id, new List<string> { "Member" });
            var result = _mapper.Map<FeesDTO>(fees);
            return Ok(result);
        }
    }
}
