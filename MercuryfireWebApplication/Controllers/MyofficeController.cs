using MercuryfireWebApplication.Models;
using MercuryfireWebApplication.Services;
using Microsoft.AspNetCore.Mvc;

namespace MercuryfireWebApplication.Controllers
{
    public class MyofficeController : Controller
    {
        private readonly IMyofficeService _myofficeService;


        public MyofficeController(IMyofficeService myofficeService)
        {
            _myofficeService = myofficeService;
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public async Task<IActionResult> GetMyofficeACPDById([FromRoute]string id)
        {
            var result = await _myofficeService.GetMyofficeACPDById(id);

            return Ok(result);
        }

        [HttpPost]
        [Route("api/[controller]")]
        public async Task<IActionResult> CreateMyofficeACPD([FromBody] MyofficeACPDModel model)
        {
            if (model == null)
            {
                return BadRequest("Invalid data.");
            }

            var result = await _myofficeService.CreateMyofficeACPD(model);

            if (result)
            {
                return Ok("Record successfully created.");
            }

            return StatusCode(500, "An error occurred while creating the record.");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMyofficeACPD([FromBody] MyofficeACPDModel model)
        {
            if (model == null)
            {
                return BadRequest("Invalid data.");
            }

            var existingRecord = await _myofficeService.GetMyofficeACPDById(model.Acpd_Sid);
            if (existingRecord == null)
            {
                return NotFound("Record not found.");
            }

            var result = await _myofficeService.UpdateMyofficeACPD(model);

            if (result)
            {
                return Ok("Record successfully updated.");
            }

            return StatusCode(500, "An error occurred while updating the record.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMyofficeACPD(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return BadRequest("Invalid ID.");
            }

            var existingRecord = await _myofficeService.GetMyofficeACPDById(id);
            if (existingRecord == null)
            {
                return NotFound("Record not found.");
            }

            var result = await _myofficeService.DeleteMyofficeACPD(id);

            if (result)
            {
                return Ok("Record successfully deleted.");
            }

            return StatusCode(500, "An error occurred while deleting the record.");
        }
    }
}
