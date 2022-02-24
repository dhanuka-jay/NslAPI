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
    public class PlayerController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PlayerController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetPlayers()
        {
            var players = await _unitOfWork.Players.GetAll(null, null, new List<string> { "Member" });
            var result = _mapper.Map<List<PlayerDTO>>(players);
            return Ok(result);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetPlayer(int id)
        {
            var player = await _unitOfWork.Players.Get(m => m.Id == id, new List<string> { "Member" });
            var result = _mapper.Map<PlayerDTO>(player);
            return Ok(result);
        }
    }
}
