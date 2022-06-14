using System;
using System.Text;

namespace Lesson_06_Task_01
{
    public class Account
    {

        // (*) Добавить в класс счет в банке два метода: снять со счета и положить на счет.
        // Метод снять со счета проверяет, возможно ли снять запрашиваемую сумму, и в случае положительного результата изменяет баланс.


        static private UInt64 _totalAccounts;   // Общее количество счетов
        private UInt64 _number;                 // Номер счета
        private Decimal _balance;               // Баланс счета
        private AccountType _type;              // Тип счета

        public Account() : this(AccountType.Undefined)
        {
        }

        public Account(Decimal balance) : this(AccountType.Current, balance)
        {
        }

        public Account(AccountType accType) : this(accType, 0)
        {
        }

        public Account(AccountType accType, Decimal balance)
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
     
        public Account PutMoney(Decimal amount)
        {
            if (amount <= 0)
            {
                throw new Exception($"The put amount ({amount}) should be grater then 0.");
            }

            Balance += amount;

            return this;
        }

        public Account WithdrawMoney(Decimal amount)
        {
            if (Balance < amount)
            {
                throw new Exception($"The withdraw amount ({amount}) is exceed you total balance {Balance}.");
            }

            if (amount <= 0)
            {
                throw new Exception($"The withdraw amount ({amount}) should be grater then 0.");
            }

            Balance -= amount;
            return this;
        }

        /// <summary>
        /// Метод перевода денег с одного счета на другой
        /// </summary>
        /// <param name="debitAccount">Счет, с которого переводятся деньги</param>
        /// <param name="amount">Сумма перевода</param>
        /// <returns></returns>
        public Account TransferMoney(Account debitAccount, Decimal amount)
        {
            if (debitAccount == null)
            {
                throw new Exception($"The withdraw account doesn't exist.");
            }

            if (this == null)
            {
                throw new Exception($"The account for crediting doesn't exist.");
            }

            if (amount < 0)
            {
                throw new Exception($"The withdraw amount is equal or less 0.");
            }

            if (debitAccount.Balance < amount)
            {
                throw new Exception($"The withdraw account doesn't have anough money.");
            }

            debitAccount.WithdrawMoney(amount);
            this.PutMoney(amount);

            return this;
        }

        public static bool operator ==(Account account1, Account account2)
        {
            if ((object)account1 == null && (object)account2 == null)
            {
                return true;
            }

            if ((object)account1 != null && (object)account2 != null)
            {
                if (account1.Number == account2.Number && 
                    account1.Type == account2.Type &&
                    account1.Balance == account2.Balance
                    )
                {
                    return true;
                }
            }
            
            return false;
        }

        public static bool operator !=(Account account1, Account account2)
        {
            return !(account1 == account2);
        }

        public override bool Equals(object obj)
        {
            if (obj != null && obj is Account)
            {
                if (
                    Number == ((Account)obj).Number &&
                    Type == ((Account)obj).Type &&
                    Balance == ((Account)obj).Balance &&
                    obj.GetHashCode() == this.GetHashCode()
                    )
                {
                    return true;
                }
            }

            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Number,Type,Balance);
        }
        public override string ToString()
        {
            return
                $"Информация по счету:{Environment.NewLine}" +
                $"Номер счета: {this.Number}{Environment.NewLine}" +
                $"Тип счета: {this.Type}{Environment.NewLine}" +
                $"Баланс счета: {this.Balance}{Environment.NewLine}";
        }
        public void PrintBalanceToConsole()
        {
            Console.WriteLine($" Баланс счета {this.Number}:  {this.Balance} ");
        }

    }
}
