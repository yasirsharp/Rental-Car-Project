using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {
        IRentalService _rentalService;

        public RentalsController(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }

        //Get Rentals All
        [HttpGet("GRAll")]
        public IActionResult GetRentalsAll()
        {
            var result = _rentalService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        
        //Get Rental Detail
        [HttpGet("GRDetail")]
        public IActionResult GetRentalDetail()
        {
            var result = _rentalService.GetRentalCarDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        
        //Rental Add
        [HttpPost("RAdd")]
        public IActionResult RentalAdd(Rental rental)
        {
            var result = _rentalService.Add(rental);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        
        //Rental Update
        [HttpPost("RUpdate")]
        public IActionResult RentalUpdate(Rental rental)
        {
            var result = _rentalService.Update(rental);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        
        //Rental Delete
        [HttpPost("RDelete")]
        public IActionResult RentalDelete(Rental rental)
        {
            var result = _rentalService.Delete(rental);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        
        //Rental Update Return Date
        [HttpPost("RUpdateReturnDate")]
        public IActionResult RentalUpdateReturnDate(Rental rental)
        {
            var result = _rentalService.UpdateReturnDate(rental);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        
        //Rental Check Return Date
        [HttpPost("RCheckReturnDate")]
        public IActionResult RentalCheckReturnDate(int carId)
        {
            var result = _rentalService.ChechReturnDate(carId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
