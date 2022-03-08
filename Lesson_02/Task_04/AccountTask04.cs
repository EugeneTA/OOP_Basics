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

    public class AccountTask04
    {

        // В классе все методы для заполнения и получения значений полей заменить на свойства.
        // Написать тестовый пример.


        static private UInt64 _totalAccounts;
        private UInt64 _number;
        private Decimal _balance;
        private AccountType _type;

        public AccountTask04() : this(AccountType.Undefined)
        {
        }

        public AccountTask04(Decimal balance) : this(AccountType.Current, balance)
        {
        }

        public AccountTask04(AccountType accType) : this(accType, 0)
        {
        }

        public AccountTask04(AccountType accType, Decimal balance)
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
            set{ }
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
            set { }
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
            set { }
        }
     
    }
}
