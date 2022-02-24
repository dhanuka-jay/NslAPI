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
    public class MemberController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<MemberController> _logger;
        private readonly IMapper _mapper;

        public MemberController(IUnitOfWork unitOfWork, ILogger<MemberController> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetMembers()
        {
            try
            {
                var members = await _unitOfWork.Members.GetAll(null, null, new List<string> { "Fees" });
                var result = _mapper.Map<List<MemberDTO>>(members);
                return Ok(result);
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, $"Something went wrong in the {nameof(GetMembers)}");
                return StatusCode(500, "Internal Server Error; Please try again later");
            }
        } 
    }
}
