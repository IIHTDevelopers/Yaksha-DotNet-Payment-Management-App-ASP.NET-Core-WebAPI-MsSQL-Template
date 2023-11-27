using PaymentManagementApp.BusinessLayer.Interfaces;
using PaymentManagementApp.BusinessLayer.Services.Repository;
using PaymentManagementApp.BusinessLayer.ViewModels;
using PaymentManagementApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PaymentManagementApp.BusinessLayer.Services
{
    public class PaymentManagementService : IPaymentManagementService
    {
        private readonly IPaymentManagementRepository _repo;

        public PaymentManagementService(IPaymentManagementRepository repo)
        {
            _repo = repo;
        }

        public async Task<Payment> CreatePayment(Payment employeePayment)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<bool> DeletePaymentById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public List<Payment> GetAllPayments()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<Payment> GetPaymentById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<Payment> UpdatePayment(PaymentViewModel model)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
