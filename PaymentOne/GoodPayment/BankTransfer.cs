namespace PaymentOne.GoodPayment
{
    public class BankTransfer : IPayment
    {
        public bool Pay()
        {
            return this.TakePaymentByBankTransfer();
        }

        private bool TakePaymentByBankTransfer()
        {
            Console.WriteLine("Banka hesabı kontrol edildi ve havale yapıldı.");
            return true;
        }
    }
}
