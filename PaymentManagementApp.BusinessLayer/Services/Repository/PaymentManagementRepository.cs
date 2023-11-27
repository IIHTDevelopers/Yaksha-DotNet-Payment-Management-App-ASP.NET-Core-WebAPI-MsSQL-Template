using Microsoft.EntityFrameworkCore;
using PaymentManagementApp.BusinessLayer.ViewModels;
using PaymentManagementApp.DataLayer;
using PaymentManagementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PaymentManagementApp.BusinessLayer.Services.Repository
{
    public class PaymentManagementRepository : IPaymentManagementRepository
    {
        private readonly PaymentManagementAppDbContext _dbContext;
        public PaymentManagementRepository(PaymentManagementAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Payment> CreatePayment(Payment PaymentModel)
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