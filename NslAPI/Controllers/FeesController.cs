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
    public class FeesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<FeesController> _logger;

        public FeesController(IUnitOfWork unitOfWork, IMapper mapper, ILogger<FeesController> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetFees()
        {
            var fees = await _unitOfWork.Fees.GetAll(null, null, new List<string> { "Member" });
            var result = _mapper.Map<List<FeesDTO>>(fees);
            return Ok(result);
        }

        [HttpGet("{id:int}", Name = "GetFee")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetFee(int id)
        {
            var fees = await _unitOfWork.Fees.Get(f => f.Id == id, new List<string> { "Member" });
            var result = _mapper.Map<FeesDTO>(fees);
            return Ok(result);
        }

        //[Authorize(Roles = "Administrator")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateFees([FromBody] CreateFeesDTO FeesDTO)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogError($"Invalid POST attempt in { nameof(CreateFees)}");
                return BadRequest(ModelState);
            }

            var fees = _mapper.Map<Fees>(FeesDTO);
            await _unitOfWork.Fees.Insert(fees);
            await _unitOfWork.Save();

            return CreatedAtRoute("GetFee", new { id = fees.Id }, fees);
        }

        //[Authorize(Roles = "Administrator")]
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateFees(int id, [FromBody] UpdateFeesDTO feesDTO)
        {
            if (!ModelState.IsValid || id < 1)
            {
                _logger.LogError($"Invalid PUT attempt in { nameof(UpdateFees)}");
                return BadRequest(ModelState);
            }

            var fees = await _unitOfWork.Fees.Get(f => f.Id == id);
            if (fees == null)
            {
                _logger.LogError($"Invalid PUT attempt in { nameof(UpdateFees)}");
                return BadRequest("Submitted data is invalid");
            }

            

            _mapper.Map(feesDTO, fees);

            _unitOfWork.Fees.Update(fees);
            await _unitOfWork.Save();

            return CreatedAtRoute("GetFee", new { id = fees.Id }, fees);
        }

        //[Authorize(Roles = "Administrator")]
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteFees(int id)
        {
            if (id < 1)
            {
                _logger.LogError($"Invalid DELETE attempt in { nameof(DeleteFees)}");
                return BadRequest();
            }

            var country = await _unitOfWork.Fees.Get(f => f.Id == id);
            if (country == null)
            {
                _logger.LogError($"Invalid DELETE attempt in { nameof(DeleteFees)}");
                return BadRequest("Submitted data is invalid");
            }

            await _unitOfWork.Fees.Delete(id);
            await _unitOfWork.Save();

            return NoContent();
        }
    }
}
