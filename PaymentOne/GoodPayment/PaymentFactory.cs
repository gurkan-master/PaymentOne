namespace PaymentOne.GoodPayment
{
    public class PaymentFactory
    {
        public IPayment GeneratePayment(string paymentType) {
            if (paymentType == PaymentType.CREDIT_CARD)
                return new CreditCard();

            if (paymentType == PaymentType.BANK_TRANSFER)
                return new BankTransfer();

            return new CreditCard();
        }
    }

    public static class PaymentType {
        public const string CREDIT_CARD = "CreditCard";
        public const string BANK_TRANSFER = "BankTransfer";
    }

}
