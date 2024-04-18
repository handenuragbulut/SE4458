using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace HandenurAgbulutMidterm.Controllers
{
    [ApiController]
    [Route("api/v1/mobileprovider")]
    [Authorize] // Apply authorization to the entire controller
    public class MobileProviderController : ControllerBase
    {
        [HttpGet("bills")]
        public IActionResult QueryBill(int subscriberNo, DateTime month)
        {
            // Implement logic to query bill
            return Ok(new { BillTotal = 100.00m, PaidStatus = true });
        }

        [HttpGet("bills/details")]
        public IActionResult QueryBillDetailed(int subscriberNo, DateTime month)
        {
            // Implement logic to query detailed bill
            return Ok(new { BillTotal = 100.00m, BillDetails = "Details..." });
        }
    }
    public class BillResponse
    {
        public decimal BillTotal { get; set; }
        public bool PaidStatus { get; set; }
    }

    public class BillDetailedResponse
    {
        public decimal BillTotal { get; set; }
        public string BillDetails { get; set; }
    }

    
    public class PaymentStatus
    {
        public string Status { get; set; }
    }

    public class TransactionStatus
    {
        public string Status { get; set; }
    }

}
