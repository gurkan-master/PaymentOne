namespace PaymentOne.GoodPayment
{
    public class CreditCard : IPayment
    {
        public bool Pay()
        {
            return this.TakeCreditCardPayment();
        }

        private bool TakeCreditCardPayment()
        {
            Console.WriteLine("Kredi Kartı ile ödeme yapıldı.");
            return true;
        }
    }
}
