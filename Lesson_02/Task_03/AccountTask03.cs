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

    public class AccountTask03
    {

        // В классе банковский счет, удалить методы заполнения полей.
        // Вместо этих методов создать конструкторы.
        // Переопределить конструктор по умолчанию,
        // создать конструктор для заполнения поля баланс,
        // конструктор для заполнения поля тип банковского счета,
        // конструктор для заполнения баланса и типа банковского счета.
        // Каждый конструктор должен вызывать метод, генерирующий номер счета.


        static private UInt64 _totalAccounts;
        private UInt64 _number;
        private Decimal _balance;
        private AccountType _type;

        public AccountTask03(): this (AccountType.Undefined)
        {
        }

        public AccountTask03(Decimal balance): this(AccountType.Current, balance)
        {
        }

        public AccountTask03(AccountType accType): this(accType, 0)
        {
        }

        public AccountTask03(AccountType accType, Decimal balance)
        {
            _number = ++_totalAccounts;
            _type = accType;
            _balance = balance;
        }


        public UInt64 GetAccountNumber()
        {
            return _number;
        }

        public decimal GetBalance()
        {
            if (_number != 0)
            {
                return _balance;
            }

            throw new Exception("Account doesn't exist");
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
