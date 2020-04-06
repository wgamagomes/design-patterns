namespace DesignPattern.Behavioral.State
{
    public class Account: IAccount
    {
        private string _owner;
        public State State { get; internal set; }


        public Account(string owner)
        {
            _owner = owner;
            State = new PositiveState(this, 0.0);
        }

        public double Balance
        {
            get { return State.Balance; }
        }

        public void Deposit(double amount)
        {
            State.Deposit(amount);
        }

        public void Withdraw(double amount)
        {
            State.Withdraw(amount);
        }
    }
}
