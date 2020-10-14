namespace AccountTest2
{
    public class Account
    {
        // Declare the class's instance variable(field)
        private string name;
        private decimal balance;

        // Define the class's set and get methods so as to able maniulate the class instance variables
        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void SetBalance(decimal balance)
        {
            if (balance < 0.0M)
            {
                this.balance = 0;
            } else {
                this.balance = balance;
            }
        }

        public decimal GetBalance()
        {
            return balance;
        }

    }
}