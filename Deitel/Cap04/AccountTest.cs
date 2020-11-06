using System;

namespace Cap04
{
    class AccountTest
    {
        static void Main(string[] args)
        {
            #region Version 5.0
            Account account1 = new Account("Jane Green",50.00m);
            Account account2 = new Account("John Blue", -7.53m);
            decimal depositAmount;

            Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C}");
            Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:C}");

            Console.Write("\nEnter deposit amount for account1: ");
            depositAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"adding {depositAmount:C} to account1 balance \n");
            account1.Deposit(depositAmount);

            Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C}");
            Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:C}");

            Console.Write("\nEnter deposit amount for account2: ");
            depositAmount= decimal.Parse(Console.ReadLine());
            Console.WriteLine($"adding {depositAmount:C} to account2 balance\n");
            account2.Deposit(depositAmount);

            Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C}");
            Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:C}");
            #endregion

            #region Version 4.0
            //Version 4.0
            /*
            Account account1 = new Account("Jane Green");
            Account account2 = new Account("John Blue");

            Console.WriteLine($"Initial name is {account1.Name}");
            Console.WriteLine($"Initial name is {account2.Name}");
            Console.ReadKey();
            */
            #endregion

            #region Version 2.0 y Version 3.0
            // Version 2.0 y Version 3.0
            /*
            Account myAccount = new Account();
            string theName;

            Console.WriteLine($"Initial name is {myAccount.Name}");
            Console.Write("Enter the Name: ");
            theName = Console.ReadLine();
            
            myAccount.Name = theName;
            
            Console.WriteLine($"myAccount's name is: {myAccount.Name}");
            Console.ReadKey();
            */
            #endregion

            #region Version 1.0
            // Version 1.0
            /*
            Account myAccount = new Account();
            string theName;

            Console.WriteLine($"Initial name is {myAccount.GetName()}");
            Console.Write("Enter the Name: ");
            theName = Console.ReadLine();
            
            myAccount.SetName(theName);
            
            Console.WriteLine($"myAccount's name is: {myAccount.GetName()}");
            Console.ReadKey();
            */
            #endregion
        }
    }
}
