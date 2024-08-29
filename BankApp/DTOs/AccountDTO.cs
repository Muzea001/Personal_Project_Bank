﻿namespace BankApp.DTOs
{
    public class AccountDTO
    {
        public int AccountId { get; set; }
        public string AccountType { get; set; }
        public decimal Balance { get; set; }
        public decimal DebtSum { get; set; }
        public int BankId { get; set; }
        public int UserId { get; set; }
    }
}
