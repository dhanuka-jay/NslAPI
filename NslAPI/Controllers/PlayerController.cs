using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
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
    public class PlayerController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<PlayerController> _logger;

        public PlayerController(IUnitOfWork unitOfWork, IMapper mapper, ILogger<PlayerController> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetPlayers()
        {
            var players = await _unitOfWork.Players.GetAll(null, null, new List<string> { "Member" });
            var result = _mapper.Map<List<PlayerDTO>>(players);
            return Ok(result);
        }

        [HttpGet("{id:int}", Name = "GetPlayer")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetPlayer(int id)
        {
            var player = await _unitOfWork.Players.Get(m => m.Id == id, new List<string> { "Member" });
            var result = _mapper.Map<PlayerDTO>(player);
            return Ok(result);
        }

        //[Authorize(Roles = "Administrator")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreatePlayer([FromBody] CreatePlayerDTO playerDTO)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogError($"Invalid POST attempt in { nameof(CreatePlayer)}");
                return BadRequest(ModelState);
            }

            var player = _mapper.Map<Player>(playerDTO);
            await _unitOfWork.Players.Insert(player);
            await _unitOfWork.Save();

            return CreatedAtRoute("GetPlayer", new { id = player.Id }, player);
        }

        //[Authorize(Roles = "Administrator")]
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdatePlayer(int id, [FromBody] UpdatePlayerDTO playerDTO)
        {
            if (!ModelState.IsValid || id < 1)
            {
                _logger.LogError($"Invalid PUT attempt in { nameof(UpdatePlayer)}");
                return BadRequest(ModelState);
            }

            var player = await _unitOfWork.Players.Get(p => p.Id == id);
            if (player == null)
            {
                _logger.LogError($"Invalid PUT attempt in { nameof(UpdatePlayer)}");
                return BadRequest("Submitted data is invalid");
            }            

            _mapper.Map(playerDTO, player);

            _unitOfWork.Players.Update(player);
            await _unitOfWork.Save();

            return CreatedAtRoute("GetPlayer", new { id = player.Id }, player);
        }

        //[Authorize(Roles = "Administrator")]
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeletePlayer(int id)
        {
            if (id < 1)
            {
                _logger.LogError($"Invalid DELETE attempt in { nameof(DeletePlayer)}");
                return BadRequest();
            }

            var country = await _unitOfWork.Players.Get(p => p.Id == id);
            if (country == null)
            {
                _logger.LogError($"Invalid DELETE attempt in { nameof(DeletePlayer)}");
                return BadRequest("Submitted data is invalid");
            }

            await _unitOfWork.Players.Delete(id);
            await _unitOfWork.Save();

            return NoContent();
        }
    }
}
