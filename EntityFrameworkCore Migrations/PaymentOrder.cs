namespace EntityFrameworkCore_Migrations
{
    public class PaymentOrder
    {
        public PaymentOrder(double amount, string phone, string payee, string beneficiary, string poNumber)
        {
            Amount = amount;
            Phone = phone;
            Payee = payee;
            Beneficiary = beneficiary;
            PoNumber = poNumber;
        }
        public double Amount { get; protected set; }

        public string Phone { get; protected set; }

        public string Payee { get; protected set; }

        public string Beneficiary { get; protected set; }

        public string PoNumber { get; protected set; }
    }
}