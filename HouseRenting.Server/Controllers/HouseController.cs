using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HouseRenting.Server.Sevices;
using Housereting.Share.HouseDTOs;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HouseRenting.Server.Controllers
{
    [ApiController]

    [Route("api/[controller]")]
    public class HouseController : Controller
    {

        private readonly IHouseService _service;
        public HouseController(IHouseService service)
        {
            _service = service;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllHouseAsync()
        {
            return Ok(await _service.GetAllHouseAsync());

        }
        [HttpGet("id")]
        public async Task<IActionResult> GetAllHouseByIdAsync(int id)
        {

            return Ok(await _service.GetHouseByIdAsync(id));

        }

        [HttpPost]
        public async Task<IActionResult> CreateHouseAsync([FromBody] HouseRequest houseRequest)
        {

            return Ok(await _service.CreateHouseAsync(houseRequest));

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateHouseAsync(int id, [FromBody] HouseRequest houseRequest)
        {

            return Ok(await _service.UpdateHouseAsync(id, houseRequest));

        }
        [HttpDelete]
        public async Task<IActionResult> DeleteHouseAsync(int id)
        {

            return Ok(await _service.DeleteHouseAsync(id));

        }

    }
}

