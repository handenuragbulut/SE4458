using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace HandenurAgbulutMidterm.Controllers
{
    [ApiController]
    [Route("api/v1/banking")]
    [Authorize] // Apply authorization to the entire controller
    public class BankingController : ControllerBase
    {
        [HttpGet("bills")]
        public IActionResult QueryBill(int subscriberNo)
        {
            // Implement logic to query unpaid bills
            return Ok(new { UnpaidBills = new List<string> { "January", "February" } });
        }
    }
}
    