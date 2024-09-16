namespace Operator_overloading
{
    class Money
    {
        private decimal _amount;
        public decimal Amount => _amount;
        public Money(decimal value)
        {
            _amount = value;
        }
        public void display()
        {
            Console.WriteLine(this._amount);
        }
        public static Money operator +(Money money1, Money money2)
        {
            var val = money1.Amount + money2.Amount;
            return new Money(val); 
        }
        public static Money operator -(Money money1, Money money2)
        {
            var val = money1.Amount - money2.Amount;
            return new Money(val);
        }
        public static bool operator >(Money money1, Money money2)
        {
            return money1.Amount>money2.Amount;
        }
        public static bool operator <(Money money1, Money money2)
        {
            return money1.Amount < money2.Amount;
        }
        public static bool operator >=(Money money1, Money money2)
        {
            return money1.Amount >= money2.Amount;
        }
        public static bool operator <=(Money money1, Money money2)
        {
            return money1.Amount <= money2.Amount;
        }
        public static bool operator ==(Money money1, Money money2)
        {
            return money1.Amount == money2.Amount;
        }
        public static bool operator !=(Money money1, Money money2)
        {
            return money1.Amount != money2.Amount;
        }
        public static Money operator ++(Money money1)
        {
            var val=money1.Amount;
            return new Money(++val);
        }
        public static Money operator --(Money money1)
        {
            var val = money1.Amount;
            return new Money(--val);
        }
    }
}
