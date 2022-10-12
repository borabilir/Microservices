using UI.Models.FakePayments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Services.Interfaces
{
    public interface IPaymentService
    {
        Task<bool> ReceivePayment(PaymentInfoInput paymentInfoInput);
    }
}