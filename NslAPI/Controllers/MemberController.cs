using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NslAPI.Data;
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
        private readonly ILogger<MemberController> _logger;

        public MemberController(IUnitOfWork unitOfWork, IMapper mapper, ILogger<MemberController> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetMembers()
        {
            var members = await _unitOfWork.Members.GetAll(null, null, new List<string> { "Fees" });
            var result = _mapper.Map<List<MemberDTO>>(members);
            return Ok(result);
        }

        [Authorize]
        [HttpGet("{id:int}", Name = "GetMember")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetMember(int id)
        {
            var member = await _unitOfWork.Members.Get(m => m.Id == id, new List<string> { "Fees" });
            var result = _mapper.Map<MemberDTO>(member);
            return Ok(result);
        }

        //[Authorize(Roles = "Administrator")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateMember([FromBody] CreateMemberDTO memberDTO)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogError($"Invalid POST attempt in { nameof(CreateMember)}");
                return BadRequest(ModelState);
            }

            var member = _mapper.Map<Member>(memberDTO);
            await _unitOfWork.Members.Insert(member);
            await _unitOfWork.Save();

            return CreatedAtRoute("GetMember", new { id = member.Id }, member);
        }

        //[Authorize(Roles = "Administrator")]
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateMember(int id, [FromBody] UpdateMemberDTO memberDTO)
        {
            if (!ModelState.IsValid || id < 1)
            {
                _logger.LogError($"Invalid PUT attempt in { nameof(UpdateMember)}");
                return BadRequest(ModelState);
            }

            var member = await _unitOfWork.Members.Get(m => m.Id == id);
            if (member == null)
            {
                _logger.LogError($"Invalid PUT attempt in { nameof(UpdateMember)}");
                return BadRequest("Submitted data is invalid");
            }

            _mapper.Map(memberDTO, member);
           
            _unitOfWork.Members.Update(member);
            await _unitOfWork.Save();

            return CreatedAtRoute("GetMember", new { id = member.Id }, member);
        }

        //[Authorize(Roles = "Administrator")]
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteMember(int id)
        {
            if (id < 1)
            {
                _logger.LogError($"Invalid DELETE attempt in { nameof(DeleteMember)}");
                return BadRequest();
            }

            var country = await _unitOfWork.Members.Get(m => m.Id == id);
            if (country == null)
            {
                _logger.LogError($"Invalid DELETE attempt in { nameof(DeleteMember)}");
                return BadRequest("Submitted data is invalid");
            }

            await _unitOfWork.Members.Delete(id);
            await _unitOfWork.Save();

            return NoContent();
        }

    }
}
