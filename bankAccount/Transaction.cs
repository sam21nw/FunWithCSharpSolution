using System;

public class Transaction
{
  public decimal Amount { get; }
  public DateTime Date { get; }
  public string Notes { get; }
  public Transaction(decimal amount, DateTime date, string note) =>
  (Amount, Date, Notes) = (amount, date, note);
}
