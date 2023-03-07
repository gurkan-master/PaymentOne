namespace PaymentOne.BadPayment
{
    public class PayManagerA
    {
        //Gelen Talepler;
        //1.Tek çekim ve taksitli ödeme özelliği
        //2.X bankası için 3 taksit , Y bankası için 4 taksit olsun, X bankası %10 indirim yapacakken, Y bankasının
        //%5 indirim yapması istendi.
        //3.X bankası için akşam 5 ten sonra indirim geçerli olsun.
        //baya bir condition oluşacak ve yapılması zorlaşacak. yazılım geliştirici bu yapılamaz alt yapı bunu sağlamaz,
        // vb. uygulamanın yeniden yazılması gerektiğini söyler.
        public bool Pay(string product, string basket, string paymentType) { 
            bool result = false;
            string productName = string.Empty;
            string productBasket = string.Empty;

            if (paymentType == "CreditCard") {//kredi kartı
                productName = product;
                productBasket = basket;
                result = this.TakeCreditCardPayment();
            }
            else if(paymentType == "BankTransfer"){//havale
                productName = product;
                productBasket = basket;
                result = this.TakePaymentByBankTransfer();
            }
            else { //default credit card payment
                productName = product;
                productBasket = basket;
                result = this.TakeCreditCardPayment();
            }

            return result;
        }

        private bool TakePaymentByBankTransfer()
        {
            //do something
            return true;
        }

        private bool TakeCreditCardPayment()
        {
            //do something
            return true;
        }
    }
}
