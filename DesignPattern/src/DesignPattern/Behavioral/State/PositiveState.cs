namespace DesignPattern.Behavioral.State
{
    public class PositiveState : State
    {
        public PositiveState(Account account, double balance) 
            : this(account)
        {
            Balance = balance;
        }
        public PositiveState(Account account) 
            : base(account)
        {

        }

        public override void Deposit(double amount)
        {
            Balance += amount * 0.98;
        }

        public override void Withdraw(double amount)
        {
            Balance -= amount;

            if (Balance < 0)
            {
                _account.State = new NegativeState(_account);
            }
        }
    }
}
