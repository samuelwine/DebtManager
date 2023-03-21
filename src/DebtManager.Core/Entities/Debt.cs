namespace DebtManager.Core.Entities;

public class Debt
{
    public int Id { get; set; }
    public DateTimeOffset LoanDate { get; set; }
    public DateTimeOffset? DueDate { get; set; }
    public decimal LoanAmount { get; set; }
    public decimal AmountOutstanding { get; set; }
    public List<Payment> Payments { get; set; }
    public string Creditor { get; set; }
}