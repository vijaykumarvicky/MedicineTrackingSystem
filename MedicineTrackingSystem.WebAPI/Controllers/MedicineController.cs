using MedicineTrackingSystem.BusinessModel;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MedicineTrackingSystem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicineController : ControllerBase
    {
        private readonly IMedicineService _medicineService;

        public MedicineController( MedicineService medicineService)
        {
            _medicineService = medicineService;
        }

        [HttpGet]
        [Route("api/Medicine/GetMedicines")]
        public IActionResult GetAll()
        {
            var medicines = _medicineService.GetAll();
            return Ok(medicines);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var user = _medicineService.GetById(id);
            return Ok(user);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Medicine model)
        {
           
            try
            {
                _medicineService.Update(model);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _medicineService.Delete(id);
            return Ok();
        }


    }
}
