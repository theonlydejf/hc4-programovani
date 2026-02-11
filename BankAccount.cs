using System;
using System.Collections.Generic;
using System.Linq;

public sealed class BankAccount
{
    private readonly List<Transaction> transactions = new();

    public string Owner { get; }

    public double Balance =>
        transactions.Sum(t =>
            (ReferenceEquals(t.To, this) ? t.Amount : 0.0) -
            (ReferenceEquals(t.From, this) ? t.Amount : 0.0));

    public IReadOnlyList<Transaction> Transactions => transactions;

    public BankAccount(string owner)
    {
        if (string.IsNullOrWhiteSpace(owner))
            throw new ArgumentException("Owner nesmí být prázdný.", nameof(owner));

        Owner = owner;
    }

    public void Deposit(double amount)
    {
        ValidateAmount(amount);

        var t = new Transaction(from: null, to: this, amount: amount);
        transactions.Add(t);
    }

    public void Withdraw(double amount)
    {
        ValidateAmount(amount);

        if (Balance <= amount)
            throw new InvalidOperationException("Nedostatečný zůstatek.");

        var t = new Transaction(from: this, to: null, amount: amount);
        transactions.Add(t);
    }

    public void SendMoney(BankAccount to, double amount)
    {
        if (to is null) throw new ArgumentNullException(nameof(to));
        if (ReferenceEquals(to, this))
            throw new ArgumentException("Nelze poslat peníze na stejný účet.", nameof(to));

        ValidateAmount(amount);

        if (Balance < amount)
            throw new InvalidOperationException("Nedostatečný zůstatek.");

        var t = new Transaction(from: this, to: to, amount: amount);
        transactions.Add(t);
        to.transactions.Add(t);
    }

    private static void ValidateAmount(double amount)
    {
        if (double.IsNaN(amount) || double.IsInfinity(amount))
            throw new ArgumentException("Amount musí být konečné číslo.", nameof(amount));
        if (amount <= 0)
            throw new ArgumentException("Amount musí být > 0.", nameof(amount));
    }
}

public sealed class Transaction
{
    public BankAccount? From { get; }
    public BankAccount? To { get; }
    public double Amount { get; }

    public Transaction(BankAccount? from, BankAccount? to, double amount)
    {
        if (from is null && to is null)
            throw new ArgumentException("From a To nemůžou být obě null zároveň.");
        if (ReferenceEquals(from, to))
            throw new ArgumentException("From a To nemůžou být stejný účet");

        if (double.IsNaN(amount) || double.IsInfinity(amount))
            throw new ArgumentException("Amount musí být konečné číslo.", nameof(amount));
        if (amount <= 0)
            throw new ArgumentException("Amount musí být > 0.", nameof(amount));

        From = from;
        To = to;
        Amount = amount;
    }
}
