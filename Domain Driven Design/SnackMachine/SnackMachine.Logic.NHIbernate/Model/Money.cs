using System;

namespace SnackMachine.Logic.NHIbernate.Model
{
    public class Money : ValueObject<Money>
    {
        //Static Money instances for Readability when creating new Money
        public static Money None = new Money(0,0,0,0);
        public static Money FiveCent = new Money(1, 0, 0, 0);
        public static Money TenCent = new Money(0, 1, 0, 0);
        public static Money Dollar  = new Money(0, 0, 1, 0);
        public static Money FiveDollar = new Money(0, 0, 0, 1);

        //Virtual Properties and Protected Setters for them necessitated by NHibernate (or other ORM)
        public virtual int FiveCentCount { get; protected set; }
        public virtual int TenCentCount { get; protected set; }
        public virtual int OneDollarCount { get; protected set; }
        public virtual int FiveDollarCount { get; protected set; }

        public Money(int fiveCentCount, int tenCentCount, int oneDollarCount, int fiveDollarCount)
        {
            if (fiveCentCount < 0 || tenCentCount < 0 || oneDollarCount < 0 || fiveDollarCount < 0)
                throw new InvalidOperationException("Money can't be initialized with negative counts");

            FiveCentCount = fiveCentCount;
            TenCentCount = tenCentCount;
            OneDollarCount = oneDollarCount;
            FiveDollarCount = fiveDollarCount;
        }

        private Money()
        {
            //Parameterless constructer needed by NHibernate because it constructs objects by Reflection. It can be private
            //No need to define explicitly if there are no other constructors since compiler adds one by default
        }

        public decimal Amount
        {
            get
            {
                return FiveCentCount * 0.05m + TenCentCount * 0.1m + OneDollarCount + FiveDollarCount * 5m;
            }
        }


        public override bool EqualsCore(Money obj)
        {
            return obj.FiveCentCount == FiveCentCount && obj.TenCentCount == TenCentCount && obj.OneDollarCount == OneDollarCount
                && obj.FiveDollarCount == FiveDollarCount;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        public static Money operator +(Money lhs, Money rhs)
        {
            return new Money(lhs.FiveCentCount + rhs.FiveCentCount, lhs.TenCentCount + rhs.TenCentCount,
                lhs.OneDollarCount + rhs.OneDollarCount, lhs.FiveDollarCount + rhs.FiveDollarCount);
        }

        public override string ToString()
        {
            var totalInDollars = Amount;
            if (totalInDollars < 1) return string.Format("¢{0}",(int) (totalInDollars * 100));
            return string.Format("${0:0.00}", totalInDollars);
        }
    }
}
