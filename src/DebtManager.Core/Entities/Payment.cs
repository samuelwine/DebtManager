using DebtManager.Core.Enums;

namespace DebtManager.Core.Entities
{
    public class Payment
    {
        public int Id { get; set; }
        public DateTimeOffset Date { get; set; }
        public decimal Amount { get; set; }
        public PaymentMethods PaymentMethod { get; set; }
    }
}
