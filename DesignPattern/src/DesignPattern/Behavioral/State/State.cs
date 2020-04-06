namespace DesignPattern.Behavioral.State
{
    public abstract class State
    {
        protected Account _account;

        public State(Account account)
        {
            _account = account;
        }

        public double Balance { get; protected set; }

        public abstract void Deposit(double amount);

        public abstract void Withdraw(double amount);
    }       
}
