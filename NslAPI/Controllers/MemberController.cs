using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NslAPI.Services.DTOs;
using NslAPI.Services.IRepository;

namespace NslAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public MemberController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetMembers()
        {
            var members = await _unitOfWork.Members.GetAll(null, null, new List<string> { "Fees" });
            var result = _mapper.Map<List<MemberDTO>>(members);
            return Ok(result);
        }

        [Authorize]
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetMember(int id)
        {
            var member = await _unitOfWork.Members.Get(m => m.Id == id, new List<string> { "Fees" });
            var result = _mapper.Map<MemberDTO>(member);
            return Ok(result);
        }
    }
}
