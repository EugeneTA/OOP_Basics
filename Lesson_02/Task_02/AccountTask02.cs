using System;
using System.Text;

namespace Lesson_02
{
    public enum AccountType
    {
        Undefined,
        Current,    // Текущий, расчетный
        Credit,     // Кредитный
        Deposit     // Депозит
    }

    public class AccountTask02
    {
        // Изменить класс счет в банке из упражнения таким образом,
        // чтобы номер счета генерировался сам и был уникальным.
        // Для этого надо создать в классе статическую переменную и метод, который увеличивает значение этого переменной.


        static private UInt64 _totalAccounts;
        private UInt64 _number;
        private Decimal _balance;
        private AccountType _type;

 
        public UInt64 CreateAccount()
        {
            _number = ++_totalAccounts;
            return _number;
        }

        public UInt64 GetAccountNumber()
        {
            return _number;
        }

        public void SetBalance(decimal amount)
        {
            if (_number != 0)
            {
                _balance = amount;
            }
            else
            {
                throw new Exception("Account doesn't exist");
            }
        }

        public decimal GetBalance()
        {
            if (_number != 0)
            {
                return _balance;
            }

            throw new Exception("Account doesn't exist");
        }

        public void SetAccountType(AccountType accountType)
        {
            if (_number != 0)
            {
                _type = accountType;
            }
            else
            {
                throw new Exception("Account doesn't exist");
            }

        }

        public AccountType GetAccountType()
        {
            if (_number != 0)
            {
                return _type;
            }
            else
            {
                throw new Exception("Account doesn't exist");
            }

        }
    }
}
