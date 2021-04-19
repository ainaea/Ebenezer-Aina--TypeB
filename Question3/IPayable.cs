namespace Question3
{
    public interface IPayable
    {
        public decimal RetrieveAmount();

        public void AddToAmountDue(double addition);

        public string PaymentAddress();

    }
}