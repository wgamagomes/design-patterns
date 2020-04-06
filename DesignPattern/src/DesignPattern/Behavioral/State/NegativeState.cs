using System;

namespace DesignPattern.Behavioral.State
{
    public class NegativeState : State
    {
        public NegativeState(Account account) : base(account)
        {
        }

        public override void Deposit(double amount)
        {
            Balance += amount * 0.95; 

            if (Balance >= 0)
            {
                _account.State = new PositiveState(_account);
            }
        }

        public override void Withdraw(double amount)
        {
            throw new Exception("Your bank account is in the red.");
        }
    }
}
