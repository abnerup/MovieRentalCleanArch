using App.Application.Service.Interface;
using App.Domain.Entities;
using Microsoft.AspNetCore.Mvc;


namespace Movies.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalController : ControllerBase
    {
        private readonly IRentalService _rentalService;

        public RentalController(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Rental>>> GetAllRentals()
        {
            var list = await _rentalService.GetAllRentals();
            return Ok(list);
        }

        [HttpPut]
        public async Task<ActionResult<List<Rental>>> CreateRental(Rental req)
        {
            var list = await _rentalService.CreateRental(req);
            return Ok(list);
        }

    }
}
