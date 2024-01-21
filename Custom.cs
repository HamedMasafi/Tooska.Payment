using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tooska.Payment
{
    public class CustomTransaction<T> : AbstractPaymentGateway<T> where T : AbstractTransaction
    {
        public override PaymentForm CreateForm(ref T t)
        {
            var f = new PaymentForm
            {
                Method = PaymentForm.MethodType.Get,
                ActionUrl = Options.Payment.Global.DashboardUrl,
                ButtonText = "بازگشت به صقحه خانگی"
            };
            return f;
        }

        public override int GetTransactionId()
        {
            throw new NotImplementedException();
        }

        public override void InitTransaction(ref T t)
        {
            t.Status = TransactionStatus.Successful;
        }

        public override bool VerifyTransaction(ref T t)
        {
            throw new NotImplementedException();
        }

    }
    [Obsolete("InPlace has been obsoleted, use CustomTransaction")]
    public class InPlace<T> : CustomTransaction<T> where T : AbstractTransaction
    {

    }
}