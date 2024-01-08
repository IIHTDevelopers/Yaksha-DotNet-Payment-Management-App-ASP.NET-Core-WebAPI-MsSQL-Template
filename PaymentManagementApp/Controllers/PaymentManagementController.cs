using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PaymentManagementApp.BusinessLayer.Interfaces;
using PaymentManagementApp.BusinessLayer.ViewModels;
using PaymentManagementApp.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PaymentManagementApp.Controllers
{
    [ApiController]
    public class PaymentManagementController : ControllerBase
    {
        private readonly IPaymentManagementService  _paymentService;
        public PaymentManagementController(IPaymentManagementService paymentservice)
        {
             _paymentService = paymentservice;
        }

        [HttpPost]
        [Route("create-payment")]
        [AllowAnonymous]
        public async Task<IActionResult> CreatePayment([FromBody] Payment model)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpPut]
        [Route("update-payment")]
        public async Task<IActionResult> UpdatePayment([FromBody] PaymentViewModel model)
        {
            //write your code here
            throw new NotImplementedException();
        }

      
        [HttpDelete]
        [Route("delete-payment")]
        public async Task<IActionResult> DeletePayment(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("get-payment-by-id")]
        public async Task<IActionResult> GetPaymentById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("get-all-payments")]
        public async Task<IEnumerable<Payment>> GetAllPayments()
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
