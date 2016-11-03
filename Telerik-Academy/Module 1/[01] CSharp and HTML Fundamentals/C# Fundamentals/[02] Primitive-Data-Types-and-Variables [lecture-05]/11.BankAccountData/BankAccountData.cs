/*
Problem 11. Bank Account Data

A bank account has a holder name (first name, middle name and last name),
available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
Declare the variables needed to keep the information for a single bank account
using the appropriate data types and descriptive names.
*/
namespace BankAccountData
{
    using System;

    class BankAccountData
    {
        static void Main()
        {
            string firstName = "Mad";
            string middleName = "Monster";
            string lastName = "Max";
            decimal balance = 2500;
            string bankName = "BNB";
            string IBAN = "BG80BNBG96611020345678";
            ulong creditCard1 = 144231;
            ulong creditCard2 = 244431;
            ulong creditCard3 = 323114;
        }
    }
}