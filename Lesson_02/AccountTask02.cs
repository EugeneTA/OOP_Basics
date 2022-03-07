using System;
using System.Text;

namespace Lesson_02
{
    public enum AccountType
    {
        Undefined,
        Current,
        Credit,
        Deposit
    }

    class AccountTask02
    {
        // Изменить класс счет в банке из упражнения таким образом,
        // чтобы номер счета генерировался сам и был уникальным.
        // Для этого надо создать в классе статическую переменную и метод, который увеличивает значение этого переменной.


        static UInt64 _totalAccounts;
        UInt64 _number;
        Decimal _balance;
        AccountType _type;

 
        public UInt64 CreateAccount()
        {
            _number = ++_totalAccounts;
            return _number;
        }


        public UInt64 GetAccountNumber()
        {
            return _number;
        }

        public decimal PutTheMoney(decimal amount)
        {
            if (_number != 0)
            {
                _balance += amount;
                return _balance;
            }

            throw new Exception("Account doesn't exist");
        }

        public decimal WithdrawMoney(decimal amount)
        {
            if (_number != 0)
            {
                if (amount > _balance)
                {
                    throw new Exception($"The withdraw amount is exceed the amount of you account. You total account amount is {_balance}.");
                }
                
                _balance -= amount;
                return _balance;
            }

            throw new Exception("Account doesn't exist");
        }

        public decimal GetAccountAmount()
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
