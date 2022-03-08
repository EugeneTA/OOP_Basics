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

    public class AccountTask05
    {

        // (*) Добавить в класс счет в банке два метода: снять со счета и положить на счет.
        // Метод снять со счета проверяет, возможно ли снять запрашиваемую сумму, и в случае положительного результата изменяет баланс.


        static private UInt64 _totalAccounts;   // Общее количество счетов
        private UInt64 _number;                 // Номер счета
        private Decimal _balance;               // Баланс счета
        private AccountType _type;              // Тип счета

        public AccountTask05() : this(AccountType.Undefined)
        {
        }

        public AccountTask05(Decimal balance) : this(AccountType.Current, balance)
        {
        }

        public AccountTask05(AccountType accType) : this(accType, 0)
        {
        }

        public AccountTask05(AccountType accType, Decimal balance)
        {
            _number = ++_totalAccounts;
            _type = accType;
            _balance = balance;
        }


        public UInt64 Number
        {
            get
            {
               if (_number == 0)
                {
                    throw new Exception("Account doesn't exist");
                }
                return _number;
            }
            private set
            {
                _number = value;
            }
        }

        public Decimal Balance
        {
            get
            {
                if (_number == 0)
                {
                    throw new Exception("Account doesn't exist");
                }
                return _balance;
            }
            private set
            {
                if (_number == 0)
                {
                    throw new Exception("Account doesn't exist");
                }

                _balance = value;
            }
        }

        public AccountType Type
        {
            get
            {
                if (_number == 0)
                {
                    throw new Exception("Account doesn't exist");
                }
                return _type;
            }
            private set
            {
                if (_number == 0)
                {
                    throw new Exception("Account doesn't exist");
                }
                _type = value;
            }
        }
     
        public AccountTask05 PutMoney(Decimal amount)
        {
            Balance += amount;
            return this;
        }

        public AccountTask05 WithdrawMoney(Decimal amount)
        {
            if (Balance < amount)
            {
                throw new Exception($"The withdraw amount ({amount}) is exceed you total balance {Balance}.");
            }
            Balance -= amount;
            return this;
        }
    }
}
