using System;
namespace Cap04
{
    public class Account
    {
        #region Version 5.0
        // Version 5.0
        public string Name { get; set; }
        private decimal balance;
        public Account(string accountName, decimal initialBalance)
        {
            Name = accountName;
            Balance = initialBalance;
        }
        public decimal Balance
        {
            get
            {
                return balance;
            }
            private set
            {
                if (value > 0.0m)
                {
                    balance = value;
                }
            }
        }
        public void Deposit(decimal depositAmount)
        {
            if (depositAmount > 0.0m)
            {
                Balance = Balance + depositAmount;
            }
        }
        #endregion
        
        #region Version 4.0
        // Version 4.0
        /*
        public string Name { get; set; }
        public Account(string accountName)
        {
            Name = accountName;
        }
        */
        #endregion

        #region Version 3.0
        // Version 3.0
        /* 
        public string Name { get; set; }
        */
        #endregion

        #region Version 2.0
        // Version 2.0
        /*
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        */
        #endregion

        #region Version 1.0
        // Version 1.0
        /*
        private string name;
        public void SetName(string accountName)
        {
            name = accountName;
        }

        public string GetName()
        {
            return name;
        }
        */    
        #endregion 
        
    }
}