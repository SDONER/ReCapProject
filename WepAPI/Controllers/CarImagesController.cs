using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        //Loosly Coupled
        //Naming convantion
        //IoC Container
        ICarImageService _carImageService;

            public CarImagesController(ICarImageService carImageService)
            {
                _carImageService = carImageService;
            }

            [HttpGet("getall")]
            public IActionResult GetAll(CarImage carImage)
            {
                var result = _carImageService.GetAll();
                if (result.Success)
                {
                    return Ok(result.Data);
                }
                return BadRequest(result);
            }


            [HttpGet("getbyid")]
            public IActionResult GetById(int Id)
            {
                var result = _carImageService.GetById(Id);
                if (result.Success)
                {
                    return Ok(result.Data);
                }
                return BadRequest(result);
            }


            [HttpGet("getimagesbycarid")]
            public IActionResult GetImagesByCarId(int Id)
            {
               var result = _carImageService.GetImagesByCarId(Id);
               if (result.Success)
               {
                return Ok(result.Data);
               }
               return BadRequest(result);
            }

        [HttpPost("add")]
            public IActionResult Add([FromForm(Name = ("Image"))] IFormFile file, [FromForm] CarImage carImage)
            {
                var result = _carImageService.Add(file,carImage);
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }

            [HttpPost("delete")]
            public IActionResult Delete(CarImage carImage)
            {
                var result = _carImageService.Delete(carImage);
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }

            [HttpPost("update")]
            public IActionResult Update([FromForm(Name = ("Image"))] IFormFile file, [FromForm(Name = ("Id"))] int Id)
            {
            var carImage = _carImageService.Get(Id).Data;
            var result = _carImageService.Update(file, carImage);
            if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }

        
    }
}
