using HandenurAgbulutMidterm.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.AspNetCore.Authorization;

namespace HandenurAgbulutMidterm.Controllers
{
    [ApiController]
    [Route("api/v1/website")]
    [Authorize] // Apply authorization to the entire controller
    public class WebsiteController : ControllerBase
    {
        [HttpPost("pay")]
        public IActionResult PayBill(int subscriberNo, DateTime month)
        {
            // Implement logic to pay bill
            bool paymentStatus = true; // Simulated response
            return Ok(new { PaymentStatus = paymentStatus ? "Successful" : "Error" });
        }

        [HttpPost("admin/addbill")]
        public IActionResult AddBill(int subscriberNo, DateTime month)
        {
            // Implement logic to add bill
            bool transactionStatus = true; // Simulated response
            return Ok(new { TransactionStatus = transactionStatus });
        }
    }
}

